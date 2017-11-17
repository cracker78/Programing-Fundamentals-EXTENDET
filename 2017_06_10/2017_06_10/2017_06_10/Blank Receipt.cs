using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_06_10
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }

        static void PrintHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }

        static void PrintBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        static void PrintFooter()
        {
            char symbol = '©';
            Console.WriteLine("------------------------------");
            Console.WriteLine($"{symbol} SoftUni");
        }
    }
}
