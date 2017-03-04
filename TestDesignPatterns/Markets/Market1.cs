using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Collections;

namespace TestDesignPatterns
{
    class Market1 : IMarket
    {
        ArrayList array = new ArrayList();

        public Market1()
        {
            Create();
            Display();
            
        }

        public virtual  void Create()
        {              
            Tradable t = new Security("0001");            
            Add(t);

            Tradable t2 = new Futures("CHKH7", "0001", 2017, 1);         
            Add(t2);

            Tradable t3 = new Option("CHKH7_100C", "0001", 2017, 1, 100, 'C');
     
            Add(t3);
        }

        public  void Add(Tradable t)
        {
             array.Add(t);
        }

        public virtual void Display()
        {
            foreach (object o in array)
            {
                Tradable test = o as Tradable;
                if (test != null)
                {
                    Console.WriteLine(test.symbol);
                }

                Futures test2 = o as Futures;
                if (test2 != null)
                {
                    Console.WriteLine("Futures underlying=" + test2.underlying);
                    Console.WriteLine("Theroratical Price=" + test2.TheoraticalPrice());
                }

                Option test3 = o as Option;
                if (test3 != null)
                {
                    Console.WriteLine("Option underlying=" + test3.underlying);
                    Console.WriteLine("Theroratical Price=" + test3.TheoraticalPrice());
                }
            }
        }
    }
}
