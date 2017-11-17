using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var volume = int.Parse(Console.ReadLine());
            var energy = int.Parse(Console.ReadLine());
            var sugar = int.Parse(Console.ReadLine());

            var cal = (double)(volume * energy) / 100;
            var sweet = (double)(volume * sugar) / 100;

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{cal}kcal, {sweet}g sugars");

        }
    }
}
