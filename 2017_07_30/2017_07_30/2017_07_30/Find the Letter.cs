using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_07_30
{
    class Program
    {
        static void Main(string[] args)
        {

            string inputText = Console.ReadLine();
            string[] array = Console.ReadLine().Split(' ').ToArray();
            var index = array[1].ToCharArray();
            var letter = array[0].ToCharArray();
            char letterToSerch = (char) letter[0];
            var neshtosi = index[0];
            int counter = 0;
            int indexToSerch = index[0] - '0';

            for (int i = 0; i < indexToSerch; i++)
            {
                counter++;
                index=inputText.IndexOf(letterToSerch, i);
            }

            Console.WriteLine(indexToSerch);

        }
    }
}
