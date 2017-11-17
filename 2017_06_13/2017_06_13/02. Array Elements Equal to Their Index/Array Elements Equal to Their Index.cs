using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Array_Elements_Equal_to_Their_Index
{
    class Program
    {
        static void Main(string[] args)
        {
            var strArray = Console.ReadLine().Split(' ');
            int[] intArray= new int[strArray.Length];

            for (int i = 1; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);
                if (i== intArray[i])
                {
                    Console.Write($"{intArray[i]}");
                }
            }
        }
    }
}
