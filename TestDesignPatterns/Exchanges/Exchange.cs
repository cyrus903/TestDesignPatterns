using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestDesignPatterns
{
    class Exchange
    {
        public string name { get; set; }

        public Exchange(string name)
        {
            this.name = name;
        }

        public virtual void Trade()
        {
        }

        public Exchange Clone()
        {
            Exchange ex = new Exchange(this.name);
            return ex;
        }
    }

    
    
}
