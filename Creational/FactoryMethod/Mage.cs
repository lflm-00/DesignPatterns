using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Factory
{
    internal class Mage : ICharacter
    {
        public void Display()
        {
            Console.WriteLine("I'm Mage.");
        }
    }
}
