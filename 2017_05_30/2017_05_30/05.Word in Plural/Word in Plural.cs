using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Word_in_Plural
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = Console.ReadLine();

            if (name.EndsWith("y"))
            {
                name = name.Remove(name.Length - 1);
                name = name + "ies";
            }
            else if (name.EndsWith("o") || 
                name.EndsWith("ch") || 
                name.EndsWith("s") || 
                name.EndsWith("sh")|| 
                name.EndsWith("x")|| 
                name.EndsWith("z"))
            {
                name = name + "es";
            }
            else
            {
                name += "s";
            }
            Console.WriteLine(name);
        }
    }
}
