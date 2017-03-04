using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestDesignPatterns
{
    interface IMarket
    {   
        void Create();
        void Display();
        void Add(Tradable t);
    }
}
