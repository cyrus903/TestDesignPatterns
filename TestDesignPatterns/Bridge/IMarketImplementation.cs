using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestDesignPatterns
{
    interface IMarketImplementation
    {      
        void Display(IMarket m);
        void AddTradable(IMarket m, Tradable t);
        void AddExchange(IMarket m,Exchange ex);
    }
}
