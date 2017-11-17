using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sort_Array_Using_Bubble_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int temp=0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length-1; j++)
                {                
                    if (arr[j]>arr[j+1])
                     {
                     temp = arr[j];
                     arr[j] = arr[j + 1];
                     arr[j + 1] = temp;
                    }
                }

            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
