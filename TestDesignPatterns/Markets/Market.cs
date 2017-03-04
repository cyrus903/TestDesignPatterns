using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Collections;


namespace TestDesignPatterns
{
    class Market: IMarket
    {
        ArrayList array = new ArrayList();        

        public Market()
        {
            Create();
            Display();
        }

        public virtual void Create()
        {
        }

        public virtual void Display()
        {
            int count = 0;
            foreach (object o in array)
            {
                count++;
                Console.WriteLine("item: " + count);

                Console.WriteLine("Is Tradable?");
                Tradable test = o as Tradable;
                if (test != null)
                {
                    Console.WriteLine("YES symbol = " + test.symbol);
                }

                Console.WriteLine("Is Security?");
                Security test1 = o as Security;
                if (test1 != null)
                {
                    Console.WriteLine("YES symbol = " + test1.symbol);
                }                

                Console.WriteLine("Is Futures?");
                Futures test2 = o as Futures;
                if (test2 != null)
                {
                    Console.WriteLine("YES Futures underlying=" + test2.underlying);
                    Console.WriteLine("Theroratical Price=" + test2.TheoraticalPrice());
                }              

                Console.WriteLine("Is Option?");
                Option test3 = o as Option;
                if (test3 != null)
                {
                    Console.WriteLine("YES Option underlying=" + test3.underlying);
                    Console.WriteLine("Theroratical Price=" + test3.TheoraticalPrice());
                }

                Console.WriteLine("Is CFD?");
                CFD test4 = o as CFD;
                if (test4 != null)
                {
                    Console.WriteLine("YES symbol = " + test4.symbol);
                }


                Console.WriteLine();
            }
        }
        public virtual void Add(Tradable t)
        {
            array.Add(t);
        }

        //Parameterised Factory Method
        public static IMarket ParameterisedCreate(int i)
        {
            if (i == 0)
            {
                return new Market();
            }

            if (i == 1)
            {
                return new Market1();
            }

            if (i == 2)
            {
                return new Market2();
            }

            return new Market();
        }

 
    }
}
