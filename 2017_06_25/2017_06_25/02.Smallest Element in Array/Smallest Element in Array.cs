using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_06_25
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int temp = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (temp>arr[i])
                {
                    temp = arr[i];
                }

            }

            Console.WriteLine(temp);
        }
    }
}
