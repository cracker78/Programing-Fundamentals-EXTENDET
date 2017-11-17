using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_05_28
{
    class Passed
    {
        static void Main(string[] args)
        {
            var grade = double.Parse(Console.ReadLine());

            if (grade>=3)
            {
                Console.WriteLine("Passed!");
            }

        }
    }
}
