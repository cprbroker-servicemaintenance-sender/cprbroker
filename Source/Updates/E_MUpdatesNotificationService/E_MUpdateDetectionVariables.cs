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

using GKApp2010.RTE;
using UpdateLib;

namespace E_MUpdatesNotification
{
    public class E_MUpdateDetectionVariables : UpdateDetectionVariables
    {
        // From Runner        
        public override string Tag
        {
            get { return "E_MUpdateLib.Runner"; }
        }
        public override string ServiceName
        {
            get { return "E_MUpdatesNotificationService"; }
        }
        public override string ServiceDisplayName
        {
            get { return "E&M Updates Notification Service"; }
        }

        // From UpdateStagingBatch
        public override string ConnectionStringName
        {
            get { return "E_MUpdates"; }
        }
        public override string PnrColumnName
        {
            get { return "PERSONNUMMER"; }
        }
        public override string IdColumnName
        {
            get { return "Id"; }
        }
        public override string StagingTableName
        {
            get { return "T_E_MUpdateStaging"; }
        }
        public override string TableColumnName
        {
            get { return "E_MTable"; }
        }
        public override string TimestampColumnName
        {
            get { return "CreateTS"; }
        }
        public override string SchemaName
        {
            get { return "dbo"; }
        }

        // From UpdatesNotificationService

        // From ProjectInstaller
        public override string ServiceDescription
        {
            get
            {
                string s = "";
                s += "Collect changes made to persons in the E_M database and notify target systems such as CPRBroker of these changes. ";
                s += "In this version of the service, collection occurs at predefined intervals (polling the DB). Poll interval is defined in configuration. ";
                s += "Version=[" + Info.GetRuntimeVersion() + "]. ";
                s += "20120206/BB";
                return s;
            }
        }

        // From CustomActions
        public override string ServiceExeFileName
        {
            get { return "E_MUpdatesNotificationService.exe"; }
        }
        public override string DatabaseFeatureName
        {
            get { return "E_MN"; }
        }

        // From SQL
        public override string[] TrackedTableNames
        {
            get
            {
                // Should AA70100T be included if we care for historical addresses? probably no necause this will also trigger something in AA70000T.
                return new string[] { "AA70000T", "AA70300T" };
            }
        }
        public override string TablesTableName
        {
            get { return "T_E_MUpdateStaging_E_MTable"; }
        }
        public override string SystemName
        {
            get { return "E_M"; }
        }

        // Control parameters
        public override bool TriggersEnabled
        {
            get { return false; }
        }
        public override string ExtraDatabaseCreateDDL
        {
            get
            {
                return Properties.Resources.create_EM_objects;
            }
        }
        public override string ExtraDatabaseDropDDL
        {
            get
            {
                return Properties.Resources.drop_EM_objects;
            }
        }
    }
}
