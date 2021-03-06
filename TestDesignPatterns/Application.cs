﻿using System;
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

            //Creational Patterns

            //////////////////////////////////////////////

            //Factory Methods: Market is defined (number of securities / derivatives) at compilation. (Market1 / Market2 / Market3 can be switch but compisitions of them could not be changed)

            //IMarket mktA = CreateMarket(); //Factory Method

            //IMarket mktB = Market.ParameterisedCreate(1); //Parameterised Factory Method by static method

            //using creator ? = delegation
            //Creator c1 = new ParameterisedCreator(); //Parameterised Factory Method using Creator
            //IMarket mktC = c1.Create(1); 

            //Creator c2 = new GenericCreator<Market1>(); //Factory Method using Generic Creator
            //IMarket mktD = c2.Create(); //Factory Method   

            //////////////////////////////////////////////

            //How to create a different market (different compositions) at run-time?
            //Abstract Factory: To create a family of objects - without specifying the concrete classes
            //Provide an interface for creating families of related or dependent objects without specifying their concrete classes
            //focuses on building a families of parts (either simple or complex), and returns the part IMMEDIATELY. 
            //Client assembles the parts into complex object

            //AbstractMarketFactory f1 = new SecurityMarketFactory();
            //IMarket mktE = f1.CreateMarket(); //parts
            //Tradable t1 = f1.CreateTradable("t1"); //parts
            //mktE.AddTradable(t1);
            //Exchange ex = f1.CreateExchange();
            //mktE.AddExchange(ex);
            //mktE.Display();           

            //AbstractMarketFactory f2 = new CFDMarketFactory();
            //IMarket mktF = f2.CreateMarket(); //parts
            //Tradable t2 = f2.CreateTradable("t2"); //parts
            //mktF.AddTradable(t2);
            //Exchange ex2 = f2.CreateExchange();
            //mktF.AddExchange(ex2);
            //mktF.Display();

            //////////////////////////////////////////////

            //Builder
            //the same construction process can create different representations
            //Separate the construction of a complex object from its representation so that the same construction process can create different representations
            //BUILDER RETURNS THE PRODUCT AS A FINAL STEP
            //Change Builder, change representation

            //MarketBuilder mktBuilder = new SecurityMarketBuilder();            
            //mktBuilder.BuildTradable("0005HK"); //same construction process
            //IMarket mktG = mktBuilder.GetMarket();
            //mktG.Display();

            //MarketBuilder mktBuilder = new CFDMarketBuilder();
            //mktBuilder.BuildTradable("0005HK");  //same construction process
            //IMarket mktG = mktBuilder.GetMarket();
            //mktG.Display();

            //////////////////////////////////////////////

            //Prototype
            //Abstract Factory and Builder are used for a pre-set combination of parts
            //for multi options x multi options combination => class explosion
            //
            //each market has 1 tradable and 1 exchange
            //tradable: Security or CFD
            //exchange: Security Exchange or CFD exchange

            //MarketPrototypeFactory f3 = new MarketPrototypeFactory(new Exchanges.SecurityExchange("PrototypeExchange"), new Security("PrototypeTradable"));
            //IMarket mktH = f3.CreateMarket();
            //Exchange ex3 = f3.CreateExchange("Security Exchange ABC");
            //mktH.AddExchange(ex3);
            //Tradable t = f3.CreateTradable("Security AAPL");
            //mktH.AddTradable(t);
            //mktH.Display();

            //MarketPrototypeFactory f4 = new MarketPrototypeFactory(new Exchanges.CFDExchange("PrototypeExchange"), new CFD("PrototypeTradable"));
            //IMarket mktI = f4.CreateMarket();
            //Exchange ex4 = f4.CreateExchange("CFD Exchange ABC");
            //mktI.AddExchange(ex4);
            //Tradable t = f4.CreateTradable("CFD AAPL");
            //mktI.AddTradable(t);
            //mktI.Display();

            //MarketPrototypeFactory f5 = new MarketPrototypeFactory(new Exchanges.FuturesExchange("PrototypeExchange"), new Futures("PrototypeTradable", "", 0, 0));
            //IMarket mktJ = f5.CreateMarket();
            //Exchange ex5 = f5.CreateExchange("Futures Exchange ABC");
            //mktJ.AddExchange(ex5);
            //Tradable t5 = f5.CreateTradable("Futures AAPL");
            //mktJ.AddTradable(t5);
            //mktJ.Display();

            //////////////////////////////////////////////

            //Singleton
            //Singleton.Logger logger = Singleton.Logger.Instance();
            //logger.Log(logger.GetHashCode().ToString());

            //Singleton.Logger logger2 = Singleton.Logger.Instance();
            //logger2.Log(logger2.GetHashCode().ToString());

            //Console.WriteLine(logger.Equals(logger2));

            //Singleton.Logger logger3 = Singleton.DerivedLogger.Instance();
            //logger.Log(logger3.GetHashCode().ToString());

            //Singleton.Logger logger4 = Singleton.DerivedLogger.Instance();
            //logger2.Log(logger4.GetHashCode().ToString());

            //Console.WriteLine(logger3.Equals(logger4));

            /////////////////////////////////////////////////////////////////////////////////////////

            //Structual Patterns

            //Adapter
            //also known as Wrapper
            //client uses new system and reuse old system codes
            //Convert the interface of a class into another interface clients expect. 
            //Adapter lets classes work together that couldn’t otherwise because of incompatible interfaces
            //by class adapter or object adapter            

            //class adapter
            //INewMarket mkt = new ClassAdapter_NewMarket();
            //mkt.AddTradable(new Security("class adapter"));
            //mkt.Display();

            //Market test = mkt as Market;
            //if (test != null)
            //{
            //    test.OldMethod(); //interfaces of old system are exposed to new system => problematic
            //}           

            //object adapter
            //INewMarket mkt2 = new ObjectAdapter_NewMarket();
            ////interfaces of old system do not expose
            //mkt2.AddTradable(new Security("object adapter"));            
            //mkt2.Display();

            //////////////////////////////////////////////

            //Builder
            //segregate implememtation by delegation to implementation class

            //FlexibleMarket mkt = new FlexibleMarket(new SecurityMarketImplementation());
            //mkt.Create();
            //mkt.AddTradable(new Security("test2"));
            //mkt.AddExchange(new Exchanges.SecurityExchange("1"));
            //mkt.Display();


            //////////////////////////////////////////////

            //Composite Pattern
            //Compose objects into tree structures to represent part-whole hierarchies. 
            //Composite let clients treat individual objects and compositions of objects uniformly
            //Strategy is a tradable and Strategy has tradable(s)

            //Strategy s = new Strategy("Calendar Spread");
            //Futures f1 = new Futures("ABCF7", "ABC", 2017, 1);
            //f1.price = 1;
            //Futures f2 = new Futures("ABCG7", "ABC", 2017, 2);
            //f2.price = 2;
            //s.AddTradable(f1);
            //s.AddTradable(f2);
            //Console.WriteLine("strategy price s = " + s.Price());

            ////recurrsive
            //Strategy s2 = new Strategy("new strategy");
            //s2.AddTradable(s);
            //Futures f3 = new Futures("ABCH7", "ABC", 2017, 3);
            //f3.price = 4;
            //s2.AddTradable(f3);
            //Console.WriteLine("strategy price s2 = " + s2.Price());

            

            //////////////////////////////////////////////

            //Decorator
            //Also known as Wrapper (vs Adaptor)
            //Class inheritence approach vs object delegation approach
            //Class inheritence approach: combinational problem, class explosion
            //Object delegation approach is better
            //Attach additional responsibilities to an object dynamically. 
            //Decorators provide a flexible alternative to subclassing for extending functionality

            //Stream is a decorator
            //FileStream, CryptoStream has-a Stream and is-a Stream.
            //Composite Pattern?
            //infinite recursive to work on _Next Stream
            //flexibible number of layers / number of stream operatons

            //Decorator d = new Decorator();
            //d.Write();
            //string output = d.Read();
            //Console.WriteLine(output);




            //////////////////////////////////////////////

            //Visitor Pattern

            Exchange exch = new SecurityExchange("HKEX");
            Visitor v1 = new Visitor_Trade();
            exch.Accept(v1);
            Visitor v2 = new Visitor_Settle();
            exch.Accept(v2);

            //Exchange exch2 = new CFDExchange("CFD EX");
            //exch2.Accept(v1);
            //exch2.Accept(v2);

            //////////////////////////////////////////////

            //////////////////////////////////////////////


            /////////////////////////////////////////////////////////////////////////////////////////


            //Behaviour Patterns



        }

        private IMarket CreateMarket() //Factory Method
        {
            return new Market1(); //Change this line to switch to different markets
        }
    }
}
