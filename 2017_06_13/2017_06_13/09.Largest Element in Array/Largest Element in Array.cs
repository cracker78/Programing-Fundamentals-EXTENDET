using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Largest_Element_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var num = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                var input = int.Parse(Console.ReadLine());
                if (input > num)
                {
                    num = input;
                }
            }
            Console.WriteLine(num);
        }
    }
}
