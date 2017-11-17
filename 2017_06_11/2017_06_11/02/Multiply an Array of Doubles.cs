using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double number = double.Parse(Console.ReadLine());
            double[] resultArray = new double[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                resultArray[i] = arr[i] * number;
                Console.Write(resultArray[i]);
                Console.Write(" ");
            }
            Console.WriteLine();

        }
    }
}
