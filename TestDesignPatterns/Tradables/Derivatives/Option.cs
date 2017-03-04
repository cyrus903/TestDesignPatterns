using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestDesignPatterns
{
    class Option : Derivative
    {    
        double strike_price { get; set; }
        char type { get; set; }

        public Option(string symbol, string underlying, int year, int month, double strike_price, char type)
            : base(symbol, underlying, year, month)
        {
            this.strike_price = strike_price;
            this.type = type;
        }

        public override double TheoraticalPrice()
        {
            return 2;
        }
    }
}
