using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestDesignPatterns
{
    class MarketBuilder
    {
        IMarket mkt = new Market();

        protected void Add(Tradable t)
        {
            mkt.Add(t);
        }

        public virtual IMarket GetMarket()
        {
            return mkt;
        }

        public virtual void BuildTradable(string symbol)
        { 
        }      
    }

    class SecurityMarketBuilder : MarketBuilder
    {
        public override void BuildTradable(string symbol)
        {
            Tradable t = new Security(symbol);
            Add(t);
        }
    }

    class CFDMarketBuilder : MarketBuilder
    {
        public override void BuildTradable(string symbol)
        {
            Tradable t = new CFD(symbol);
            Add(t);
        }
    }
}
