﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Deployment.WindowsInstaller;
using System.Data.SqlClient;
using CprBroker.Installers;
using CprBroker.Utilities;

namespace InstallerLib
{
    public partial class CustomActions
    {
        private static readonly string ServiceExeFileName = "DPRUpdatesNotificationService.exe";
        private static readonly string ServiceName = "DPR Updates Notification Service";

        [CustomAction]
        public static ActionResult TestDatabaseConnection(Session session)
        {
            return DatabaseCustomAction.TestConnectionString(session, false);
        }

        [CustomAction]
        public static ActionResult DeployDatabase(Session session)
        {
            DatabaseSetupInfo databaseSetupInfo = DatabaseSetupInfo.FromSession(session);
            DatabaseCustomAction.ExecuteDDL(Properties.Resources.crebas, databaseSetupInfo);
            DatabaseCustomAction.CreateDatabaseUser(databaseSetupInfo, new string[] { "T_DPRUpdateStaging" });
            return ActionResult.Success;
        }

        [CustomAction]
        public static ActionResult RollbackDatabase(Session session)
        {
            DatabaseSetupInfo databaseSetupInfo = DatabaseSetupInfo.FromSession(session);
            DatabaseCustomAction.ExecuteDDL(Properties.Resources.drpbas, databaseSetupInfo);
            DatabaseCustomAction.DropDatabaseUser(databaseSetupInfo);
            return ActionResult.Success;
        }

        [CustomAction]
        public static ActionResult RemoveDatabase(Session session)
        {
            DatabaseSetupInfo databaseSetupInfo = DatabaseSetupInfo.FromSession(session);
            DatabaseCustomAction.ExecuteDDL(Properties.Resources.drpbas, databaseSetupInfo);
            DatabaseCustomAction.DropDatabaseUser(databaseSetupInfo);
            return ActionResult.Success;
        }

        [CustomAction]
        public static ActionResult ValidateCprBrokerServicesUrl(Session session)
        {
            var service = CreateAdminServiceProxy(session);
            try
            {
                var response = service.ListAppRegistrations();
                session["CPRBROKERSERVICESURL_VALID"] = "True";
            }
            catch (Exception ex)
            {
                session["CPRBROKERSERVICESURL_VALID"] = "False";
            }
            return ActionResult.Success;
        }

        [CustomAction]
        public static ActionResult InstallDprUpdatesService(Session session)
        {
            System.Diagnostics.Debugger.Break();
            string appToken = RegisterApplicationInCprBroker(session);
            UpdateConfigFile(session, appToken);
            UpdateRegistry(session, appToken);
            InstallAndStartService(session);
            return ActionResult.Success;
        }

        [CustomAction]
        public static ActionResult RollbackDprUpdatesService(Session session)
        {
            return RemoveDprUpdatesService(session);
        }

        [CustomAction]
        public static ActionResult RemoveDprUpdatesService(Session session)
        {
            System.Diagnostics.Debugger.Break();
            UnregisterApplicationInCprBroker(session);
            StopAndUnInstallService(session);
            return ActionResult.Success;
        }

    }
}
