using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Prototype.Example1
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Crear un objeto prototipo
            IPrototype prototype = new ConcretePrototype
            {
                Property1 = 42,
                Property2 = "Prototype"
            };

            // Clonar el objeto prototipo
            IPrototype clone = prototype.Clone();

            // Modificar la propiedad del clon sin afectar al original
            ((ConcretePrototype)clone).Property1 = 99;
            ((ConcretePrototype)clone).Property2 = "Cloned";

            // Mostrar los detalles del prototipo y el clon
            //Console.WriteLine("Prototype Details:");
            //prototype.Display();

            //Console.WriteLine("\nCloned Details:");
            //clone.Display();
        }
    }
}
