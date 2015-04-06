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
using System.Linq;
using System.Text;
using CprBroker.Schemas.Part;
using System.Xml;

namespace CprBroker.Providers.CprServices
{
    /// <summary>
    /// Data tuple representing a person that is returned from a search operation
    /// </summary>
    public class SearchPerson : IEquatable<SearchPerson>
    {
        public string PNR;
        public NavnStrukturType Name;
        public AdresseType Address;
        public DateTime? Timestamp;
        public string SourceXml;

        public bool Equals(SearchPerson other)
        {
            return string.Equals(other.PNR, PNR);
        }

        public SearchPerson(XmlElement elm)
        {
            this.SourceXml = elm.OuterXml;
            this.Timestamp = ToStartDate(elm);
            this.Name = ToName(elm);
            this.PNR = GetFieldValue(elm, "PNR");
            this.Address = ToAdresseType(elm);
        }

        public DateTime? ToStartDate(XmlElement elm)
        {
            DateTime ret;
            if (DateTime.TryParseExact(
                GetFieldValue(elm, "STARTDATO"),
                "yyyyMMddHHmm", // 198112131338                    
                null,
                 System.Globalization.DateTimeStyles.None,
                 out ret))
                return ret;
            else
                return null;
        }

        public AdresseType ToAdresseType(XmlElement elm)
        {
            var kom = GetFieldValue(elm, "KOMKOD");
            var foreignCountryCode = GetFieldValue(elm, "UDRLANDEKOD");
            if (!string.IsNullOrEmpty(kom))
            {
                var komK = decimal.Parse(kom);

                return new AdresseType()
                {
                    Item =
                        komK >= CprBroker.Schemas.Part.AddressConstants.GreenlandMunicipalCodeStart ?
                            ToGroenlandskAdresseType(elm, kom) as AdresseBaseType
                            : ToDanskAdresseType(elm, kom)
                };
            }
            else if (string.IsNullOrEmpty(foreignCountryCode))
            {
                return ToAdresseTypeFromString(elm);
            }
            else
            {
                return new AdresseType()
                {
                    Item = ToVerdenAdresseType(elm, foreignCountryCode)
                };
            }
        }

        public DanskAdresseType ToDanskAdresseType(XmlElement elm, string kom)
        {
            return new DanskAdresseType()
            {
                AddressComplete = new AddressCompleteType()
                {
                    AddressAccess = new AddressAccessType()
                    {
                        MunicipalityCode = kom,
                        StreetCode = GetFieldValue(elm, "VEJKOD"),
                        StreetBuildingIdentifier = GetFieldValue(elm, "HUSNR")
                    },
                    AddressPostal = new AddressPostalType()
                    {
                        CountryIdentificationCode = CountryIdentificationCodeType.Create(_CountryIdentificationSchemeType.imk, Constants.DenmarkCountryCode.ToString()),

                        FloorIdentifier = GetFieldValue(elm, "ETAGE"),
                        StreetBuildingIdentifier = GetFieldValue(elm, "HUSNR"),
                        SuiteIdentifier = GetFieldValue(elm, "SIDEDOER"),

                        // TODO: Lookup
                        PostCodeIdentifier = GetFieldValue(elm, "POSTNR"),
                        DistrictName = GetFieldText(elm, "POSTNR"),

                        // TODO: This workd only in Lookup metrhods. Lookup street name and addressing name in Search methods
                        StreetName = GetFieldText(elm, "VEJKOD"),
                        // TODO: Shall we read from tm="xyz"?
                        StreetNameForAddressingName = GetFieldText(elm, "VEJKOD"),
                        DistrictSubdivisionIdentifier = GetFieldValue(elm, "BYNVN"),

                        // Not implemented
                        MailDeliverySublocationIdentifier = null,
                        PostOfficeBoxIdentifier = null,
                    }
                },
                // TODO: Fill post district in search methods
                PostDistriktTekst = GetFieldText(elm, "POSTNR"),
                SpecielVejkodeIndikator = false,
                SpecielVejkodeIndikatorSpecified = true,
                UkendtAdresseIndikator = false,

                // Not implemented
                AddressPoint = null,
                NoteTekst = null,
                PolitiDistriktTekst = null,
                SkoleDistriktTekst = null,
                SogneDistriktTekst = null,
                SocialDistriktTekst = null,
                ValgkredsDistriktTekst = null,
            };
        }

        public GroenlandAdresseType ToGroenlandskAdresseType(XmlElement elm, string kom)
        {
            return new GroenlandAdresseType()
            {
                AddressCompleteGreenland = new AddressCompleteGreenlandType()
                {
                    CountryIdentificationCode = CountryIdentificationCodeType.Create(_CountryIdentificationSchemeType.imk, Constants.DenmarkCountryCode.ToString()),
                    MunicipalityCode = kom,
                    StreetCode = GetFieldValue(elm, "VEJKOD"),

                    StreetBuildingIdentifier = GetFieldValue(elm, "HUSNR"),
                    GreenlandBuildingIdentifier = GetFieldValue(elm, "BNR"),
                    FloorIdentifier = GetFieldValue(elm, "ETAGE"),
                    SuiteIdentifier = GetFieldValue(elm, "SIDEDOER"),

                    // This is only available in Stam+
                    StreetName = GetFieldText(elm, "VEJADRNVN"),
                    StreetNameForAddressingName = GetFieldText(elm, "VEJADRNVN"),

                    // Post code, district & town
                    PostCodeIdentifier = GetFieldValue(elm, "POSTNR"),
                    DistrictName = GetFieldText(elm, "POSTNR"),
                    DistrictSubdivisionIdentifier = GetFieldValue(elm, "BYNVN"),

                    // Unsupported
                    MailDeliverySublocationIdentifier = null,
                },
                SpecielVejkodeIndikator = true,
                SpecielVejkodeIndikatorSpecified = true,
                UkendtAdresseIndikator = false,

                // Unsupported
                NoteTekst = null,
            };
        }

        public AdresseType ToAdresseTypeFromString(XmlElement elm)
        {
            var streetAddress = GetFieldValue(elm, "STADR");
            if (!string.IsNullOrEmpty(streetAddress))
            {
                // Parse the strings
                var arr = streetAddress.Split(' ');
                string streetName, houseNr;
                if (arr.Length > 1)
                {
                    streetName = string.Join(" ", arr.Take(arr.Length - 1).ToArray());
                    houseNr = arr.Last();
                }
                else
                {
                    streetName = streetAddress;
                    houseNr = null;
                }
                var postCode = GetFieldValue(elm, "POSTNR");
                var postDist = GetFieldText(elm, "POSTNR");

                // Fill the object
                return new AdresseType()
                {
                    Item = new DanskAdresseType()
                    {
                        AddressComplete = new AddressCompleteType()
                        {
                            // TODO: Can we fill Address access by lookup?
                            AddressAccess = null,
                            AddressPostal = new AddressPostalType()
                            {
                                CountryIdentificationCode = CountryIdentificationCodeType.Create(_CountryIdentificationSchemeType.imk, Constants.DenmarkCountryCode.ToString()),
                                StreetName = streetName,
                                StreetBuildingIdentifier = houseNr,
                                StreetNameForAddressingName = streetName,
                                // TODO: See if we can get floor & suite
                                FloorIdentifier = null,
                                SuiteIdentifier = null,
                                DistrictName = postDist,
                                PostCodeIdentifier = postCode,

                                // Not implemented
                                MailDeliverySublocationIdentifier = null,
                                PostOfficeBoxIdentifier = null,
                                DistrictSubdivisionIdentifier = null,
                            }
                        },
                        PostDistriktTekst = postDist,
                        SpecielVejkodeIndikator = false,
                        SpecielVejkodeIndikatorSpecified = false,
                        UkendtAdresseIndikator = false,

                        // Not implemented
                        NoteTekst = null,
                        AddressPoint = null,
                        PolitiDistriktTekst = null,
                        SkoleDistriktTekst = null,
                        SocialDistriktTekst = null,
                        SogneDistriktTekst = null,
                        ValgkredsDistriktTekst = null
                    }
                };
            }
            return null;
        }

        public VerdenAdresseType ToVerdenAdresseType(XmlElement elm, string foreignCountryCode)
        {
            return new VerdenAdresseType()
            {
                ForeignAddressStructure = new ForeignAddressStructureType()
                {
                    CountryIdentificationCode = CountryIdentificationCodeType.Create(_CountryIdentificationSchemeType.imk, foreignCountryCode),
                    PostalAddressFirstLineText = GetFieldValue(elm, "UDLANDSADR1"),
                    PostalAddressSecondLineText = GetFieldValue(elm, "UDLANDSADR2"),
                    PostalAddressThirdLineText = GetFieldValue(elm, "UDLANDSADR3"),
                    PostalAddressFourthLineText = GetFieldValue(elm, "UDLANDSADR4"),
                    PostalAddressFifthLineText = GetFieldValue(elm, "UDLANDSADR5"),
                    LocationDescriptionText = null,

                }
            };
        }

        public NavnStrukturType ToName(XmlElement elm)
        {
            var name = GetFieldValue(elm, "CNVN_ADRNVN");

            if (string.IsNullOrEmpty(name))
                name = GetFieldValue(elm, "ADRNVN");

            if (!string.IsNullOrEmpty(name))
                return NavnStrukturType.Create(new string[] { name }, name);
            else
                return null;
        }

        public string GetFieldValue(XmlElement elm, string name)
        {
            return GetFieldAttributeValue(elm, name, "v");
        }

        public string GetFieldText(XmlElement elm, string name)
        {
            return GetFieldAttributeValue(elm, name, "t");
        }

        public string GetFieldAttributeValue(XmlElement elm, string name, string attributeName)
        {
            var nsmgr = new XmlNamespaceManager(elm.OwnerDocument.NameTable);
            nsmgr.AddNamespace("c", Constants.XmlNamespace);

            var ndPath = string.Format("c:Field[@r='{0}']", name);
            var nd = elm.SelectSingleNode(ndPath, nsmgr);
            if (nd != null && nd.Attributes[attributeName] != null)
                return nd.Attributes[attributeName].Value.Trim();
            return null;
        }

        public LaesResultatType ToLaesResultatType(Func<string, Guid> uuidGetter)
        {
            return new LaesResultatType()
            {
                Item = new FiltreretOejebliksbilledeType()
                {
                    AttributListe = new AttributListeType()
                    {
                        Egenskab = new EgenskabType[]{
                            new EgenskabType(){ NavnStruktur = Name}
                        },
                        RegisterOplysning = new RegisterOplysningType[]
                        {
                            new RegisterOplysningType() { Item = new CprBorgerType(){ 
                                PersonCivilRegistrationIdentifier = PNR,
                                FolkeregisterAdresse =  Address
                            }}
                        }
                    },
                    BrugervendtNoegleTekst = PNR,
                    RelationListe = null,
                    TilstandListe = null,
                    UUID = uuidGetter(PNR).ToString()
                }
            };
        }

        public RegistreringType1 ToRegistreringType1()
        {
            return new RegistreringType1()
            {

                AttributListe = new AttributListeType()
                {
                    Egenskab = new EgenskabType[]
                    {
                        new EgenskabType()
                        { 
                            NavnStruktur = Name, 
                            Virkning = VirkningType.Create(Timestamp,null), 
                            BirthDate = PartInterface.Strings.PersonNumberToDate(this.PNR).Value
                        }
                    },
                    RegisterOplysning = new RegisterOplysningType[]
                    {
                        new RegisterOplysningType() 
                        { 
                            Item = new CprBorgerType()
                            { 
                                PersonCivilRegistrationIdentifier = PNR,
                                FolkeregisterAdresse =  Address
                            },
                            Virkning = VirkningType.Create(Timestamp,null)
                        }
                    }
                },
                RelationListe = null,
                TilstandListe = null,
                Tidspunkt = TidspunktType.Create(DateTime.Now),
                LivscyklusKode = LivscyklusKodeType.Rettet,
                AktoerRef = UnikIdType.Create(Constants.ActroId),
                CommentText = null,
                SourceObjectsXml = this.SourceXml
            };
        }


    }
}
