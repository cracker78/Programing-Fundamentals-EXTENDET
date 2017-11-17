using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Calculate_Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double heigt = double.Parse(Console.ReadLine());
            double area = GetTriangleArea(width, heigt);
            Console.WriteLine(area);
        }

        static double GetTriangleArea(double width, double heigt)
        {
            double area = width * heigt / 2;
            return area;
        }
    }
}
