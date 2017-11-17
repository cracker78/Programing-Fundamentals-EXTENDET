using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Min_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirthNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMin(firstNumber, GetMin(secondNumber, thirthNumber)));

        }

        static int GetMin(int firstNumber, int secondNumber)
        {
            return Math.Min(firstNumber, secondNumber);
        }
    }
}
