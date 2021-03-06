
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using CprBroker.Schemas.Wrappers;
    
      using CprBroker.Providers.DPR;using CprBroker.Providers.CPRDirect;
    
    namespace CprBroker.DBR
    {
    
    public partial class ClassicRequestType: NewRequestType
    {
        #region Common

        public override int Length
        {
            get { return base.Length; }
        }
        #endregion

        #region Properties


        #endregion
        public override Tuple<string, int, int>[] DefaultPropertyDefinitions
        {
            get 
            {
                var ret = base.DefaultPropertyDefinitions.ToList();
                ret.AddRange(new Tuple<string, int, int>[]{
                });
                return ret.OrderBy(pd => pd.Item2).ToArray();
            }
        }

    }

  
    public partial class DiversionResponseType: Wrapper
    {
        #region Common

        public override int Length
        {
            get { return base.Length; }
        }
        #endregion

        #region Properties

        public InquiryType Type
        {
            get { return this.GetEnum<InquiryType>(1, 1); }
            set { this.SetEnum<InquiryType>(value, 1, 1); }
        }
        public DetailType LargeData
        {
            get { return this.GetEnum<DetailType>(2, 1); }
            set { this.SetEnum<DetailType>(value, 2, 1); }
        }
        ///  <summary>
        /// Danish: FEJLNR
        ///  </summary>
        public string ErrorNumber
        {
            get { return this.GetString(3, 2); }
            set { this.SetString(value, 3, 2); }
        }

        #endregion
        public override Tuple<string, int, int>[] DefaultPropertyDefinitions
        {
            get 
            {
                var ret = base.DefaultPropertyDefinitions.ToList();
                ret.AddRange(new Tuple<string, int, int>[]{
                    new Tuple<string, int, int>("Type", 1, 1),
                    new Tuple<string, int, int>("LargeData", 2, 1),
                    new Tuple<string, int, int>("ErrorNumber", 3, 2)
                });
                return ret.OrderBy(pd => pd.Item2).ToArray();
            }
        }

    }

  
    public partial class ClassicResponseType: DiversionResponseType
    {
        #region Common

        public override int Length
        {
            get { return 236; }
        }
        #endregion

        #region Properties

        public string PNR
        {
            get { return this.GetString(5, 10); }
            set { this.SetString(value, 5, 10); }
        }
        public string Data
        {
            get { return this.GetString(15, 222); }
            set { this.SetString(value, 15, 222); }
        }

        #endregion
        public override Tuple<string, int, int>[] DefaultPropertyDefinitions
        {
            get 
            {
                var ret = base.DefaultPropertyDefinitions.ToList();
                ret.AddRange(new Tuple<string, int, int>[]{
                    new Tuple<string, int, int>("PNR", 5, 10),
                    new Tuple<string, int, int>("Data", 15, 222)
                });
                return ret.OrderBy(pd => pd.Item2).ToArray();
            }
        }

    }

  
    public partial class ResponseBasicDataBaseType: Wrapper
    {
        #region Common

        public override int Length
        {
            get { return base.Length; }
        }
        #endregion

        #region Properties

        public string PNR
        {
            get { return this.GetString(1, 10); }
            set { this.SetString(value, 1, 10); }
        }
        ///  <summary>
        /// Danish: EFTERNVN
        ///  </summary>
        public string LastName
        {
            get { return this.GetString(11, 40); }
            set { this.SetString(value, 11, 40); }
        }
        ///  <summary>
        /// Danish: FORNVN
        ///  </summary>
        public string FirstAndMiddleNames
        {
            get { return this.GetString(51, 50); }
            set { this.SetString(value, 51, 50); }
        }
        ///  <summary>
        /// De første 4 karakterer er: C/O og en blank
        ///  </summary>
        public string CareOfName
        {
            get { return this.GetString(101, 34); }
            set { this.SetString(value, 101, 34); }
        }
        public string StreetName
        {
            get { return this.GetString(135, 40); }
            set { this.SetString(value, 135, 40); }
        }
        ///  <summary>
        /// husnummer 3 karakterer, og husbogstav, 1 karakter.
        ///  </summary>
        public string HouseNumber
        {
            get { return this.GetString(175, 4); }
            set { this.SetString(value, 175, 4); }
        }
        public string BNR
        {
            get { return this.GetString(185, 4); }
            set { this.SetString(value, 185, 4); }
        }
        public decimal PostCode
        {
            get { return this.GetDecimal(189, 4); }
            set { this.SetDecimal(value, 189, 4); }
        }
        public string PostDistrict
        {
            get { return this.GetString(193, 20); }
            set { this.SetString(value, 193, 20); }
        }

        #endregion
        public override Tuple<string, int, int>[] DefaultPropertyDefinitions
        {
            get 
            {
                var ret = base.DefaultPropertyDefinitions.ToList();
                ret.AddRange(new Tuple<string, int, int>[]{
                    new Tuple<string, int, int>("PNR", 1, 10),
                    new Tuple<string, int, int>("LastName", 11, 40),
                    new Tuple<string, int, int>("FirstAndMiddleNames", 51, 50),
                    new Tuple<string, int, int>("CareOfName", 101, 34),
                    new Tuple<string, int, int>("StreetName", 135, 40),
                    new Tuple<string, int, int>("HouseNumber", 175, 4),
                    new Tuple<string, int, int>("BNR", 185, 4),
                    new Tuple<string, int, int>("PostCode", 189, 4),
                    new Tuple<string, int, int>("PostDistrict", 193, 20)
                });
                return ret.OrderBy(pd => pd.Item2).ToArray();
            }
        }

    }

  
    public partial class ClassicResponseBasicDataType: ResponseBasicDataBaseType
    {
        #region Common

        public override int Length
        {
            get { return 222; }
        }
        #endregion

        #region Properties

        public string Floor
        {
            get { return this.GetString(179, 2); }
            set { this.SetString(value, 179, 2); }
        }
        public string Door
        {
            get { return this.GetString(181, 4); }
            set { this.SetString(value, 181, 4); }
        }
        ///  <summary>
        /// Day, month, century, year
        ///  </summary>
        public string AddressProtectionDate
        {
            get { return this.GetString(213, 8); }
            set { this.SetString(value, 213, 8); }
        }
        public decimal Status
        {
            get { return this.GetDecimal(221, 2); }
            set { this.SetDecimal(value, 221, 2); }
        }

        #endregion
        public override Tuple<string, int, int>[] DefaultPropertyDefinitions
        {
            get 
            {
                var ret = base.DefaultPropertyDefinitions.ToList();
                ret.AddRange(new Tuple<string, int, int>[]{
                    new Tuple<string, int, int>("Floor", 179, 2),
                    new Tuple<string, int, int>("Door", 181, 4),
                    new Tuple<string, int, int>("AddressProtectionDate", 213, 8),
                    new Tuple<string, int, int>("Status", 221, 2)
                });
                return ret.OrderBy(pd => pd.Item2).ToArray();
            }
        }

    }

  
    public partial class NewRequestType: DiversionRequest
    {
        #region Common

        public override int Length
        {
            get { return 40; }
        }
        #endregion

        #region Properties

        public InquiryType Type
        {
            get { return this.GetEnum<InquiryType>(1, 1); }
            set { this.SetEnum<InquiryType>(value, 1, 1); }
        }
        public DetailType LargeData
        {
            get { return this.GetEnum<DetailType>(2, 1); }
            set { this.SetEnum<DetailType>(value, 2, 1); }
        }
        public string PNR
        {
            get { return this.GetString(3, 10); }
            set { this.SetString(value, 3, 10); }
        }
        ///  <summary>
        /// Always contains 'MMXIII', IE. Roman numeral for 2013, where the new solution came into operation
        ///  </summary>
        public string NewType
        {
            get { return this.GetString(13, 6); }
            set { this.SetString(value, 13, 6); }
        }
        ///  <summary>
        /// Calls to the DPR forwarding enforced on to CPR Directly in all cases regardless of the application's lookup-check for invalid markup, PNR or uncertainty '1 0' call.
        ///  </summary>
        public decimal ForceDiversion
        {
            get { return this.GetDecimal(19, 1); }
            set { this.SetDecimal(value, 19, 1); }
        }
        public char ReponseData
        {
            get { return this.GetChar(20); }
            set { this.SetChar(value, 20); }
        }
        ///  <summary>
        /// End user's user ID or possibly. fagsystemet system user ID.
        ///  </summary>
        public string UserID
        {
            get { return this.GetString(21, 20); }
            set { this.SetString(value, 21, 20); }
        }

        #endregion
        public override Tuple<string, int, int>[] DefaultPropertyDefinitions
        {
            get 
            {
                var ret = base.DefaultPropertyDefinitions.ToList();
                ret.AddRange(new Tuple<string, int, int>[]{
                    new Tuple<string, int, int>("Type", 1, 1),
                    new Tuple<string, int, int>("LargeData", 2, 1),
                    new Tuple<string, int, int>("PNR", 3, 10),
                    new Tuple<string, int, int>("NewType", 13, 6),
                    new Tuple<string, int, int>("ForceDiversion", 19, 1),
                    new Tuple<string, int, int>("ReponseData", 20, 1),
                    new Tuple<string, int, int>("UserID", 21, 20)
                });
                return ret.OrderBy(pd => pd.Item2).ToArray();
            }
        }

    }

  
    public partial class NewResponseType: DiversionResponseType
    {
        #region Common

        public override int Length
        {
            get { return 4; }
        }
        #endregion

        #region Properties


        #endregion
        public override Tuple<string, int, int>[] DefaultPropertyDefinitions
        {
            get 
            {
                var ret = base.DefaultPropertyDefinitions.ToList();
                ret.AddRange(new Tuple<string, int, int>[]{
                });
                return ret.OrderBy(pd => pd.Item2).ToArray();
            }
        }

    }

  
    public partial class NewResponseNoDataType: Wrapper
    {
        #region Common

        public override int Length
        {
            get { return 110; }
        }
        #endregion

        #region Properties

        public string PNR
        {
            get { return this.GetString(1, 10); }
            set { this.SetString(value, 1, 10); }
        }
        public string OkOrError
        {
            get { return this.GetString(11, 100); }
            set { this.SetString(value, 11, 100); }
        }

        #endregion
        public override Tuple<string, int, int>[] DefaultPropertyDefinitions
        {
            get 
            {
                var ret = base.DefaultPropertyDefinitions.ToList();
                ret.AddRange(new Tuple<string, int, int>[]{
                    new Tuple<string, int, int>("PNR", 1, 10),
                    new Tuple<string, int, int>("OkOrError", 11, 100)
                });
                return ret.OrderBy(pd => pd.Item2).ToArray();
            }
        }

    }

  
    public partial class NewResponseBasicDataType: ResponseBasicDataBaseType
    {
        #region Common

        public override int Length
        {
            get { return 215; }
        }
        #endregion

        #region Properties

        public string Door
        {
            get { return this.GetString(179, 4); }
            set { this.SetString(value, 179, 4); }
        }
        public string Floor
        {
            get { return this.GetString(183, 2); }
            set { this.SetString(value, 183, 2); }
        }
        public char AddressProtectionMarker
        {
            get { return this.GetChar(213); }
            set { this.SetChar(value, 213); }
        }
        public decimal Status
        {
            get { return this.GetDecimal(214, 2); }
            set { this.SetDecimal(value, 214, 2); }
        }

        #endregion
        public override Tuple<string, int, int>[] DefaultPropertyDefinitions
        {
            get 
            {
                var ret = base.DefaultPropertyDefinitions.ToList();
                ret.AddRange(new Tuple<string, int, int>[]{
                    new Tuple<string, int, int>("Door", 179, 4),
                    new Tuple<string, int, int>("Floor", 183, 2),
                    new Tuple<string, int, int>("AddressProtectionMarker", 213, 1),
                    new Tuple<string, int, int>("Status", 214, 2)
                });
                return ret.OrderBy(pd => pd.Item2).ToArray();
            }
        }

    }

  
    public partial class NewResponseFullDataType: Wrapper
    {
        #region Common

        public override int Length
        {
            get { return 3242; }
        }
        #endregion

        #region Properties

        ///  <summary>
        /// Danish: PNR
        ///  </summary>
        public string PNR
        {
            get { return this.GetString(5, 11); }
            set { this.SetString(value, 5, 11); }
        }
        ///  <summary>
        /// Danish: AJFDTO_NAVNE
        ///  </summary>
        public DateTime? AJFDTO_NAVNE
        {
            get { return this.GetDateTime(16, 13, "yyyyMMddHHmm"); }
            set { this.SetDateTime(value, 16, 13, "yyyyMMddHHmm"); }
        }

        public Decimal AJFDTO_NAVNEDecimal
        {
            get { return this.GetDecimal(16, 13); }
            set { this.SetDecimal(value, 16, 13); }
        }

        ///  <summary>
        /// Danish: MYNKOD_NAVNE
        ///  </summary>
        public decimal MYNKOD_NAVNE
        {
            get { return this.GetDecimal(29, 5); }
            set { this.SetDecimal(value, 29, 5); }
        }
        ///  <summary>
        /// Danish: STATUS
        ///  </summary>
        public string STATUS
        {
            get { return this.GetString(34, 3); }
            set { this.SetString(value, 34, 3); }
        }
        ///  <summary>
        /// Danish: STATUSHAENSTART
        ///  </summary>
        public DateTime? STATUSHAENSTART
        {
            get { return this.GetDateTime(37, 13, "yyyyMMddHHmm"); }
            set { this.SetDateTime(value, 37, 13, "yyyyMMddHHmm"); }
        }

        public Decimal STATUSHAENSTARTDecimal
        {
            get { return this.GetDecimal(37, 13); }
            set { this.SetDecimal(value, 37, 13); }
        }

        ///  <summary>
        /// Danish: FORNVNMARK
        ///  </summary>
        public char FORNVNMARK
        {
            get { return this.GetChar(50); }
            set { this.SetChar(value, 50); }
        }
        ///  <summary>
        /// Danish: EFTERNVNMARK
        ///  </summary>
        public char EFTERNVNMARK
        {
            get { return this.GetChar(51); }
            set { this.SetChar(value, 51); }
        }
        ///  <summary>
        /// Danish: NVNHAENSTART
        ///  </summary>
        public DateTime? NVNHAENSTART
        {
            get { return this.GetDateTime(52, 13, "yyyyMMddHHmm"); }
            set { this.SetDateTime(value, 52, 13, "yyyyMMddHHmm"); }
        }

        public Decimal NVNHAENSTARTDecimal
        {
            get { return this.GetDecimal(52, 13); }
            set { this.SetDecimal(value, 52, 13); }
        }

        ///  <summary>
        /// Danish: ADRNVNHAENSTART
        ///  </summary>
        public DateTime? ADRNVNHAENSTART
        {
            get { return this.GetDateTime(65, 13, "yyyyMMddHHmm"); }
            set { this.SetDateTime(value, 65, 13, "yyyyMMddHHmm"); }
        }

        public Decimal ADRNVNHAENSTARTDecimal
        {
            get { return this.GetDecimal(65, 13); }
            set { this.SetDecimal(value, 65, 13); }
        }

        ///  <summary>
        /// Danish: INDRAP
        ///  </summary>
        public string INDRAP
        {
            get { return this.GetString(78, 3); }
            set { this.SetString(value, 78, 3); }
        }
        ///  <summary>
        /// Danish: MYNTXTAJFDTO
        ///  </summary>
        public DateTime? MYNTXTAJFDTO
        {
            get { return this.GetDateTime(81, 13, "yyyyMMddHHmm"); }
            set { this.SetDateTime(value, 81, 13, "yyyyMMddHHmm"); }
        }

        public Decimal MYNTXTAJFDTODecimal
        {
            get { return this.GetDecimal(81, 13); }
            set { this.SetDecimal(value, 81, 13); }
        }

        ///  <summary>
        /// Danish: FORNVN
        ///  </summary>
        public string FORNVN
        {
            get { return this.GetString(94, 50); }
            set { this.SetString(value, 94, 50); }
        }
        ///  <summary>
        /// Danish: EFTERNVN
        ///  </summary>
        public string EFTERNVN
        {
            get { return this.GetString(144, 40); }
            set { this.SetString(value, 144, 40); }
        }
        ///  <summary>
        /// Danish: SFORNVN
        ///  </summary>
        public string SFORNVN
        {
            get { return this.GetString(184, 50); }
            set { this.SetString(value, 184, 50); }
        }
        ///  <summary>
        /// Danish: SEFTERNVN
        ///  </summary>
        public string SEFTERNVN
        {
            get { return this.GetString(234, 40); }
            set { this.SetString(value, 234, 40); }
        }
        ///  <summary>
        /// Danish: ADRNVN
        ///  </summary>
        public string ADRNVN
        {
            get { return this.GetString(274, 34); }
            set { this.SetString(value, 274, 34); }
        }
        ///  <summary>
        /// Danish: MYNTXT_NAVNE
        ///  </summary>
        public string MYNTXT_NAVNE
        {
            get { return this.GetString(308, 20); }
            set { this.SetString(value, 308, 20); }
        }
        ///  <summary>
        /// Danish: AJFDTO_PERSON
        ///  </summary>
        public DateTime? AJFDTO_PERSON
        {
            get { return this.GetDateTime(328, 13, "yyyyMMddHHmm"); }
            set { this.SetDateTime(value, 328, 13, "yyyyMMddHHmm"); }
        }

        public Decimal AJFDTO_PERSONDecimal
        {
            get { return this.GetDecimal(328, 13); }
            set { this.SetDecimal(value, 328, 13); }
        }

        ///  <summary>
        /// Danish: FOEDDTO
        ///  </summary>
        public decimal FOEDDTO
        {
            get { return this.GetDecimal(341, 9); }
            set { this.SetDecimal(value, 341, 9); }
        }
        ///  <summary>
        /// Danish: KOEN
        ///  </summary>
        public char KOEN
        {
            get { return this.GetChar(350); }
            set { this.SetChar(value, 350); }
        }
        ///  <summary>
        /// Danish: FOEDMYNKOD
        ///  </summary>
        public decimal FOEDMYNKOD
        {
            get { return this.GetDecimal(351, 5); }
            set { this.SetDecimal(value, 351, 5); }
        }
        ///  <summary>
        /// Danish: FOEDMYNHAENSTART
        ///  </summary>
        public DateTime? FOEDMYNHAENSTART
        {
            get { return this.GetDateTime(356, 13, "yyyyMMddHHmm"); }
            set { this.SetDateTime(value, 356, 13, "yyyyMMddHHmm"); }
        }

        public Decimal FOEDMYNHAENSTARTDecimal
        {
            get { return this.GetDecimal(356, 13); }
            set { this.SetDecimal(value, 356, 13); }
        }

        ///  <summary>
        /// Danish: FOEDMYNAJFDTO
        ///  </summary>
        public DateTime? FOEDMYNAJFDTO
        {
            get { return this.GetDateTime(369, 13, "yyyyMMddHHmm"); }
            set { this.SetDateTime(value, 369, 13, "yyyyMMddHHmm"); }
        }

        public Decimal FOEDMYNAJFDTODecimal
        {
            get { return this.GetDecimal(369, 13); }
            set { this.SetDecimal(value, 369, 13); }
        }

        ///  <summary>
        /// Danish: FKIRK
        ///  </summary>
        public char FKIRK
        {
            get { return this.GetChar(382); }
            set { this.SetChar(value, 382); }
        }
        ///  <summary>
        /// Danish: FKIRKAJFDTO
        ///  </summary>
        public DateTime? FKIRKAJFDTO
        {
            get { return this.GetDateTime(383, 13, "yyyyMMddHHmm"); }
            set { this.SetDateTime(value, 383, 13, "yyyyMMddHHmm"); }
        }

        public Decimal FKIRKAJFDTODecimal
        {
            get { return this.GetDecimal(383, 13); }
            set { this.SetDecimal(value, 383, 13); }
        }

        ///  <summary>
        /// Danish: FKIRKMYNKOD
        ///  </summary>
        public decimal FKIRKMYNKOD
        {
            get { return this.GetDecimal(396, 5); }
            set { this.SetDecimal(value, 396, 5); }
        }
        ///  <summary>
        /// Danish: FKIRKHAENSTART
        ///  </summary>
        public DateTime? FKIRKHAENSTART
        {
            get { return this.GetDateTime(401, 13, "yyyyMMddHHmm"); }
            set { this.SetDateTime(value, 401, 13, "yyyyMMddHHmm"); }
        }

        public Decimal FKIRKHAENSTARTDecimal
        {
            get { return this.GetDecimal(401, 13); }
            set { this.SetDecimal(value, 401, 13); }
        }

        ///  <summary>
        /// Danish: UMYNMYNKOD
        ///  </summary>
        public decimal UMYNMYNKOD
        {
            get { return this.GetDecimal(414, 5); }
            set { this.SetDecimal(value, 414, 5); }
        }
        ///  <summary>
        /// Danish: UMYNAJFDTO
        ///  </summary>
        public DateTime? UMYNAJFDTO
        {
            get { return this.GetDateTime(419, 13, "yyyyMMddHHmm"); }
            set { this.SetDateTime(value, 419, 13, "yyyyMMddHHmm"); }
        }

        public Decimal UMYNAJFDTODecimal
        {
            get { return this.GetDecimal(419, 13); }
            set { this.SetDecimal(value, 419, 13); }
        }

        ///  <summary>
        /// Danish: UMYNMYNHAENSTART
        ///  </summary>
        public DateTime? UMYNMYNHAENSTART
        {
            get { return this.GetDateTime(432, 13, "yyyyMMddHHmm"); }
            set { this.SetDateTime(value, 432, 13, "yyyyMMddHHmm"); }
        }

        public Decimal UMYNMYNHAENSTARTDecimal
        {
            get { return this.GetDecimal(432, 13); }
            set { this.SetDecimal(value, 432, 13); }
        }

        ///  <summary>
        /// Danish: PNRMRKHAENSTART
        ///  </summary>
        public DateTime? PNRMRKHAENSTART
        {
            get { return this.GetDateTime(445, 13, "yyyyMMddHHmm"); }
            set { this.SetDateTime(value, 445, 13, "yyyyMMddHHmm"); }
        }

        public Decimal PNRMRKHAENSTARTDecimal
        {
            get { return this.GetDecimal(445, 13); }
            set { this.SetDecimal(value, 445, 13); }
        }

        ///  <summary>
        /// Danish: PNRHAENSTART
        ///  </summary>
        public DateTime? PNRHAENSTART
        {
            get { return this.GetDateTime(458, 13, "yyyyMMddHHmm"); }
            set { this.SetDateTime(value, 458, 13, "yyyyMMddHHmm"); }
        }

        public Decimal PNRHAENSTARTDecimal
        {
            get { return this.GetDecimal(458, 13); }
            set { this.SetDecimal(value, 458, 13); }
        }

        ///  <summary>
        /// Danish: AJFDTO_PNRGAELD
        ///  </summary>
        public DateTime? AJFDTO_PNRGAELD
        {
            get { return this.GetDateTime(471, 13, "yyyyMMddHHmm"); }
            set { this.SetDateTime(value, 471, 13, "yyyyMMddHHmm"); }
        }

        public Decimal AJFDTO_PNRGAELDDecimal
        {
            get { return this.GetDecimal(471, 13); }
            set { this.SetDecimal(value, 471, 13); }
        }

        ///  <summary>
        /// Danish: PNRGAELD
        ///  </summary>
        public decimal PNRGAELD
        {
            get { return this.GetDecimal(484, 11); }
            set { this.SetDecimal(value, 484, 11); }
        }
        ///  <summary>
        /// Danish: PNRHAENSLUT
        ///  </summary>
        public DateTime? PNRHAENSLUT
        {
            get { return this.GetDateTime(495, 13, "yyyyMMddHHmm"); }
            set { this.SetDateTime(value, 495, 13, "yyyyMMddHHmm"); }
        }

        public Decimal PNRHAENSLUTDecimal
        {
            get { return this.GetDecimal(495, 13); }
            set { this.SetDecimal(value, 495, 13); }
        }

        ///  <summary>
        /// Danish: STILLINGDTO
        ///  </summary>
        public DateTime? STILLINGDTO
        {
            get { return this.GetDateTime(508, 13, "yyyyMMddHHmm"); }
            set { this.SetDateTime(value, 508, 13, "yyyyMMddHHmm"); }
        }

        public Decimal STILLINGDTODecimal
        {
            get { return this.GetDecimal(508, 13); }
            set { this.SetDecimal(value, 508, 13); }
        }

        ///  <summary>
        /// Danish: FOEDTXTAJFDTO
        ///  </summary>
        public DateTime? FOEDTXTAJFDTO
        {
            get { return this.GetDateTime(521, 13, "yyyyMMddHHmm"); }
            set { this.SetDateTime(value, 521, 13, "yyyyMMddHHmm"); }
        }

        public Decimal FOEDTXTAJFDTODecimal
        {
            get { return this.GetDecimal(521, 13); }
            set { this.SetDecimal(value, 521, 13); }
        }

        ///  <summary>
        /// Danish: KUNDENR
        ///  </summary>
        public decimal KUNDENR
        {
            get { return this.GetDecimal(534, 5); }
            set { this.SetDecimal(value, 534, 5); }
        }
        ///  <summary>
        /// Danish: AJFDTO_MORFAR
        ///  </summary>
        public DateTime? AJFDTO_MORFAR
        {
            get { return this.GetDateTime(539, 13, "yyyyMMddHHmm"); }
            set { this.SetDateTime(value, 539, 13, "yyyyMMddHHmm"); }
        }

        public Decimal AJFDTO_MORFARDecimal
        {
            get { return this.GetDecimal(539, 13); }
            set { this.SetDecimal(value, 539, 13); }
        }

        ///  <summary>
        /// Danish: PNRMOR
        ///  </summary>
        public decimal PNRMOR
        {
            get { return this.GetDecimal(552, 11); }
            set { this.SetDecimal(value, 552, 11); }
        }
        ///  <summary>
        /// Danish: MORFOEDDTO
        ///  </summary>
        public decimal MORFOEDDTO
        {
            get { return this.GetDecimal(563, 9); }
            set { this.SetDecimal(value, 563, 9); }
        }
        ///  <summary>
        /// Danish: MORDOK
        ///  </summary>
        public string MORDOK
        {
            get { return this.GetString(572, 3); }
            set { this.SetString(value, 572, 3); }
        }
        ///  <summary>
        /// Danish: PNRFAR
        ///  </summary>
        public decimal PNRFAR
        {
            get { return this.GetDecimal(575, 11); }
            set { this.SetDecimal(value, 575, 11); }
        }
        ///  <summary>
        /// Danish: FARFOEDDTO
        ///  </summary>
        public decimal FARFOEDDTO
        {
            get { return this.GetDecimal(586, 9); }
            set { this.SetDecimal(value, 586, 9); }
        }
        ///  <summary>
        /// Danish: FARDOK
        ///  </summary>
        public string FARDOK
        {
            get { return this.GetString(595, 3); }
            set { this.SetString(value, 595, 3); }
        }
        ///  <summary>
        /// Danish: FARSKABHAENSTART
        ///  </summary>
        public DateTime? FARSKABHAENSTART
        {
            get { return this.GetDateTime(598, 13, "yyyyMMddHHmm"); }
            set { this.SetDateTime(value, 598, 13, "yyyyMMddHHmm"); }
        }

        public Decimal FARSKABHAENSTARTDecimal
        {
            get { return this.GetDecimal(598, 13); }
            set { this.SetDecimal(value, 598, 13); }
        }

        ///  <summary>
        /// Danish: FARSKABMYNKOD
        ///  </summary>
        public decimal FARSKABMYNKOD
        {
            get { return this.GetDecimal(611, 5); }
            set { this.SetDecimal(value, 611, 5); }
        }
        ///  <summary>
        /// Danish: MORNVN
        ///  </summary>
        public string MORNVN
        {
            get { return this.GetString(616, 34); }
            set { this.SetString(value, 616, 34); }
        }
        ///  <summary>
        /// Danish: FARNVN
        ///  </summary>
        public string FARNVN
        {
            get { return this.GetString(650, 34); }
            set { this.SetString(value, 650, 34); }
        }
        ///  <summary>
        /// Danish: FOEDMYNTXT
        ///  </summary>
        public string FOEDMYNTXT
        {
            get { return this.GetString(684, 20); }
            set { this.SetString(value, 684, 20); }
        }
        ///  <summary>
        /// Danish: STILLING
        ///  </summary>
        public string STILLING
        {
            get { return this.GetString(704, 34); }
            set { this.SetString(value, 704, 34); }
        }
        ///  <summary>
        /// Danish: UMYNSLETDATE
        ///  </summary>
        public DateTime? UMYNSLETDATE
        {
            get { return this.GetDateTime(738, 10, "yyyy-MM-dd"); }
            set { this.SetDateTime(value, 738, 10, "yyyy-MM-dd"); }
        }

        public Decimal UMYNSLETDATEDecimal
        {
            get { return this.GetDecimal(738, 10); }
            set { this.SetDecimal(value, 738, 10); }
        }

        ///  <summary>
        /// Danish: UMYNRELTYP
        ///  </summary>
        public decimal UMYNRELTYP
        {
            get { return this.GetDecimal(748, 4); }
            set { this.SetDecimal(value, 748, 4); }
        }
        ///  <summary>
        /// Danish: AKTKOMNVN
        ///  </summary>
        public string AKTKOMNVN
        {
            get { return this.GetString(752, 20); }
            set { this.SetString(value, 752, 20); }
        }
        ///  <summary>
        /// Danish: NVNADRBESKMRK
        ///  </summary>
        public char NVNADRBESKMRK
        {
            get { return this.GetChar(772); }
            set { this.SetChar(value, 772); }
        }
        ///  <summary>
        /// Danish: LOKBESKMRK
        ///  </summary>
        public char LOKBESKMRK
        {
            get { return this.GetChar(773); }
            set { this.SetChar(value, 773); }
        }
        ///  <summary>
        /// Danish: FOEDREGSTED
        ///  </summary>
        public string FOEDREGSTED
        {
            get { return this.GetString(774, 20); }
            set { this.SetString(value, 774, 20); }
        }
        ///  <summary>
        /// Danish: MOR
        ///  </summary>
        public string MOR
        {
            get { return this.GetString(794, 11); }
            set { this.SetString(value, 794, 11); }
        }
        ///  <summary>
        /// Danish: MORMRK
        ///  </summary>
        public char MORMRK
        {
            get { return this.GetChar(805); }
            set { this.SetChar(value, 805); }
        }
        ///  <summary>
        /// Danish: FAR
        ///  </summary>
        public string FAR
        {
            get { return this.GetString(806, 11); }
            set { this.SetString(value, 806, 11); }
        }
        ///  <summary>
        /// Danish: FARMRK
        ///  </summary>
        public char FARMRK
        {
            get { return this.GetChar(817); }
            set { this.SetChar(value, 817); }
        }
        ///  <summary>
        /// Danish: UDRINDRMRK
        ///  </summary>
        public char UDRINDRMRK
        {
            get { return this.GetChar(818); }
            set { this.SetChar(value, 818); }
        }
        ///  <summary>
        /// Danish: FORSVINDMRK
        ///  </summary>
        public char FORSVINDMRK
        {
            get { return this.GetChar(819); }
            set { this.SetChar(value, 819); }
        }
        ///  <summary>
        /// Danish: AEGTE
        ///  </summary>
        public string AEGTE
        {
            get { return this.GetString(820, 11); }
            set { this.SetString(value, 820, 11); }
        }
        ///  <summary>
        /// Danish: AEGTEMRK
        ///  </summary>
        public char AEGTEMRK
        {
            get { return this.GetChar(831); }
            set { this.SetChar(value, 831); }
        }
        ///  <summary>
        /// Danish: POSTDISTTXT
        ///  </summary>
        public string POSTDISTTXT
        {
            get { return this.GetString(832, 20); }
            set { this.SetString(value, 832, 20); }
        }
        ///  <summary>
        /// Danish: BARNMRK
        ///  </summary>
        public char BARNMRK
        {
            get { return this.GetChar(852); }
            set { this.SetChar(value, 852); }
        }
        ///  <summary>
        /// Danish: SUPLADRMRK
        ///  </summary>
        public char SUPLADRMRK
        {
            get { return this.GetChar(853); }
            set { this.SetChar(value, 853); }
        }
        ///  <summary>
        /// Danish: TIDLPNRMRK
        ///  </summary>
        public char TIDLPNRMRK
        {
            get { return this.GetChar(854); }
            set { this.SetChar(value, 854); }
        }
        ///  <summary>
        /// Danish: FARSKABMYNNVN
        ///  </summary>
        public string FARSKABMYNNVN
        {
            get { return this.GetString(855, 20); }
            set { this.SetString(value, 855, 20); }
        }
        ///  <summary>
        /// Danish: CIVMYN
        ///  </summary>
        public string CIVMYN
        {
            get { return this.GetString(875, 20); }
            set { this.SetString(value, 875, 20); }
        }
        ///  <summary>
        /// Danish: STATSBORGER
        ///  </summary>
        public string STATSBORGER
        {
            get { return this.GetString(895, 20); }
            set { this.SetString(value, 895, 20); }
        }
        ///  <summary>
        /// Danish: TIDLKOMNVN
        ///  </summary>
        public string TIDLKOMNVN
        {
            get { return this.GetString(915, 20); }
            set { this.SetString(value, 915, 20); }
        }
        ///  <summary>
        /// Danish: STANDARDADR
        ///  </summary>
        public string STANDARDADR
        {
            get { return this.GetString(935, 34); }
            set { this.SetString(value, 935, 34); }
        }
        ///  <summary>
        /// Danish: KONTAKTADRMRK
        ///  </summary>
        public char KONTAKTADRMRK
        {
            get { return this.GetChar(969); }
            set { this.SetChar(value, 969); }
        }
        ///  <summary>
        /// Danish: AJFDTO_STAT
        ///  </summary>
        public DateTime? AJFDTO_STAT
        {
            get { return this.GetDateTime(970, 13, "yyyyMMddHHmm"); }
            set { this.SetDateTime(value, 970, 13, "yyyyMMddHHmm"); }
        }

        public Decimal AJFDTO_STATDecimal
        {
            get { return this.GetDecimal(970, 13); }
            set { this.SetDecimal(value, 970, 13); }
        }

        ///  <summary>
        /// Danish: MYNKOD_STAT
        ///  </summary>
        public decimal MYNKOD_STAT
        {
            get { return this.GetDecimal(983, 5); }
            set { this.SetDecimal(value, 983, 5); }
        }
        ///  <summary>
        /// Danish: HAENSTART_STAT
        ///  </summary>
        public DateTime? HAENSTART_STAT
        {
            get { return this.GetDateTime(988, 13, "yyyyMMddHHmm"); }
            set { this.SetDateTime(value, 988, 13, "yyyyMMddHHmm"); }
        }

        public Decimal HAENSTART_STATDecimal
        {
            get { return this.GetDecimal(988, 13); }
            set { this.SetDecimal(value, 988, 13); }
        }

        ///  <summary>
        /// Danish: AJFDTO_CIV
        ///  </summary>
        public DateTime? AJFDTO_CIV
        {
            get { return this.GetDateTime(1001, 13, "yyyyMMddHHmm"); }
            set { this.SetDateTime(value, 1001, 13, "yyyyMMddHHmm"); }
        }

        public Decimal AJFDTO_CIVDecimal
        {
            get { return this.GetDecimal(1001, 13); }
            set { this.SetDecimal(value, 1001, 13); }
        }

        ///  <summary>
        /// Danish: CIVST
        ///  </summary>
        public char CIVST
        {
            get { return this.GetChar(1014); }
            set { this.SetChar(value, 1014); }
        }
        ///  <summary>
        /// Danish: MYNKOD_CIV
        ///  </summary>
        public decimal MYNKOD_CIV
        {
            get { return this.GetDecimal(1015, 5); }
            set { this.SetDecimal(value, 1015, 5); }
        }
        ///  <summary>
        /// Danish: AEGTEPNR
        ///  </summary>
        public decimal AEGTEPNR
        {
            get { return this.GetDecimal(1020, 11); }
            set { this.SetDecimal(value, 1020, 11); }
        }
        ///  <summary>
        /// Danish: AEGTEFOEDDTO
        ///  </summary>
        public decimal AEGTEFOEDDTO
        {
            get { return this.GetDecimal(1031, 9); }
            set { this.SetDecimal(value, 1031, 9); }
        }
        ///  <summary>
        /// Danish: AEGTEDOK
        ///  </summary>
        public string AEGTEDOK
        {
            get { return this.GetString(1040, 3); }
            set { this.SetString(value, 1040, 3); }
        }
        ///  <summary>
        /// Danish: HAENSTART_CIV
        ///  </summary>
        public DateTime? HAENSTART_CIV
        {
            get { return this.GetDateTime(1043, 13, "yyyyMMddHHmm"); }
            set { this.SetDateTime(value, 1043, 13, "yyyyMMddHHmm"); }
        }

        public Decimal HAENSTART_CIVDecimal
        {
            get { return this.GetDecimal(1043, 13); }
            set { this.SetDecimal(value, 1043, 13); }
        }

        ///  <summary>
        /// Danish: MYNTXTAJFDTO_CIV
        ///  </summary>
        public DateTime? MYNTXTAJFDTO_CIV
        {
            get { return this.GetDateTime(1056, 13, "yyyyMMddHHmm"); }
            set { this.SetDateTime(value, 1056, 13, "yyyyMMddHHmm"); }
        }

        public Decimal MYNTXTAJFDTO_CIVDecimal
        {
            get { return this.GetDecimal(1056, 13); }
            set { this.SetDecimal(value, 1056, 13); }
        }

        ///  <summary>
        /// Danish: MYNTXT_CIV
        ///  </summary>
        public string MYNTXT_CIV
        {
            get { return this.GetString(1069, 20); }
            set { this.SetString(value, 1069, 20); }
        }
        ///  <summary>
        /// Danish: AEGTENVN
        ///  </summary>
        public string AEGTENVN
        {
            get { return this.GetString(1089, 34); }
            set { this.SetString(value, 1089, 34); }
        }
        ///  <summary>
        /// Danish: AJFDTO_PERSONBOLIG
        ///  </summary>
        public DateTime? AJFDTO_PERSONBOLIG
        {
            get { return this.GetDateTime(1123, 13, "yyyyMMddHHmm"); }
            set { this.SetDateTime(value, 1123, 13, "yyyyMMddHHmm"); }
        }

        public Decimal AJFDTO_PERSONBOLIGDecimal
        {
            get { return this.GetDecimal(1123, 13); }
            set { this.SetDecimal(value, 1123, 13); }
        }

        ///  <summary>
        /// Danish: KOMKOD
        ///  </summary>
        public decimal KOMKOD
        {
            get { return this.GetDecimal(1136, 5); }
            set { this.SetDecimal(value, 1136, 5); }
        }
        ///  <summary>
        /// Danish: VEJKOD
        ///  </summary>
        public decimal VEJKOD
        {
            get { return this.GetDecimal(1141, 5); }
            set { this.SetDecimal(value, 1141, 5); }
        }
        ///  <summary>
        /// Danish: HUSNR
        ///  </summary>
        public string HUSNR
        {
            get { return this.GetString(1146, 4); }
            set { this.SetString(value, 1146, 4); }
        }
        ///  <summary>
        /// Danish: ETAGE
        ///  </summary>
        public string ETAGE
        {
            get { return this.GetString(1150, 2); }
            set { this.SetString(value, 1150, 2); }
        }
        ///  <summary>
        /// Danish: SIDEDOER
        ///  </summary>
        public string SIDEDOER
        {
            get { return this.GetString(1152, 4); }
            set { this.SetString(value, 1152, 4); }
        }
        ///  <summary>
        /// Danish: BNR
        ///  </summary>
        public string BNR
        {
            get { return this.GetString(1156, 4); }
            set { this.SetString(value, 1156, 4); }
        }
        ///  <summary>
        /// Danish: POSTNR
        ///  </summary>
        public decimal POSTNR
        {
            get { return this.GetDecimal(1160, 5); }
            set { this.SetDecimal(value, 1160, 5); }
        }
        ///  <summary>
        /// Danish: KOMNVN
        ///  </summary>
        public string KOMNVN
        {
            get { return this.GetString(1165, 20); }
            set { this.SetString(value, 1165, 20); }
        }
        ///  <summary>
        /// Danish: VEJADRNVN
        ///  </summary>
        public string VEJADRNVN
        {
            get { return this.GetString(1185, 20); }
            set { this.SetString(value, 1185, 20); }
        }
        ///  <summary>
        /// Danish: TILFLYDTO
        ///  </summary>
        public DateTime? TILFLYDTO
        {
            get { return this.GetDateTime(1205, 13, "yyyyMMddHHmm"); }
            set { this.SetDateTime(value, 1205, 13, "yyyyMMddHHmm"); }
        }

        public Decimal TILFLYDTODecimal
        {
            get { return this.GetDecimal(1205, 13); }
            set { this.SetDecimal(value, 1205, 13); }
        }

        ///  <summary>
        /// Danish: TILFLYDTOMRK
        ///  </summary>
        public char TILFLYDTOMRK
        {
            get { return this.GetChar(1218); }
            set { this.SetChar(value, 1218); }
        }
        ///  <summary>
        /// Danish: FRAFLYKOMKOD
        ///  </summary>
        public decimal FRAFLYKOMKOD
        {
            get { return this.GetDecimal(1219, 5); }
            set { this.SetDecimal(value, 1219, 5); }
        }
        ///  <summary>
        /// Danish: FRAFLYKOMDTO
        ///  </summary>
        public DateTime? FRAFLYKOMDTO
        {
            get { return this.GetDateTime(1224, 13, "yyyyMMddHHmm"); }
            set { this.SetDateTime(value, 1224, 13, "yyyyMMddHHmm"); }
        }

        public Decimal FRAFLYKOMDTODecimal
        {
            get { return this.GetDecimal(1224, 13); }
            set { this.SetDecimal(value, 1224, 13); }
        }

        ///  <summary>
        /// Danish: TILFLYKOMDTO
        ///  </summary>
        public DateTime? TILFLYKOMDTO
        {
            get { return this.GetDateTime(1237, 13, "yyyyMMddHHmm"); }
            set { this.SetDateTime(value, 1237, 13, "yyyyMMddHHmm"); }
        }

        public Decimal TILFLYKOMDTODecimal
        {
            get { return this.GetDecimal(1237, 13); }
            set { this.SetDecimal(value, 1237, 13); }
        }

        ///  <summary>
        /// Danish: SUPLADRHAENSTART
        ///  </summary>
        public DateTime? SUPLADRHAENSTART
        {
            get { return this.GetDateTime(1250, 13, "yyyyMMddHHmm"); }
            set { this.SetDateTime(value, 1250, 13, "yyyyMMddHHmm"); }
        }

        public Decimal SUPLADRHAENSTARTDecimal
        {
            get { return this.GetDecimal(1250, 13); }
            set { this.SetDecimal(value, 1250, 13); }
        }

        ///  <summary>
        /// Danish: CONVN
        ///  </summary>
        public string CONVN
        {
            get { return this.GetString(1263, 34); }
            set { this.SetString(value, 1263, 34); }
        }
        ///  <summary>
        /// Danish: BYNVN
        ///  </summary>
        public string BYNVN
        {
            get { return this.GetString(1297, 34); }
            set { this.SetString(value, 1297, 34); }
        }
        ///  <summary>
        /// Danish: LOKALITET
        ///  </summary>
        public string LOKALITET
        {
            get { return this.GetString(1331, 34); }
            set { this.SetString(value, 1331, 34); }
        }
        ///  <summary>
        /// Danish: SUPLADR1
        ///  </summary>
        public string SUPLADR1
        {
            get { return this.GetString(1365, 34); }
            set { this.SetString(value, 1365, 34); }
        }
        ///  <summary>
        /// Danish: SUPLADR2
        ///  </summary>
        public string SUPLADR2
        {
            get { return this.GetString(1399, 34); }
            set { this.SetString(value, 1399, 34); }
        }
        ///  <summary>
        /// Danish: SUPLADR3
        ///  </summary>
        public string SUPLADR3
        {
            get { return this.GetString(1433, 34); }
            set { this.SetString(value, 1433, 34); }
        }
        ///  <summary>
        /// Danish: SUPLADR4
        ///  </summary>
        public string SUPLADR4
        {
            get { return this.GetString(1467, 34); }
            set { this.SetString(value, 1467, 34); }
        }
        ///  <summary>
        /// Danish: SUPLADR5
        ///  </summary>
        public string SUPLADR5
        {
            get { return this.GetString(1501, 34); }
            set { this.SetString(value, 1501, 34); }
        }
        ///  <summary>
        /// Danish: AJFDTO_FORSVIND
        ///  </summary>
        public DateTime? AJFDTO_FORSVIND
        {
            get { return this.GetDateTime(1535, 13, "yyyyMMddHHmm"); }
            set { this.SetDateTime(value, 1535, 13, "yyyyMMddHHmm"); }
        }

        public Decimal AJFDTO_FORSVINDDecimal
        {
            get { return this.GetDecimal(1535, 13); }
            set { this.SetDecimal(value, 1535, 13); }
        }

        ///  <summary>
        /// Danish: FORSVINDDTO
        ///  </summary>
        public DateTime? FORSVINDDTO
        {
            get { return this.GetDateTime(1548, 13, "yyyyMMddHHmm"); }
            set { this.SetDateTime(value, 1548, 13, "yyyyMMddHHmm"); }
        }

        public Decimal FORSVINDDTODecimal
        {
            get { return this.GetDecimal(1548, 13); }
            set { this.SetDecimal(value, 1548, 13); }
        }

        ///  <summary>
        /// Danish: AJFDTO_UDRINDR
        ///  </summary>
        public DateTime? AJFDTO_UDRINDR
        {
            get { return this.GetDateTime(1561, 13, "yyyyMMddHHmm"); }
            set { this.SetDateTime(value, 1561, 13, "yyyyMMddHHmm"); }
        }

        public Decimal AJFDTO_UDRINDRDecimal
        {
            get { return this.GetDecimal(1561, 13); }
            set { this.SetDecimal(value, 1561, 13); }
        }

        ///  <summary>
        /// Danish: UDRMYNKOD
        ///  </summary>
        public decimal UDRMYNKOD
        {
            get { return this.GetDecimal(1574, 5); }
            set { this.SetDecimal(value, 1574, 5); }
        }
        ///  <summary>
        /// Danish: UDRDTO
        ///  </summary>
        public DateTime? UDRDTO
        {
            get { return this.GetDateTime(1579, 13, "yyyyMMddHHmm"); }
            set { this.SetDateTime(value, 1579, 13, "yyyyMMddHHmm"); }
        }

        public Decimal UDRDTODecimal
        {
            get { return this.GetDecimal(1579, 13); }
            set { this.SetDecimal(value, 1579, 13); }
        }

        ///  <summary>
        /// Danish: UDRAJFDTO
        ///  </summary>
        public DateTime? UDRAJFDTO
        {
            get { return this.GetDateTime(1592, 13, "yyyyMMddHHmm"); }
            set { this.SetDateTime(value, 1592, 13, "yyyyMMddHHmm"); }
        }

        public Decimal UDRAJFDTODecimal
        {
            get { return this.GetDecimal(1592, 13); }
            set { this.SetDecimal(value, 1592, 13); }
        }

        ///  <summary>
        /// Danish: UDLANDADRDTO
        ///  </summary>
        public DateTime? UDLANDADRDTO
        {
            get { return this.GetDateTime(1605, 13, "yyyyMMddHHmm"); }
            set { this.SetDateTime(value, 1605, 13, "yyyyMMddHHmm"); }
        }

        public Decimal UDLANDADRDTODecimal
        {
            get { return this.GetDecimal(1605, 13); }
            set { this.SetDecimal(value, 1605, 13); }
        }

        ///  <summary>
        /// Danish: VALGRETDTO
        ///  </summary>
        public DateTime? VALGRETDTO
        {
            get { return this.GetDateTime(1618, 13, "yyyyMMddHHmm"); }
            set { this.SetDateTime(value, 1618, 13, "yyyyMMddHHmm"); }
        }

        public Decimal VALGRETDTODecimal
        {
            get { return this.GetDecimal(1618, 13); }
            set { this.SetDecimal(value, 1618, 13); }
        }

        ///  <summary>
        /// Danish: UDLANDSADR1
        ///  </summary>
        public string UDLANDSADR1
        {
            get { return this.GetString(1631, 34); }
            set { this.SetString(value, 1631, 34); }
        }
        ///  <summary>
        /// Danish: UDLANDSADR2
        ///  </summary>
        public string UDLANDSADR2
        {
            get { return this.GetString(1665, 34); }
            set { this.SetString(value, 1665, 34); }
        }
        ///  <summary>
        /// Danish: UDLANDSADR3
        ///  </summary>
        public string UDLANDSADR3
        {
            get { return this.GetString(1699, 34); }
            set { this.SetString(value, 1699, 34); }
        }
        ///  <summary>
        /// Danish: UDLANDSADR4
        ///  </summary>
        public string UDLANDSADR4
        {
            get { return this.GetString(1733, 34); }
            set { this.SetString(value, 1733, 34); }
        }
        ///  <summary>
        /// Danish: UDLANDSADR5
        ///  </summary>
        public string UDLANDSADR5
        {
            get { return this.GetString(1767, 34); }
            set { this.SetString(value, 1767, 34); }
        }
        ///  <summary>
        /// Danish: AJFDTO_KONTAKTADR
        ///  </summary>
        public DateTime? AJFDTO_KONTAKTADR
        {
            get { return this.GetDateTime(1801, 13, "yyyyMMddHHmm"); }
            set { this.SetDateTime(value, 1801, 13, "yyyyMMddHHmm"); }
        }

        public Decimal AJFDTO_KONTAKTADRDecimal
        {
            get { return this.GetDecimal(1801, 13); }
            set { this.SetDecimal(value, 1801, 13); }
        }

        ///  <summary>
        /// Danish: KONTAKTADR_KOMKOD
        ///  </summary>
        public decimal KONTAKTADR_KOMKOD
        {
            get { return this.GetDecimal(1814, 5); }
            set { this.SetDecimal(value, 1814, 5); }
        }
        ///  <summary>
        /// Danish: KONTAKTADRSTART
        ///  </summary>
        public DateTime? KONTAKTADRSTART
        {
            get { return this.GetDateTime(1819, 13, "yyyyMMddHHmm"); }
            set { this.SetDateTime(value, 1819, 13, "yyyyMMddHHmm"); }
        }

        public Decimal KONTAKTADRSTARTDecimal
        {
            get { return this.GetDecimal(1819, 13); }
            set { this.SetDecimal(value, 1819, 13); }
        }

        ///  <summary>
        /// Danish: KONTAKTADR1
        ///  </summary>
        public string KONTAKTADR1
        {
            get { return this.GetString(1832, 34); }
            set { this.SetString(value, 1832, 34); }
        }
        ///  <summary>
        /// Danish: KONTAKTADR2
        ///  </summary>
        public string KONTAKTADR2
        {
            get { return this.GetString(1866, 34); }
            set { this.SetString(value, 1866, 34); }
        }
        ///  <summary>
        /// Danish: KONTAKTADR3
        ///  </summary>
        public string KONTAKTADR3
        {
            get { return this.GetString(1900, 34); }
            set { this.SetString(value, 1900, 34); }
        }
        ///  <summary>
        /// Danish: KONTAKTADR4
        ///  </summary>
        public string KONTAKTADR4
        {
            get { return this.GetString(1934, 34); }
            set { this.SetString(value, 1934, 34); }
        }
        ///  <summary>
        /// Danish: KONTAKTADR5
        ///  </summary>
        public string KONTAKTADR5
        {
            get { return this.GetString(1968, 34); }
            set { this.SetString(value, 1968, 34); }
        }
        ///  <summary>
        /// Danish: AJFDTO_RELPNR_1
        ///  </summary>
        public DateTime? AJFDTO_RELPNR_1
        {
            get { return this.GetDateTime(2002, 13, "yyyyMMddHHmm"); }
            set { this.SetDateTime(value, 2002, 13, "yyyyMMddHHmm"); }
        }

        public Decimal AJFDTO_RELPNR_1Decimal
        {
            get { return this.GetDecimal(2002, 13); }
            set { this.SetDecimal(value, 2002, 13); }
        }

        ///  <summary>
        /// Danish: RELPNR_1
        ///  </summary>
        public decimal RELPNR_1
        {
            get { return this.GetDecimal(2015, 11); }
            set { this.SetDecimal(value, 2015, 11); }
        }
        ///  <summary>
        /// Danish: RELTYP_1
        ///  </summary>
        public decimal RELTYP_1
        {
            get { return this.GetDecimal(2026, 4); }
            set { this.SetDecimal(value, 2026, 4); }
        }
        ///  <summary>
        /// Danish: STARTDATE_1
        ///  </summary>
        public DateTime? STARTDATE_1
        {
            get { return this.GetDateTime(2030, 10, "yyyy-MM-dd"); }
            set { this.SetDateTime(value, 2030, 10, "yyyy-MM-dd"); }
        }

        public Decimal STARTDATE_1Decimal
        {
            get { return this.GetDecimal(2030, 10); }
            set { this.SetDecimal(value, 2030, 10); }
        }

        ///  <summary>
        /// Danish: SLETDATE_1
        ///  </summary>
        public DateTime? SLETDATE_1
        {
            get { return this.GetDateTime(2040, 10, "yyyy-MM-dd"); }
            set { this.SetDateTime(value, 2040, 10, "yyyy-MM-dd"); }
        }

        public Decimal SLETDATE_1Decimal
        {
            get { return this.GetDecimal(2040, 10); }
            set { this.SetDecimal(value, 2040, 10); }
        }

        ///  <summary>
        /// Danish: MYNKOD_5_1
        ///  </summary>
        public decimal MYNKOD_5_1
        {
            get { return this.GetDecimal(2050, 5); }
            set { this.SetDecimal(value, 2050, 5); }
        }
        ///  <summary>
        /// Danish: AJFDTO_RELPNR_5
        ///  </summary>
        public DateTime? AJFDTO_RELPNR_5
        {
            get { return this.GetDateTime(2055, 13, "yyyyMMddHHmm"); }
            set { this.SetDateTime(value, 2055, 13, "yyyyMMddHHmm"); }
        }

        public Decimal AJFDTO_RELPNR_5Decimal
        {
            get { return this.GetDecimal(2055, 13); }
            set { this.SetDecimal(value, 2055, 13); }
        }

        ///  <summary>
        /// Danish: RELPNR_5
        ///  </summary>
        public decimal RELPNR_5
        {
            get { return this.GetDecimal(2068, 11); }
            set { this.SetDecimal(value, 2068, 11); }
        }
        ///  <summary>
        /// Danish: RELTYP_5
        ///  </summary>
        public decimal RELTYP_5
        {
            get { return this.GetDecimal(2079, 4); }
            set { this.SetDecimal(value, 2079, 4); }
        }
        ///  <summary>
        /// Danish: STARTDATE_5
        ///  </summary>
        public DateTime? STARTDATE_5
        {
            get { return this.GetDateTime(2083, 10, "yyyy-MM-dd"); }
            set { this.SetDateTime(value, 2083, 10, "yyyy-MM-dd"); }
        }

        public Decimal STARTDATE_5Decimal
        {
            get { return this.GetDecimal(2083, 10); }
            set { this.SetDecimal(value, 2083, 10); }
        }

        ///  <summary>
        /// Danish: SLETDATE_5
        ///  </summary>
        public DateTime? SLETDATE_5
        {
            get { return this.GetDateTime(2093, 10, "yyyy-MM-dd"); }
            set { this.SetDateTime(value, 2093, 10, "yyyy-MM-dd"); }
        }

        public Decimal SLETDATE_5Decimal
        {
            get { return this.GetDecimal(2093, 10); }
            set { this.SetDecimal(value, 2093, 10); }
        }

        ///  <summary>
        /// Danish: MYNKOD_5_5
        ///  </summary>
        public decimal MYNKOD_5_5
        {
            get { return this.GetDecimal(2103, 5); }
            set { this.SetDecimal(value, 2103, 5); }
        }
        ///  <summary>
        /// Danish: AJFDTO_RELPNR_6
        ///  </summary>
        public DateTime? AJFDTO_RELPNR_6
        {
            get { return this.GetDateTime(2108, 13, "yyyyMMddHHmm"); }
            set { this.SetDateTime(value, 2108, 13, "yyyyMMddHHmm"); }
        }

        public Decimal AJFDTO_RELPNR_6Decimal
        {
            get { return this.GetDecimal(2108, 13); }
            set { this.SetDecimal(value, 2108, 13); }
        }

        ///  <summary>
        /// Danish: RELPNR_6
        ///  </summary>
        public decimal RELPNR_6
        {
            get { return this.GetDecimal(2121, 11); }
            set { this.SetDecimal(value, 2121, 11); }
        }
        ///  <summary>
        /// Danish: RELTYP_6
        ///  </summary>
        public decimal RELTYP_6
        {
            get { return this.GetDecimal(2132, 4); }
            set { this.SetDecimal(value, 2132, 4); }
        }
        ///  <summary>
        /// Danish: STARTDATE_6
        ///  </summary>
        public DateTime? STARTDATE_6
        {
            get { return this.GetDateTime(2136, 10, "yyyy-MM-dd"); }
            set { this.SetDateTime(value, 2136, 10, "yyyy-MM-dd"); }
        }

        public Decimal STARTDATE_6Decimal
        {
            get { return this.GetDecimal(2136, 10); }
            set { this.SetDecimal(value, 2136, 10); }
        }

        ///  <summary>
        /// Danish: SLETDATE_6
        ///  </summary>
        public DateTime? SLETDATE_6
        {
            get { return this.GetDateTime(2146, 10, "yyyy-MM-dd"); }
            set { this.SetDateTime(value, 2146, 10, "yyyy-MM-dd"); }
        }

        public Decimal SLETDATE_6Decimal
        {
            get { return this.GetDecimal(2146, 10); }
            set { this.SetDecimal(value, 2146, 10); }
        }

        ///  <summary>
        /// Danish: MYNKOD_5_6
        ///  </summary>
        public decimal MYNKOD_5_6
        {
            get { return this.GetDecimal(2156, 5); }
            set { this.SetDecimal(value, 2156, 5); }
        }
        ///  <summary>
        /// Danish: AJFDTO_RELTXT
        ///  </summary>
        public DateTime? AJFDTO_RELTXT
        {
            get { return this.GetDateTime(2161, 13, "yyyyMMddHHmm"); }
            set { this.SetDateTime(value, 2161, 13, "yyyyMMddHHmm"); }
        }

        public Decimal AJFDTO_RELTXTDecimal
        {
            get { return this.GetDecimal(2161, 13); }
            set { this.SetDecimal(value, 2161, 13); }
        }

        ///  <summary>
        /// Danish: RELADRSAT
        ///  </summary>
        public string RELADRSAT
        {
            get { return this.GetString(2174, 34); }
            set { this.SetString(value, 2174, 34); }
        }
        ///  <summary>
        /// Danish: RELTYP_TXT
        ///  </summary>
        public decimal RELTYP_TXT
        {
            get { return this.GetDecimal(2208, 4); }
            set { this.SetDecimal(value, 2208, 4); }
        }
        ///  <summary>
        /// Danish: RELTXT1
        ///  </summary>
        public string RELTXT1
        {
            get { return this.GetString(2212, 34); }
            set { this.SetString(value, 2212, 34); }
        }
        ///  <summary>
        /// Danish: RELTXT2
        ///  </summary>
        public string RELTXT2
        {
            get { return this.GetString(2246, 34); }
            set { this.SetString(value, 2246, 34); }
        }
        ///  <summary>
        /// Danish: RELTXT3
        ///  </summary>
        public string RELTXT3
        {
            get { return this.GetString(2280, 34); }
            set { this.SetString(value, 2280, 34); }
        }
        ///  <summary>
        /// Danish: RELTXT4
        ///  </summary>
        public string RELTXT4
        {
            get { return this.GetString(2314, 34); }
            set { this.SetString(value, 2314, 34); }
        }
        ///  <summary>
        /// Danish: RELTXT5
        ///  </summary>
        public string RELTXT5
        {
            get { return this.GetString(2348, 34); }
            set { this.SetString(value, 2348, 34); }
        }
        ///  <summary>
        /// Danish: STARTDATE_TXT
        ///  </summary>
        public DateTime? STARTDATE_TXT
        {
            get { return this.GetDateTime(2382, 10, "yyyy-MM-dd"); }
            set { this.SetDateTime(value, 2382, 10, "yyyy-MM-dd"); }
        }

        public Decimal STARTDATE_TXTDecimal
        {
            get { return this.GetDecimal(2382, 10); }
            set { this.SetDecimal(value, 2382, 10); }
        }

        ///  <summary>
        /// Danish: SLETDATE_TXT
        ///  </summary>
        public string SLETDATE_TXT
        {
            get { return this.GetString(2392, 10); }
            set { this.SetString(value, 2392, 10); }
        }
        ///  <summary>
        /// Danish: MYNKOD_5_TXT
        ///  </summary>
        public decimal MYNKOD_5_TXT
        {
            get { return this.GetDecimal(2402, 5); }
            set { this.SetDecimal(value, 2402, 5); }
        }
        ///  <summary>
        /// Danish: AJFDTO_SEP
        ///  </summary>
        public DateTime? AJFDTO_SEP
        {
            get { return this.GetDateTime(2407, 13, "yyyyMMddHHmm"); }
            set { this.SetDateTime(value, 2407, 13, "yyyyMMddHHmm"); }
        }

        public Decimal AJFDTO_SEPDecimal
        {
            get { return this.GetDecimal(2407, 13); }
            set { this.SetDecimal(value, 2407, 13); }
        }

        ///  <summary>
        /// Danish: SEP_HENVIS_TS
        ///  </summary>
        public string SEP_HENVIS_TS
        {
            get { return this.GetString(2420, 26); }
            set { this.SetString(value, 2420, 26); }
        }
        ///  <summary>
        /// Danish: START_MYNKOD_SEP
        ///  </summary>
        public decimal START_MYNKOD_SEP
        {
            get { return this.GetDecimal(2446, 5); }
            set { this.SetDecimal(value, 2446, 5); }
        }
        ///  <summary>
        /// Danish: STARTDATE
        ///  </summary>
        public DateTime? STARTDATE_SEP
        {
            get { return this.GetDateTime(2451, 19, "dd-MM-yyyy HH:mm:ss"); }
            set { this.SetDateTime(value, 2451, 19, "dd-MM-yyyy HH:mm:ss"); }
        }

        public Decimal STARTDATE_SEPDecimal
        {
            get { return this.GetDecimal(2451, 19); }
            set { this.SetDecimal(value, 2451, 19); }
        }

        ///  <summary>
        /// Danish: STARTDATE_UMRK
        ///  </summary>
        public char STARTDATE_SEP_UMRK
        {
            get { return this.GetChar(2470); }
            set { this.SetChar(value, 2470); }
        }
        ///  <summary>
        /// Danish: RELTYP_FORALD_35
        ///  </summary>
        public decimal RELTYP_FORALD_35
        {
            get { return this.GetDecimal(2471, 4); }
            set { this.SetDecimal(value, 2471, 4); }
        }
        ///  <summary>
        /// Danish: AJFDTO_FORALD_35
        ///  </summary>
        public DateTime? AJFDTO_FORALD_35
        {
            get { return this.GetDateTime(2475, 13, "yyyyMMddHHmm"); }
            set { this.SetDateTime(value, 2475, 13, "yyyyMMddHHmm"); }
        }

        public Decimal AJFDTO_FORALD_35Decimal
        {
            get { return this.GetDecimal(2475, 13); }
            set { this.SetDecimal(value, 2475, 13); }
        }

        ///  <summary>
        /// Danish: STARTMYNKOD_FORALD_35
        ///  </summary>
        public decimal STARTMYNKOD_FORALD_35
        {
            get { return this.GetDecimal(2488, 5); }
            set { this.SetDecimal(value, 2488, 5); }
        }
        ///  <summary>
        /// Danish: STARTDATE_FORALD_35
        ///  </summary>
        public DateTime? STARTDATE_FORALD_35
        {
            get { return this.GetDateTime(2493, 10, "yyyy-MM-dd"); }
            set { this.SetDateTime(value, 2493, 10, "yyyy-MM-dd"); }
        }

        public Decimal STARTDATE_FORALD_35Decimal
        {
            get { return this.GetDecimal(2493, 10); }
            set { this.SetDecimal(value, 2493, 10); }
        }

        ///  <summary>
        /// Danish: STARTDATE_FORALD_UMRK_35
        ///  </summary>
        public char STARTDATE_FORALD_UMRK_35
        {
            get { return this.GetChar(2503); }
            set { this.SetChar(value, 2503); }
        }
        ///  <summary>
        /// Danish: SLETDATE_FORALD_35
        ///  </summary>
        public DateTime? SLETDATE_FORALD_35
        {
            get { return this.GetDateTime(2504, 10, "yyyy-MM-dd"); }
            set { this.SetDateTime(value, 2504, 10, "yyyy-MM-dd"); }
        }

        public Decimal SLETDATE_FORALD_35Decimal
        {
            get { return this.GetDecimal(2504, 10); }
            set { this.SetDecimal(value, 2504, 10); }
        }

        ///  <summary>
        /// Danish: RELTYP_FORALD_46
        ///  </summary>
        public decimal RELTYP_FORALD_46
        {
            get { return this.GetDecimal(2514, 4); }
            set { this.SetDecimal(value, 2514, 4); }
        }
        ///  <summary>
        /// Danish: AJFDTO_FORALD_46
        ///  </summary>
        public DateTime? AJFDTO_FORALD_46
        {
            get { return this.GetDateTime(2518, 13, "yyyyMMddHHmm"); }
            set { this.SetDateTime(value, 2518, 13, "yyyyMMddHHmm"); }
        }

        public Decimal AJFDTO_FORALD_46Decimal
        {
            get { return this.GetDecimal(2518, 13); }
            set { this.SetDecimal(value, 2518, 13); }
        }

        ///  <summary>
        /// Danish: STARTMYNKOD_FORALD_46
        ///  </summary>
        public decimal STARTMYNKOD_FORALD_46
        {
            get { return this.GetDecimal(2531, 5); }
            set { this.SetDecimal(value, 2531, 5); }
        }
        ///  <summary>
        /// Danish: STARTDATE_FORALD_46
        ///  </summary>
        public DateTime? STARTDATE_FORALD_46
        {
            get { return this.GetDateTime(2536, 10, "yyyy-MM-dd"); }
            set { this.SetDateTime(value, 2536, 10, "yyyy-MM-dd"); }
        }

        public Decimal STARTDATE_FORALD_46Decimal
        {
            get { return this.GetDecimal(2536, 10); }
            set { this.SetDecimal(value, 2536, 10); }
        }

        ///  <summary>
        /// Danish: STARTDATE_FORALD_UMRK_46
        ///  </summary>
        public char STARTDATE_FORALD_UMRK_46
        {
            get { return this.GetChar(2555); }
            set { this.SetChar(value, 2555); }
        }
        ///  <summary>
        /// Danish: SLETDATE_FORALD_46
        ///  </summary>
        public DateTime? SLETDATE_FORALD_46
        {
            get { return this.GetDateTime(2556, 10, "yyyy-MM-dd"); }
            set { this.SetDateTime(value, 2556, 10, "yyyy-MM-dd"); }
        }

        public Decimal SLETDATE_FORALD_46Decimal
        {
            get { return this.GetDecimal(2556, 10); }
            set { this.SetDecimal(value, 2556, 10); }
        }

        ///  <summary>
        /// Danish: ANTAL_BOERN
        ///  </summary>
        public decimal ANTAL_BOERN
        {
            get { return this.GetDecimal(2566, 2); }
            set { this.SetDecimal(value, 2566, 2); }
        }
        ///  <summary>
        /// Danish: PNR_BORN
        ///  </summary>
        public string PNR_BORN
        {
            get { return this.GetString(2568, 675); }
            set { this.SetString(value, 2568, 675); }
        }

        #endregion
        public override Tuple<string, int, int>[] DefaultPropertyDefinitions
        {
            get 
            {
                var ret = base.DefaultPropertyDefinitions.ToList();
                ret.AddRange(new Tuple<string, int, int>[]{
                    new Tuple<string, int, int>("PNR", 5, 11),
                    new Tuple<string, int, int>("AJFDTO_NAVNE", 16, 13),
                    new Tuple<string, int, int>("MYNKOD_NAVNE", 29, 5),
                    new Tuple<string, int, int>("STATUS", 34, 3),
                    new Tuple<string, int, int>("STATUSHAENSTART", 37, 13),
                    new Tuple<string, int, int>("FORNVNMARK", 50, 1),
                    new Tuple<string, int, int>("EFTERNVNMARK", 51, 1),
                    new Tuple<string, int, int>("NVNHAENSTART", 52, 13),
                    new Tuple<string, int, int>("ADRNVNHAENSTART", 65, 13),
                    new Tuple<string, int, int>("INDRAP", 78, 3),
                    new Tuple<string, int, int>("MYNTXTAJFDTO", 81, 13),
                    new Tuple<string, int, int>("FORNVN", 94, 50),
                    new Tuple<string, int, int>("EFTERNVN", 144, 40),
                    new Tuple<string, int, int>("SFORNVN", 184, 50),
                    new Tuple<string, int, int>("SEFTERNVN", 234, 40),
                    new Tuple<string, int, int>("ADRNVN", 274, 34),
                    new Tuple<string, int, int>("MYNTXT_NAVNE", 308, 20),
                    new Tuple<string, int, int>("AJFDTO_PERSON", 328, 13),
                    new Tuple<string, int, int>("FOEDDTO", 341, 9),
                    new Tuple<string, int, int>("KOEN", 350, 1),
                    new Tuple<string, int, int>("FOEDMYNKOD", 351, 5),
                    new Tuple<string, int, int>("FOEDMYNHAENSTART", 356, 13),
                    new Tuple<string, int, int>("FOEDMYNAJFDTO", 369, 13),
                    new Tuple<string, int, int>("FKIRK", 382, 1),
                    new Tuple<string, int, int>("FKIRKAJFDTO", 383, 13),
                    new Tuple<string, int, int>("FKIRKMYNKOD", 396, 5),
                    new Tuple<string, int, int>("FKIRKHAENSTART", 401, 13),
                    new Tuple<string, int, int>("UMYNMYNKOD", 414, 5),
                    new Tuple<string, int, int>("UMYNAJFDTO", 419, 13),
                    new Tuple<string, int, int>("UMYNMYNHAENSTART", 432, 13),
                    new Tuple<string, int, int>("PNRMRKHAENSTART", 445, 13),
                    new Tuple<string, int, int>("PNRHAENSTART", 458, 13),
                    new Tuple<string, int, int>("AJFDTO_PNRGAELD", 471, 13),
                    new Tuple<string, int, int>("PNRGAELD", 484, 11),
                    new Tuple<string, int, int>("PNRHAENSLUT", 495, 13),
                    new Tuple<string, int, int>("STILLINGDTO", 508, 13),
                    new Tuple<string, int, int>("FOEDTXTAJFDTO", 521, 13),
                    new Tuple<string, int, int>("KUNDENR", 534, 5),
                    new Tuple<string, int, int>("AJFDTO_MORFAR", 539, 13),
                    new Tuple<string, int, int>("PNRMOR", 552, 11),
                    new Tuple<string, int, int>("MORFOEDDTO", 563, 9),
                    new Tuple<string, int, int>("MORDOK", 572, 3),
                    new Tuple<string, int, int>("PNRFAR", 575, 11),
                    new Tuple<string, int, int>("FARFOEDDTO", 586, 9),
                    new Tuple<string, int, int>("FARDOK", 595, 3),
                    new Tuple<string, int, int>("FARSKABHAENSTART", 598, 13),
                    new Tuple<string, int, int>("FARSKABMYNKOD", 611, 5),
                    new Tuple<string, int, int>("MORNVN", 616, 34),
                    new Tuple<string, int, int>("FARNVN", 650, 34),
                    new Tuple<string, int, int>("FOEDMYNTXT", 684, 20),
                    new Tuple<string, int, int>("STILLING", 704, 34),
                    new Tuple<string, int, int>("UMYNSLETDATE", 738, 10),
                    new Tuple<string, int, int>("UMYNRELTYP", 748, 4),
                    new Tuple<string, int, int>("AKTKOMNVN", 752, 20),
                    new Tuple<string, int, int>("NVNADRBESKMRK", 772, 1),
                    new Tuple<string, int, int>("LOKBESKMRK", 773, 1),
                    new Tuple<string, int, int>("FOEDREGSTED", 774, 20),
                    new Tuple<string, int, int>("MOR", 794, 11),
                    new Tuple<string, int, int>("MORMRK", 805, 1),
                    new Tuple<string, int, int>("FAR", 806, 11),
                    new Tuple<string, int, int>("FARMRK", 817, 1),
                    new Tuple<string, int, int>("UDRINDRMRK", 818, 1),
                    new Tuple<string, int, int>("FORSVINDMRK", 819, 1),
                    new Tuple<string, int, int>("AEGTE", 820, 11),
                    new Tuple<string, int, int>("AEGTEMRK", 831, 1),
                    new Tuple<string, int, int>("POSTDISTTXT", 832, 20),
                    new Tuple<string, int, int>("BARNMRK", 852, 1),
                    new Tuple<string, int, int>("SUPLADRMRK", 853, 1),
                    new Tuple<string, int, int>("TIDLPNRMRK", 854, 1),
                    new Tuple<string, int, int>("FARSKABMYNNVN", 855, 20),
                    new Tuple<string, int, int>("CIVMYN", 875, 20),
                    new Tuple<string, int, int>("STATSBORGER", 895, 20),
                    new Tuple<string, int, int>("TIDLKOMNVN", 915, 20),
                    new Tuple<string, int, int>("STANDARDADR", 935, 34),
                    new Tuple<string, int, int>("KONTAKTADRMRK", 969, 1),
                    new Tuple<string, int, int>("AJFDTO_STAT", 970, 13),
                    new Tuple<string, int, int>("MYNKOD_STAT", 983, 5),
                    new Tuple<string, int, int>("HAENSTART_STAT", 988, 13),
                    new Tuple<string, int, int>("AJFDTO_CIV", 1001, 13),
                    new Tuple<string, int, int>("CIVST", 1014, 1),
                    new Tuple<string, int, int>("MYNKOD_CIV", 1015, 5),
                    new Tuple<string, int, int>("AEGTEPNR", 1020, 11),
                    new Tuple<string, int, int>("AEGTEFOEDDTO", 1031, 9),
                    new Tuple<string, int, int>("AEGTEDOK", 1040, 3),
                    new Tuple<string, int, int>("HAENSTART_CIV", 1043, 13),
                    new Tuple<string, int, int>("MYNTXTAJFDTO_CIV", 1056, 13),
                    new Tuple<string, int, int>("MYNTXT_CIV", 1069, 20),
                    new Tuple<string, int, int>("AEGTENVN", 1089, 34),
                    new Tuple<string, int, int>("AJFDTO_PERSONBOLIG", 1123, 13),
                    new Tuple<string, int, int>("KOMKOD", 1136, 5),
                    new Tuple<string, int, int>("VEJKOD", 1141, 5),
                    new Tuple<string, int, int>("HUSNR", 1146, 4),
                    new Tuple<string, int, int>("ETAGE", 1150, 2),
                    new Tuple<string, int, int>("SIDEDOER", 1152, 4),
                    new Tuple<string, int, int>("BNR", 1156, 4),
                    new Tuple<string, int, int>("POSTNR", 1160, 5),
                    new Tuple<string, int, int>("KOMNVN", 1165, 20),
                    new Tuple<string, int, int>("VEJADRNVN", 1185, 20),
                    new Tuple<string, int, int>("TILFLYDTO", 1205, 13),
                    new Tuple<string, int, int>("TILFLYDTOMRK", 1218, 1),
                    new Tuple<string, int, int>("FRAFLYKOMKOD", 1219, 5),
                    new Tuple<string, int, int>("FRAFLYKOMDTO", 1224, 13),
                    new Tuple<string, int, int>("TILFLYKOMDTO", 1237, 13),
                    new Tuple<string, int, int>("SUPLADRHAENSTART", 1250, 13),
                    new Tuple<string, int, int>("CONVN", 1263, 34),
                    new Tuple<string, int, int>("BYNVN", 1297, 34),
                    new Tuple<string, int, int>("LOKALITET", 1331, 34),
                    new Tuple<string, int, int>("SUPLADR1", 1365, 34),
                    new Tuple<string, int, int>("SUPLADR2", 1399, 34),
                    new Tuple<string, int, int>("SUPLADR3", 1433, 34),
                    new Tuple<string, int, int>("SUPLADR4", 1467, 34),
                    new Tuple<string, int, int>("SUPLADR5", 1501, 34),
                    new Tuple<string, int, int>("AJFDTO_FORSVIND", 1535, 13),
                    new Tuple<string, int, int>("FORSVINDDTO", 1548, 13),
                    new Tuple<string, int, int>("AJFDTO_UDRINDR", 1561, 13),
                    new Tuple<string, int, int>("UDRMYNKOD", 1574, 5),
                    new Tuple<string, int, int>("UDRDTO", 1579, 13),
                    new Tuple<string, int, int>("UDRAJFDTO", 1592, 13),
                    new Tuple<string, int, int>("UDLANDADRDTO", 1605, 13),
                    new Tuple<string, int, int>("VALGRETDTO", 1618, 13),
                    new Tuple<string, int, int>("UDLANDSADR1", 1631, 34),
                    new Tuple<string, int, int>("UDLANDSADR2", 1665, 34),
                    new Tuple<string, int, int>("UDLANDSADR3", 1699, 34),
                    new Tuple<string, int, int>("UDLANDSADR4", 1733, 34),
                    new Tuple<string, int, int>("UDLANDSADR5", 1767, 34),
                    new Tuple<string, int, int>("AJFDTO_KONTAKTADR", 1801, 13),
                    new Tuple<string, int, int>("KONTAKTADR_KOMKOD", 1814, 5),
                    new Tuple<string, int, int>("KONTAKTADRSTART", 1819, 13),
                    new Tuple<string, int, int>("KONTAKTADR1", 1832, 34),
                    new Tuple<string, int, int>("KONTAKTADR2", 1866, 34),
                    new Tuple<string, int, int>("KONTAKTADR3", 1900, 34),
                    new Tuple<string, int, int>("KONTAKTADR4", 1934, 34),
                    new Tuple<string, int, int>("KONTAKTADR5", 1968, 34),
                    new Tuple<string, int, int>("AJFDTO_RELPNR_1", 2002, 13),
                    new Tuple<string, int, int>("RELPNR_1", 2015, 11),
                    new Tuple<string, int, int>("RELTYP_1", 2026, 4),
                    new Tuple<string, int, int>("STARTDATE_1", 2030, 10),
                    new Tuple<string, int, int>("SLETDATE_1", 2040, 10),
                    new Tuple<string, int, int>("MYNKOD_5_1", 2050, 5),
                    new Tuple<string, int, int>("AJFDTO_RELPNR_5", 2055, 13),
                    new Tuple<string, int, int>("RELPNR_5", 2068, 11),
                    new Tuple<string, int, int>("RELTYP_5", 2079, 4),
                    new Tuple<string, int, int>("STARTDATE_5", 2083, 10),
                    new Tuple<string, int, int>("SLETDATE_5", 2093, 10),
                    new Tuple<string, int, int>("MYNKOD_5_5", 2103, 5),
                    new Tuple<string, int, int>("AJFDTO_RELPNR_6", 2108, 13),
                    new Tuple<string, int, int>("RELPNR_6", 2121, 11),
                    new Tuple<string, int, int>("RELTYP_6", 2132, 4),
                    new Tuple<string, int, int>("STARTDATE_6", 2136, 10),
                    new Tuple<string, int, int>("SLETDATE_6", 2146, 10),
                    new Tuple<string, int, int>("MYNKOD_5_6", 2156, 5),
                    new Tuple<string, int, int>("AJFDTO_RELTXT", 2161, 13),
                    new Tuple<string, int, int>("RELADRSAT", 2174, 34),
                    new Tuple<string, int, int>("RELTYP_TXT", 2208, 4),
                    new Tuple<string, int, int>("RELTXT1", 2212, 34),
                    new Tuple<string, int, int>("RELTXT2", 2246, 34),
                    new Tuple<string, int, int>("RELTXT3", 2280, 34),
                    new Tuple<string, int, int>("RELTXT4", 2314, 34),
                    new Tuple<string, int, int>("RELTXT5", 2348, 34),
                    new Tuple<string, int, int>("STARTDATE_TXT", 2382, 10),
                    new Tuple<string, int, int>("SLETDATE_TXT", 2392, 10),
                    new Tuple<string, int, int>("MYNKOD_5_TXT", 2402, 5),
                    new Tuple<string, int, int>("AJFDTO_SEP", 2407, 13),
                    new Tuple<string, int, int>("SEP_HENVIS_TS", 2420, 26),
                    new Tuple<string, int, int>("START_MYNKOD_SEP", 2446, 5),
                    new Tuple<string, int, int>("STARTDATE_SEP", 2451, 19),
                    new Tuple<string, int, int>("STARTDATE_SEP_UMRK", 2470, 1),
                    new Tuple<string, int, int>("RELTYP_FORALD_35", 2471, 4),
                    new Tuple<string, int, int>("AJFDTO_FORALD_35", 2475, 13),
                    new Tuple<string, int, int>("STARTMYNKOD_FORALD_35", 2488, 5),
                    new Tuple<string, int, int>("STARTDATE_FORALD_35", 2493, 10),
                    new Tuple<string, int, int>("STARTDATE_FORALD_UMRK_35", 2503, 1),
                    new Tuple<string, int, int>("SLETDATE_FORALD_35", 2504, 10),
                    new Tuple<string, int, int>("RELTYP_FORALD_46", 2514, 4),
                    new Tuple<string, int, int>("AJFDTO_FORALD_46", 2518, 13),
                    new Tuple<string, int, int>("STARTMYNKOD_FORALD_46", 2531, 5),
                    new Tuple<string, int, int>("STARTDATE_FORALD_46", 2536, 10),
                    new Tuple<string, int, int>("STARTDATE_FORALD_UMRK_46", 2555, 1),
                    new Tuple<string, int, int>("SLETDATE_FORALD_46", 2556, 10),
                    new Tuple<string, int, int>("ANTAL_BOERN", 2566, 2),
                    new Tuple<string, int, int>("PNR_BORN", 2568, 675)
                });
                return ret.OrderBy(pd => pd.Item2).ToArray();
            }
        }

        #region Sub objects

        private List<NewResponseFullChildType> _NewResponseFullChild = new List<NewResponseFullChildType>();

        [MinMaxOccurs(MinOccurs = 0, MaxOccurs = 25)]
        public List<NewResponseFullChildType> NewResponseFullChild
        {
            get { return _NewResponseFullChild; }
            set { _NewResponseFullChild = value; }
        }


        #endregion
    
    }

  
    public partial class NewResponseFullChildType: Wrapper
    {
        #region Common

        public override int Length
        {
            get { return 27; }
        }
        #endregion

        #region Properties

        ///  <summary>
        /// Danish: AJFDTO
        ///  </summary>
        public DateTime? AJFDTO
        {
            get { return this.GetDateTime(1, 13, "yyyyMMddHHmm"); }
            set { this.SetDateTime(value, 1, 13, "yyyyMMddHHmm"); }
        }

        public Decimal AJFDTODecimal
        {
            get { return this.GetDecimal(1, 13); }
            set { this.SetDecimal(value, 1, 13); }
        }

        public string PNR
        {
            get { return this.GetString(14, 11); }
            set { this.SetString(value, 14, 11); }
        }
        ///  <summary>
        /// Danish: DOK
        ///  </summary>
        public string DOK
        {
            get { return this.GetString(25, 3); }
            set { this.SetString(value, 25, 3); }
        }

        #endregion
        public override Tuple<string, int, int>[] DefaultPropertyDefinitions
        {
            get 
            {
                var ret = base.DefaultPropertyDefinitions.ToList();
                ret.AddRange(new Tuple<string, int, int>[]{
                    new Tuple<string, int, int>("AJFDTO", 1, 13),
                    new Tuple<string, int, int>("PNR", 14, 11),
                    new Tuple<string, int, int>("DOK", 25, 3)
                });
                return ret.OrderBy(pd => pd.Item2).ToArray();
            }
        }

    }

  
    }
  