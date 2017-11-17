using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int start = 1;
            int end = num;
            Triangle(start, end);

        }
        static void Triangle(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + "");
            }
            Console.WriteLine();
        }
    }
}
