
using System;

namespace CprBroker.Providers.CPRDirect
{
      
    class IndividualRequest: Wrapper
    {
        public override int Length
        {
            get { return 39; }
        }

        
        ///  <summary>
        /// CPR's transaction code
        ///  </summary>
        public string CPRTRANS
        {
            get { return this[1,4]; }
        }
            
        ///  <summary>
        /// Danish: KOMMA
        /// Comma character used as separator
        ///  </summary>
        public string Comma
        {
            get { return this[5,1]; }
        }
            
        ///  <summary>
        /// Danish: KUNDENR
        /// Identification of the customer
        ///  </summary>
        public decimal CustomerNumber
        {
            get { return decimal.Parse(this[6,4]); }
        }
            
        ///  <summary>
        /// Danish: ABON_TYPE
        /// Subscription phrase / delete or not
        ///  </summary>
        public decimal SubscriptionType
        {
            get { return decimal.Parse(this[10,1]); }
        }
            
        ///  <summary>
        /// Danish: DATA_TYPE
        /// Desired output - 0 in LOGONINDIVID
        ///  </summary>
        public decimal DataType
        {
            get { return decimal.Parse(this[11,1]); }
        }
            
        ///  <summary>
        /// Danish: TOKEN
        ///  </summary>
        public string Token
        {
            get { return this[12,8]; }
        }
            
        ///  <summary>
        /// Danish: BRUGER_ID
        /// The CPR Unit assigned system user code
        ///  </summary>
        public string UserId
        {
            get { return this[20,8]; }
        }
            
        ///  <summary>
        /// Danish: FEJLNR
        /// Indicator of the communication process
        ///  </summary>
        public decimal ErrorNumber
        {
            get { return decimal.Parse(this[28,2]); }
        }
            
        ///  <summary>
        /// Danish: PNR
        /// Request PNR
        ///  </summary>
        public decimal PNR
        {
            get { return decimal.Parse(this[30,10]); }
        }
            
    }
}
          
        