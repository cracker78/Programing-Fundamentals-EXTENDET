using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Rectangle_Area
{
    class rectanleArea
    {
        static void Main(string[] args)
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            var result = width * height;

            Console.WriteLine($"{result:f2}");

        }
    }
}
