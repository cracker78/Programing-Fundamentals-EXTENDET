using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_06_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            char sign = 'x';
            char empty = ' ';

            Console.Write('x');
            Console.Write(new string(' ', number-2));
            Console.WriteLine('x');

            for (int i = 1; i <= number/2-1; i++)
            {
                Console.Write(new string(' ', i));
                Console.Write("x");
                Console.Write(new string(' ', number - 2*i-2));
                Console.Write("x");
                Console.WriteLine(new string(' ', i));
            }
            Console.Write(new string(' ', number/2));
            Console.Write('x');
            Console.WriteLine(new string(' ', number / 2));

            for (int i = (number / 2 - 1); i >= 1; i--)
            {
                Console.Write(new string(' ', i));
                Console.Write("x");
                Console.Write(new string(' ', number - 2 * i - 2));
                Console.Write("x");
                Console.WriteLine(new string(' ', i));
            }
            Console.Write('x');
            Console.Write(new string(' ', number - 2));
            Console.WriteLine('x');
        }
    }
}
