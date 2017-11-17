using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i <num; i++)
            {
                for (int j = 0; j <num; j++)
                {
                    for (int k = 0; k <num; k++)
                    {
                        Console.Write($"{(char)(97+i)}{(char)(97+j)}{(char)(97+k)}");
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
