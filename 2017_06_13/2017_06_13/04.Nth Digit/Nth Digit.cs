﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Nth_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());
            FindNthDigit(number, index);
            Console.WriteLine(FindNthDigit(number, index));
        }

        static int FindNthDigit(int number, int index)
        {
            int currentIndex = 1;
            while (number!=0)
            {
                if (currentIndex==index)
                {
                    return number % 10;
                }
                currentIndex++;
                number /= 10;
            }
            return number%10;
        }
    }
}
