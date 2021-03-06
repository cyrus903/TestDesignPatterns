﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestDesignPatterns
{
    class CFD : Tradable
    {

        public CFD(string symbol)
            : base(symbol)
        {    
        }

        public override Tradable Clone()
        {
            Tradable t = new CFD(this.symbol);
            return t;
        }
    }
}
