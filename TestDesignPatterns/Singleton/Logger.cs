using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestDesignPatterns.Singleton
{
    class Logger
    {
        private static Logger _instance = null;

        //protected = not allow "server" to instantiate an object, private => subclass cannot create the object of super class
        //even subclass share the same super class instance
        protected Logger()
        {
        }

        public static Logger Instance()
        {
            if (_instance == null)
            {
                _instance = new Logger();
            }
            return _instance;
        }

        public void Log(string data)
        {
            Console.WriteLine("Logger writes: " + data);
        }
    }
}

