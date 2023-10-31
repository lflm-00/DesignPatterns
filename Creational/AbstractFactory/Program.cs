using Creational.AbstractFactory.ConcreteFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.AbstractFactory
{
    public class Program
    {
        static void Main(string[] args)
        {
            CharacterFactory warriorFactory = new WarriorFactory();
            CharacterFactory mageFactory = new MageFactory();

            Game game = new Game(warriorFactory);
            game.CreateCharacter();

            game = new Game(mageFactory);
            game.CreateCharacter();
        }
    }
}
