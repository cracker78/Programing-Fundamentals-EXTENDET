using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Camel_s_Back
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CamelsBack
    {
        public static void Main()
        {
            var building = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var camelSize = int.Parse(Console.ReadLine());

            if (building.Count <= camelSize)
            {
                Console.WriteLine($"already stable: {string.Join(" ", building)}");
            }
            else
            {
                var rouds = (building.Count - camelSize) / 2;
                building = building.Skip(rouds).Take(camelSize).ToList();
                Console.WriteLine($"{rouds} rounds");
                Console.WriteLine($"remaining: {string.Join(" ", building)}");
            }
        }
    }
}
