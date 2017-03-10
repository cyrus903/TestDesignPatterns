using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestDesignPatterns
{
    class Visitor_Trade : Visitor
    {
        public override void Visit(Exchange ex)
        {
            Console.WriteLine("Trade function is called");
        }
    }
}
