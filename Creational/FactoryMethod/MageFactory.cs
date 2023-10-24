using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Factory
{
    internal class MageFactory : CharacterFactory
    {
        public override ICharacter CreateCharacter()
        {
            return new Mage();
        }
    }
}
