using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            while (input!= "It’s Training Men!")
            {
                string[] tokens = input.Split(new string[] {" -> ", " : "}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (tokens.Length<3)
                {
                    string trainName = tokens[0];
                    string otherTrainName = tokens[1];
                }
                else
                {
                    string train = tokens[0];
                    string wagons = tokens[1];
                    int power = int.Parse(tokens[2]);
                }
                





            }

        }
    }
}
