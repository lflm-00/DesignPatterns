using Creational.AbstractFactory.AbstractProduct;
using Creational.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.AbstractFactory
{
    /* La clase CharacterFactory actua como un abstract Factory
    */
    public abstract class CharacterFactory
    {
        public abstract Character CreateCharacter();
        public abstract Weapon CreateWeapon();
        public abstract Armor CreateArmor();

       
    }
}
