﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_06_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Years - ");
            byte years = byte.Parse(Console.ReadLine());
            int days = years * 365;
            int hours = days * 24;
            int minutes = hours * 60;
            Console.WriteLine($"{years} years = {days} days = {hours} hours = {minutes} minutes.");
        }
    }
}
