using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Append_Lists
{
    class Append_Lists
    {
        static void Main(string[] args)
        {
            List<string> partsOfItems = Console.ReadLine().Split('|').ToList();
            partsOfItems.Reverse();
            var result = new List<string>();
            foreach (var item in partsOfItems)
            {
                List<string> nums = item.Split(' ').ToList();
                foreach (var num in nums)
                {
                    if (num != "") result.Add(num);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}