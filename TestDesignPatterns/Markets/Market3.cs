using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestDesignPatterns
{
    class Market3 : IMarket //Empty Market
    {
        public  void Create()
        {
            Tradable t = new Security("0003");
            Add(t);
        }
        public  void Display()
        {
        }
        public  void Add(Tradable t)
        {
        }
    }
}
