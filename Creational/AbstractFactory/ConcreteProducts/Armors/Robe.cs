using Creational.AbstractFactory.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.AbstractFactory.ConcreteProducts.Armors
{
    public class Robe : Armor
    {
        public override string getDescription()
        {
            return "Robe";
        }
    }
}
