using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Prototype.Example2
{
    public class Person : ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public ICloneable Clone()
        {
            return new Person { Name = this.Name, Age = this.Age };
        }
        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}
