using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestDesignPatterns
{
    class Visitor
    {
        public virtual void Visit(Exchange ex)
        {
            
        }

        //Option B, through Visitor pattern
        public virtual void Visit(SecurityExchange ex)
        {

        }

        //public virtual void Visit(CFDExchange ex)
        //{

        //}
    }
}
