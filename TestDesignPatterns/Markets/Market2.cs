using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestDesignPatterns
{
    class Market2 : Market1
    {
        public override void Create()
        {
            Tradable t = new Security("0002");
            Add(t);

            Tradable t2 = new Futures("CLPF7", "0002", 2017, 1);
            Add(t2);

            Tradable t3 = new Option("CLPF7_100C", "0002", 2017, 1, 100, 'C');
            Add(t3);            
        }

        public override void Display()
        {
            Console.WriteLine("This is Market2");
            base.Display();
        }

    }
}
