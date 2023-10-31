using Creational.AbstractFactory.AbstractProduct;
using Creational.AbstractFactory.ConcreteProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.AbstractFactory.ConcreteFactory
{
    public class MageFactory : CharacterFactory
    {
        public override Armor CreateArmor()
        {
            return new Robe();
        }

        public override Character CreateCharacter()
        {
            return new MageCharacter();
        }

        public override Weapon CreateWeapon()
        {
            return new Staff();
        }
    }
}
