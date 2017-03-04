using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestDesignPatterns
{
    //Abstract Factory
    class MarketFactory
    {
        public virtual IMarket CreateMarket()
        {
            return null;
        }  

        public virtual Tradable CreateTradable(string symbol)
        {
            return null;
        }

        public virtual Exchange CreateExchange(string name)
        {
            return null;
        }

        public virtual void AddTradable(IMarket mkt, Tradable t)
        {
            mkt.AddTradable(t);
        }
    }

    class SecurityMarketFactory : MarketFactory
    {
        public override IMarket CreateMarket()
        {
            IMarket mkt = new Market(); 
            return mkt;
        }

        public override Tradable CreateTradable(string symbol)
        {
            return new Security(symbol);
        }

        public override Exchange CreateExchange(string name)
        {
            return new Exchanges.SecurityExchange(name);
        }
    }


    class CFDMarketFactory : MarketFactory
    {
        public override IMarket CreateMarket()
        {
            IMarket mkt = new Market();
            return mkt;
        }

        public override Tradable CreateTradable(string symbol)
        {
            return new CFD(symbol);
        }

        public override Exchange CreateExchange(string name)
        {
            return new Exchanges.CFDExchange(name);
        }

    }

    //Prototype
    class MarketPrototypeFactory : MarketFactory
    {
        Exchange _ex;
        Tradable _t;

        public MarketPrototypeFactory(Exchange ex, Tradable t)
        {
            _ex = ex;
            _t = t;
        }

        public override IMarket CreateMarket()
        {
            IMarket mkt = new Market();
            return mkt;
        }

        public override Tradable CreateTradable(string symbol)
        {           
            Tradable t = null;           
            t = _t.Clone();
            ////Copy other attributes
            t.symbol = symbol;            
            return t;
        }

        public override Exchange CreateExchange(string name)
        {
            Exchange ex = _ex.Clone();
            ex.name = name;
            return ex;
        }

       
    }

}
