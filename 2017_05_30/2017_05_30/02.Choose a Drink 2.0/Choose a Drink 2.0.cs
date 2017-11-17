using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_05_30
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();
            var quantity = double.Parse(Console.ReadLine());

            switch (title)
            {
                case "Athlete": Console.WriteLine($"The {title} has to pay {(quantity*0.7):f2}."); break;
                case "Businessman": Console.WriteLine($"The {title} has to pay {(quantity * 1.0):f2}."); break;
                case "Businesswoman": Console.WriteLine($"The {title} has to pay {(quantity * 1.0):f2}."); break;
                case "SoftUni Student": Console.WriteLine($"The {title} has to pay {(quantity * 1.7):f2}."); break;
                default:
                    Console.WriteLine($"The {title} has to pay {(quantity * 1.2):f2}.");
                    break;
            }

        }
    }
}
