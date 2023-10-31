using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Builder
{
    public class ConcreteBuilder : IBuilder
    {
        private Product product = new Product();


        public void Reset()
        {
            this.product = new Product();
        }
        public void BuildPart1()
        {
            product.Part1 = "Part 1 built";
        }

        public void BuildPart2()
        {
            product.Part2 = "Part 2 built";
        }

        public void BuildPart3()
        {
            product.Part3 = "Part 3 built";
        }

        public Product GetResult()
        {
            Product result = this.product;
            this.Reset();
            return result;
        }
    }
}
