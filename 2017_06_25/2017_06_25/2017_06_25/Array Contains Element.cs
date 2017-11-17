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
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]==num)
                {
                    Console.WriteLine("yes");
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}
