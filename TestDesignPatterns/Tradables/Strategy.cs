using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Collections;

namespace TestDesignPatterns
{
    class Strategy : Tradable
    {
        ArrayList array = new ArrayList(); 

        public Strategy(string symbol)
            : base(symbol)
        {

        }

        public void AddTradable(Tradable t)
        {            
            array.Add(t);
        }

        public override double Price()
        {
            double p = 0;
            foreach (object o in array)
            {
                Tradable t = o as Tradable;
                p += t.Price();
            }
            return p;
        }

    }
}
