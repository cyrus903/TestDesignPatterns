using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestDesignPatterns
{
    class AbstractMarketFactory
    {
        public virtual IMarket CreateMarket()
        {
            return null;
        }
    }

    class SecurityMarketFactory : AbstractMarketFactory
    {
        public override IMarket CreateMarket()
        {
            IMarket mkt = new Market();

            Tradable t = new Security("1");
            mkt.Add(t);

            t = new Security("2");
            mkt.Add(t);

            t = new Security("3");
            mkt.Add(t);

            return mkt;
        }
    }


    class FuturesMarketFactory : AbstractMarketFactory
    {
        public override IMarket CreateMarket()
        {
            IMarket mkt = new Market();

            Tradable t = new Futures("HSIX1", "HSI", 2017, 1);
            mkt.Add(t);

            t = new Futures("HSIX2", "HSI", 2017, 2);
            mkt.Add(t);

            t = new Futures("HSIX3", "HSI", 2017, 3);
            mkt.Add(t);

            return mkt;
        }
    }

}
