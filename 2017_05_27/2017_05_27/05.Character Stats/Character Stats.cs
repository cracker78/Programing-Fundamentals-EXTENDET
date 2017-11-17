using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var currentHealth = int.Parse(Console.ReadLine());
            var maxHealth = int.Parse(Console.ReadLine());
            var currentEnergy = int.Parse(Console.ReadLine());
            var maxEnergy = int.Parse(Console.ReadLine());

            var health = maxHealth - currentHealth;
            var energy = maxEnergy - currentEnergy;

            Console.WriteLine($"Name: {name}");
            Console.Write($"Health: ");
            Console.Write('|');
            Console.Write(new string('|', currentHealth));
            Console.Write(new string('.', health));
            Console.WriteLine('|');

            Console.Write($"Energy: ");
            Console.Write('|');
            Console.Write(new string('|', currentEnergy));
            Console.Write(new string('.', energy));
            Console.WriteLine('|');



        }
    }
}
