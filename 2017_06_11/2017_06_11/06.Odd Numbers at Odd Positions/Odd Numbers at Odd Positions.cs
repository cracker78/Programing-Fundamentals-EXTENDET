using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Odd_Numbers_at_Odd_Positions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 1; i < inputArray.Length; i=i+2)
            {


                if (Math.Abs(inputArray[i])%2==1)
                {
                    Console.WriteLine($"Index {i} -> {inputArray[i]}");
                }
            }

        }
    }
}
