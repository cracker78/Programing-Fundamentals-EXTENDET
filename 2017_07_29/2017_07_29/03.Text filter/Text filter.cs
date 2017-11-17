using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Text_filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(new char[','], StringSplitOptions.RemoveEmptyEntries).ToArray();

            string inputText = Console.ReadLine();

            foreach (var word in bannedWords)
            {
                if (inputText.Contains(bannedWords))
                {
                    
                }
                
            }

            Console.WriteLine(bannedWords);
        }
    }
}
