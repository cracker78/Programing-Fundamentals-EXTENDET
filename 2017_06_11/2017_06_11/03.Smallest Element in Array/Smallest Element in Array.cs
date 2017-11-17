using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Smallest_Element_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int min = int.MaxValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (min>array[i])
                {
                    min = array[i];
                }
            }

            Console.WriteLine(min);
        }
    }
}
