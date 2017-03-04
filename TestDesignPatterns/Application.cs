using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestDesignPatterns
{
    class Application
    {
        public void Run()
        {            
            //Market1 mkt = new Market2(); //ok
            //Market1 mkt = new Market2(); //ok
            //Market3 mkt = new Market2(); //not ok
            //IMarket mkt = new Market2(); //ok

            //IMarket mkt = CreateMarket(); //Factory Method

            //IMarket mkt = Market.ParameterisedCreate(2); //Parameterised Factory Method by static method

            //using creator ? = delegation
            //Creator c1 = new ParameterisedCreator(); //Parameterised Factory Method using Creator
            //IMarket mktA = c1.Create(2); 

            //Creator c2 = new GenericCreator<Market2>(); //Factory Method using Generic Creator
            //IMarket mktB = c2.Create(); //Factory Method

            
        
            

        }

        private IMarket CreateMarket() //Factory Method
        {
            return new Market2(); //Change this line to switch to different markets
        }
    }
}
