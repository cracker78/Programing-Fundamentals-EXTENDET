using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Megapixels
{
    class Megapixels
    {
        static void Main(string[] args)
        {
            decimal horizontalPixels = int.Parse(Console.ReadLine());
            decimal verticalPixels = int.Parse(Console.ReadLine());
            decimal totalPixels = ((horizontalPixels * verticalPixels) / 1000000);

            Console.WriteLine($"{horizontalPixels}x{verticalPixels} => {Math.Round(totalPixels, 1)}MP");
        }
    }
}
