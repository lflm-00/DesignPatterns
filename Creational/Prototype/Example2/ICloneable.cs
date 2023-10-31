using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Prototype.Example2
{
    public interface ICloneable
    {
        ICloneable Clone();
        void Display();
    }
}
