using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Entertrain
    {
        static void Main(string[] args)
        {

            int power = int.Parse(Console.ReadLine());

            int lokomotiv = power;

            List<int> vagoni=new List<int>();

            string weight = Console.ReadLine();

            int sum = 0;

            int count = 0;

            while (weight!= "All ofboard!")
            {
                int vagon = int.Parse(weight);

                vagoni.Add(vagon);

                sum += vagon;
                count++;

                weight = Console.ReadLine();

            }

            int average = 0;

            if (sum>power)
            {
                average = sum / count;
            }

            

            for (int i = 0; i < vagoni.Count; i++)
            {
                if (vagoni[i]<average)
                {
                    power -=vagoni[i];
                    vagoni.RemoveAt(0);
                }
            }

            vagoni.Reverse();
            //Console.WriteLine(sum);

            Console.Write(string.Join(" ", vagoni));
            Console.WriteLine($" {lokomotiv}");
        }
    }
}
