using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Transport
{
    class Transport
    {
        static void Main(string[] args)
        {
            int pepole = int.Parse(Console.ReadLine());
            double course= Math.Ceiling((double)pepole/24);
            Console.WriteLine(course);
        }
    }
}
