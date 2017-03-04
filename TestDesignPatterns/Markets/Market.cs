using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestDesignPatterns
{
    class Market: IMarket
    {
        public Market()
        {
            Display();
        }

        public virtual void Create()
        {
        }
        public virtual void Display()
        {          
        }
        public virtual void Add(Tradable t)
        {
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
