using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Singleton.Example1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Thread thread = new Thread(() =>
                {
                    Singleton singleton = Singleton.GetInstance();
                    singleton.SomeMethod();
                });
                thread.Start();
            }
        }
    }
}
