using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestDesignPatterns
{
    class SecurityExchange : Exchange
    {
        public SecurityExchange(string name)
            : base(name)
        {
        }

        public override void Accept(Visitor v)
        {
            v.Visit(this);
        }
    }
}
