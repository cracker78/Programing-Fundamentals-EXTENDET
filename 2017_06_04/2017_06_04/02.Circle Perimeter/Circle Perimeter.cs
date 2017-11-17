using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Circle_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"{2*Math.PI*radius:f12}");
        }
    }
}
