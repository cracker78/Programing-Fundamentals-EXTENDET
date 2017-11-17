using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_05_27
{
    class cardNumber
    {
        static void Main(string[] args)
        {

            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());
            var thirdNumber = int.Parse(Console.ReadLine());
            var forthNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"{firstNumber:D4} {secondNumber:D4} {thirdNumber:D4} {forthNumber:D4}");

        }
    }
}
