using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Builder
{
    public class Product
    {
        public string Part1 { get; set; }
        public string Part2 { get; set; }
        public string Part3 { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($"Part 1: {Part1}");
            Console.WriteLine($"Part 2: {Part2}");
            Console.WriteLine($"Part 3: {Part3}");
        }
    }
}
