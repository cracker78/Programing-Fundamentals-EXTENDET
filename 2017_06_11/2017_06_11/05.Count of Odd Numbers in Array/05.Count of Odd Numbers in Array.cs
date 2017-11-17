using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Count_of_Odd_Numbers_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int count = 0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                inputArray[i] = Math.Abs(inputArray[i]);

                if (inputArray[i] %2==1)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
