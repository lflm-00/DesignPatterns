﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Prototype.Example1
{
    public interface IPrototype
    {
        IPrototype Clone();
    }
}
