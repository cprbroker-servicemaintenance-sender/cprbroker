﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPRBroker.Schemas.Part
{
    public class UnknownCitizenData : PersonData
    {
        public string ReplacementCprNumber { get; set; }
    }
}
