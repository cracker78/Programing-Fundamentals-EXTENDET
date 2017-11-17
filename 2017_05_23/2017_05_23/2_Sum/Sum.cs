using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Sum
{
    class Sum
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber+secondNumber}");
        }
    }
}
