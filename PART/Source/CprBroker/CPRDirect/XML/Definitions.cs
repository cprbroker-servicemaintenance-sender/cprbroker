
    using System;
    using System.Collections.Generic;

    namespace CprBroker.Providers.CPRDirect
    {
    
    class IndividualRequestType: Wrapper
    {
        #region Common
        public override int Length
        {
            get { return 39; }
        }
        #endregion
        
        #region Properties
    
        ///  <summary>
        /// CPR's transaction code
        ///  </summary>
        public string CPRTRANS
        {
            get { return this[1, 4]; }
        }
  
        ///  <summary>
        /// Danish: KOMMA
        /// Comma character used as separator
        ///  </summary>
        public string Comma
        {
            get { return this[5, 1]; }
        }
  
        ///  <summary>
        /// Danish: KUNDENR
        /// Identification of the customer
        ///  </summary>
        public decimal CustomerNumber
        {
            get { return this.GetDecimal(6, 4); }
        }
  
        ///  <summary>
        /// Danish: ABON_TYPE
        /// Subscription phrase / delete or not
        ///  </summary>
        public decimal SubscriptionType
        {
            get { return this.GetDecimal(10, 1); }
        }
  
        ///  <summary>
        /// Danish: DATA_TYPE
        /// Desired output - 0 in LOGONINDIVID
        ///  </summary>
        public decimal DataType
        {
            get { return this.GetDecimal(11, 1); }
        }
  
        ///  <summary>
        /// Danish: TOKEN
        ///  </summary>
        public string Token
        {
            get { return this[12, 8]; }
        }
  
        ///  <summary>
        /// Danish: BRUGER_ID
        /// The CPR Unit assigned system user code
        ///  </summary>
        public string UserId
        {
            get { return this[20, 8]; }
        }
  
        ///  <summary>
        /// Danish: FEJLNR
        /// Indicator of the communication process
        ///  </summary>
        public decimal ErrorNumber
        {
            get { return this.GetDecimal(28, 2); }
        }
  
        ///  <summary>
        /// Danish: PNR
        /// Request PNR
        ///  </summary>
        public decimal PNR
        {
            get { return this.GetDecimal(30, 10); }
        }
  
        #endregion

    }

  
    class IndividualResponseType: Wrapper
    {
        #region Common
        public override int Length
        {
            get { return 2908; }
        }
        #endregion
        
        #region Properties
    
        ///  <summary>
        /// Danish: KUNDENR
        /// Identification of the customer
        ///  </summary>
        public decimal CustomerNumber
        {
            get { return this.GetDecimal(1, 4); }
        }
  
        ///  <summary>
        /// Danish: ABON_TYPE
        /// Subscription phrase / delete or not
        ///  </summary>
        public decimal SubscriptionType
        {
            get { return this.GetDecimal(5, 1); }
        }
  
        ///  <summary>
        /// Danish: DATA_TYPE
        /// 0 in LOGONINDIVID (see Annex 2)Desired output
        ///  </summary>
        public decimal DataType
        {
            get { return this.GetDecimal(6, 1); }
        }
  
        ///  <summary>
        /// Danish: TOKEN
        /// Taken from the logon
        ///  </summary>
        public string Token
        {
            get { return this[7, 8]; }
        }
  
        ///  <summary>
        /// Danish: BRUGER-ID
        /// The CPR Unit assigned system user code
        ///  </summary>
        public string UserId
        {
            get { return this[15, 8]; }
        }
  
        ///  <summary>
        /// Danish: FEJLNR
        /// Indicator of the communication process
        ///  </summary>
        public decimal ErrorNumber
        {
            get { return this.GetDecimal(23, 2); }
        }
  
        ///  <summary>
        /// Length of structure 28 + data MAX 2880
        ///  </summary>
        public decimal DataLength
        {
            get { return this.GetDecimal(25, 4); }
        }
  
        ///  <summary>
        /// Danish: DATA
        /// Personal data from the CPR (format and amount depends on DATA_TYPE
        ///  </summary>
        public string Data
        {
            get { return this[29, 2880]; }
        }
  
        #endregion

        #region Sub objects
        
        [MinMaxOccurs(MinOccurs = 1, MaxOccurs = 1)]
        public StartRecordType StartRecord = null;

        [MinMaxOccurs(MinOccurs = 1, MaxOccurs = 1)]
        public PersonInformationType PersonInformation = null;

        [MinMaxOccurs(MinOccurs = 0, MaxOccurs = 1)]
        public CurrentAddressInformationType CurrentAddressInformation = null;

        [MinMaxOccurs(MinOccurs = 1, MaxOccurs = 1)]
        public ClearWrittenAddressType ClearWrittenAddress = null;

        [MinMaxOccurs(MinOccurs = 0, MaxOccurs = 4)]
        public List<ProtectionType> Protection = new List<ProtectionType>();

        [MinMaxOccurs(MinOccurs = 0, MaxOccurs = 1)]
        public CurrentDepartureDataType CurrentDepartureData = null;

        [MinMaxOccurs(MinOccurs = 0, MaxOccurs = 1)]
        public ContactAddressType ContactAddress = null;

        [MinMaxOccurs(MinOccurs = 0, MaxOccurs = 1)]
        public CurrentDisappearanceInformationType CurrentDisappearanceInformation = null;

        [MinMaxOccurs(MinOccurs = 1, MaxOccurs = 1)]
        public CurrentNameInformationType CurrentNameInformation = null;

        [MinMaxOccurs(MinOccurs = 1, MaxOccurs = 1)]
        public BirthRegistrationInformationType BirthRegistrationInformation = null;

        [MinMaxOccurs(MinOccurs = 1, MaxOccurs = 1)]
        public CurrentCitizenshipType CurrentCitizenship = null;

        [MinMaxOccurs(MinOccurs = 1, MaxOccurs = 1)]
        public ChurchInformationType ChurchInformation = null;

        [MinMaxOccurs(MinOccurs = 1, MaxOccurs = 1)]
        public CurrentCivilStatusType CurrentCivilStatus = null;

        [MinMaxOccurs(MinOccurs = 0, MaxOccurs = 1)]
        public CurrentSeparationType CurrentSeparation = null;

        [MinMaxOccurs(MinOccurs = 0, MaxOccurs = 25)]
        public List<ChildType> Child = new List<ChildType>();

        [MinMaxOccurs(MinOccurs = 1, MaxOccurs = 1)]
        public ParentsInformationType ParentsInformation = null;

        [MinMaxOccurs(MinOccurs = 0, MaxOccurs = 2)]
        public List<ParentalAuthorityType> ParentalAuthority = new List<ParentalAuthorityType>();

        [MinMaxOccurs(MinOccurs = 0, MaxOccurs = 1)]
        public DisempowermentType Disempowerment = null;

        [MinMaxOccurs(MinOccurs = 0, MaxOccurs = 1)]
        public MunicipalConditionsType MunicipalConditions = null;

        [MinMaxOccurs(MinOccurs = 1, MaxOccurs = 1)]
        public EndRecordType EndRecord = null;


        #endregion

    }

  
    class StartRecordType: Wrapper
    {
        #region Common
        public override int Length
        {
            get { return 35; }
        }
        #endregion
        
        #region Properties
    
        ///  <summary>
        /// Danish: RECORDTYPE
        /// Equals last three digits of the record name
        ///  </summary>
        public decimal RecordType
        {
            get { return this.GetDecimal(1, 3); }
        }
  
        ///  <summary>
        /// Danish: SORTFELT-10
        /// BLACK BOX-10
        ///  </summary>
        public string BlackBox10
        {
            get { return this[4, 10]; }
        }
  
        ///  <summary>
        /// Danish: OPGAVENR
        ///  </summary>
        public decimal TaskNumber
        {
            get { return this.GetDecimal(14, 6); }
        }
  
        ///  <summary>
        /// Danish: PRODDTO
        /// Production date YYYYMMDD
        ///  </summary>
        public DateTime ProductionDate
        {
            get { return this.GetDateTime(20, 8, "YYYYMMDD"); }
        }
  
        ///  <summary>
        /// Danish: PRODDTOFORRIG
        /// Previous production date YYYYMMDD
        ///  </summary>
        public DateTime PreviousProductionDate
        {
            get { return this.GetDateTime(28, 8, "YYYYMMDD"); }
        }
  
        #endregion

    }

  
    class PersonInformationType: Wrapper
    {
        #region Common
        public override int Length
        {
            get { return 106; }
        }
        #endregion
        
        #region Properties
    
        ///  <summary>
        /// Danish: RECORDTYPE
        /// Equals last three digits of the record name
        ///  </summary>
        public decimal RecordType
        {
            get { return this.GetDecimal(1, 3); }
        }
  
        ///  <summary>
        /// Danish: PNR
        /// CPR Number
        ///  </summary>
        public string PNR
        {
            get { return this[4, 10]; }
        }
  
        ///  <summary>
        /// Danish: PNRGAELD
        /// Current CPR Number
        ///  </summary>
        public string CurrentCprNumber
        {
            get { return this[14, 10]; }
        }
  
        ///  <summary>
        /// Danish: STATUS
        /// Status
        ///  </summary>
        public decimal Status
        {
            get { return this.GetDecimal(24, 2); }
        }
  
        ///  <summary>
        /// Danish: STATUSHAENSTART
        /// Status date YYYYMMDDTTMM
        ///  </summary>
        public DateTime StatusStartDate
        {
            get { return this.GetDateTime(26, 12, "YYYYMMDDHHmm"); }
        }
  
        ///  <summary>
        /// Danish: STATUSDTO_UMRK
        /// Status date uncertainty marker
        ///  </summary>
        public string StatusDateUncertainty
        {
            get { return this[38, 1]; }
        }
  
        ///  <summary>
        /// Danish: KOEN
        /// CPR Number
        ///  </summary>
        public string Gender
        {
            get { return this[39, 1]; }
        }
  
        ///  <summary>
        /// Danish: FOED_DT
        /// Birth date YYYY-MM-DD
        ///  </summary>
        public DateTime Birthdate
        {
            get { return this.GetDateTime(40, 10, "YYYY-MM-DD"); }
        }
  
        ///  <summary>
        /// Danish: FOED_DT_UMRK
        /// Birth date uncertainty marker
        ///  </summary>
        public string BirthdateUncertainty
        {
            get { return this[50, 1]; }
        }
  
        ///  <summary>
        /// Danish: START_DT-PERSON
        /// Person start date YYYY-MM-DD
        ///  </summary>
        public DateTime PersonStartDate
        {
            get { return this.GetDateTime(51, 10, "YYYY-MM-DD"); }
        }
  
        ///  <summary>
        /// Danish: START_DT_UMRK-PERSON
        /// Start date uncertainty marker
        ///  </summary>
        public string PersonStartDateUncertainty
        {
            get { return this[61, 1]; }
        }
  
        ///  <summary>
        /// Danish: SLUT_DT-PERSON
        /// Person end date YYYY-MM-DD
        ///  </summary>
        public DateTime PersonEndDate 
        {
            get { return this.GetDateTime(62, 10, "YYYY-MM-DD"); }
        }
  
        ///  <summary>
        /// Danish: PNR
        /// End date uncertainty marker
        ///  </summary>
        public string EndDateUncertainty
        {
            get { return this[72, 1]; }
        }
  
        ///  <summary>
        /// Danish: STILLING
        /// Job
        ///  </summary>
        public string Job
        {
            get { return this[73, 34]; }
        }
  
        #endregion

    }

  
    class CurrentAddressInformationType: Wrapper
    {
        #region Common
        public override int Length
        {
            get { return 306; }
        }
        #endregion
        
        #region Properties
    
        ///  <summary>
        /// Danish: RECORDTYPE
        /// Equals last three digits of the record name
        ///  </summary>
        public decimal RecordType
        {
            get { return this.GetDecimal(1, 3); }
        }
  
        ///  <summary>
        /// Danish: PNR
        /// CPR Number
        ///  </summary>
        public string PNR
        {
            get { return this[4, 10]; }
        }
  
        ///  <summary>
        /// Danish: KOMKOD
        /// Municipality
        ///  </summary>
        public decimal MunicipalityCode
        {
            get { return this.GetDecimal(14, 4); }
        }
  
        ///  <summary>
        /// Danish: VEJKOD
        /// Street
        ///  </summary>
        public decimal StreetCode
        {
            get { return this.GetDecimal(18, 4); }
        }
  
        ///  <summary>
        /// Danish: HUSNR
        /// House
        ///  </summary>
        public string HouseNumber
        {
            get { return this[22, 4]; }
        }
  
        ///  <summary>
        /// Danish: ETAGE
        /// Floor
        ///  </summary>
        public string Floor
        {
            get { return this[26, 2]; }
        }
  
        ///  <summary>
        /// Danish: SIDEDOER
        /// Door
        ///  </summary>
        public string Door
        {
            get { return this[28, 4]; }
        }
  
        ///  <summary>
        /// Danish: BNR
        /// Building number
        ///  </summary>
        public string BuildingNumber
        {
            get { return this[32, 4]; }
        }
  
        ///  <summary>
        /// Danish: CONVN
        /// C/O name
        ///  </summary>
        public string CareOfName
        {
            get { return this[36, 34]; }
        }
  
        ///  <summary>
        /// Danish: TILFLYDTO
        /// Relocation date YYYYMMDDTTMM
        ///  </summary>
        public DateTime RelocationDate
        {
            get { return this.GetDateTime(70, 12, "YYYYMMDDHHmm"); }
        }
  
        ///  <summary>
        /// Danish: TILFLYDT_UMRK
        /// Relocation date uncertainty marker
        ///  </summary>
        public string RelocationDateUncertainty
        {
            get { return this[82, 1]; }
        }
  
        ///  <summary>
        /// Danish: TILFLYKOMDTO
        /// Municipality arrival date YYYYMMDDTTMM
        ///  </summary>
        public DateTime MunicipalityArrivalDate
        {
            get { return this.GetDateTime(83, 12, "YYYYMMDDHHmm"); }
        }
  
        ///  <summary>
        /// Danish: TILFLYKOMDT_UMRK
        /// Municipality arrival date uncertainty marker
        ///  </summary>
        public string MunicipalityArrivalDateUncertainty
        {
            get { return this[95, 1]; }
        }
  
        ///  <summary>
        /// Danish: FRAFLYKOMKOD
        /// Leaving municipality code
        ///  </summary>
        public decimal LeavingMunicipalityCode
        {
            get { return this.GetDecimal(96, 4); }
        }
  
        ///  <summary>
        /// Danish: FRAFLYKOMDTO
        /// Municipality departure date YYYYMMDDTTMM
        ///  </summary>
        public DateTime MunicipalityDepartureDate
        {
            get { return this.GetDateTime(100, 12, "YYYYMMDDHHmm"); }
        }
  
        ///  <summary>
        /// Danish: FRAFLYKOMDT_UMRK
        /// Municipality departure date uncertainty
        ///  </summary>
        public string MunicipalityDepartureDateUncertainty
        {
            get { return this[112, 1]; }
        }
  
        ///  <summary>
        /// Danish: START_MYNKOD-ADRTXT
        /// HomeAuthority
        ///  </summary>
        public decimal HomeAuthority
        {
            get { return this.GetDecimal(113, 4); }
        }
  
        ///  <summary>
        /// Danish: ADR1-SUPLADR
        /// First line of supplementary address
        ///  </summary>
        public string SupplementaryAddress1
        {
            get { return this[117, 34]; }
        }
  
        ///  <summary>
        /// Danish: ADR2-SUPLADR
        /// Second line of supplementary address
        ///  </summary>
        public string SupplementaryAddress2
        {
            get { return this[151, 34]; }
        }
  
        ///  <summary>
        /// Danish: ADR3-SUPLADR
        /// Third line of supplementary address
        ///  </summary>
        public string SupplementaryAddress3
        {
            get { return this[185, 34]; }
        }
  
        ///  <summary>
        /// Danish: ADR4-SUPLADR
        /// Fourth line of supplementary address
        ///  </summary>
        public string SupplementaryAddress4
        {
            get { return this[219, 34]; }
        }
  
        ///  <summary>
        /// Danish: ADR5-SUPLADR
        /// Fifth line of supplementary address
        ///  </summary>
        public string SupplementaryAddress5
        {
            get { return this[253, 34]; }
        }
  
        ///  <summary>
        /// Danish: START_DT-ADRTXT
        /// Start date YYYY-MM-DD
        ///  </summary>
        public DateTime StartDate
        {
            get { return this.GetDateTime(287, 10, "YYYY-MM-DD"); }
        }
  
        ///  <summary>
        /// Danish: SLET_DT-ADRTXT
        /// End date YYYY-MM-DD
        ///  </summary>
        public DateTime EndDate
        {
            get { return this.GetDateTime(297, 10, "YYYY-MM-DD"); }
        }
  
        #endregion

    }

  
    class ClearWrittenAddressType: Wrapper
    {
        #region Common
        public override int Length
        {
            get { return 249; }
        }
        #endregion
        
        #region Properties
    
        ///  <summary>
        /// Danish: RECORDTYPE
        /// Equals last three digits of the record name
        ///  </summary>
        public decimal RecordType
        {
            get { return this.GetDecimal(1, 3); }
        }
  
        ///  <summary>
        /// Danish: PNR
        /// CPR Number
        ///  </summary>
        public string PNR
        {
            get { return this[4, 10]; }
        }
  
        ///  <summary>
        /// Danish: ADRNVN
        /// Addressing name
        ///  </summary>
        public string AddressingName
        {
            get { return this[14, 34]; }
        }
  
        ///  <summary>
        /// Danish: CONVN
        /// C/O name
        ///  </summary>
        public string CareOfName
        {
            get { return this[48, 34]; }
        }
  
        ///  <summary>
        /// Danish: LOKALITET
        /// Location
        ///  </summary>
        public string Location
        {
            get { return this[82, 34]; }
        }
  
        ///  <summary>
        /// Danish: STANDARDADR
        /// Road addressing name, house number, floor, side doors BNR. Labelled Address
        ///  </summary>
        public string LabelledAddress
        {
            get { return this[116, 34]; }
        }
  
        ///  <summary>
        /// Danish: BYNVN
        /// City name
        ///  </summary>
        public string CityName
        {
            get { return this[150, 34]; }
        }
  
        ///  <summary>
        /// Danish: POSTNR
        /// Post code
        ///  </summary>
        public decimal PostCode
        {
            get { return this.GetDecimal(184, 4); }
        }
  
        ///  <summary>
        /// Danish: POSTDISTTXT
        /// Post district text
        ///  </summary>
        public string PostDistrictText
        {
            get { return this[188, 20]; }
        }
  
        ///  <summary>
        /// Danish: KOMKOD
        /// Municipality code
        ///  </summary>
        public decimal MunicipalityCode
        {
            get { return this.GetDecimal(208, 4); }
        }
  
        ///  <summary>
        /// Danish: VEJKOD
        /// Street code
        ///  </summary>
        public decimal StreetCode
        {
            get { return this.GetDecimal(212, 4); }
        }
  
        ///  <summary>
        /// Danish: HUSNR
        /// House number
        ///  </summary>
        public string HouseNumber
        {
            get { return this[216, 4]; }
        }
  
        ///  <summary>
        /// Danish: ETAGE
        /// Floor
        ///  </summary>
        public string Floor
        {
            get { return this[220, 2]; }
        }
  
        ///  <summary>
        /// Danish: SIDEDOER
        /// Door
        ///  </summary>
        public string Door
        {
            get { return this[222, 4]; }
        }
  
        ///  <summary>
        /// Danish: BNR
        /// Building number
        ///  </summary>
        public string BuildingNumber
        {
            get { return this[226, 4]; }
        }
  
        ///  <summary>
        /// Danish: VEJADRNVN
        /// Street addressing name
        ///  </summary>
        public string StreetAddressingName
        {
            get { return this[230, 20]; }
        }
  
        #endregion

    }

  
    class ProtectionType: Wrapper
    {
        #region Common
        public override int Length
        {
            get { return 37; }
        }
        #endregion
        
        #region Properties
    
        ///  <summary>
        /// Danish: RECORDTYPE
        /// Equals last three digits of the record name
        ///  </summary>
        public decimal RecordType
        {
            get { return this.GetDecimal(1, 3); }
        }
  
        ///  <summary>
        /// Danish: PNR
        /// CPR Number
        ///  </summary>
        public string PNR
        {
            get { return this[4, 10]; }
        }
  
        ///  <summary>
        /// Danish: BESKYTTYPE
        /// Protection type
        ///  </summary>
        public decimal ProtectionType_
        {
            get { return this.GetDecimal(14, 4); }
        }
  
        ///  <summary>
        /// Danish: START_DT-BESKYTTELSE
        /// Start date YYYY-MM-DD
        ///  </summary>
        public DateTime StartDate
        {
            get { return this.GetDateTime(18, 10, "YYYY-MM-DD"); }
        }
  
        ///  <summary>
        /// Danish: SLET_DT-BESKYTTELSE
        /// End date YYYY-MM-DD
        ///  </summary>
        public DateTime EndDate
        {
            get { return this.GetDateTime(28, 10, "YYYY-MM-DD"); }
        }
  
        #endregion

    }

  
    class CurrentDepartureDataType: Wrapper
    {
        #region Common
        public override int Length
        {
            get { return 200; }
        }
        #endregion
        
        #region Properties
    
        ///  <summary>
        /// Danish: RECORDTYPE
        /// Equals last three digits of the record name
        ///  </summary>
        public decimal RecordType
        {
            get { return this.GetDecimal(1, 3); }
        }
  
        ///  <summary>
        /// Danish: PNR
        /// CPR Number
        ///  </summary>
        public string PNR
        {
            get { return this[4, 10]; }
        }
  
        ///  <summary>
        /// Danish: UDR_LANDEKOD
        /// Exit country code
        ///  </summary>
        public decimal ExitCountryCode
        {
            get { return this.GetDecimal(14, 4); }
        }
  
        ///  <summary>
        /// Danish: UDRDTO
        /// Exit date YYYYMMDDTTMM
        ///  </summary>
        public DateTime ExitDate
        {
            get { return this.GetDateTime(18, 12, "YYYYMMDDHHmm"); }
        }
  
        ///  <summary>
        /// Danish: UDRDTO_UMRK
        /// Exit date uncertainty marker
        ///  </summary>
        public string ExitDateUncertainty
        {
            get { return this[30, 1]; }
        }
  
        ///  <summary>
        /// Danish: UDLANDADR1
        /// Foreign Address 1
        ///  </summary>
        public string ForeignAddress1
        {
            get { return this[31, 34]; }
        }
  
        ///  <summary>
        /// Danish: UDLANDADR2
        /// Foreign Address 2
        ///  </summary>
        public string ForeignAddress2
        {
            get { return this[65, 34]; }
        }
  
        ///  <summary>
        /// Danish: UDLANDADR3
        /// Foreign Address 3
        ///  </summary>
        public string ForeignAddress3
        {
            get { return this[99, 34]; }
        }
  
        ///  <summary>
        /// Danish: UDLANDADR4
        /// Foreign Address 4
        ///  </summary>
        public string ForeignAddress4
        {
            get { return this[133, 34]; }
        }
  
        ///  <summary>
        /// Danish: UDLANDADR5
        /// Foreign Address 5
        ///  </summary>
        public string ForeignAddress5
        {
            get { return this[167, 34]; }
        }
  
        #endregion

    }

  
    class ContactAddressType: Wrapper
    {
        #region Common
        public override int Length
        {
            get { return 203; }
        }
        #endregion
        
        #region Properties
    
        ///  <summary>
        /// Danish: RECORDTYPE
        /// Equals last three digits of the record name
        ///  </summary>
        public decimal RecordType
        {
            get { return this.GetDecimal(1, 3); }
        }
  
        ///  <summary>
        /// Danish: PNR
        /// CPR Number
        ///  </summary>
        public string PNR
        {
            get { return this[4, 10]; }
        }
  
        ///  <summary>
        /// Danish: ADR1-KONTAKTADR
        /// Contact address line 1
        ///  </summary>
        public string Line1
        {
            get { return this[14, 34]; }
        }
  
        ///  <summary>
        /// Danish: ADR2-KONTAKTADR
        /// Contact address line 2
        ///  </summary>
        public string Line2
        {
            get { return this[48, 34]; }
        }
  
        ///  <summary>
        /// Danish: ADR3-KONTAKTADR
        /// Contact address line 3
        ///  </summary>
        public string Line3
        {
            get { return this[82, 34]; }
        }
  
        ///  <summary>
        /// Danish: ADR4-KONTAKTADR
        /// Contact address line 4
        ///  </summary>
        public string Line4
        {
            get { return this[116, 34]; }
        }
  
        ///  <summary>
        /// Danish: ADR5-KONTAKTADR
        /// Contact address line 5
        ///  </summary>
        public string Line5
        {
            get { return this[150, 34]; }
        }
  
        ///  <summary>
        /// Danish: START_DT-ADRTXT
        /// Start date YYYY-MM-DD
        ///  </summary>
        public DateTime StartDate
        {
            get { return this.GetDateTime(184, 10, "YYYY-MM-DD"); }
        }
  
        ///  <summary>
        /// Danish: SLET_DT-ADRTXT
        /// End date YYYY-MM-DD
        ///  </summary>
        public DateTime EndDate
        {
            get { return this.GetDateTime(194, 10, "YYYY-MM-DD"); }
        }
  
        #endregion

    }

  
    class CurrentDisappearanceInformationType: Wrapper
    {
        #region Common
        public override int Length
        {
            get { return 26; }
        }
        #endregion
        
        #region Properties
    
        ///  <summary>
        /// Danish: RECORDTYPE
        /// Equals last three digits of the record name
        ///  </summary>
        public decimal RecordType
        {
            get { return this.GetDecimal(1, 3); }
        }
  
        ///  <summary>
        /// Danish: PNR
        /// CPR Number
        ///  </summary>
        public string PNR
        {
            get { return this[4, 10]; }
        }
  
        ///  <summary>
        /// Danish: FORSVINDDTO
        /// Disappearance date YYYYMMDDTTMM
        ///  </summary>
        public DateTime DisappearanceDate
        {
            get { return this.GetDateTime(14, 12, "YYYYMMDDHHmm"); }
        }
  
        ///  <summary>
        /// Danish: FORSVINDDTO_UMRK
        /// Disappearance date uncertainty marker
        ///  </summary>
        public string DisappearanceDateUncertainty
        {
            get { return this[26, 1]; }
        }
  
        #endregion

    }

  
    class CurrentNameInformationType: Wrapper
    {
        #region Common
        public override int Length
        {
            get { return 193; }
        }
        #endregion
        
        #region Properties
    
        ///  <summary>
        /// Danish: RECORDTYPE
        /// Equals last three digits of the record name
        ///  </summary>
        public decimal RecordType
        {
            get { return this.GetDecimal(1, 3); }
        }
  
        ///  <summary>
        /// Danish: PNR
        /// CPR Number
        ///  </summary>
        public string PNR
        {
            get { return this[4, 10]; }
        }
  
        ///  <summary>
        /// Danish: FORNVN
        /// First name (s)
        ///  </summary>
        public string FirstName_s
        {
            get { return this[14, 50]; }
        }
  
        ///  <summary>
        /// Danish: FORNVN_MRK
        /// First name marker
        ///  </summary>
        public string FirstNameMarker
        {
            get { return this[64, 1]; }
        }
  
        ///  <summary>
        /// Danish: MELNVN
        /// Middle name
        ///  </summary>
        public string MiddleName
        {
            get { return this[65, 40]; }
        }
  
        ///  <summary>
        /// Danish: MELNVN_MRK
        /// Middle name marker
        ///  </summary>
        public string MiddleNameMarker
        {
            get { return this[105, 1]; }
        }
  
        ///  <summary>
        /// Danish: EFTERNVN
        /// Last name
        ///  </summary>
        public string LastName
        {
            get { return this[106, 40]; }
        }
  
        ///  <summary>
        /// Danish: EFTERNVN_MRK
        /// Last name marker
        ///  </summary>
        public string LastNameMarker
        {
            get { return this[146, 1]; }
        }
  
        ///  <summary>
        /// Danish: NVNHAENSTART
        /// Name start date YYYYMMDDTTMM
        ///  </summary>
        public DateTime NameStartDate
        {
            get { return this.GetDateTime(147, 12, "YYYYMMDDHHmm"); }
        }
  
        ///  <summary>
        /// Danish: HAENSTART_UMRK-NAVNE
        /// Name start date uncertainty marker
        ///  </summary>
        public string NameStartDateUncertainty
        {
            get { return this[159, 1]; }
        }
  
        ///  <summary>
        /// Danish: ADRNVN
        /// AddressingName
        ///  </summary>
        public string AddressingName
        {
            get { return this[160, 34]; }
        }
  
        #endregion

    }

  
    class BirthRegistrationInformationType: Wrapper
    {
        #region Common
        public override int Length
        {
            get { return 37; }
        }
        #endregion
        
        #region Properties
    
        ///  <summary>
        /// Danish: RECORDTYPE
        /// Equals last three digits of the record name
        ///  </summary>
        public decimal RecordType
        {
            get { return this.GetDecimal(1, 3); }
        }
  
        ///  <summary>
        /// Danish: PNR
        /// CPR Number
        ///  </summary>
        public string PNR
        {
            get { return this[4, 10]; }
        }
  
        ///  <summary>
        /// Danish: START_MYNKOD-FØDESTED
        /// Birth registration authority code
        ///  </summary>
        public decimal BirthRegistrationAuthorityCode
        {
            get { return this.GetDecimal(14, 4); }
        }
  
        ///  <summary>
        /// Danish: MYNTXT-FØDESTED
        /// Additional birth registration text
        ///  </summary>
        public string AdditionalBirthRegistrationText
        {
            get { return this[18, 20]; }
        }
  
        #endregion

    }

  
    class CurrentCitizenshipType: Wrapper
    {
        #region Common
        public override int Length
        {
            get { return 30; }
        }
        #endregion
        
        #region Properties
    
        ///  <summary>
        /// Danish: RECORDTYPE
        /// Equals last three digits of the record name
        ///  </summary>
        public decimal RecordType
        {
            get { return this.GetDecimal(1, 3); }
        }
  
        ///  <summary>
        /// Danish: PNR
        /// CPR Number
        ///  </summary>
        public string PNR
        {
            get { return this[4, 10]; }
        }
  
        ///  <summary>
        /// Danish: LANDEKOD
        /// Country code
        ///  </summary>
        public decimal CountryCode
        {
            get { return this.GetDecimal(14, 4); }
        }
  
        ///  <summary>
        /// Danish: HAENSTART-STATSBORGERSKAB
        /// Citizenship start date YYYYMMDDTTMM
        ///  </summary>
        public DateTime CitizenshipStartDate
        {
            get { return this.GetDateTime(18, 12, "YYYYMMDDHHmm"); }
        }
  
        ///  <summary>
        /// Danish: HAENSTART_UMRK-STATSBORGERSKAB
        /// Citizenship start date uncertainty marker
        ///  </summary>
        public string CitizenshipStartDateUncertainty
        {
            get { return this[30, 1]; }
        }
  
        #endregion

    }

  
    class ChurchInformationType: Wrapper
    {
        #region Common
        public override int Length
        {
            get { return 25; }
        }
        #endregion
        
        #region Properties
    
        ///  <summary>
        /// Danish: RECORDTYPE
        /// Equals last three digits of the record name
        ///  </summary>
        public decimal RecordType
        {
            get { return this.GetDecimal(1, 3); }
        }
  
        ///  <summary>
        /// Danish: PNR
        /// CPR Number
        ///  </summary>
        public string PNR
        {
            get { return this[4, 10]; }
        }
  
        ///  <summary>
        /// Danish: FKIRK
        /// church Relationship
        ///  </summary>
        public string ChurchRelationship
        {
            get { return this[14, 1]; }
        }
  
        ///  <summary>
        /// Danish: START_DT-FOLKEKIRKE
        /// Start date YYYY-MM-DD
        ///  </summary>
        public DateTime StartDate
        {
            get { return this.GetDateTime(15, 10, "YYYY-MM-DD"); }
        }
  
        ///  <summary>
        /// Danish: START_DT_UMRK-FOLKEKIRKE
        /// Start date uncertainty marker
        ///  </summary>
        public string StartDateUncertainty
        {
            get { return this[25, 1]; }
        }
  
        #endregion

    }

  
    class CurrentCivilStatusType: Wrapper
    {
        #region Common
        public override int Length
        {
            get { return 95; }
        }
        #endregion
        
        #region Properties
    
        ///  <summary>
        /// Danish: RECORDTYPE
        /// Equals last three digits of the record name
        ///  </summary>
        public decimal RecordType
        {
            get { return this.GetDecimal(1, 3); }
        }
  
        ///  <summary>
        /// Danish: PNR
        /// CPR Number
        ///  </summary>
        public string PNR
        {
            get { return this[4, 10]; }
        }
  
        ///  <summary>
        /// Danish: CIVST
        /// Civil status
        ///  </summary>
        public string CivilStatus
        {
            get { return this[14, 1]; }
        }
  
        ///  <summary>
        /// Danish: AEGTEPNR
        /// Spouse PNR
        ///  </summary>
        public string SpousePNR
        {
            get { return this[15, 10]; }
        }
  
        ///  <summary>
        /// Danish: AEGTEFOED_DT
        /// Spouse birth date YYYY-MM-DD
        ///  </summary>
        public DateTime SpouseBirthDate
        {
            get { return this.GetDateTime(25, 10, "YYYY-MM-DD"); }
        }
  
        ///  <summary>
        /// Danish: AEGTEFOEDDT_UMRK
        /// Spouse birth date uncertainty
        ///  </summary>
        public string SpouseBirthDateUncertainty
        {
            get { return this[35, 1]; }
        }
  
        ///  <summary>
        /// Danish: AEGTENVN
        /// Spouse name
        ///  </summary>
        public string SpouseName
        {
            get { return this[36, 34]; }
        }
  
        ///  <summary>
        /// Danish: AEGTENVN_MRK
        /// Spouse name marker
        ///  </summary>
        public string SpouseNameMarker
        {
            get { return this[70, 1]; }
        }
  
        ///  <summary>
        /// Danish: HAENSTART-CIVILSTAND
        /// Civil status start date
        ///  </summary>
        public DateTime CivilStatusStartDate
        {
            get { return this.GetDateTime(71, 12, "YYYYMMDDHHmm"); }
        }
  
        ///  <summary>
        /// Danish: HAENSTART_UMRK-CIVILSTAND
        /// Civil status start date uncertainty marker
        ///  </summary>
        public string CivilStatusStartDateUncertainty
        {
            get { return this[83, 1]; }
        }
  
        ///  <summary>
        /// Danish: SEP_HENVIS-CIVILSTAND
        /// Reference to any. separation YYYYMMDDTTMM
        ///  </summary>
        public DateTime ReferenceToAnySeparation
        {
            get { return this.GetDateTime(84, 12, "YYYYMMDDHHmm"); }
        }
  
        #endregion

    }

  
    class CurrentSeparationType: Wrapper
    {
        #region Common
        public override int Length
        {
            get { return 36; }
        }
        #endregion
        
        #region Properties
    
        ///  <summary>
        /// Danish: RECORDTYPE
        /// Equals last three digits of the record name
        ///  </summary>
        public decimal RecordType
        {
            get { return this.GetDecimal(1, 3); }
        }
  
        ///  <summary>
        /// Danish: PNR
        /// CPR Number
        ///  </summary>
        public string PNR
        {
            get { return this[4, 10]; }
        }
  
        ///  <summary>
        /// Danish: SEP_HENVIS-SEPARATION
        /// Reference to any. marital status YYYYMMDDTTMM
        ///  </summary>
        public DateTime ReferenceToAnyMaritalStatus
        {
            get { return this.GetDateTime(14, 12, "YYYYMMDDHHmm"); }
        }
  
        ///  <summary>
        /// Danish: START_DT-SEPARATION
        /// Separation start date YYYY-MM-DD
        ///  </summary>
        public DateTime SeparationStartDate
        {
            get { return this.GetDateTime(26, 10, "YYYY-MM-DD"); }
        }
  
        ///  <summary>
        /// Danish: START_DT_UMRK-SEPARATION
        /// Separation start date uncertainty marker
        ///  </summary>
        public string SeparationStartDateUncertainty
        {
            get { return this[36, 1]; }
        }
  
        #endregion

    }

  
    class ChildType: Wrapper
    {
        #region Common
        public override int Length
        {
            get { return 23; }
        }
        #endregion
        
        #region Properties
    
        ///  <summary>
        /// Danish: RECORDTYPE
        /// Equals last three digits of the record name
        ///  </summary>
        public decimal RecordType
        {
            get { return this.GetDecimal(1, 3); }
        }
  
        ///  <summary>
        /// Danish: PNR
        /// CPR Number
        ///  </summary>
        public string PNR
        {
            get { return this[4, 10]; }
        }
  
        ///  <summary>
        /// Danish: PNR
        /// Child PNR
        ///  </summary>
        public string ChildPNR
        {
            get { return this[14, 10]; }
        }
  
        #endregion

    }

  
    class ParentsInformationType: Wrapper
    {
        #region Common
        public override int Length
        {
            get { return 147; }
        }
        #endregion
        
        #region Properties
    
        ///  <summary>
        /// Danish: RECORDTYPE
        /// Equals last three digits of the record name
        ///  </summary>
        public decimal RecordType
        {
            get { return this.GetDecimal(1, 3); }
        }
  
        ///  <summary>
        /// Danish: PNR
        /// CPR Number
        ///  </summary>
        public string PNR
        {
            get { return this[4, 10]; }
        }
  
        ///  <summary>
        /// Danish: MOR_DT
        /// Mother date YYYY-MM-DD
        ///  </summary>
        public DateTime MotherDate
        {
            get { return this.GetDateTime(14, 10, "YYYY-MM-DD"); }
        }
  
        ///  <summary>
        /// Danish: MOR_DT_UMRK
        /// Mother date uncertainty marker
        ///  </summary>
        public string MotherDateUncertaintyMarker
        {
            get { return this[24, 1]; }
        }
  
        ///  <summary>
        /// Danish: PNRMOR
        /// Mother PNR
        ///  </summary>
        public string MotherPNR
        {
            get { return this[25, 10]; }
        }
  
        ///  <summary>
        /// Danish: MOR_FOED_DT
        /// Mother birth date YYYY-MM-DD
        ///  </summary>
        public DateTime MotherBirthDate
        {
            get { return this.GetDateTime(35, 10, "YYYY-MM-DD"); }
        }
  
        ///  <summary>
        /// Danish: MOR_FOED_DT_UMRK
        /// Mother birth date uncertainty marker
        ///  </summary>
        public string MotherBirthDateUncertainty
        {
            get { return this[45, 1]; }
        }
  
        ///  <summary>
        /// Danish: MORNVN
        /// Mother name
        ///  </summary>
        public string MotherName
        {
            get { return this[46, 34]; }
        }
  
        ///  <summary>
        /// Danish: MORNVN_MRK
        /// Mother name marker
        ///  </summary>
        public string MotherNameUncertainty
        {
            get { return this[80, 1]; }
        }
  
        ///  <summary>
        /// Danish: FAR_DT
        /// Father date YYYY-MM-DD
        ///  </summary>
        public DateTime FatherDate
        {
            get { return this.GetDateTime(81, 10, "YYYY-MM-DD"); }
        }
  
        ///  <summary>
        /// Danish: FAR_DT_UMRK
        /// Father date uncertainty marker
        ///  </summary>
        public string FatherDateUncertainty
        {
            get { return this[91, 1]; }
        }
  
        ///  <summary>
        /// Danish: PNRFAR
        /// Father PNR
        ///  </summary>
        public string FatherPNR
        {
            get { return this[92, 10]; }
        }
  
        ///  <summary>
        /// Danish: FAR_FOED_DT
        /// Father birth date YYYY-MM-DD
        ///  </summary>
        public DateTime FatherBirthDate
        {
            get { return this.GetDateTime(102, 10, "YYYY-MM-DD"); }
        }
  
        ///  <summary>
        /// Danish: FAR_FOED_DT_UMRK
        /// Father birth date uncertainty marker
        ///  </summary>
        public string FatherBirthDateUncertainty
        {
            get { return this[112, 1]; }
        }
  
        ///  <summary>
        /// Danish: FARNVN
        /// Father name
        ///  </summary>
        public string FatherName
        {
            get { return this[113, 34]; }
        }
  
        ///  <summary>
        /// Danish: FARNVN_MRK
        /// Father name marker
        ///  </summary>
        public string FatherNameUncertainty
        {
            get { return this[147, 1]; }
        }
  
        #endregion

    }

  
    class ParentalAuthorityType: Wrapper
    {
        #region Common
        public override int Length
        {
            get { return 58; }
        }
        #endregion
        
        #region Properties
    
        ///  <summary>
        /// Danish: RECORDTYPE
        /// Equals last three digits of the record name
        ///  </summary>
        public decimal RecordType
        {
            get { return this.GetDecimal(1, 3); }
        }
  
        ///  <summary>
        /// Danish: PNR
        /// CPR Number
        ///  </summary>
        public string PNR
        {
            get { return this[4, 10]; }
        }
  
        ///  <summary>
        /// Danish: RELTYP-FORÆLDREMYN
        /// Relationship type
        ///  </summary>
        public decimal RelationshipType
        {
            get { return this.GetDecimal(14, 4); }
        }
  
        ///  <summary>
        /// Danish: START_DT-FORÆLDREMYN
        /// Custody start date YYYY-MM-DD
        ///  </summary>
        public DateTime CustodyStartDate
        {
            get { return this.GetDateTime(18, 10, "YYYY-MM-DD"); }
        }
  
        ///  <summary>
        /// Danish: START_DT_UMRK-FORÆLDREMYN
        /// Custody start date uncertainty marker
        ///  </summary>
        public string CustodyStartDateUncertainty
        {
            get { return this[28, 1]; }
        }
  
        ///  <summary>
        /// Danish: SLET_DT-FORÆLDREMYN
        /// Custody end date YYYY-MM-DD
        ///  </summary>
        public DateTime CustodyEndDate
        {
            get { return this.GetDateTime(29, 10, "YYYY-MM-DD"); }
        }
  
        ///  <summary>
        /// Danish: RELPNR
        /// Relation PNR
        ///  </summary>
        public string RelationPNR
        {
            get { return this[39, 10]; }
        }
  
        ///  <summary>
        /// Danish: START_DT-RELPNR_PNR
        /// Relation PNR start date YYYY-MM-DD
        ///  </summary>
        public DateTime RelationPNRStartDate
        {
            get { return this.GetDateTime(49, 10, "YYYY-MM-DD"); }
        }
  
        #endregion

    }

  
    class DisempowermentType: Wrapper
    {
        #region Common
        public override int Length
        {
            get { return 272; }
        }
        #endregion
        
        #region Properties
    
        ///  <summary>
        /// Danish: RECORDTYPE
        /// Equals last three digits of the record name
        ///  </summary>
        public decimal RecordType
        {
            get { return this.GetDecimal(1, 3); }
        }
  
        ///  <summary>
        /// Danish: PNR
        /// CPR Number
        ///  </summary>
        public string PNR
        {
            get { return this[4, 10]; }
        }
  
        ///  <summary>
        /// Danish: START_DT-UMYNDIG
        /// Disempowerment start date YYYY-MM-DD
        ///  </summary>
        public DateTime DisempowermentStartDate
        {
            get { return this.GetDateTime(14, 10, "YYYY-MM-DD"); }
        }
  
        ///  <summary>
        /// Danish: PNR
        /// Disempowerment start date uncertainty marker
        ///  </summary>
        public string DisempowermentStartDateUncertainty
        {
            get { return this[24, 1]; }
        }
  
        ///  <summary>
        /// Danish: SLET_DT-UMYNDIG
        /// Disempowerment end date YYYY-MM-DD
        ///  </summary>
        public DateTime DisempowermentEndDate
        {
            get { return this.GetDateTime(25, 10, "YYYY-MM-DD"); }
        }
  
        ///  <summary>
        /// Danish: UMYN_RELTYP
        /// Guardian relation type
        ///  </summary>
        public decimal GuardianRelationType
        {
            get { return this.GetDecimal(35, 4); }
        }
  
        ///  <summary>
        /// Danish: RELPNR
        /// Relation PNR
        ///  </summary>
        public string RelationPNR
        {
            get { return this[39, 10]; }
        }
  
        ///  <summary>
        /// Danish: START_DT-RELPNR_PNR
        /// Relation PNR start date YYYY-MM-DD
        ///  </summary>
        public DateTime RelationPNRStartDate
        {
            get { return this.GetDateTime(49, 10, "YYYY-MM-DD"); }
        }
  
        ///  <summary>
        /// Danish: RELADRSAT_RELPNR_TXT
        /// Guardian's name
        ///  </summary>
        public string GuardianName
        {
            get { return this[59, 34]; }
        }
  
        ///  <summary>
        /// Danish: START_DT-RELPNR_TXT
        /// Guardian's address start date YYYY-MM-DD
        ///  </summary>
        public DateTime GuardianAddressStartDate
        {
            get { return this.GetDateTime(93, 10, "YYYY-MM-DD"); }
        }
  
        ///  <summary>
        /// Danish: RELTXT1
        /// Relation text 1
        ///  </summary>
        public string RelationText1
        {
            get { return this[103, 34]; }
        }
  
        ///  <summary>
        /// Danish: RELTXT2
        /// Relation text 2
        ///  </summary>
        public string RelationText2
        {
            get { return this[137, 34]; }
        }
  
        ///  <summary>
        /// Danish: RELTXT3
        /// Relation text 3
        ///  </summary>
        public string RelationText3
        {
            get { return this[171, 34]; }
        }
  
        ///  <summary>
        /// Danish: RELTXT4
        /// Relation text 4
        ///  </summary>
        public string RelationText4
        {
            get { return this[205, 34]; }
        }
  
        ///  <summary>
        /// Danish: RELTXT5
        /// Relation text 5
        ///  </summary>
        public string RelationText5
        {
            get { return this[239, 34]; }
        }
  
        #endregion

    }

  
    class MunicipalConditionsType: Wrapper
    {
        #region Common
        public override int Length
        {
            get { return 60; }
        }
        #endregion
        
        #region Properties
    
        ///  <summary>
        /// Danish: RECORDTYPE
        /// Equals last three digits of the record name
        ///  </summary>
        public decimal RecordType
        {
            get { return this.GetDecimal(1, 3); }
        }
  
        ///  <summary>
        /// Danish: PNR
        /// CPR Number
        ///  </summary>
        public string PNR
        {
            get { return this[4, 10]; }
        }
  
        ///  <summary>
        /// Danish: KOMFORHTYP
        /// Municipal condition type
        ///  </summary>
        public decimal MunicipalConditionType
        {
            get { return this.GetDecimal(14, 1); }
        }
  
        ///  <summary>
        /// Danish: KOMFORHKOD
        /// Municipal condition code
        ///  </summary>
        public string MunicipalConditionCode
        {
            get { return this[15, 5]; }
        }
  
        ///  <summary>
        /// Danish: START_DT-KOMMUNALE-FORHOLD
        /// Municipal condition start date YYYY-MM-DD
        ///  </summary>
        public DateTime MunicipalConditionStartDate
        {
            get { return this.GetDateTime(20, 10, "YYYY-MM-DD"); }
        }
  
        ///  <summary>
        /// Danish: START_DT_UMRK-KOMMUNALE-FORHOL
        /// Start date uncertainty marker
        ///  </summary>
        public string MunicipalConditionStartDateUncertaintyMarker
        {
            get { return this[30, 1]; }
        }
  
        ///  <summary>
        /// Danish: BEMAERK-KOMMUNALE-FORHOLD
        /// Municipal condition comment
        ///  </summary>
        public string MunicipalConditionComment
        {
            get { return this[31, 30]; }
        }
  
        #endregion

    }

  
    class EndRecordType: Wrapper
    {
        #region Common
        public override int Length
        {
            get { return 21; }
        }
        #endregion
        
        #region Properties
    
        ///  <summary>
        /// Danish: RECORDTYPE
        /// Equals last three digits of the record name
        ///  </summary>
        public decimal RecordType
        {
            get { return this.GetDecimal(1, 3); }
        }
  
        ///  <summary>
        /// Danish: TAELLER
        /// BLACK BOX 10
        ///  </summary>
        public string BlackBox10
        {
            get { return this[4, 10]; }
        }
  
        ///  <summary>
        /// Danish: TAELLER
        /// Counter
        ///  </summary>
        public string Counter
        {
            get { return this[14, 8]; }
        }
  
        #endregion

    }

  
    }
  