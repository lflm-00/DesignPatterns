using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Prototype.Example2
{
    internal class Program
    {
       static void Main(string[] args)
        {
            // Create prototype object
            ICloneable originalPerson = new Person { Name = "Luis", Age = 23 };

            // Clone the prototype object
            ICloneable clonedPerson = originalPerson.Clone();

            //modifi the clone without affecting the original
            ((Person)clonedPerson).Name = "Bob";
            ((Person)clonedPerson).Age = 25;

            // Show details
            Console.WriteLine("Original Personl");
            originalPerson.Display();

            Console.WriteLine("Cloned Person");
            clonedPerson.Display();
        }
    }
}
