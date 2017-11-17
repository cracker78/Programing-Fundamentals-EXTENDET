using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Key_Key_Value_Value
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstLineKey = Console.ReadLine();
            string secondLineValue = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> firstDict=new Dictionary<string, List<string>>();

            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split(new char[] {'=', '>'}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                firstDict.Add(input[1], new List<string>());

                List<string> second=new List<string>();

                foreach (var words in second)
                {
                    firstDict[input[i]].Add(words);

                }
            }

            foreach (var item in firstDict)
            {
                Console.WriteLine(item.Key);
                foreach (var second in item.Value)
                {
                    Console.WriteLine(string.Join(", ", second));
                }
            }
        }
    }
}
