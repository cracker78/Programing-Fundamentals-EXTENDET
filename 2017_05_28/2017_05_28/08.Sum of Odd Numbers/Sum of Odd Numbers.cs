using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            var sum = 0;

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine("{0}", 2 * i - 1);
                sum += 2 * i - 1;
            }
            Console.WriteLine("Sum: {0}", sum);
        }
    }
}

