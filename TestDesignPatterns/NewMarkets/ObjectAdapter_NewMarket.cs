using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestDesignPatterns
{
    class ObjectAdapter_NewMarket : INewMarket //allow implementation inheritance to NewMarket
    {
        Market adaptee = new Market();

        public  void Create()
        {
            adaptee.Create();
        }
        public  void Display()
        {
            adaptee.Display();
        }
        public  void AddTradable(Tradable t)
        {
            adaptee.AddTradable(t);
        }
        public  void AddExchange(Exchange ex) 
        {
            adaptee.AddExchange(ex);
        }
    }
}
