﻿/* ***** BEGIN LICENSE BLOCK *****
 * Version: MPL 1.1/GPL 2.0/LGPL 2.1
 *
 * The contents of this file are subject to the Mozilla Public License
 * Version 1.1 (the "License"); you may not use this file except in
 * compliance with the License. You may obtain a copy of the License at
 * http://www.mozilla.org/MPL/
 *
 * Software distributed under the License is distributed on an "AS IS"basis,
 * WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
 * for the specific language governing rights and limitations under the
 * License.
 *
 * The CPR Broker concept was initally developed by
 * Gentofte Kommune / Municipality of Gentofte, Denmark.
 * Contributor(s):
 * Steen Deth
 *
 *
 * The Initial Code for CPR Broker and related components is made in
 * cooperation between Magenta, Gentofte Kommune and IT- og Telestyrelsen /
 * Danish National IT and Telecom Agency
 *
 * Contributor(s):
 * Beemen Beshara
 * Niels Elgaard Larsen
 * Leif Lodahl
 * Steen Deth
 *
 * The code is currently governed by IT- og Telestyrelsen / Danish National
 * IT and Telecom Agency
 *
 * Alternatively, the contents of this file may be used under the terms of
 * either the GNU General Public License Version 2 or later (the "GPL"), or
 * the GNU Lesser General Public License Version 2.1 or later (the "LGPL"),
 * in which case the provisions of the GPL or the LGPL are applicable instead
 * of those above. If you wish to allow use of your version of this file only
 * under the terms of either the GPL or the LGPL, and not to allow others to
 * use your version of this file under the terms of the MPL, indicate your
 * decision by deleting the provisions above and replace them with the notice
 * and other provisions required by the GPL or the LGPL. If you do not delete
 * the provisions above, a recipient may use your version of this file under
 * the terms of any one of the MPL, the GPL or the LGPL.
 *
 * ***** END LICENSE BLOCK ***** */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CprBroker.Engine;
using CprBroker.Schemas;
using CprBroker.Schemas.Part;
using CprBroker.Utilities;
using CprBroker.Engine.Local;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace CprBroker.Providers.CPRDirect
{
    public partial class CPRDirectExtractDataProvider : IPartReadDataProvider, IExternalDataProvider
    {

        public string GetFtpUrl(string subPath = null)
        {
            string url = FtpAddress;
            url = Strings.EnsureStartString(url, "ftp://", false, StringComparison.CurrentCultureIgnoreCase);

            if (FtpPort.HasValue)
                url += ":" + FtpPort;

            if (!string.IsNullOrEmpty(FtpUser) || !string.IsNullOrEmpty(FtpPassword))
            {
                //Admin.LogFormattedSuccess("Adding credentials");
                url = string.Format("{0}:{1}@{2}", FtpUser, FtpPassword, url);
                //ftpRequest.Credentials = new NetworkCredential(FtpUser, FtpPassword);
            }

            url = Strings.EnsureStartString(url, "ftp://", true, StringComparison.CurrentCultureIgnoreCase);

            url = Utilities.Strings.EnsureEndString(url, "/", false);

            subPath = string.Format("{0}", subPath);
            subPath = Utilities.Strings.EnsureStartString(subPath, "/", false);
            subPath = Utilities.Strings.EnsureEndString(subPath, "/", false);

            if (!string.IsNullOrEmpty(subPath))
            {
                url += "/" + subPath;
            }
            Admin.LogFormattedSuccess("URL <{0}>", url);
            return url;
        }

        public FtpWebRequest CreateFtpRequest()
        {
            //ServicePointManager.ServerCertificateValidationCallback =
             //   (object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) =>
               //     true;

            FtpWebRequest ftpRequest = WebRequest.Create(GetFtpUrl()) as FtpWebRequest;
            //ftpRequest.EnableSsl = true;
            //ftpRequest.KeepAlive = false;                        
            //ftpRequest.UsePassive = false;
            return ftpRequest;
        }

        public string[] ListFtpContents()
        {
            var request = CreateFtpRequest();
            request.Method = WebRequestMethods.Ftp.ListDirectory;
            var res = request.GetResponse() as FtpWebResponse;
            var reader = new StreamReader(res.GetResponseStream());
            var txt = reader.ReadToEnd();
            return txt.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
        }

        public string PutTempFile()
        {
            string fileName = string.Format("{0}.txt", Guid.NewGuid());
            FtpWebRequest request = WebRequest.Create(GetFtpUrl(fileName)) as FtpWebRequest;
            request.Method = WebRequestMethods.Ftp.UploadFile;
            var w = new StreamWriter(request.GetRequestStream());
            w.Write("sss");
            w.Close();
            var rd = new StreamReader(request.GetResponse().GetResponseStream());
            var sss = rd.ReadToEnd();
            return fileName;
        }

        public void DeleteFile(string subPath)
        {
            FtpWebRequest request = WebRequest.Create(GetFtpUrl(subPath)) as FtpWebRequest;
            request.Method = WebRequestMethods.Ftp.DeleteFile;
            var reqponse = request.GetResponse();
        }

        public void DownloadFile(string subPath)
        {
            string localFileName = ExtractsFolder + "\\" + subPath;
            using (var localFile = new FileStream(localFileName, FileMode.CreateNew))
            {
                FtpWebRequest request = WebRequest.Create(GetFtpUrl(subPath)) as FtpWebRequest;
                request.Method = WebRequestMethods.Ftp.DownloadFile;
                using (var response = request.GetResponse())
                {
                    using (var responseStream = response.GetResponseStream())
                    {
                        var buffer = new byte[1024 * 32];
                        int read = 0;
                        while ((read = responseStream.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            localFile.Write(buffer, 0, read);
                        }
                    }
                }
            }
        }

    }
}
