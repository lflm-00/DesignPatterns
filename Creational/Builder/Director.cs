using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Builder
{
    public class Director
    {
        /* Puedes personalizar la construcción del producto
         * cambiando el orden en el que se llaman a los métodos
         * BuildPart1, BuildPart2 y BuildPart3 en el Director.
         */
        private IBuilder builder;

        public Director(IBuilder builder)
        {
            this.builder = builder;
        }

        public void Construct()
        {
            builder.BuildPart1();
            builder.BuildPart2();
            builder.BuildPart3();
        }
    }
}
