using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace TestDesignPatterns
{
    class Market1 : Market
    {       

        //public Market1()
        //{       
            
        //}

        public override void Create()
        {              
            Tradable t = new Security("0001");            
            Add(t);

            Tradable t2 = new Futures("CHKH7", "0001", 2017, 1);         
            Add(t2);

            Tradable t3 = new Option("CHKH7_100C", "0001", 2017, 1, 100, 'C');     
            Add(t3);            
        }

        //public  void Add(Tradable t)
        //{
           
        //}

        public override void Display()
        {
            Console.WriteLine("This is Market1");
            base.Display();
        }
    }
}
