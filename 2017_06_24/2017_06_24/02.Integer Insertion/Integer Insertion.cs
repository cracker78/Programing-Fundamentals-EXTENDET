using System;
using System.Collections.Generic;
using System.Linq;

    public class IntegerInsertion
    {
        public static void Main()
        {
            var num = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var stringInput = Console.ReadLine();
            num = Insertion(num, stringInput);

            Console.WriteLine(string.Join(" ", num));
        }
        static List<int> Insertion(List<int> numbers, string stringInput)
        {
            while (stringInput != "end")
            {
                var insertIndex = int.Parse(stringInput[0].ToString());
                var number = int.Parse(stringInput);

                numbers.Insert(insertIndex, number);

                stringInput = Console.ReadLine();
            }
            return numbers;
        }
    }