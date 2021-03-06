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
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using CprBroker.Engine;
using CprBroker.Utilities;
using CprBroker.EventBroker.Notifications;
using CprBroker.Engine.Tasks;

namespace CprBroker.EventBroker.Backend
{
    /// <summary>
    /// This service is responsible for the scheduling of publishing events to subscribers
    /// </summary>
    public partial class BackendService : System.ServiceProcess.ServiceBase
    {
        public BackendService()
        {
            InitializeComponent();
            TaskFactory.ConfigSectionError += TaskFactory_ConfigSectionError;
            TaskFactory.TaskElementConfigError += TaskFactory_TaskElementConfigError;
        }

        public TaskFactory TaskFactory = new TaskFactory();
        
        void TaskFactory_TaskElementConfigError(object sender, TaskFactory.ErrorEventArgs<Utilities.Config.TasksConfigurationSection.TaskElement> e)
        {
            CprBroker.Engine.Local.Admin.LogFormattedError(
                "Task loading error: <{0}> from <{1}>",
                e.Message,
                e.Object == null ? "" : e.Object.TypeName);
        }

        void TaskFactory_ConfigSectionError(object sender, TaskFactory.ErrorEventArgs<Utilities.Config.TasksConfigurationSection> e)
        {
            CprBroker.Engine.Local.Admin.LogFormattedError(
                "Task config loading error: <{0}> from <{1}>",
                e.Message,
                e.Object);
        }

        
        public void PopulateTaskExecuters()
        {
            if (_TaskExecuters == null)
            {
                _TaskExecuters = this.TaskFactory.LoadTasks()
                            .Where(t => t != null)
                            .ToArray();

                foreach (var t in _TaskExecuters)
                    components.Add(t);
            }
        }

        PeriodicTaskExecuter[] _TaskExecuters;

        public void StartTasks()
        {
            PopulateTaskExecuters();
            foreach (var queue in this._TaskExecuters)
                queue.Start();
        }

        public void StopTasks()
        {
            foreach (var task in this._TaskExecuters)
                task.Stop();
        }

        protected override void OnStart(string[] args)
        {
            BrokerContext.Initialize(Constants.EventBrokerApplicationToken.ToString(), Constants.UserToken);
            CprBroker.Engine.Local.Admin.LogSuccess(TextMessages.BackendServiceStarting);
            StartTasks();
            CprBroker.Engine.Local.Admin.LogSuccess(TextMessages.BackendServiceStarted);
        }

        protected override void OnStop()
        {
            BrokerContext.Initialize(Constants.EventBrokerApplicationToken.ToString(), Constants.UserToken);
            StopTasks();
        }

        protected override void OnContinue()
        {
            StartTasks();
        }

        protected override void OnPause()
        {
            StopTasks();
        }

    }
}
