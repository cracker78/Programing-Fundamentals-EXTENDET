using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Back_in_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            if (minutes+30>=60)
            {
                hours = hours + 1;
                minutes = (minutes + 30) - 60;
                if (hours>23)
                {
                    hours = hours - 24;
                }
                Console.WriteLine($"{hours}:{minutes:D2}");
            }

            else
            {
                Console.WriteLine($"{hours}:{(minutes+30):D2}");
            }
        }
    }
}
