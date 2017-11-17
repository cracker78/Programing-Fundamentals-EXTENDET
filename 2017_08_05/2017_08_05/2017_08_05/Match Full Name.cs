using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2017_08_05
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string regex = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            MatchCollection machedNames = Regex.Matches(input, regex);

            foreach (Match name in machedNames)
            {
                Console.Write(name.Value + " ");
            }

            Console.WriteLine();
        }
    }
}
