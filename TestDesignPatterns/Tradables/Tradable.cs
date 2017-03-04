using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestDesignPatterns
{
    class Tradable
    {
        public string symbol { get; set; }

        public Tradable(string symbol)
        {
            this.symbol = symbol;
        }

        public void MethodA()
        {
            //do something A
        }
    }
}
