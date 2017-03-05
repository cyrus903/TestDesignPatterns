using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestDesignPatterns
{
    class ClassAdapter_NewMarket : Market, INewMarket //implementation inheritance to Market only, cannot multiple implementation inheritance to NewMarket
    {
        public override void Create()
        {
            base.Create();
        }
        public override void Display()
        {
            base.Display();
        }
        public override void AddTradable(Tradable t)
        {
            base.AddTradable(t);
        }
        public new void AddExchange(Exchange ex) //old system AddExchange is not virtual
        {
            base.AddExchange(ex); //using implementation of old system 
        }
    }
}
