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

using CprBroker.Engine.Local;
using CprBroker.Data.Applications;
using CprBroker.Data.DataProviders;

namespace CprBroker.Engine.Budget
{
    public class BudgetController
    {

        public static void CheckAllIntervals()
        {
            using (var dataContext = new DataProvidersDataContext())
            {
                foreach (var be in dataContext.BudgetIntervals.OrderBy(be => be.IntervalMillisecods).ToArray())
                {
                    // Check each interval in a separate try/catch block
                    try
                    {
                        CheckInterval(dataContext, be);
                    }
                    catch (Exception ex)
                    {
                        Admin.LogException(ex);
                    }
                }
            }
        }

        public static void CheckInterval(DataProvidersDataContext dataContext, BudgetInterval be)
        {
            var checkTime = DateTime.Now;

            if ((checkTime - be.EffectiveLastCheckedTime) >= TimeSpan.FromMilliseconds(be.IntervalMillisecods))
            {
                using (var appDataContext = new ApplicationDataContext())
                {
                    // Set start time. For simplicity, we ignore periods in the past when the check was not run
                    var startTime = checkTime.AddMilliseconds(-be.IntervalMillisecods);

                    var intervalEntries = appDataContext.DataProviderCalls.Where(dce => dce.CallTime >= startTime && dce.CallTime < checkTime);

                    CheckInterval<decimal>(be.Name, () => intervalEntries.Sum(dpe => dpe.Cost), be.CostThreshold, "cost");
                    CheckInterval<int>(be.Name, () => intervalEntries.Count(), be.CallThreshold, "calls");

                    be.LastChecked = checkTime;
                    dataContext.SubmitChanges();
                }
            }
        }

        public static void CheckInterval<T>(string intervalName, Func<T> evaluator, T? threshold, string type)
            where T : struct,IComparable
        {
            if (threshold.HasValue)
            {
                var value = evaluator();
                if (value.CompareTo(threshold.Value) >= 0)
                {
                    string msg = string.Format("Overbudget alarm: interval={0}, type={1}, threshold={2}, value={3}", intervalName, type, threshold.Value, value);
                    Admin.AddNewLog(System.Diagnostics.TraceEventType.Warning, "CheckInterval", msg, null, null);
                }
                else
                {
                    string msg = string.Format("Budget OK: interval={0}, type={1}, threshold={2}, value={3}", intervalName, type, threshold.Value, value);
                    Admin.AddNewLog(System.Diagnostics.TraceEventType.Information, "CheckInterval", msg, null, null);
                }
            }
        }
    }
}
