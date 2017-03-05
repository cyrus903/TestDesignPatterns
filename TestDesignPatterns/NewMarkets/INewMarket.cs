using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestDesignPatterns
{
    interface INewMarket
    {
        void Create();
        void Display();
        void AddTradable(Tradable t);
        void AddExchange(Exchange ex);
    }
}
