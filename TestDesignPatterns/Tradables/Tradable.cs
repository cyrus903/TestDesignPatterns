using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestDesignPatterns
{
    class Tradable
    {
        public string symbol { get; set; }

        public double price { get; set; }

        public Tradable(string symbol)
        {
            this.symbol = symbol;
        }

        protected void MethodA()
        {
            //do something A
        }

        public virtual Tradable Clone()
        {
            Tradable t = new Tradable(this.symbol);
            return t;
        }

        public virtual double Price()
        {
            return price;
        }
    }
}
