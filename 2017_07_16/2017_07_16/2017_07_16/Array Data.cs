using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _2017_07_16
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string command = Console.ReadLine();

            //List<int> result= new List<int>();

            if (command=="Min")
            {
                double average = input.Average();
                Console.WriteLine(string.Join(" ", input.OrderBy(x => x).Where(x=> x>=average).Min().ToString()));

                //result = input.Select(int.Parse).Min().ToList;
            }

            else if (command=="Max")
            {
                double average = input.Average();
                Console.WriteLine(string.Join(" ", input.Where(x=> x>=average).Max().ToString()));
            }

            else if (command=="All")
            {
                double average=input.Average();
                List<int> result = input.Where(x => x >= average).ToList();

                Console.WriteLine(string.Join(" ", result.OrderBy(x=> x).ToList()));
            }

            //Console.WriteLine(string.Join(" ", input));
        }
    }
}
