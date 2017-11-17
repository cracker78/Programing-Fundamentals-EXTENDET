using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int count = 1;

            while (number>=count)
            {
                
                if ((count % 10 + count / 10) == 5)
                {
                    Console.WriteLine($"{count} -> True");
                }
                else if ((count % 10 + count / 10) == 7)
                {
                    Console.WriteLine($"{count} -> True");
                }
                else if ((count % 10 + count / 10) == 11)
                {
                    Console.WriteLine($"{count} -> True");
                }
                else
                {
                    Console.WriteLine($"{count} -> False");
                }
                count++;
            }
        }
    }
}
