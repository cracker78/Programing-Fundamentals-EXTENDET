using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Magic_Letter
{
    class Program
    {
        public static void Main()
        {
            var firstLetter = char.Parse(Console.ReadLine().ToLower());
            var secondLetter = char.Parse(Console.ReadLine().ToLower());
            var ignoredLetter = char.Parse(Console.ReadLine().ToLower());

            for (char i = firstLetter; i <= secondLetter; i++)
            {
                for (char j = firstLetter; j <= secondLetter; j++)
                {
                    for (char k = firstLetter; k <= secondLetter; k++)
                    {
                        if (!i.Equals(ignoredLetter) && !j.Equals(ignoredLetter) && !k.Equals(ignoredLetter))
                        {
                            Console.Write($"{i}{j}{k}" + " ");
                        }
                    }
                }
            }
        }
    }
}