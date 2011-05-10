﻿/* ***** BEGIN LICENSE BLOCK *****
 * Version: MPL 1.1/GPL 2.0/LGPL 2.1
 *
 * The contents of this file are subject to the Mozilla Public License Version
 * 1.1 (the "License"); you may not use this file except in compliance with
 * the License. You may obtain a copy of the License at
 * http://www.mozilla.org/MPL/
 *
 * Software distributed under the License is distributed on an "AS IS"basis,
 * WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
 * for the specific language governing rights and limitations under the
 * License.
 *
 *
 * The Initial Developer of the Original Code is
 * IT- og Telestyrelsen / Danish National IT and Telecom Agency.
 *
 * Contributor(s):
 * Beemen Beshara
 * Niels Elgaard Larsen
 * Leif Lodahl
 * Steen Deth
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
using Microsoft.Deployment.WindowsInstaller;
using CprBroker.Installers.Installers;
using CprBroker.Installers.CprBrokerInstallers;
using CprBroker.Data.Part;
using CprBroker.Data.Applications;

namespace CprBrokerWixInstallers
{
    public class CprBrokerDatabaseCustomAction
    {
        [CustomAction]
        public static ActionResult TestConnectionString(Session session)
        {
            return DatabaseCustomAction.TestConnectionString(session);
        }

        [CustomAction]
        public static ActionResult ValidateConnectionString(Session session)
        {
            return DatabaseCustomAction.ValidateConnectionString(session);
        }

        [CustomAction]
        public static ActionResult FinalizeCprBrokerDatabase(Session session)
        {
            List<KeyValuePair<string, string>> ret = new List<KeyValuePair<string, string>>();
            ret.Add(new KeyValuePair<string, string>(typeof(CprBroker.Data.Part.AddressCoordinateQualityType).Name, CprBroker.Installers.CprBrokerInstallers.Properties.Resources.AddressCoordinateQualityType));
            ret.Add(new KeyValuePair<string, string>(typeof(CprBroker.Data.Applications.Application).Name, CprBroker.Installers.CprBrokerInstallers.Properties.Resources.Application));
            ret.Add(new KeyValuePair<string, string>(typeof(CivilStatusCodeType).Name, CprBroker.Installers.CprBrokerInstallers.Properties.Resources.CivilStatusCodeType));
            ret.Add(new KeyValuePair<string, string>(typeof(ContactChannelType).Name, CprBroker.Installers.CprBrokerInstallers.Properties.Resources.ContactChannelType));
            ret.Add(new KeyValuePair<string, string>(typeof(CountrySchemeType).Name, CprBroker.Installers.CprBrokerInstallers.Properties.Resources.CountrySchemeType));
            ret.Add(new KeyValuePair<string, string>(typeof(Gender).Name, CprBroker.Installers.CprBrokerInstallers.Properties.Resources.Gender));
            ret.Add(new KeyValuePair<string, string>(typeof(LifecycleStatus).Name, CprBroker.Installers.CprBrokerInstallers.Properties.Resources.LifecycleStatus));
            ret.Add(new KeyValuePair<string, string>(typeof(LifeStatusCodeType).Name, CprBroker.Installers.CprBrokerInstallers.Properties.Resources.LifeStatusCodeType));
            ret.Add(new KeyValuePair<string, string>(typeof(LogType).Name, CprBroker.Installers.CprBrokerInstallers.Properties.Resources.LogType));
            ret.Add(new KeyValuePair<string, string>(typeof(RelationshipType).Name, CprBroker.Installers.CprBrokerInstallers.Properties.Resources.RelationshipType));

            return DatabaseCustomAction.FinalizeDatabase(session, CprBroker.Installers.CprBrokerInstallers.Properties.Resources.CreatePartDatabaseObjects, ret.ToArray());
        }

        [CustomAction]
        public static ActionResult RemoveCprBrokerDatabase(Session session)
        {
            return DatabaseCustomAction.RemoveCprBrokerDatabase(session);
        }
    }
}
