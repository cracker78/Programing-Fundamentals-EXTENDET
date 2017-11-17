using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;

            for (int i = 0; i <= 20; i++)
            {
                name = Console.ReadLine();

                if (name!="Bake!")
                {
                    Console.WriteLine($"Adding ingredient {name}.");
                }
                else
                {
                    Console.WriteLine($"Preparing cake with {i} ingredients.");
                    break;
                }

            }            
        }
    }
}
