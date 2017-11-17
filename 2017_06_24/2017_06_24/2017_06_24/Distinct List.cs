using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2017_06_24
{
    class Program
    {
        static void Main()
        {
            var num=Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < num.Count; i++)
            {
                for (int j = i + 1; j < num.Count; j++)
                {
                    if (num[i] == num[j])
                    {
                        num.RemoveAt(j);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", num));
        }
    }
}
