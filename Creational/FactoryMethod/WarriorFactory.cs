using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Factory
{
    internal class WarriorFactory : CharacterFactory
    {
        public override ICharacter CreateCharacter()
        {
           return new Warrior();
        }
    }
}

