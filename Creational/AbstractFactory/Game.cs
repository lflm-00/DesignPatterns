using Creational.AbstractFactory.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.AbstractFactory
{
    public class Game
    {
        private CharacterFactory characterFactory;

        public Game(CharacterFactory characterFactory)
        {
            this.characterFactory = characterFactory;
        }
        public void CreateCharacter()
        {
            Character character = characterFactory.CreateCharacter();
            Weapon weapon = characterFactory.CreateWeapon();
            Armor armor = characterFactory.CreateArmor();

            Console.WriteLine($"{character.getDescription()} equipped with a {weapon.getDescription()} and wearing {armor.getDescription()}.");
        }
    }
}
