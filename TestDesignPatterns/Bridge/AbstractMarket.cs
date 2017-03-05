using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestDesignPatterns
{
    class AbstractMarket : IMarket
    {
        IMarket _mkt;
        IMarketImplementation _imp;

        public AbstractMarket(IMarketImplementation imp)
        {            
            SetImplementation(imp);
            Create();
        }


        private void SetMarket(IMarket mkt)
        {
            this._mkt = mkt;
        }

        private void SetImplementation(IMarketImplementation imp)
        {
            this._imp = imp;
        }

        public virtual void Create()
        {
            this._mkt = new Market();
        }

        public virtual void Display()
        {
            _imp.Display(_mkt);
        }
        public virtual void AddTradable(Tradable t)
        {
            _imp.AddTradable(_mkt, t);
        }
        public virtual void AddExchange(Exchange ex)
        {
            _imp.AddExchange(_mkt, ex);
        }
    }

    class FlexibleMarket : AbstractMarket
    {
        public FlexibleMarket(IMarketImplementation imp) 
            :base(imp)
        {                  
        }        
    }

    
}
