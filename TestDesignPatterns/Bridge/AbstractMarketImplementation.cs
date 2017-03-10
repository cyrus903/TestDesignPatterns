using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestDesignPatterns
{
    class AbstractMarketImplementation : IMarketImplementation
    {      
       
        public virtual void Display(IMarket m)
        {            
        }
        public virtual void AddTradable(IMarket m, Tradable t)
        {            
        }
        public virtual void AddExchange(IMarket m, Exchange ex)
        {
            m.AddExchange(ex);
        }
    }

    class SecurityMarketImplementation : AbstractMarketImplementation
    {              
        public override void Display(IMarket m)
        {
            m.Display();
        }
        public override void AddTradable(IMarket m, Tradable t)
        {
            m.AddTradable(t);
        }
        public void AddExchange(IMarket m, SecurityExchange ex)
        {           
            m.AddExchange(ex);           
        }
    }

    class CFDMarketImplementation : AbstractMarketImplementation
    {        
        public override void Display(IMarket m)
        {
            m.Display();
        }
        public override void AddTradable(IMarket m, Tradable t)
        {
            m.AddTradable(t);
        }
        public void AddExchange(IMarket m, CFDExchange ex)
        {
            m.AddExchange(ex);
        }
    }
    

    
}
