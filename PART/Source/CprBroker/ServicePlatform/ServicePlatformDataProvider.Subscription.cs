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
 * Thomas Kristensen
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

using CprBroker.Engine;
using CprBroker.Schemas;
using CprBroker.Engine.Local;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CprBroker.Providers.ServicePlatform
{
    public partial class ServicePlatformDataProvider : IPutSubscriptionDataProvider
    {

        protected enum ReturnCodePNR { ADDED, REMOVED, ALREADY_EXISTED, NON_EXISTING_PNR };
        protected enum ReturnCodeMunicipality { ADDED, REMOVED, ALREADY_EXISTED, NON_EXISTING_MUNICIPALITYCODE };

        public bool PutSubscription(PersonIdentifier personIdentifier)
        {
            var service = CreateService<CprSubscriptionService.CprSubscriptionWebServicePortType, CprSubscriptionService.CprSubscriptionWebServicePortTypeClient>(ServiceInfo.CPRSubscription);
            
            using (var callContext = this.BeginCall("AddPNRSubscription", personIdentifier.CprNumber))
            {
                try
                {

                    var request = new CprSubscriptionService.AddPNRSubscriptionType()
                    {
                        InvocationContext = GetInvocationContext<CprSubscriptionService.InvocationContextType>(ServiceInfo.CPRSubscription.UUID),
                        PNR = personIdentifier.CprNumber
                    };

                    var resultWrp = service.AddPNRSubscription(request);
                    if (resultWrp != null)
                    {
                        ReturnCodePNR returnCode = (ReturnCodePNR)Enum.Parse(typeof(ReturnCodePNR), resultWrp.Result); //will throw an overflow exception in case of unknown value.
                        switch (returnCode)
                        {
                            case ReturnCodePNR.ADDED:
                                //success
                                break;
                            case ReturnCodePNR.ALREADY_EXISTED:
                                //success
                                break;
                            case ReturnCodePNR.NON_EXISTING_PNR:
                                throw new Exception(String.Format("Error placing subscription for UUID <{0}>, service platform returns NON_EXISTING_PNR.", personIdentifier.UUID));
                            default:
                                throw new Exception(String.Format("Error placing subscription for UUID <{0}>, service platform returns unexpected code <{1}>.", personIdentifier.UUID, returnCode));
                        }
                        //Admin.LogSuccess(String.Format("Placed service platform subscription on UUID [%s], returned value [%s] ",personIdentifier.UUID, returnCode)); //TODO: Remove this log line
                        callContext.Succeed();
                        return true;
                    }
                    else
                    {
                        throw new Exception(String.Format("Null value returned by service api call AddPNRSubscription, when trying to place subscription for UUID: <{0}>", personIdentifier.UUID));
                    }

                }
                catch (Exception ex)
                {
                    Admin.LogException(ex);
                    callContext.Fail();
                    return false;
                }
            }
        }

        public bool PutSubscription(MunicipalityIdentifier municipalityIdentifier)
        {
            var service = CreateService<CprSubscriptionService.CprSubscriptionWebServicePortType, CprSubscriptionService.CprSubscriptionWebServicePortTypeClient>(ServiceInfo.CPRSubscription);

            using (var callContext = this.BeginCall("AddMunicipalitySubscription", municipalityIdentifier.MunicipalityCode))
            {
                try
                {

                    var request = new CprSubscriptionService.AddMunicipalityCodeSubscriptionType()
                    {
                        InvocationContext = GetInvocationContext<CprSubscriptionService.InvocationContextType>(ServiceInfo.CPRSubscription.UUID),
                    };
                    request.MunicipalityCode = municipalityIdentifier.MunicipalityCode;

                    var resultWrp = service.AddMunicipalityCodeSubscription(request);
                    if (resultWrp != null)
                    {
                        ReturnCodeMunicipality returnCode = (ReturnCodeMunicipality)Enum.Parse(typeof(ReturnCodeMunicipality), resultWrp.Result); //will throw an overflow exception in case of unknown value.
                        switch (returnCode)
                        {
                            case ReturnCodeMunicipality.ADDED:
                                //success
                                break;
                            case ReturnCodeMunicipality.ALREADY_EXISTED:
                                //success
                                break;
                            case ReturnCodeMunicipality.NON_EXISTING_MUNICIPALITYCODE:
                                throw new Exception(String.Format("Error placing subscription for municipality code <{0}>, service platform returns NON_EXISTING_MUNICIPALITYCODE.", municipalityIdentifier.MunicipalityCode));
                            default:
                                throw new Exception(String.Format("Error placing subscription for municipality code <{0}>, service platform returns unexpected code <{1}>.", municipalityIdentifier.MunicipalityCode, returnCode));
                        }
                        //Admin.LogSuccess(String.Format("Placed service platform subscription on municipality code [%s], returned value [%s] ",municipalityIdentifier.MunicipalityCode, returnCode)); //TODO: Remove this log line
                        callContext.Succeed();
                        return true;
                    }
                    else
                    {
                        throw new Exception(String.Format("Null value returned by service api call AddMunicipalityCodeSubscription, when trying to place subscription for MunicipalityCode: <{0}>", municipalityIdentifier.MunicipalityCode));
                    }

                }
                catch (Exception ex)
                {
                    Admin.LogException(ex);
                    callContext.Fail();
                    return false;
                }
            }
        }

        public bool RemoveSubscription(MunicipalityIdentifier municipalityIdentifier)
        {
            var service = CreateService<CprSubscriptionService.CprSubscriptionWebServicePortType, CprSubscriptionService.CprSubscriptionWebServicePortTypeClient>(ServiceInfo.CPRSubscription);

            using (var callContext = this.BeginCall("RemoveMunicipalitySubscription", municipalityIdentifier.MunicipalityCode))
            {
                try
                {

                    var request = new CprSubscriptionService.RemoveMunicipalityCodeSubscriptionType()
                    {
                        InvocationContext = GetInvocationContext<CprSubscriptionService.InvocationContextType>(ServiceInfo.CPRSubscription.UUID),
                    };
                    request.MunicipalityCode = municipalityIdentifier.MunicipalityCode;

                    var resultWrp = service.RemoveMunicipalityCodeSubscription(request);
                    if (resultWrp != null)
                    {
                        ReturnCodeMunicipality returnCode = (ReturnCodeMunicipality)Enum.Parse(typeof(ReturnCodeMunicipality), resultWrp.Result); //will throw an overflow exception in case of unknown value.
                        switch (returnCode)
                        {
                            case ReturnCodeMunicipality.REMOVED:
                                //success
                                break;
                            case ReturnCodeMunicipality.NON_EXISTING_MUNICIPALITYCODE:
                                throw new Exception(String.Format("Error removing subscription for municipality code <{0}>, service platform returns NON_EXISTING_MUNICIPALITYCODE.", municipalityIdentifier.MunicipalityCode));
                            default:
                                throw new Exception(String.Format("Error removing subscription for municipality code <{0}>, service platform returns unexpected code <{1}>.", municipalityIdentifier.MunicipalityCode, returnCode));
                        }
                        //Admin.LogSuccess(String.Format("Placed service platform subscription on municipality code [%s], returned value [%s] ",municipalityIdentifier.MunicipalityCode, returnCode)); //TODO: Remove this log line
                        callContext.Succeed();
                        return true;
                    }
                    else
                    {
                        throw new Exception(String.Format("Null value returned by service api call RemoveMunicipalityCodeSubscription, when trying to place subscription for MunicipalityCode: <{0}>", municipalityIdentifier.MunicipalityCode));
                    }

                }
                catch (Exception ex)
                {
                    Admin.LogException(ex);
                    callContext.Fail();
                    return false;
                }
            }
        }


    }
}