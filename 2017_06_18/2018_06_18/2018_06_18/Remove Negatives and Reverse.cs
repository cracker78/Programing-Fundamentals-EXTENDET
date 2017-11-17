using System;
using System.Collections.Generic;
using System.Linq;

namespace removeNegativeAndReverse
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var resultListPositive = new List<int>();


            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (list[i] >= 0)
                {
                    resultListPositive.Add(list[i]);
                }

            }
            if (resultListPositive.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", resultListPositive));
            }
        }
    }
}
