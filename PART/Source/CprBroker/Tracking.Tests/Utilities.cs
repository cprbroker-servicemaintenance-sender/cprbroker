﻿using CprBroker.Data.Part;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CprBroker.Utilities;
using CprBroker.Data.Applications;
using CprBroker.Engine;

namespace CprBroker.Tests.Tracking
{
    class Utilities
    {
        public static Guid[] newUuids;

        public static void InsertPersons(string connectionString, int insertedPersons)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                newUuids = Enumerable.Range(0, insertedPersons).Select(i => Guid.NewGuid()).ToArray();
                var personsMappings = newUuids.Select(id => new PersonMapping()
                {
                    UUID = id,
                    CprNumber = PartInterface.Utilities.RandomCprNumber(),
                });
                var persons = personsMappings.Select(id => new Person()
                {
                    UUID = id.UUID,
                    UserInterfaceKeyText = id.CprNumber,
                });
                var personRegistrations = newUuids.Select(id => new PersonRegistration()
                {
                    UUID = id,
                    PersonRegistrationId = Guid.NewGuid(),
                    BrokerUpdateDate = DateTime.Now,
                    RegistrationDate = DateTime.Now,
                    LifecycleStatusId = (int)CprBroker.Schemas.Part.LivscyklusKodeType.Rettet
                });

                conn.Open();
                conn.BulkInsertAll(personsMappings);
                conn.BulkInsertAll(persons);
                conn.BulkInsertAll(personRegistrations);
            }
        }

        public static void AddUsage(string connectionString, Guid[] uuids, params OperationType.Types[] ops)
        {
            var uuidStr = uuids.Select(id => id.ToString()).ToArray();
            foreach (var op in ops)
            {
                BrokerContext.Current.RegisterOperation(op, uuidStr);
            }
        }

        public static void InitBrokerContext()
        {
            BrokerContext.Initialize(CprBroker.Utilities.Constants.BaseApplicationToken.ToString(), "", true);
        }
    }
}