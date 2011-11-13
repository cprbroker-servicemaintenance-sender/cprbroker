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
        public virtual LokalUdvidelseType ToLokalUdvidelseType()
        {
            // No extension
            return null;
        }

        public virtual KontaktKanalType ToNextOfKin()
        {
            // No NextOfKin
            return null;
        }

        public virtual KontaktKanalType ToKontaktKanalType()
        {
            // No contact channels
            return null;
        }

        public virtual AdresseType ToAndreAdresse()
        {
            return null;
        }

        public virtual SundhedOplysningType ToSundhedOplysningType()
        {
            return null;
        }
    }
}