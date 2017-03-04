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


            //Factory Methods: Market is defined (number of securities / derivatives) at compilation. (Market1 / Market2 / Market3 can be switch but compisitions of them could not be changed)

            //IMarket mktA = CreateMarket(); //Factory Method

            //IMarket mktB = Market.ParameterisedCreate(1); //Parameterised Factory Method by static method

            //using creator ? = delegation
            //Creator c1 = new ParameterisedCreator(); //Parameterised Factory Method using Creator
            //IMarket mktC = c1.Create(1); 

            //Creator c2 = new GenericCreator<Market1>(); //Factory Method using Generic Creator
            //IMarket mktD = c2.Create(); //Factory Method            

            //How to create a different market (different compositions) at run-time?
            //Abstract Factory: To create a family of objects - without specifying the concrete classes
            //Provide an interface for creating families of related or dependent objects without specifying their concrete classes
            //focuses on building a families of parts (either simple or complex), and returns the part immediately. Client assembles the parts into complex object


            //AbstractMarketFactory f = new SecurityMarketFactory();
            //IMarket mktE = f.CreateMarket();
            //mktE.Display();

            //AbstractMarketFactory f = new FuturesMarketFactory();
            //IMarket mktF = f.CreateMarket();
            //mktF.Display();

            //Builder
            //the same construction process can create different representations
            //Separate the construction of a complex object from its representation so that the same construction process can create different representations
            //Builder returns the product as a final step
            //Change Builder, change representation


            //MarketBuilder mktBuilder = new SecurityMarketBuilder();            
            //mktBuilder.BuildTradable("0005HK"); //same construction process
            //IMarket mktG = mktBuilder.GetMarket();
            //mktG.Display();

            MarketBuilder mktBuilder = new CFDMarketBuilder();
            mktBuilder.BuildTradable("0005HK");  //same construction process
            IMarket mktG = mktBuilder.GetMarket();
            mktG.Display();


        }

        private IMarket CreateMarket() //Factory Method
        {
            return new Market1(); //Change this line to switch to different markets
        }
    }
}
