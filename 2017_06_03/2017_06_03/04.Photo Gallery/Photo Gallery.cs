using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Photo_Gallery
{
    class Program
    {
        static void Main(string[] args)
        {
            int imageNumber = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int size = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            string orientation;

            if (size<1000)
            {
                Console.WriteLine(size);
            }
            if (width>height)
            {
                orientation = "landscape";
            }
            else if (width<height)
            {
                orientation = "portrait";
            }
            else
            {
                orientation = "square";
            }
            Console.WriteLine($"Name: DSC_{imageNumber:D4}.jpg");
            Console.WriteLine($"Date Taken: {day:D2}/{month:D2}/{year} {hour:D2}:{minutes:D2}");
            Console.WriteLine($"Size: {Math.Round(((double)size / 1000000), 1)}MB");
            Console.WriteLine($"Resolution: {width}x{height} ({orientation})");
        }
    }
}
