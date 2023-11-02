using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Singleton.Example1
{
    internal class Singleton
    {
        private static Singleton _instance;
        private static readonly object lockObject = new object();

        private Singleton() { }

        public static Singleton GetInstance()
        {
            if(_instance == null)
            {
                lock (lockObject)
                {
                    if(_instance == null)
                    {
                        _instance = new Singleton();
                    }
                }
            }
            return _instance;
        }

        public void SomeMethod()
        {
            Console.WriteLine("Singleton method called.");
        }
    }
} 
