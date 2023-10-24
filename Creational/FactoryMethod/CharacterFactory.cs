using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Factory
{
    /* La clase CharacterFactory actua como un Factory Method
     */
    public abstract class CharacterFactory
    {
        public abstract ICharacter CreateCharacter();
    }
}
