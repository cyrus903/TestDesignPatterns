using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestDesignPatterns
{
    class Creator
    {
        public virtual IMarket Create()
        {
            return null;
        }

        public virtual IMarket Create(int i)
        {
            return null;
        }
    }  

    class ParameterisedCreator : Creator
    {
        public override IMarket Create(int i)
        {
            if (i == 1)
            {
                return new Market1();
            }
            else if (i == 2)
            {
                return new Market2();
            }
            else if (i == 3)
            {
                return new Market3();
            }
            else
            {
                return base.Create(i);
            }
        }
    }

    class GenericCreator<T> : Creator where T: IMarket, new() 
    {
        public override IMarket Create()
        {
            return new T();
        }
    }

   
}
