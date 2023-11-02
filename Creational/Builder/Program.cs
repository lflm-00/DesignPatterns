using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Builder
{
    public class Program
    {
        static void Main(string[] args)
        {
            IBuilder builder = new ConcreteBuilder();
            Director director = new Director(builder);

            director.Construct();
            Product product = builder.GetResult();

            Console.WriteLine("Product Details:");
            product.ShowInfo();
        }
    }
}
