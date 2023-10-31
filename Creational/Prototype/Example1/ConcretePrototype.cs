using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Prototype.Example1
{
    // Concreteclass implements IPrototype
    public class ConcretePrototype : IPrototype
    {
        public int Property1 { get; set; }
        public string Property2 { get; set; }
        public IPrototype Clone()
        {
            // Clone the actually object
            return new ConcretePrototype
            {
                Property1 = this.Property1,
                Property2 = this.Property2
            };
        }
        public void Display()
        {
            Console.WriteLine($"Property1: {Property1}, Property2: {Property2}");
        }
    }
}
