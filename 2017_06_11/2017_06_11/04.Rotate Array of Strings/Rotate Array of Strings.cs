using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Rotate_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputArray = Console.ReadLine().Split(' ').ToArray();

            string[] resultArray=new string[inputArray.Length];

            for (int i = 0; i < inputArray.Length-1; i++)
            {
                resultArray[i+1] = inputArray[i];
            }

            resultArray[0] = inputArray[inputArray.Length-1];

            Console.WriteLine(string.Join(" ", resultArray));

        }
    }
}
