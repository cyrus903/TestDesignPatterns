using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestDesignPatterns
{
    class Security: Tradable
    {
        public Security(string symbol)
            : base(symbol)
        {    
        }

        public override Tradable Clone()
        {
            Tradable t = new Security(this.symbol);
            return t;
        }
    }
}
