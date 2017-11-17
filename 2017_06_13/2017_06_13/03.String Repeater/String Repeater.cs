using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.String_Repeater
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordToRepeat = Console.ReadLine();
            int counter = int.Parse(Console.ReadLine());
            RepeatString(wordToRepeat, counter);

        }
        static string RepeatString(string wordToRepeat, int counter)
        {
            string repeatedString = string.Empty;

            for (int i = 0; i < counter; i++)
            {
                Console.Write($"{wordToRepeat}");
            }

            return repeatedString;
        }
    }
}
