using Creational.AbstractFactory.AbstractProduct;
using Creational.AbstractFactory.ConcreteProducts;
using Creational.AbstractFactory.ConcreteProducts.Armors;
using Creational.AbstractFactory.ConcreteProducts.Characters;
using Creational.AbstractFactory.ConcreteProducts.Weapons;
using Creational.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.AbstractFactory.ConcreteFactory
{
    public class WarriorFactory : CharacterFactory
    {
        public override Armor CreateArmor()
        {
            return new PlateArmor();
        }

        public override Character CreateCharacter()
        {
            return new WarriorCharacter();
        }

        public override Weapon CreateWeapon()
        {
            return new Sword();
        }
    }
}
