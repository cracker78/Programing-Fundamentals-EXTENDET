using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_06_11
{
    class Program
    {
        static void Main(string[] args)
        {

            int numbersOfArray = int.Parse(Console.ReadLine());
            int[] arr=new int[numbersOfArray];
            int sum = 0;


            for (int cnt = 0; cnt < arr.Length; cnt++)
            {
                arr[cnt] = int.Parse(Console.ReadLine());
                sum = sum + arr[cnt];
            }

            Console.WriteLine(sum);
        }
    }
}
