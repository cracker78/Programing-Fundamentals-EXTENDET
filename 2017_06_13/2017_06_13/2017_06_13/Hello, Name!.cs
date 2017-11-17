using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2017_06_13
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            GetName(name);

        }

        static void GetName(string name)

        {

            Console.WriteLine("Hello, {0}!", name);
        }


    }
}
