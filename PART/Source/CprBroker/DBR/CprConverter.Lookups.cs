﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.SqlClient;
using System.Data.Linq.Mapping;
using CprBroker.Providers.DPR;
using CprBroker.Providers.CPRDirect;
using CprBroker.DBR.Extensions;

namespace CprBroker.DBR
{
    public partial class CprConverter
    {
        public static Dictionary<string, string> SplitFile(string path, Dictionary<string, Type> objectMap)
        {
            var ret = new Dictionary<string, string>();
            var streams = new Dictionary<string, StreamWriter>();

            using (var source = new System.IO.StreamReader(path, Encoding.GetEncoding(1252)))
            {
                while (!source.EndOfStream)
                {
                    int batchSize = 100;
                    var wrappers = CprBroker.Providers.CPRDirect.CompositeWrapper.Parse(source, objectMap, batchSize);

                    foreach (var w in wrappers)
                    {
                        var code = w.Contents.Substring(0, 3);
                        StreamWriter target;
                        if (streams.ContainsKey(code))
                        {
                            target = streams[code];
                        }
                        else
                        {
                            var fileName = string.Format("{0}-{1}-{2}.txt", path, code, w.GetType().Name);
                            target = new StreamWriter(fileName, false, Encoding.GetEncoding(1252));
                            streams[code] = target;
                            ret[code] = fileName;
                        }
                        target.Write(w.Contents);
                    }
                }
            }
            foreach (var kvp in streams)
            {
                kvp.Value.Close();
            }
            return ret;
        }

        public static int ImportLookups(string fileName, int batchSize, Encoding encoding, string dprConnectionString, Dictionary<string, Type> objectMap)
        {
            var ret = 0;

            var fileMap = SplitFile(fileName, objectMap);

            var extensionType = typeof(CprConverterExtensions);
            foreach (var kvp in fileMap)
            {
                // Init type parameters
                var typeKey = kvp.Key;
                var typeFile = kvp.Value;
                var sourceType = objectMap[kvp.Key];
                var method = extensionType.GetMethods().Where(m =>
                    {
                        var pars = m.GetParameters();
                        return pars.Length == 1 && pars.Where(p => p.ParameterType.Equals(sourceType)).Count() == 1;
                    }).SingleOrDefault();
                if (method != null)
                {
                    var targetType = method.ReturnType;
                    Converter<object, object> converter = (o) => method.Invoke(o, new object[] { o });

                    // Call batch conversion and insertion
                    ret += ImportLookup(typeFile, targetType, batchSize, encoding, dprConnectionString, converter, objectMap);
                }
            }
            return ret;
        }

        public static int ImportLookup(string fileName, Type targetType, int batchSize, Encoding encoding, string dprConnectionString,
            Converter<object, object> func, Dictionary<string, Type> objectMap)
        {
            int totalReadLinesCount = 0;
            var tableName = Utilities.DataLinq.GetTableName(targetType);

            var loadedKeys = new Dictionary<string, bool>();
            var keyProps = targetType.GetProperties()
                .Select(p => new { Property = p, Attribute = p.GetCustomAttributes(typeof(ColumnAttribute), true).FirstOrDefault() as ColumnAttribute })
                .Where(p => p.Attribute != null && p.Attribute.IsPrimaryKey)
                .Select(p => p.Property)
                .ToArray();

            using (var file = new StreamReader(fileName, encoding))
            {
                using (var conn = new SqlConnection(dprConnectionString))
                {
                    conn.Open();
                    using (var cmd = new SqlCommand(string.Format("truncate table [{0}];", tableName), conn))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    // Start reading the file
                    while (!file.EndOfStream)
                    {
                        var wrappers = CompositeWrapper.Parse(file, objectMap, batchSize);
                        var batchReadLinesCount = wrappers.Count;

                        var dprObjects = wrappers.Select(w => func(w)).ToArray();
                        if (keyProps.Length > 0)
                        {
                            var filtered = dprObjects
                                .GroupBy(o =>
                                {
                                    var values = keyProps.Select(p => p.GetValue(o, null).ToString()).ToArray();
                                    return string.Join("_", values);
                                });
                            filtered = filtered
                                .Where(g => !loadedKeys.ContainsKey(g.Key))
                                .ToArray();
                            dprObjects = filtered.Select(g => g.First()).ToArray();
                            foreach (var g in filtered)
                            {
                                loadedKeys[g.Key] = true;
                            }   
                        }

                        conn.BulkInsertAll(targetType, dprObjects);
                        totalReadLinesCount += batchReadLinesCount;
                    }
                }
            }
            return totalReadLinesCount;
        }
    }
}