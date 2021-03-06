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
 * Dennis Isaksen
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
using CprBroker.Schemas.Util;
using System.Linq.Expressions;

namespace CprBroker.Providers.DPR
{
    /// <summary>
    /// Contains code for access of DPR diversion
    /// </summary>
    public partial class DprDatabaseDataProvider
    {
        static DprDatabaseDataProvider()
        {
            ErrorCodes = DiversionErrorCodes.ErrorCodes_En();
        }

        /// <summary>
        /// Ensures that the DPR database contains the given person
        /// </summary>
        /// <param name="cprNumber"></param>
        protected void EnsurePersonDataExists(string cprNumber)
        {
            if (!this.DisableDiversion)
            {
                decimal cprNum = Convert.ToDecimal(cprNumber);
                using (DPRDataContext dataContext = new DPRDataContext(ConnectionString))
                {
                    var exists = (from personTotal in dataContext.PersonTotals
                                  select personTotal.PNR).Contains(cprNum);

                    if (exists)
                    {
                        Engine.Local.Admin.AddNewLog(System.Diagnostics.TraceEventType.Information, "EnsurePersonDataExists", string.Format("PNR {0} Exists in DPR, DPR Diversion not called", cprNumber), null, null);
                    }
                    else
                    {
                        Engine.Local.Admin.AddNewLog(System.Diagnostics.TraceEventType.Information, "EnsurePersonDataExists", string.Format("Calling DPR Diversion : {0}", cprNumber), null, null);
                        CallDiversion(InquiryType.DataUpdatedAutomaticallyFromCpr, DetailType.ExtendedData, cprNumber);
                    }
                }
            }
            else
            {
                Engine.Local.Admin.AddNewLog(System.Diagnostics.TraceEventType.Information, "EnsurePersonDataExists", string.Format("DPR Diversion is disabled: {0}", cprNumber), null, null);
            }
        }

        public bool IsDiversionAlive()
        {
            System.Net.Sockets.TcpClient client = new System.Net.Sockets.TcpClient();
            try
            {
                if (!DisableDiversion)
                {
                    // Try to open a socket on the server
                    // TODO: Do more complex testing for Write() and Read()
                    client.Connect(this.Address, this.Port);
                    client.GetStream().Close();
                }
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                client.Close();
            }
        }

        public bool IsReady
        {
            get
            {
                try
                {
                    using (var updateDataContext = new Queues.UpdatesDataContext(this.ConnectionString))
                    {
                        // Select event - staging table existence
                        var u = updateDataContext.T_DPRUpdateStagings.FirstOrDefault();

                        // Insert event
                        var u2 = new Queues.T_DPRUpdateStaging() { CreateTS = DateTime.Now, PNR = 0, DPRTable = "DTTOTAL" };
                        updateDataContext.T_DPRUpdateStagings.InsertOnSubmit(u2);
                        updateDataContext.SubmitChanges();

                        // Delete event
                        var u3 = updateDataContext.T_DPRUpdateStagings.Where(o => o.PNR == 0).ToArray();
                        updateDataContext.T_DPRUpdateStagings.DeleteAllOnSubmit(u3);
                        updateDataContext.SubmitChanges();

                        return true;
                    }
                }
                catch (Exception ex)
                {
                    CprBroker.Engine.Local.Admin.LogException(ex);
                    return false;
                }
            }
        }

        public bool IsDatabaseAlive()
        {
            using (var conn = new System.Data.SqlClient.SqlConnection())
            {
                try
                {
                    conn.ConnectionString = this.ConnectionString;
                    conn.Open();
                    using (var dprDataContext = new DPRDataContext(conn))
                    {
                        var p = dprDataContext.PersonTotals.FirstOrDefault();
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    Engine.Local.Admin.LogException(ex);
                    return false;
                }
            }
        }

        public bool IsAlive()
        {
            var ret = IsDiversionAlive() && IsDatabaseAlive();
            if (AutoUpdate)
                ret &= IsReady;
            return ret;
        }

        public string CreateMessage(InquiryType inquiryType, DetailType detailType, string cprNumber)
        {
            return string.Format("{0}{1}{2}",
                 (int)inquiryType,
                 (int)detailType,
                 cprNumber
             );
        }

        public string CallDiversion(InquiryType inquiryType, DetailType detailType, string cprNumber)
        {
            string message = CreateMessage(inquiryType, detailType, cprNumber);
            string operation = string.Format("{0}-{1},{2}", Constants.DiversionOperationName, inquiryType, detailType);
            return Send(message, operation, cprNumber);
        }

    }
}

