﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Deployment.WindowsInstaller;
using System.Data.SqlClient;
using CprBroker.Installers;
using CprBroker.Utilities;
using Microsoft.Win32;

namespace InstallerLib
{
    public partial class CustomActions
    {
        private static AdminService.Admin CreateAdminServiceProxy(Session session)
        {
            return new AdminService.Admin()
            {
                Url = session.GetPropertyValue("PARTSERVICEURL").ToLower().Replace("part.asmx", "admin.asmx"),
                ApplicationHeaderValue = new AdminService.ApplicationHeader()
                {
                    ApplicationToken = session.GetPropertyValue("BASEAPPLICATIONTOKEN"),
                    UserToken = ""
                }
            };
        }

        private static string RegisterApplicationInCprBroker(Session session)
        {
            AdminService.Admin service = CreateAdminServiceProxy(session);
            var response = service.RequestAppRegistration(
                string.Format(
                    "{0} {1}",
                    session.GetPropertyValue("ProductName"),
                    new Random().Next(100000, 1000000)
                )
            );
            if (int.Parse(response.StandardRetur.StatusKode) != 200)
            {
                throw new Exception(string.Format("App registration failed. {0} {1}", response.StandardRetur.StatusKode, response.StandardRetur.FejlbeskedTekst));
            }
            var response2 = service.ApproveAppRegistration(response.Item.Token);
            if (int.Parse(response.StandardRetur.StatusKode) != 200)
            {
                throw new Exception(string.Format("App approve failed. {0} {1}", response.StandardRetur.StatusKode, response.StandardRetur.FejlbeskedTekst));
            }
            return response.Item.Token;
        }

        private static void UnregisterApplicationInCprBroker(Session session)
        {
            AdminService.Admin service = CreateAdminServiceProxy(session);
            string appToken = session.GetPropertyValue("APPLICATIONTOKEN");
            var response = service.UnregisterApp(appToken);
        }

        private static string GetConfigFileName(Session session)
        {
            return string.Format("{0}bin\\{1}.config", session.GetInstallDirProperty(), ServiceExeFileName);
        }
        private static void UpdateConfigFile(Session session, string appToken)
        {
            string configFileName = GetConfigFileName(session);
            // Connection string
            DatabaseSetupInfo databaseSetupInfo = DatabaseSetupInfo.FromSession(session);
            CprBroker.Utilities.Installation.SetConnectionStringInConfigFile(
                configFileName,
                "DPRUpdates",
                databaseSetupInfo.CreateConnectionString(false, true)
            );
            // Service url
            CprBroker.Utilities.Installation.SetApplicationSettingInConfigFile(
                configFileName,
                "DPRUpdatesNotification.Properties.Settings",
                "CPRBrokerPartServiceUrl",
                string.Format("{0}/Services/Part.asmx", session.GetPropertyValue("PARTSERVICEURL"))
            );
            // App token
            CprBroker.Utilities.Installation.SetApplicationSettingInConfigFile(
                configFileName,
                "DPRUpdatesNotification.Properties.Settings",
                "ApplicationToken",
                appToken
            );
        }

        private static void InstallAndStartService(Session session)
        {
            CprBroker.Utilities.Installation.RunCommand(
                string.Format("{0}installutil.exe", CprBroker.Utilities.Installation.GetNetFrameworkDirectory(new Version(4, 0))),
                string.Format("/i \"{0}bin\\{1}\"", session.GetInstallDirProperty(), ServiceExeFileName)
            );
            new System.ServiceProcess.ServiceController(ServiceName).Start();
        }

        private static void StopAndUnInstallService(Session session)
        {
            var controller = new System.ServiceProcess.ServiceController(ServiceName);
            if (controller.CanStop)
                controller.Stop();

            CprBroker.Utilities.Installation.RunCommand(
                string.Format("{0}installutil.exe", CprBroker.Utilities.Installation.GetNetFrameworkDirectory(new Version(4, 0))),
                string.Format("/u \"{0}bin\\{1}\"", session.GetInstallDirProperty(), ServiceExeFileName)
            );
        }

        private static void UpdateRegistry(Session session, string appToken)
        {
            Registry.SetValue(
                string.Format(@"HKEY_LOCAL_MACHINE\Software\{0}\{1}\CprBroker", session.GetPropertyValue("Manufacturer"), session.GetPropertyValue("ProductName")),
                "ApplicationToken",
                appToken,
                RegistryValueKind.String
            );
        }

    }
}
