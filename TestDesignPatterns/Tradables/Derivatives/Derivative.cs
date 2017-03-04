using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestDesignPatterns
{
    class Derivative : Tradable
    {
        public string underlying { get; set; }
        public int year { get; set; }
        public int month { get; set; }

        public Derivative(string symbol, string underlying, int year, int month) : base(symbol)
        {
            this.underlying = underlying;
            this.year = year;
            this.month = month;
        }

        public virtual double TheoraticalPrice()
        {
            return 0;
        }
    }
}
