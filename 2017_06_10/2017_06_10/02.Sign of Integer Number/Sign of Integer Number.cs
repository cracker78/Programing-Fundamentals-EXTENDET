﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Sign_of_Integer_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            NumberSign(num);

        }

        static void NumberSign(int num)
        {
            if (num==0)
            {
                Console.WriteLine($"The number {num} is zero.");
            }
            else if (num>0)
	        {
                Console.WriteLine($"The number {num} is positive.");
	        }
            else
	           {
             Console.WriteLine($"The number {num} is negative.");
	        }
        }
    }
}

