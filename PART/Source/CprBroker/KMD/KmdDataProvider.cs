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

namespace CprBroker.Providers.KMD
{
    /// <summary>
    /// Contains the base methods for accessing KMD web services
    /// </summary>
    public partial class KmdDataProvider : IDataProvider, IExternalDataProvider, IPerCallDataProvider
    {

        public enum ServiceTypes
        {
            AN08002,
            AN08010,
            AS78205,
            AS78206,
            AS78207,
            AN08300,
            AN08100,
        }
        #region PrivateMethods
        /// <summary>
        /// Sets the KMD web service url to the correct value based on the database object and the service name
        /// </summary>
        /// <param name="service">Web service proxy object</param>
        /// <param name="serviceType">Type of service</param>
        private void SetServiceUrl(System.Web.Services.Protocols.SoapHttpClientProtocol service, ServiceTypes serviceType)
        {
            string query = string.Format("?zservice={0}", serviceType);
            string url = Address.Split(new char[] { '?' }, StringSplitOptions.RemoveEmptyEntries)[0];
            url += query;
            service.Url = url;
        }

        /// <summary>
        /// Searches for the return code in a list of error codes, throws an Exception if a match is found
        /// </summary>
        /// <param name="returnCode">Code returned fromDate web service</param>
        /// <param name="returnText">Text returned fromDate the web service, used as the Exception's message if thrown</param>
        private void ValidateReturnCode(PerCallContext callContext, string returnCode, string returnText)
        {
            string[] errorCodes = new string[] 
            {
                //"00",//	Everything ok
                "07",//	Person is unknown in the municipality
                "08",//	Person is unknown in the region
                "10",//	The person is inactive -- moved from region
                //"15",//	Person number is invalid - former double issue
                //"16",//	Person number is invalid - the person is nynummereret
                //"17",//	The person is inactive - disappeared
                //"18",//	The person is inactive - emigrate
                //"19",//	The person is inactive - dead
                "22",//	The person is unknown in CPR
                "50",//	Bind error - contact DBA
                "51",//	Bind error - contact DBA
                "52",//	Bind error - contact DBA
                "53",//	Problems with connection to CPR - try again later
                "54",//	There are currently unable to carry on CPR
                "55",//	There is no such CICS through to DC. '
                "70",//municipal code / personal identification number is not numeric
                "78",// Error in personal / replacement personal
            };
            if (errorCodes.Contains(returnCode))
            {
                Engine.Local.Admin.AddNewLog(System.Diagnostics.TraceEventType.Error, "KMD data provider", "Request failed", null, null);
                // We log the call and set the success parameter to false
                callContext.Fail();
                throw new Exception(returnText);
            }
        }
        #endregion

        #region IDataProvider Members

        public bool IsAlive()
        {
            System.Net.WebClient client = new System.Net.WebClient();
            try
            {
                System.Uri uri = new Uri(Address);
                uri = new Uri(uri, "wsdl/AN08002.wsdl");
                client.DownloadData(uri);
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                client.Dispose();
            }
        }

        public Version Version
        {
            get
            {
                return new Version(CprBroker.Utilities.Constants.Versioning.Major, CprBroker.Utilities.Constants.Versioning.Minor);
            }
        }

        #endregion

        #region IExternalDataProvider Members

        public Dictionary<string, string> ConfigurationProperties { get; set; }

        public DataProviderConfigPropertyInfo[] ConfigurationKeys
        {
            get
            {
                return new DataProviderConfigPropertyInfo[] 
                { 
                    new DataProviderConfigPropertyInfo(){Name="Address",Required=true, Confidential=false},
                    new DataProviderConfigPropertyInfo(){Name="Username",Required=true,Confidential=false},
                    new DataProviderConfigPropertyInfo(){Name="Password" ,Required=true,Confidential=true}
                };
            }
        }

        public string[] OperationKeys
        {
            get
            {
                return new string[] { 
                    "Online",
                };
            }
        }

        #endregion

        #region Configuration properties

        public string Address
        {
            get
            {
                return ConfigurationProperties["Address"];
            }
        }

        public string UserName
        {
            get
            {
                return ConfigurationProperties["Username"];
            }
        }

        public string Password
        {
            get
            {
                return ConfigurationProperties["Password"];
            }
        }

        #endregion
    }
}
