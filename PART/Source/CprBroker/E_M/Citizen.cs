﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CprBroker.Schemas;
using CprBroker.Schemas.Part;

namespace CprBroker.Providers.E_M
{
    public partial class Citizen
    {
        public static RegistreringType1 ToRegistreringType1(Citizen citizen, Func<string, Guid> cpr2uuidFunc)
        {
            var ret = new RegistreringType1()
            {
                AktoerRef = UnikIdType.Create(E_MDataProvider.ActorId),
                AttributListe = ToAttributListeType(citizen),
                CommentText = null,
                LivscyklusKode = LivscyklusKodeType.Rettet,
                RelationListe = ToRelationListeType(citizen, cpr2uuidFunc),
                Tidspunkt = ToTidspunktType(citizen),
                TilstandListe = ToTilstandListeType(citizen),
                Virkning = null
            };
            ret.CalculateVirkning();
            return ret;
        }

        private static AttributListeType ToAttributListeType(Citizen citizen)
        {
            return new AttributListeType()
            {
                Egenskab = new EgenskabType[] { ToEgenskabType(citizen) },
                LokalUdvidelse = ToLokalUdvidelseType(citizen),
                RegisterOplysning = new RegisterOplysningType[] { ToRegisterOplysningType(citizen) },
                SundhedOplysning = new SundhedOplysningType[] { ToSundhedOplysningType(citizen) }
            };
        }

        private static EgenskabType ToEgenskabType(Citizen citizen)
        {
            var ret = new EgenskabType()
            {
                AndreAdresser = ToAndreAdresse(citizen),
                BirthDate = ToBirthdate(citizen),
                FoedestedNavn = citizen.BirthPlaceText,
                FoedselsregistreringMyndighedNavn = Authority.ToAuthorityName(citizen.BirthRegistrationAuthority),
                KontaktKanal = ToKontaktKanalType(citizen),
                NaermestePaaroerende = ToNextOfKin(citizen),
                NavnStruktur = ToNavnStrukturType(citizen),
                PersonGenderCode = Converters.ToPersonGenderCodeType(citizen.Gender),
                Virkning = ToVirkningType(citizen)
            };
            return ret;
        }

        private static NavnStrukturType ToNavnStrukturType(Citizen citizen)
        {
            //TODO: Fill person name
            return null;
        }

        private static RegisterOplysningType ToRegisterOplysningType(Citizen citizen)
        {
            var ret = new RegisterOplysningType()
            {
                Item = null,
                // TODO: Fill effect dates
                Virkning = null,
            };
            if (Constants.UnknownCountryCodes.Contains(citizen.CountryCode))
            {
                ret.Item = ToUkendtBorgerType(citizen);
            }
            else if (citizen.CountryCode == Constants.DenmarkCountryCode)
            {
                ret.Item = ToCprBorgerType(citizen);
            }
            else
            {
                ret.Item = ToUdenlandskBorgerType(citizen);
            }
            return ret;
        }

        private static CprBorgerType ToCprBorgerType(Citizen citizen)
        {
            return new CprBorgerType()
            {
                AdresseNoteTekst = null,
                FolkekirkeMedlemIndikator = false,
                FolkeregisterAdresse = ToAdresseType(citizen),
                ForskerBeskyttelseIndikator = false,
                NavneAdresseBeskyttelseIndikator = false,
                PersonCivilRegistrationIdentifier = null,
                PersonNationalityCode = null,
                PersonNummerGyldighedStatusIndikator = false,
                TelefonNummerBeskyttelseIndikator = false
            };
        }

        public static UdenlandskBorgerType ToUdenlandskBorgerType(Citizen citizen)
        {
            if (citizen != null)
            {
                return new UdenlandskBorgerType()
                {
                    // TODO: See if we can find a birth nationality (different from current nationality)
                    FoedselslandKode = null,
                    // TODO: Shall PersonCivilRegistrationReplacementIdentifier and PersonIdentifikator be swapped ?
                    PersonCivilRegistrationReplacementIdentifier = Converters.ToCprNumber(citizen.PNR),
                    PersonIdentifikator = null,
                    PersonNationalityCode = new CountryIdentificationCodeType[] { ToCountryIdentificationCodeType(citizen) },
                    SprogKode = null
                };
            }
            else
            {
                throw new ArgumentNullException("citizen");
            }
        }

        public static UkendtBorgerType ToUkendtBorgerType(Citizen citizen)
        {
            if (citizen != null)
            {
                return new UkendtBorgerType()
                {
                    PersonCivilRegistrationReplacementIdentifier = Converters.ToCprNumber(citizen.PNR)
                };
            }
            else
            {
                throw new ArgumentNullException("citizen");
            }
        }

    }
}
