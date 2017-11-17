using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Reverse_Array_In_place
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int left = 0;
            int right = arr.Length - 1;
            int temp;

            for (int i = 0; i < arr.Length/2; i++)
            {
                temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;

                left++;
                right--;
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
