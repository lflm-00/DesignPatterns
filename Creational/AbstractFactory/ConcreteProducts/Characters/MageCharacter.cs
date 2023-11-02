using Creational.AbstractFactory.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.AbstractFactory.ConcreteProducts.Characters
{
    public class MageCharacter : Character
    {
        public override string getDescription()
        {
            return "Mage Character";
        }
    }
}
