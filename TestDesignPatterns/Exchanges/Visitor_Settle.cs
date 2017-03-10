using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestDesignPatterns
{
    class Visitor_Settle : Visitor
    {
        public override void Visit(Exchange ex)
        {
            //Only security exchange can settle

            //option A, through checking of ex's Type
            var o = ex as SecurityExchange;
            if (o != null)
            {
                Console.WriteLine("Security Exchange " + ex.name + " is visited");
            }

            Console.WriteLine("Settle function is called");
        }

        //Option B, through Visitor pattern
        public override void Visit(SecurityExchange ex)
        {
            Console.WriteLine("Security Exchange " + ex.name + " is visited");
            //Visit((Exchange)ex);
        }
    }
}
