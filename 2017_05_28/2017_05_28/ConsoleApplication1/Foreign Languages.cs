using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            var country = Console.ReadLine();

            switch (country)
            {
                case "USA": Console.WriteLine("English"); break;
                case "England": Console.WriteLine("English"); break;
                case "Spain": Console.WriteLine("Spanish"); break;
                case "Argentina": Console.WriteLine("Spanish"); break;
                case "Mexico": Console.WriteLine("Spanish"); break;

                default: Console.WriteLine("unknown"); break;
            }
        }
    }
}
