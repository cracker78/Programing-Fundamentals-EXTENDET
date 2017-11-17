using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2017_08_06
{
    class Cards
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"(([2-9]|10)|[J,Q,K,A])+[S,H,D,C]";

            MatchCollection matches = Regex.Matches(text, pattern);

            string[] output=new string[matches.Count];

            for (int i = 0; i < output.Length; i++)
            {
                output[i] = matches[i].Groups[0].Value;
            }

            Console.WriteLine(string.Join(", ", output));

            
        }
    }
}
