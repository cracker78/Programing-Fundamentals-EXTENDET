using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Vapor_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            string game = Console.ReadLine();
            double curentMoney = money;
            bool lamp = false;

            while (game != "Game Time")
            {
                if (game == "OutFall 4")
                {
                    if (money < 39.98)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine("Bought OutFall 4");
                        money -= 39.99;
                    }
                }
                else if (game == "CS: OG")
                {
                    if (money < 15.98)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine("Bought CS: OG");
                        money -= 15.99;
                    }
                }
                else if (game == "Zplinter Zell")
                {
                    if (money < 19.98)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine("Bought Zplinter Zell");
                        money -= 19.99;
                    }
                }
                else if (game == "Honored 2")
                {
                    if (money < 59.98)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine("Bought Honored 2");
                        money -= 59.99;
                    }
                }
                else if (game == "RoverWatch")
                {
                    if (money < 29.98)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine("Bought RoverWatch");
                        money -= 29.99;
                    }
                }
                else if (game == "RoverWatch Origins Edition")
                {
                    if (money < 39.98)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine("Bought RoverWatch Origins Edition");
                        money -= 39.99;
                    }
                }
                else
                {
                    Console.WriteLine("Not Found");
                }

                if (money <= 0)
                {
                    Console.WriteLine("Out of money!");
                    lamp = true;
                    break;
                }

                game = Console.ReadLine();

            }

            if (lamp == false || game == "Game Time")
            {
                curentMoney -= money;
                Console.WriteLine($"Total spent: ${curentMoney:f2}. Remaining: ${money:f2}", curentMoney, money);
            }
        }
    }
}
