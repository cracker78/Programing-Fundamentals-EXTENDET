using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex pattern=new Regex(@"(\<\[[\W\D]+\].)*(.[[\w\d]]\.)");

            string text = Console.ReadLine();

            while (text != "Traincode!")
            {
                if (pattern.IsMatch(text))
                {
                    Console.WriteLine(text);
                }

                text = Console.ReadLine();
            }
        }
    }
}
