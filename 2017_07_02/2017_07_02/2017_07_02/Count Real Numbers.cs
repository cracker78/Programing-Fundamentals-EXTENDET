using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_07_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string[] words = input.Split(' ');
            var counts = new Dictionary<string, int>();
            foreach (var word in words)
                if (counts.ContainsKey(word))
                    counts[word]++;
                else counts[word] = 1;
            var results = new List<string>();
            foreach (var pair in counts)
                // TODO: add pair.Key to results if pair.Value is odd
                Console.WriteLine(string.Join(", ", results));

        }
    }
}
