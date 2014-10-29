﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CprBroker.Tests.CprServices
{
    public class SearchMethodTestsBase
    {
        public string[] AvailableInputs
        {
            get
            {
                return new string[]{
                        CprBroker.Providers.CprServices.Properties.Resources.ADRSOG1,
                        CprBroker.Providers.CprServices.Properties.Resources.ADRESSE3,
                        CprBroker.Providers.CprServices.Properties.Resources.NVNSOG2
                    };
            }
        }

    }

}
