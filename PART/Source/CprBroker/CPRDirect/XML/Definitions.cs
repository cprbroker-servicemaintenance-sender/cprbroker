
    using System;
    using System.Collections.Generic;

    namespace CprBroker.Providers.CPRDirect
    {
    
    public partial class IndividualRequestType: Wrapper
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
            get { return this.GetString(1, 4); }

            set { this.SetString(value, 1, 4); }
        }  
        ///  <summary>
        /// Danish: KOMMA
        /// Comma character used as separator
        ///  </summary>
        public char Comma
        {
            get { return this.GetChar(5); }

            set { this.SetChar(value, 5); }
        }  
        ///  <summary>
        /// Danish: KUNDENR
        /// Identification of the customer
        ///  </summary>
        public decimal CustomerNumber
        {
            get { return this.GetDecimal(6, 4); }

            set { this.SetDecimal(value, 6, 4); }
        }  
        ///  <summary>
        /// Danish: ABON_TYPE
        /// Subscription phrase / delete or not
        ///  </summary>
        public decimal SubscriptionType
        {
            get { return this.GetDecimal(10, 1); }

            set { this.SetDecimal(value, 10, 1); }
        }  
        ///  <summary>
        /// Danish: DATA_TYPE
        /// Desired output - 0 in LOGONINDIVID
        ///  </summary>
        public decimal DataType
        {
            get { return this.GetDecimal(11, 1); }

            set { this.SetDecimal(value, 11, 1); }
        }  
        ///  <summary>
        /// Danish: TOKEN
        ///  </summary>
        public string Token
        {
            get { return this.GetString(12, 8); }

            set { this.SetString(value, 12, 8); }
        }  
        ///  <summary>
        /// Danish: BRUGER_ID
        /// The CPR Unit assigned system user code
        ///  </summary>
        public string UserId
        {
            get { return this.GetString(20, 8); }

            set { this.SetString(value, 20, 8); }
        }  
        ///  <summary>
        /// Danish: FEJLNR
        /// Indicator of the communication process
        ///  </summary>
        public decimal ErrorNumber
        {
            get { return this.GetDecimal(28, 2); }

            set { this.SetDecimal(value, 28, 2); }
        }  
        ///  <summary>
        /// Danish: PNR
        /// Request PNR
        ///  </summary>
        public decimal PNR
        {
            get { return this.GetDecimal(30, 10); }

            set { this.SetDecimal(value, 30, 10); }
        }  
        #endregion

    }

  
    public partial class IndividualResponseType: Wrapper
    {
        #region Common
        public override int Length
        {
            get { return 0; }
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

            set { this.SetDecimal(value, 1, 4); }
        }  
        ///  <summary>
        /// Danish: ABON_TYPE
        /// Subscription phrase / delete or not
        ///  </summary>
        public decimal SubscriptionType
        {
            get { return this.GetDecimal(5, 1); }

            set { this.SetDecimal(value, 5, 1); }
        }  
        ///  <summary>
        /// Danish: DATA_TYPE
        /// 0 in LOGONINDIVID (see Annex 2)Desired output
        ///  </summary>
        public decimal DataType
        {
            get { return this.GetDecimal(6, 1); }

            set { this.SetDecimal(value, 6, 1); }
        }  
        ///  <summary>
        /// Danish: TOKEN
        /// Taken from the logon
        ///  </summary>
        public string Token
        {
            get { return this.GetString(7, 8); }

            set { this.SetString(value, 7, 8); }
        }  
        ///  <summary>
        /// Danish: BRUGER-ID
        /// The CPR Unit assigned system user code
        ///  </summary>
        public string UserId
        {
            get { return this.GetString(15, 8); }

            set { this.SetString(value, 15, 8); }
        }  
        ///  <summary>
        /// Danish: FEJLNR
        /// Indicator of the communication process
        ///  </summary>
        public decimal ErrorNumber
        {
            get { return this.GetDecimal(23, 2); }

            set { this.SetDecimal(value, 23, 2); }
        }  
        ///  <summary>
        /// Length of structure 28 + data MAX 2880
        ///  </summary>
        public decimal DataLength
        {
            get { return this.GetDecimal(25, 4); }

            set { this.SetDecimal(value, 25, 4); }
        }  
        ///  <summary>
        /// Danish: DATA
        /// Personal data from the CPR (format and amount depends on DATA_TYPE
        ///  </summary>
        public string Data
        {
            get { return this.GetString(29, 2880); }

            set { this.SetString(value, 29, 2880); }
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

  
    public partial class StartRecordType: Wrapper
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

            set { this.SetDecimal(value, 1, 3); }
        }  
        ///  <summary>
        /// Danish: SORTFELT-10
        /// BLACK BOX-10
        ///  </summary>
        public string BlackBox10
        {
            get { return this.GetString(4, 10); }

            set { this.SetString(value, 4, 10); }
        }  
        ///  <summary>
        /// Danish: OPGAVENR
        ///  </summary>
        public decimal TaskNumber
        {
            get { return this.GetDecimal(14, 6); }

            set { this.SetDecimal(value, 14, 6); }
        }  
        ///  <summary>
        /// Danish: PRODDTO
        /// Production date yyyyMMdd
        ///  </summary>
        public DateTime? ProductionDate
        {
            get { return this.GetDateTime(20, 8, "yyyyMMdd"); }

            set { this.SetDateTime(value, 20, 8, "yyyyMMdd"); }
        }  
        ///  <summary>
        /// Danish: PRODDTOFORRIG
        /// Previous production date yyyyMMdd
        ///  </summary>
        public DateTime? PreviousProductionDate
        {
            get { return this.GetDateTime(28, 8, "yyyyMMdd"); }

            set { this.SetDateTime(value, 28, 8, "yyyyMMdd"); }
        }  
        #endregion

    }

  
    public partial class PersonInformationType: Wrapper
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

            set { this.SetDecimal(value, 1, 3); }
        }  
        ///  <summary>
        /// Danish: PNR
        /// CPR Number
        ///  </summary>
        public string PNR
        {
            get { return this.GetString(4, 10); }

            set { this.SetString(value, 4, 10); }
        }  
        ///  <summary>
        /// Danish: PNRGAELD
        /// Current CPR Number
        ///  </summary>
        public string CurrentCprNumber
        {
            get { return this.GetString(14, 10); }

            set { this.SetString(value, 14, 10); }
        }  
        ///  <summary>
        /// Danish: STATUS
        /// Status
        ///  </summary>
        public decimal Status
        {
            get { return this.GetDecimal(24, 2); }

            set { this.SetDecimal(value, 24, 2); }
        }  
        ///  <summary>
        /// Danish: STATUSHAENSTART
        /// Status date yyyyMMddHHmm
        ///  </summary>
        public DateTime? StatusStartDate
        {
            get { return this.GetDateTime(26, 12, "yyyyMMddHHmm"); }

            set { this.SetDateTime(value, 26, 12, "yyyyMMddHHmm"); }
        }  
        ///  <summary>
        /// Danish: STATUSDTO_UMRK
        /// Status date uncertainty marker
        ///  </summary>
        public char StatusDateUncertainty
        {
            get { return this.GetChar(38); }

            set { this.SetChar(value, 38); }
        }  
        ///  <summary>
        /// Danish: KOEN
        /// CPR Number
        ///  </summary>
        public char Gender
        {
            get { return this.GetChar(39); }

            set { this.SetChar(value, 39); }
        }  
        ///  <summary>
        /// Danish: FOED_DT
        /// Birth date yyyy-MM-dd
        ///  </summary>
        public DateTime? Birthdate
        {
            get { return this.GetDateTime(40, 10, "yyyy-MM-dd"); }

            set { this.SetDateTime(value, 40, 10, "yyyy-MM-dd"); }
        }  
        ///  <summary>
        /// Danish: FOED_DT_UMRK
        /// Birth date uncertainty marker
        ///  </summary>
        public char BirthdateUncertainty
        {
            get { return this.GetChar(50); }

            set { this.SetChar(value, 50); }
        }  
        ///  <summary>
        /// Danish: START_DT-PERSON
        /// Person start date yyyy-MM-dd
        ///  </summary>
        public DateTime? PersonStartDate
        {
            get { return this.GetDateTime(51, 10, "yyyy-MM-dd"); }

            set { this.SetDateTime(value, 51, 10, "yyyy-MM-dd"); }
        }  
        ///  <summary>
        /// Danish: START_DT_UMRK-PERSON
        /// Start date uncertainty marker
        ///  </summary>
        public char PersonStartDateUncertainty
        {
            get { return this.GetChar(61); }

            set { this.SetChar(value, 61); }
        }  
        ///  <summary>
        /// Danish: SLUT_DT-PERSON
        /// Person end date yyyy-MM-dd
        ///  </summary>
        public DateTime? PersonEndDate 
        {
            get { return this.GetDateTime(62, 10, "yyyy-MM-dd"); }

            set { this.SetDateTime(value, 62, 10, "yyyy-MM-dd"); }
        }  
        ///  <summary>
        /// Danish: PNR
        /// End date uncertainty marker
        ///  </summary>
        public char PersonEndDateUncertainty
        {
            get { return this.GetChar(72); }

            set { this.SetChar(value, 72); }
        }  
        ///  <summary>
        /// Danish: STILLING
        /// Job
        ///  </summary>
        public string Job
        {
            get { return this.GetString(73, 34); }

            set { this.SetString(value, 73, 34); }
        }  
        #endregion

    }

  
    public partial class CurrentAddressInformationType: Wrapper
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

            set { this.SetDecimal(value, 1, 3); }
        }  
        ///  <summary>
        /// Danish: PNR
        /// CPR Number
        ///  </summary>
        public string PNR
        {
            get { return this.GetString(4, 10); }

            set { this.SetString(value, 4, 10); }
        }  
        ///  <summary>
        /// Danish: KOMKOD
        /// Municipality
        ///  </summary>
        public decimal MunicipalityCode
        {
            get { return this.GetDecimal(14, 4); }

            set { this.SetDecimal(value, 14, 4); }
        }  
        ///  <summary>
        /// Danish: VEJKOD
        /// Street
        ///  </summary>
        public decimal StreetCode
        {
            get { return this.GetDecimal(18, 4); }

            set { this.SetDecimal(value, 18, 4); }
        }  
        ///  <summary>
        /// Danish: HUSNR
        /// House
        ///  </summary>
        public string HouseNumber
        {
            get { return this.GetString(22, 4); }

            set { this.SetString(value, 22, 4); }
        }  
        ///  <summary>
        /// Danish: ETAGE
        /// Floor
        ///  </summary>
        public string Floor
        {
            get { return this.GetString(26, 2); }

            set { this.SetString(value, 26, 2); }
        }  
        ///  <summary>
        /// Danish: SIDEDOER
        /// Door
        ///  </summary>
        public string Door
        {
            get { return this.GetString(28, 4); }

            set { this.SetString(value, 28, 4); }
        }  
        ///  <summary>
        /// Danish: BNR
        /// Building number
        ///  </summary>
        public string BuildingNumber
        {
            get { return this.GetString(32, 4); }

            set { this.SetString(value, 32, 4); }
        }  
        ///  <summary>
        /// Danish: CONVN
        /// C/O name
        ///  </summary>
        public string CareOfName
        {
            get { return this.GetString(36, 34); }

            set { this.SetString(value, 36, 34); }
        }  
        ///  <summary>
        /// Danish: TILFLYDTO
        /// Relocation date yyyyMMddTTMM
        ///  </summary>
        public DateTime? RelocationDate
        {
            get { return this.GetDateTime(70, 12, "yyyyMMddHHmm"); }

            set { this.SetDateTime(value, 70, 12, "yyyyMMddHHmm"); }
        }  
        ///  <summary>
        /// Danish: TILFLYDT_UMRK
        /// Relocation date uncertainty marker
        ///  </summary>
        public char RelocationDateUncertainty
        {
            get { return this.GetChar(82); }

            set { this.SetChar(value, 82); }
        }  
        ///  <summary>
        /// Danish: TILFLYKOMDTO
        /// Municipality arrival date yyyyMMddTTMM
        ///  </summary>
        public DateTime? MunicipalityArrivalDate
        {
            get { return this.GetDateTime(83, 12, "yyyyMMddHHmm"); }

            set { this.SetDateTime(value, 83, 12, "yyyyMMddHHmm"); }
        }  
        ///  <summary>
        /// Danish: TILFLYKOMDT_UMRK
        /// Municipality arrival date uncertainty marker
        ///  </summary>
        public char MunicipalityArrivalDateUncertainty
        {
            get { return this.GetChar(95); }

            set { this.SetChar(value, 95); }
        }  
        ///  <summary>
        /// Danish: FRAFLYKOMKOD
        /// Leaving municipality code
        ///  </summary>
        public decimal LeavingMunicipalityCode
        {
            get { return this.GetDecimal(96, 4); }

            set { this.SetDecimal(value, 96, 4); }
        }  
        ///  <summary>
        /// Danish: FRAFLYKOMDTO
        /// Municipality departure date yyyyMMddTTMM
        ///  </summary>
        public DateTime? MunicipalityDepartureDate
        {
            get { return this.GetDateTime(100, 12, "yyyyMMddHHmm"); }

            set { this.SetDateTime(value, 100, 12, "yyyyMMddHHmm"); }
        }  
        ///  <summary>
        /// Danish: FRAFLYKOMDT_UMRK
        /// Municipality departure date uncertainty
        ///  </summary>
        public char MunicipalityDepartureDateUncertainty
        {
            get { return this.GetChar(112); }

            set { this.SetChar(value, 112); }
        }  
        ///  <summary>
        /// Danish: START_MYNKOD-ADRTXT
        /// HomeAuthority
        ///  </summary>
        public decimal HomeAuthority
        {
            get { return this.GetDecimal(113, 4); }

            set { this.SetDecimal(value, 113, 4); }
        }  
        ///  <summary>
        /// Danish: ADR1-SUPLADR
        /// First line of supplementary address
        ///  </summary>
        public string SupplementaryAddress1
        {
            get { return this.GetString(117, 34); }

            set { this.SetString(value, 117, 34); }
        }  
        ///  <summary>
        /// Danish: ADR2-SUPLADR
        /// Second line of supplementary address
        ///  </summary>
        public string SupplementaryAddress2
        {
            get { return this.GetString(151, 34); }

            set { this.SetString(value, 151, 34); }
        }  
        ///  <summary>
        /// Danish: ADR3-SUPLADR
        /// Third line of supplementary address
        ///  </summary>
        public string SupplementaryAddress3
        {
            get { return this.GetString(185, 34); }

            set { this.SetString(value, 185, 34); }
        }  
        ///  <summary>
        /// Danish: ADR4-SUPLADR
        /// Fourth line of supplementary address
        ///  </summary>
        public string SupplementaryAddress4
        {
            get { return this.GetString(219, 34); }

            set { this.SetString(value, 219, 34); }
        }  
        ///  <summary>
        /// Danish: ADR5-SUPLADR
        /// Fifth line of supplementary address
        ///  </summary>
        public string SupplementaryAddress5
        {
            get { return this.GetString(253, 34); }

            set { this.SetString(value, 253, 34); }
        }  
        ///  <summary>
        /// Danish: START_DT-ADRTXT
        /// Start date yyyy-MM-dd
        ///  </summary>
        public DateTime? StartDate
        {
            get { return this.GetDateTime(287, 10, "yyyy-MM-dd"); }

            set { this.SetDateTime(value, 287, 10, "yyyy-MM-dd"); }
        }  
        ///  <summary>
        /// Danish: SLET_DT-ADRTXT
        /// End date yyyy-MM-dd
        ///  </summary>
        public DateTime? EndDate
        {
            get { return this.GetDateTime(297, 10, "yyyy-MM-dd"); }

            set { this.SetDateTime(value, 297, 10, "yyyy-MM-dd"); }
        }  
        #endregion

    }

  
    public partial class ClearWrittenAddressType: Wrapper
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

            set { this.SetDecimal(value, 1, 3); }
        }  
        ///  <summary>
        /// Danish: PNR
        /// CPR Number
        ///  </summary>
        public string PNR
        {
            get { return this.GetString(4, 10); }

            set { this.SetString(value, 4, 10); }
        }  
        ///  <summary>
        /// Danish: ADRNVN
        /// Addressing name
        ///  </summary>
        public string AddressingName
        {
            get { return this.GetString(14, 34); }

            set { this.SetString(value, 14, 34); }
        }  
        ///  <summary>
        /// Danish: CONVN
        /// C/O name
        ///  </summary>
        public string CareOfName
        {
            get { return this.GetString(48, 34); }

            set { this.SetString(value, 48, 34); }
        }  
        ///  <summary>
        /// Danish: LOKALITET
        /// Location
        ///  </summary>
        public string Location
        {
            get { return this.GetString(82, 34); }

            set { this.SetString(value, 82, 34); }
        }  
        ///  <summary>
        /// Danish: STANDARDADR
        /// Road addressing name, house number, floor, side doors BNR. Labelled Address
        ///  </summary>
        public string LabelledAddress
        {
            get { return this.GetString(116, 34); }

            set { this.SetString(value, 116, 34); }
        }  
        ///  <summary>
        /// Danish: BYNVN
        /// City name
        ///  </summary>
        public string CityName
        {
            get { return this.GetString(150, 34); }

            set { this.SetString(value, 150, 34); }
        }  
        ///  <summary>
        /// Danish: POSTNR
        /// Post code
        ///  </summary>
        public decimal PostCode
        {
            get { return this.GetDecimal(184, 4); }

            set { this.SetDecimal(value, 184, 4); }
        }  
        ///  <summary>
        /// Danish: POSTDISTTXT
        /// Post district text
        ///  </summary>
        public string PostDistrictText
        {
            get { return this.GetString(188, 20); }

            set { this.SetString(value, 188, 20); }
        }  
        ///  <summary>
        /// Danish: KOMKOD
        /// Municipality code
        ///  </summary>
        public decimal MunicipalityCode
        {
            get { return this.GetDecimal(208, 4); }

            set { this.SetDecimal(value, 208, 4); }
        }  
        ///  <summary>
        /// Danish: VEJKOD
        /// Street code
        ///  </summary>
        public decimal StreetCode
        {
            get { return this.GetDecimal(212, 4); }

            set { this.SetDecimal(value, 212, 4); }
        }  
        ///  <summary>
        /// Danish: HUSNR
        /// House number
        ///  </summary>
        public string HouseNumber
        {
            get { return this.GetString(216, 4); }

            set { this.SetString(value, 216, 4); }
        }  
        ///  <summary>
        /// Danish: ETAGE
        /// Floor
        ///  </summary>
        public string Floor
        {
            get { return this.GetString(220, 2); }

            set { this.SetString(value, 220, 2); }
        }  
        ///  <summary>
        /// Danish: SIDEDOER
        /// Door
        ///  </summary>
        public string Door
        {
            get { return this.GetString(222, 4); }

            set { this.SetString(value, 222, 4); }
        }  
        ///  <summary>
        /// Danish: BNR
        /// Building number
        ///  </summary>
        public string BuildingNumber
        {
            get { return this.GetString(226, 4); }

            set { this.SetString(value, 226, 4); }
        }  
        ///  <summary>
        /// Danish: VEJADRNVN
        /// Street addressing name
        ///  </summary>
        public string StreetAddressingName
        {
            get { return this.GetString(230, 20); }

            set { this.SetString(value, 230, 20); }
        }  
        #endregion

    }

  
    public partial class ProtectionType: Wrapper
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

            set { this.SetDecimal(value, 1, 3); }
        }  
        ///  <summary>
        /// Danish: PNR
        /// CPR Number
        ///  </summary>
        public string PNR
        {
            get { return this.GetString(4, 10); }

            set { this.SetString(value, 4, 10); }
        }  
        ///  <summary>
        /// Danish: BESKYTTYPE
        /// Protection type
        ///  </summary>
        public decimal ProtectionType_
        {
            get { return this.GetDecimal(14, 4); }

            set { this.SetDecimal(value, 14, 4); }
        }  
        ///  <summary>
        /// Danish: START_DT-BESKYTTELSE
        /// Start date yyyy-MM-dd
        ///  </summary>
        public DateTime? StartDate
        {
            get { return this.GetDateTime(18, 10, "yyyy-MM-dd"); }

            set { this.SetDateTime(value, 18, 10, "yyyy-MM-dd"); }
        }  
        ///  <summary>
        /// Danish: SLET_DT-BESKYTTELSE
        /// End date yyyy-MM-dd
        ///  </summary>
        public DateTime? EndDate
        {
            get { return this.GetDateTime(28, 10, "yyyy-MM-dd"); }

            set { this.SetDateTime(value, 28, 10, "yyyy-MM-dd"); }
        }  
        #endregion

    }

  
    public partial class CurrentDepartureDataType: Wrapper
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

            set { this.SetDecimal(value, 1, 3); }
        }  
        ///  <summary>
        /// Danish: PNR
        /// CPR Number
        ///  </summary>
        public string PNR
        {
            get { return this.GetString(4, 10); }

            set { this.SetString(value, 4, 10); }
        }  
        ///  <summary>
        /// Danish: UDR_LANDEKOD
        /// Exit country code
        ///  </summary>
        public decimal ExitCountryCode
        {
            get { return this.GetDecimal(14, 4); }

            set { this.SetDecimal(value, 14, 4); }
        }  
        ///  <summary>
        /// Danish: UDRDTO
        /// Exit date yyyyMMddTTMM
        ///  </summary>
        public DateTime? ExitDate
        {
            get { return this.GetDateTime(18, 12, "yyyyMMddHHmm"); }

            set { this.SetDateTime(value, 18, 12, "yyyyMMddHHmm"); }
        }  
        ///  <summary>
        /// Danish: UDRDTO_UMRK
        /// Exit date uncertainty marker
        ///  </summary>
        public char ExitDateUncertainty
        {
            get { return this.GetChar(30); }

            set { this.SetChar(value, 30); }
        }  
        ///  <summary>
        /// Danish: UDLANDADR1
        /// Foreign Address 1
        ///  </summary>
        public string ForeignAddress1
        {
            get { return this.GetString(31, 34); }

            set { this.SetString(value, 31, 34); }
        }  
        ///  <summary>
        /// Danish: UDLANDADR2
        /// Foreign Address 2
        ///  </summary>
        public string ForeignAddress2
        {
            get { return this.GetString(65, 34); }

            set { this.SetString(value, 65, 34); }
        }  
        ///  <summary>
        /// Danish: UDLANDADR3
        /// Foreign Address 3
        ///  </summary>
        public string ForeignAddress3
        {
            get { return this.GetString(99, 34); }

            set { this.SetString(value, 99, 34); }
        }  
        ///  <summary>
        /// Danish: UDLANDADR4
        /// Foreign Address 4
        ///  </summary>
        public string ForeignAddress4
        {
            get { return this.GetString(133, 34); }

            set { this.SetString(value, 133, 34); }
        }  
        ///  <summary>
        /// Danish: UDLANDADR5
        /// Foreign Address 5
        ///  </summary>
        public string ForeignAddress5
        {
            get { return this.GetString(167, 34); }

            set { this.SetString(value, 167, 34); }
        }  
        #endregion

    }

  
    public partial class ContactAddressType: Wrapper
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

            set { this.SetDecimal(value, 1, 3); }
        }  
        ///  <summary>
        /// Danish: PNR
        /// CPR Number
        ///  </summary>
        public string PNR
        {
            get { return this.GetString(4, 10); }

            set { this.SetString(value, 4, 10); }
        }  
        ///  <summary>
        /// Danish: ADR1-KONTAKTADR
        /// Contact address line 1
        ///  </summary>
        public string Line1
        {
            get { return this.GetString(14, 34); }

            set { this.SetString(value, 14, 34); }
        }  
        ///  <summary>
        /// Danish: ADR2-KONTAKTADR
        /// Contact address line 2
        ///  </summary>
        public string Line2
        {
            get { return this.GetString(48, 34); }

            set { this.SetString(value, 48, 34); }
        }  
        ///  <summary>
        /// Danish: ADR3-KONTAKTADR
        /// Contact address line 3
        ///  </summary>
        public string Line3
        {
            get { return this.GetString(82, 34); }

            set { this.SetString(value, 82, 34); }
        }  
        ///  <summary>
        /// Danish: ADR4-KONTAKTADR
        /// Contact address line 4
        ///  </summary>
        public string Line4
        {
            get { return this.GetString(116, 34); }

            set { this.SetString(value, 116, 34); }
        }  
        ///  <summary>
        /// Danish: ADR5-KONTAKTADR
        /// Contact address line 5
        ///  </summary>
        public string Line5
        {
            get { return this.GetString(150, 34); }

            set { this.SetString(value, 150, 34); }
        }  
        ///  <summary>
        /// Danish: START_DT-ADRTXT
        /// Start date yyyy-MM-dd
        ///  </summary>
        public DateTime? StartDate
        {
            get { return this.GetDateTime(184, 10, "yyyy-MM-dd"); }

            set { this.SetDateTime(value, 184, 10, "yyyy-MM-dd"); }
        }  
        ///  <summary>
        /// Danish: SLET_DT-ADRTXT
        /// End date yyyy-MM-dd
        ///  </summary>
        public DateTime? EndDate
        {
            get { return this.GetDateTime(194, 10, "yyyy-MM-dd"); }

            set { this.SetDateTime(value, 194, 10, "yyyy-MM-dd"); }
        }  
        #endregion

    }

  
    public partial class CurrentDisappearanceInformationType: Wrapper
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

            set { this.SetDecimal(value, 1, 3); }
        }  
        ///  <summary>
        /// Danish: PNR
        /// CPR Number
        ///  </summary>
        public string PNR
        {
            get { return this.GetString(4, 10); }

            set { this.SetString(value, 4, 10); }
        }  
        ///  <summary>
        /// Danish: FORSVINddTO
        /// Disappearance date yyyyMMddTTMM
        ///  </summary>
        public DateTime? DisappearanceDate
        {
            get { return this.GetDateTime(14, 12, "yyyyMMddHHmm"); }

            set { this.SetDateTime(value, 14, 12, "yyyyMMddHHmm"); }
        }  
        ///  <summary>
        /// Danish: FORSVINDDTO_UMRK
        /// Disappearance date uncertainty marker
        ///  </summary>
        public char DisappearanceDateUncertainty
        {
            get { return this.GetChar(26); }

            set { this.SetChar(value, 26); }
        }  
        #endregion

    }

  
    public partial class CurrentNameInformationType: Wrapper
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

            set { this.SetDecimal(value, 1, 3); }
        }  
        ///  <summary>
        /// Danish: PNR
        /// CPR Number
        ///  </summary>
        public string PNR
        {
            get { return this.GetString(4, 10); }

            set { this.SetString(value, 4, 10); }
        }  
        ///  <summary>
        /// Danish: FORNVN
        /// First name (s)
        ///  </summary>
        public string FirstName_s
        {
            get { return this.GetString(14, 50); }

            set { this.SetString(value, 14, 50); }
        }  
        ///  <summary>
        /// Danish: FORNVN_MRK
        /// First name marker
        ///  </summary>
        public char FirstNameMarker
        {
            get { return this.GetChar(64); }

            set { this.SetChar(value, 64); }
        }  
        ///  <summary>
        /// Danish: MELNVN
        /// Middle name
        ///  </summary>
        public string MiddleName
        {
            get { return this.GetString(65, 40); }

            set { this.SetString(value, 65, 40); }
        }  
        ///  <summary>
        /// Danish: MELNVN_MRK
        /// Middle name marker
        ///  </summary>
        public char MiddleNameMarker
        {
            get { return this.GetChar(105); }

            set { this.SetChar(value, 105); }
        }  
        ///  <summary>
        /// Danish: EFTERNVN
        /// Last name
        ///  </summary>
        public string LastName
        {
            get { return this.GetString(106, 40); }

            set { this.SetString(value, 106, 40); }
        }  
        ///  <summary>
        /// Danish: EFTERNVN_MRK
        /// Last name marker
        ///  </summary>
        public char LastNameMarker
        {
            get { return this.GetChar(146); }

            set { this.SetChar(value, 146); }
        }  
        ///  <summary>
        /// Danish: NVNHAENSTART
        /// Name start date yyyyMMddTTMM
        ///  </summary>
        public DateTime? NameStartDate
        {
            get { return this.GetDateTime(147, 12, "yyyyMMddHHmm"); }

            set { this.SetDateTime(value, 147, 12, "yyyyMMddHHmm"); }
        }  
        ///  <summary>
        /// Danish: HAENSTART_UMRK-NAVNE
        /// Name start date uncertainty marker
        ///  </summary>
        public char NameStartDateUncertainty
        {
            get { return this.GetChar(159); }

            set { this.SetChar(value, 159); }
        }  
        ///  <summary>
        /// Danish: ADRNVN
        /// AddressingName
        ///  </summary>
        public string AddressingName
        {
            get { return this.GetString(160, 34); }

            set { this.SetString(value, 160, 34); }
        }  
        #endregion

    }

  
    public partial class BirthRegistrationInformationType: Wrapper
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

            set { this.SetDecimal(value, 1, 3); }
        }  
        ///  <summary>
        /// Danish: PNR
        /// CPR Number
        ///  </summary>
        public string PNR
        {
            get { return this.GetString(4, 10); }

            set { this.SetString(value, 4, 10); }
        }  
        ///  <summary>
        /// Danish: START_MYNKOD-FØDESTED
        /// Birth registration authority code
        ///  </summary>
        public decimal BirthRegistrationAuthorityCode
        {
            get { return this.GetDecimal(14, 4); }

            set { this.SetDecimal(value, 14, 4); }
        }  
        ///  <summary>
        /// Danish: MYNTXT-FØDESTED
        /// Additional birth registration text
        ///  </summary>
        public string AdditionalBirthRegistrationText
        {
            get { return this.GetString(18, 20); }

            set { this.SetString(value, 18, 20); }
        }  
        #endregion

    }

  
    public partial class CurrentCitizenshipType: Wrapper
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

            set { this.SetDecimal(value, 1, 3); }
        }  
        ///  <summary>
        /// Danish: PNR
        /// CPR Number
        ///  </summary>
        public string PNR
        {
            get { return this.GetString(4, 10); }

            set { this.SetString(value, 4, 10); }
        }  
        ///  <summary>
        /// Danish: LANDEKOD
        /// Country code
        ///  </summary>
        public decimal CountryCode
        {
            get { return this.GetDecimal(14, 4); }

            set { this.SetDecimal(value, 14, 4); }
        }  
        ///  <summary>
        /// Danish: HAENSTART-STATSBORGERSKAB
        /// Citizenship start date yyyyMMddTTMM
        ///  </summary>
        public DateTime? CitizenshipStartDate
        {
            get { return this.GetDateTime(18, 12, "yyyyMMddHHmm"); }

            set { this.SetDateTime(value, 18, 12, "yyyyMMddHHmm"); }
        }  
        ///  <summary>
        /// Danish: HAENSTART_UMRK-STATSBORGERSKAB
        /// Citizenship start date uncertainty marker
        ///  </summary>
        public char CitizenshipStartDateUncertainty
        {
            get { return this.GetChar(30); }

            set { this.SetChar(value, 30); }
        }  
        #endregion

    }

  
    public partial class ChurchInformationType: Wrapper
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

            set { this.SetDecimal(value, 1, 3); }
        }  
        ///  <summary>
        /// Danish: PNR
        /// CPR Number
        ///  </summary>
        public string PNR
        {
            get { return this.GetString(4, 10); }

            set { this.SetString(value, 4, 10); }
        }  
        ///  <summary>
        /// Danish: FKIRK
        /// church Relationship
        ///  </summary>
        public char ChurchRelationship
        {
            get { return this.GetChar(14); }

            set { this.SetChar(value, 14); }
        }  
        ///  <summary>
        /// Danish: START_DT-FOLKEKIRKE
        /// Start date yyyy-MM-dd
        ///  </summary>
        public DateTime? StartDate
        {
            get { return this.GetDateTime(15, 10, "yyyy-MM-dd"); }

            set { this.SetDateTime(value, 15, 10, "yyyy-MM-dd"); }
        }  
        ///  <summary>
        /// Danish: START_DT_UMRK-FOLKEKIRKE
        /// Start date uncertainty marker
        ///  </summary>
        public char StartDateUncertainty
        {
            get { return this.GetChar(25); }

            set { this.SetChar(value, 25); }
        }  
        #endregion

    }

  
    public partial class CurrentCivilStatusType: Wrapper
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

            set { this.SetDecimal(value, 1, 3); }
        }  
        ///  <summary>
        /// Danish: PNR
        /// CPR Number
        ///  </summary>
        public string PNR
        {
            get { return this.GetString(4, 10); }

            set { this.SetString(value, 4, 10); }
        }  
        ///  <summary>
        /// Danish: CIVST
        /// Civil status
        ///  </summary>
        public char CivilStatus
        {
            get { return this.GetChar(14); }

            set { this.SetChar(value, 14); }
        }  
        ///  <summary>
        /// Danish: AEGTEPNR
        /// Spouse PNR
        ///  </summary>
        public string SpousePNR
        {
            get { return this.GetString(15, 10); }

            set { this.SetString(value, 15, 10); }
        }  
        ///  <summary>
        /// Danish: AEGTEFOED_DT
        /// Spouse birth date yyyy-MM-dd
        ///  </summary>
        public DateTime? SpouseBirthDate
        {
            get { return this.GetDateTime(25, 10, "yyyy-MM-dd"); }

            set { this.SetDateTime(value, 25, 10, "yyyy-MM-dd"); }
        }  
        ///  <summary>
        /// Danish: AEGTEFOEddT_UMRK
        /// Spouse birth date uncertainty
        ///  </summary>
        public char SpouseBirthDateUncertainty
        {
            get { return this.GetChar(35); }

            set { this.SetChar(value, 35); }
        }  
        ///  <summary>
        /// Danish: AEGTENVN
        /// Spouse name
        ///  </summary>
        public string SpouseName
        {
            get { return this.GetString(36, 34); }

            set { this.SetString(value, 36, 34); }
        }  
        ///  <summary>
        /// Danish: AEGTENVN_MRK
        /// Spouse name marker
        ///  </summary>
        public char SpouseNameMarker
        {
            get { return this.GetChar(70); }

            set { this.SetChar(value, 70); }
        }  
        ///  <summary>
        /// Danish: HAENSTART-CIVILSTAND
        /// Civil status start date
        ///  </summary>
        public DateTime? CivilStatusStartDate
        {
            get { return this.GetDateTime(71, 12, "yyyyMMddHHmm"); }

            set { this.SetDateTime(value, 71, 12, "yyyyMMddHHmm"); }
        }  
        ///  <summary>
        /// Danish: HAENSTART_UMRK-CIVILSTAND
        /// Civil status start date uncertainty marker
        ///  </summary>
        public char CivilStatusStartDateUncertainty
        {
            get { return this.GetChar(83); }

            set { this.SetChar(value, 83); }
        }  
        ///  <summary>
        /// Danish: SEP_HENVIS-CIVILSTAND
        /// Reference to any. separation yyyyMMddTTMM
        ///  </summary>
        public DateTime? ReferenceToAnySeparation
        {
            get { return this.GetDateTime(84, 12, "yyyyMMddHHmm"); }

            set { this.SetDateTime(value, 84, 12, "yyyyMMddHHmm"); }
        }  
        #endregion

    }

  
    public partial class CurrentSeparationType: Wrapper
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

            set { this.SetDecimal(value, 1, 3); }
        }  
        ///  <summary>
        /// Danish: PNR
        /// CPR Number
        ///  </summary>
        public string PNR
        {
            get { return this.GetString(4, 10); }

            set { this.SetString(value, 4, 10); }
        }  
        ///  <summary>
        /// Danish: SEP_HENVIS-SEPARATION
        /// Reference to any. marital status yyyyMMddTTMM
        ///  </summary>
        public DateTime? ReferenceToAnyMaritalStatus
        {
            get { return this.GetDateTime(14, 12, "yyyyMMddHHmm"); }

            set { this.SetDateTime(value, 14, 12, "yyyyMMddHHmm"); }
        }  
        ///  <summary>
        /// Danish: START_DT-SEPARATION
        /// Separation start date yyyy-MM-dd
        ///  </summary>
        public DateTime? SeparationStartDate
        {
            get { return this.GetDateTime(26, 10, "yyyy-MM-dd"); }

            set { this.SetDateTime(value, 26, 10, "yyyy-MM-dd"); }
        }  
        ///  <summary>
        /// Danish: START_DT_UMRK-SEPARATION
        /// Separation start date uncertainty marker
        ///  </summary>
        public char SeparationStartDateUncertainty
        {
            get { return this.GetChar(36); }

            set { this.SetChar(value, 36); }
        }  
        #endregion

    }

  
    public partial class ChildType: Wrapper
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

            set { this.SetDecimal(value, 1, 3); }
        }  
        ///  <summary>
        /// Danish: PNR
        /// CPR Number
        ///  </summary>
        public string PNR
        {
            get { return this.GetString(4, 10); }

            set { this.SetString(value, 4, 10); }
        }  
        ///  <summary>
        /// Danish: PNR
        /// Child PNR
        ///  </summary>
        public string ChildPNR
        {
            get { return this.GetString(14, 10); }

            set { this.SetString(value, 14, 10); }
        }  
        #endregion

    }

  
    public partial class ParentsInformationType: Wrapper
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

            set { this.SetDecimal(value, 1, 3); }
        }  
        ///  <summary>
        /// Danish: PNR
        /// CPR Number
        ///  </summary>
        public string PNR
        {
            get { return this.GetString(4, 10); }

            set { this.SetString(value, 4, 10); }
        }  
        ///  <summary>
        /// Danish: MOR_DT
        /// Mother date yyyy-MM-dd
        ///  </summary>
        public DateTime? MotherDate
        {
            get { return this.GetDateTime(14, 10, "yyyy-MM-dd"); }

            set { this.SetDateTime(value, 14, 10, "yyyy-MM-dd"); }
        }  
        ///  <summary>
        /// Danish: MOR_DT_UMRK
        /// Mother date uncertainty marker
        ///  </summary>
        public char MotherDateUncertainty
        {
            get { return this.GetChar(24); }

            set { this.SetChar(value, 24); }
        }  
        ///  <summary>
        /// Danish: PNRMOR
        /// Mother PNR
        ///  </summary>
        public string MotherPNR
        {
            get { return this.GetString(25, 10); }

            set { this.SetString(value, 25, 10); }
        }  
        ///  <summary>
        /// Danish: MOR_FOED_DT
        /// Mother birth date yyyy-MM-dd
        ///  </summary>
        public DateTime? MotherBirthDate
        {
            get { return this.GetDateTime(35, 10, "yyyy-MM-dd"); }

            set { this.SetDateTime(value, 35, 10, "yyyy-MM-dd"); }
        }  
        ///  <summary>
        /// Danish: MOR_FOED_DT_UMRK
        /// Mother birth date uncertainty marker
        ///  </summary>
        public char MotherBirthDateUncertainty
        {
            get { return this.GetChar(45); }

            set { this.SetChar(value, 45); }
        }  
        ///  <summary>
        /// Danish: MORNVN
        /// Mother name
        ///  </summary>
        public string MotherName
        {
            get { return this.GetString(46, 34); }

            set { this.SetString(value, 46, 34); }
        }  
        ///  <summary>
        /// Danish: MORNVN_MRK
        /// Mother name marker
        ///  </summary>
        public char MotherNameUncertainty
        {
            get { return this.GetChar(80); }

            set { this.SetChar(value, 80); }
        }  
        ///  <summary>
        /// Danish: FAR_DT
        /// Father date yyyy-MM-dd
        ///  </summary>
        public DateTime? FatherDate
        {
            get { return this.GetDateTime(81, 10, "yyyy-MM-dd"); }

            set { this.SetDateTime(value, 81, 10, "yyyy-MM-dd"); }
        }  
        ///  <summary>
        /// Danish: FAR_DT_UMRK
        /// Father date uncertainty marker
        ///  </summary>
        public char FatherDateUncertainty
        {
            get { return this.GetChar(91); }

            set { this.SetChar(value, 91); }
        }  
        ///  <summary>
        /// Danish: PNRFAR
        /// Father PNR
        ///  </summary>
        public string FatherPNR
        {
            get { return this.GetString(92, 10); }

            set { this.SetString(value, 92, 10); }
        }  
        ///  <summary>
        /// Danish: FAR_FOED_DT
        /// Father birth date yyyy-MM-dd
        ///  </summary>
        public DateTime? FatherBirthDate
        {
            get { return this.GetDateTime(102, 10, "yyyy-MM-dd"); }

            set { this.SetDateTime(value, 102, 10, "yyyy-MM-dd"); }
        }  
        ///  <summary>
        /// Danish: FAR_FOED_DT_UMRK
        /// Father birth date uncertainty marker
        ///  </summary>
        public char FatherBirthDateUncertainty
        {
            get { return this.GetChar(112); }

            set { this.SetChar(value, 112); }
        }  
        ///  <summary>
        /// Danish: FARNVN
        /// Father name
        ///  </summary>
        public string FatherName
        {
            get { return this.GetString(113, 34); }

            set { this.SetString(value, 113, 34); }
        }  
        ///  <summary>
        /// Danish: FARNVN_MRK
        /// Father name marker
        ///  </summary>
        public char FatherNameUncertainty
        {
            get { return this.GetChar(147); }

            set { this.SetChar(value, 147); }
        }  
        #endregion

    }

  
    public partial class ParentalAuthorityType: Wrapper
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

            set { this.SetDecimal(value, 1, 3); }
        }  
        ///  <summary>
        /// Danish: PNR
        /// CPR Number
        ///  </summary>
        public string PNR
        {
            get { return this.GetString(4, 10); }

            set { this.SetString(value, 4, 10); }
        }  
        ///  <summary>
        /// Danish: RELTYP-FORÆLDREMYN
        /// Relationship type
        ///  </summary>
        public decimal RelationshipType
        {
            get { return this.GetDecimal(14, 4); }

            set { this.SetDecimal(value, 14, 4); }
        }  
        ///  <summary>
        /// Danish: START_DT-FORÆLDREMYN
        /// Custody start date yyyy-MM-dd
        ///  </summary>
        public DateTime? CustodyStartDate
        {
            get { return this.GetDateTime(18, 10, "yyyy-MM-dd"); }

            set { this.SetDateTime(value, 18, 10, "yyyy-MM-dd"); }
        }  
        ///  <summary>
        /// Danish: START_DT_UMRK-FORÆLDREMYN
        /// Custody start date uncertainty marker
        ///  </summary>
        public char CustodyStartDateUncertainty
        {
            get { return this.GetChar(28); }

            set { this.SetChar(value, 28); }
        }  
        ///  <summary>
        /// Danish: SLET_DT-FORÆLDREMYN
        /// Custody end date yyyy-MM-dd
        ///  </summary>
        public DateTime? CustodyEndDate
        {
            get { return this.GetDateTime(29, 10, "yyyy-MM-dd"); }

            set { this.SetDateTime(value, 29, 10, "yyyy-MM-dd"); }
        }  
        ///  <summary>
        /// Danish: RELPNR
        /// Relation PNR
        ///  </summary>
        public string RelationPNR
        {
            get { return this.GetString(39, 10); }

            set { this.SetString(value, 39, 10); }
        }  
        ///  <summary>
        /// Danish: START_DT-RELPNR_PNR
        /// Relation PNR start date yyyy-MM-dd
        ///  </summary>
        public DateTime? RelationPNRStartDate
        {
            get { return this.GetDateTime(49, 10, "yyyy-MM-dd"); }

            set { this.SetDateTime(value, 49, 10, "yyyy-MM-dd"); }
        }  
        #endregion

    }

  
    public partial class DisempowermentType: Wrapper
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

            set { this.SetDecimal(value, 1, 3); }
        }  
        ///  <summary>
        /// Danish: PNR
        /// CPR Number
        ///  </summary>
        public string PNR
        {
            get { return this.GetString(4, 10); }

            set { this.SetString(value, 4, 10); }
        }  
        ///  <summary>
        /// Danish: START_DT-UMYNDIG
        /// Disempowerment start date yyyy-MM-dd
        ///  </summary>
        public DateTime? DisempowermentStartDate
        {
            get { return this.GetDateTime(14, 10, "yyyy-MM-dd"); }

            set { this.SetDateTime(value, 14, 10, "yyyy-MM-dd"); }
        }  
        ///  <summary>
        /// Danish: PNR
        /// Disempowerment start date uncertainty marker
        ///  </summary>
        public char DisempowermentStartDateUncertainty
        {
            get { return this.GetChar(24); }

            set { this.SetChar(value, 24); }
        }  
        ///  <summary>
        /// Danish: SLET_DT-UMYNDIG
        /// Disempowerment end date yyyy-MM-dd
        ///  </summary>
        public DateTime? DisempowermentEndDate
        {
            get { return this.GetDateTime(25, 10, "yyyy-MM-dd"); }

            set { this.SetDateTime(value, 25, 10, "yyyy-MM-dd"); }
        }  
        ///  <summary>
        /// Danish: UMYN_RELTYP
        /// Guardian relation type
        ///  </summary>
        public decimal GuardianRelationType
        {
            get { return this.GetDecimal(35, 4); }

            set { this.SetDecimal(value, 35, 4); }
        }  
        ///  <summary>
        /// Danish: RELPNR
        /// Relation PNR
        ///  </summary>
        public string RelationPNR
        {
            get { return this.GetString(39, 10); }

            set { this.SetString(value, 39, 10); }
        }  
        ///  <summary>
        /// Danish: START_DT-RELPNR_PNR
        /// Relation PNR start date yyyy-MM-dd
        ///  </summary>
        public DateTime? RelationPNRStartDate
        {
            get { return this.GetDateTime(49, 10, "yyyy-MM-dd"); }

            set { this.SetDateTime(value, 49, 10, "yyyy-MM-dd"); }
        }  
        ///  <summary>
        /// Danish: RELADRSAT_RELPNR_TXT
        /// Guardian's name
        ///  </summary>
        public string GuardianName
        {
            get { return this.GetString(59, 34); }

            set { this.SetString(value, 59, 34); }
        }  
        ///  <summary>
        /// Danish: START_DT-RELPNR_TXT
        /// Guardian's address start date yyyy-MM-dd
        ///  </summary>
        public DateTime? GuardianAddressStartDate
        {
            get { return this.GetDateTime(93, 10, "yyyy-MM-dd"); }

            set { this.SetDateTime(value, 93, 10, "yyyy-MM-dd"); }
        }  
        ///  <summary>
        /// Danish: RELTXT1
        /// Relation text 1
        ///  </summary>
        public string RelationText1
        {
            get { return this.GetString(103, 34); }

            set { this.SetString(value, 103, 34); }
        }  
        ///  <summary>
        /// Danish: RELTXT2
        /// Relation text 2
        ///  </summary>
        public string RelationText2
        {
            get { return this.GetString(137, 34); }

            set { this.SetString(value, 137, 34); }
        }  
        ///  <summary>
        /// Danish: RELTXT3
        /// Relation text 3
        ///  </summary>
        public string RelationText3
        {
            get { return this.GetString(171, 34); }

            set { this.SetString(value, 171, 34); }
        }  
        ///  <summary>
        /// Danish: RELTXT4
        /// Relation text 4
        ///  </summary>
        public string RelationText4
        {
            get { return this.GetString(205, 34); }

            set { this.SetString(value, 205, 34); }
        }  
        ///  <summary>
        /// Danish: RELTXT5
        /// Relation text 5
        ///  </summary>
        public string RelationText5
        {
            get { return this.GetString(239, 34); }

            set { this.SetString(value, 239, 34); }
        }  
        #endregion

    }

  
    public partial class MunicipalConditionsType: Wrapper
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

            set { this.SetDecimal(value, 1, 3); }
        }  
        ///  <summary>
        /// Danish: PNR
        /// CPR Number
        ///  </summary>
        public string PNR
        {
            get { return this.GetString(4, 10); }

            set { this.SetString(value, 4, 10); }
        }  
        ///  <summary>
        /// Danish: KOMFORHTYP
        /// Municipal condition type
        ///  </summary>
        public decimal MunicipalConditionType
        {
            get { return this.GetDecimal(14, 1); }

            set { this.SetDecimal(value, 14, 1); }
        }  
        ///  <summary>
        /// Danish: KOMFORHKOD
        /// Municipal condition code
        ///  </summary>
        public string MunicipalConditionCode
        {
            get { return this.GetString(15, 5); }

            set { this.SetString(value, 15, 5); }
        }  
        ///  <summary>
        /// Danish: START_DT-KOMMUNALE-FORHOLD
        /// Municipal condition start date yyyy-MM-dd
        ///  </summary>
        public DateTime? MunicipalConditionStartDate
        {
            get { return this.GetDateTime(20, 10, "yyyy-MM-dd"); }

            set { this.SetDateTime(value, 20, 10, "yyyy-MM-dd"); }
        }  
        ///  <summary>
        /// Danish: START_DT_UMRK-KOMMUNALE-FORHOL
        /// Start date uncertainty marker
        ///  </summary>
        public char MunicipalConditionStartDateUncertaintyMarker
        {
            get { return this.GetChar(30); }

            set { this.SetChar(value, 30); }
        }  
        ///  <summary>
        /// Danish: BEMAERK-KOMMUNALE-FORHOLD
        /// Municipal condition comment
        ///  </summary>
        public string MunicipalConditionComment
        {
            get { return this.GetString(31, 30); }

            set { this.SetString(value, 31, 30); }
        }  
        #endregion

    }

  
    public partial class EndRecordType: Wrapper
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

            set { this.SetDecimal(value, 1, 3); }
        }  
        ///  <summary>
        /// Danish: TAELLER
        /// BLACK BOX 10
        ///  </summary>
        public string BlackBox10
        {
            get { return this.GetString(4, 10); }

            set { this.SetString(value, 4, 10); }
        }  
        ///  <summary>
        /// Danish: TAELLER
        /// Counter
        ///  </summary>
        public string Counter
        {
            get { return this.GetString(14, 8); }

            set { this.SetString(value, 14, 8); }
        }  
        #endregion

    }

  
    }
  