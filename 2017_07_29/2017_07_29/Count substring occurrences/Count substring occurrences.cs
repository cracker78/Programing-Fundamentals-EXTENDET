using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_substring_occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine().ToLower();
            string findText = Console.ReadLine().ToLower();

            int counter = 0;

            int index = inputText.IndexOf(findText);

            while (index !=-1)
            {
                counter++;
                index = inputText.IndexOf(findText, index + 1);
            }

            Console.WriteLine(counter);

        }
    }
}
