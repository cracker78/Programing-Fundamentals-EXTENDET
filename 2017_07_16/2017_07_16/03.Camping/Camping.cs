using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _03.Camping
{
    class Camping
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();  
            //List<string> input = Console.ReadLine().Split(' ').ToList();

            while (command!="end")
            {
                List<string> input = Console.ReadLine().Split(' ').ToList();

                Console.WriteLine(string.Join(" ", input));
            }
        }
    }
}
