using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = int.Parse(Console.ReadLine());
            int smallHall = 50;
            int terrace = 100;
            int greatHall = 120;
            string package = Console.ReadLine();

            if (person <= 50)
            {
                string hallName = "Small Hall";
                int price = 2500;

                if (package == "Gold")
                {
                    double totalPrice = price + 750;
                    double discount = totalPrice*0.9;
                    var pricePerPerson = (discount / person);

                    Console.WriteLine($"We can offer you the {hallName}");
                    Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
                }

                else if (package == "Normal")
                {
                    double totalPrice = price + 500;
                    double discount = totalPrice*0.95;
                    var pricePerPerson = (discount / person);

                    Console.WriteLine($"We can offer you the {hallName}");
                    Console.WriteLine($"The price per person is {pricePerPerson:f2}$");

                }
                else if (package == "Platinum")
                {
                    double totalPrice = price + 1000;
                    double discount = totalPrice*0.85;
                    var pricePerPerson = (discount / person);

                    Console.WriteLine($"We can offer you the {hallName}");
                    Console.WriteLine($"The price per person is {pricePerPerson:f2}$");

                }
            }
            else if (person > 50 && person <= 100)
            {
                string hallName = "Terrace";
                int price = 5000;

                if (package == "Gold")
                {
                    double totalPrice = price + 750;
                    double discount = totalPrice*0.9;
                    var pricePerPerson = (discount / person);

                    Console.WriteLine($"We can offer you the {hallName}");
                    Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
                }

                else if (package == "Normal")
                {
                    double totalPrice = price + 500;
                    double discount = totalPrice*0.95;
                    var pricePerPerson = (discount / person);

                    Console.WriteLine($"We can offer you the {hallName}");
                    Console.WriteLine($"The price per person is {pricePerPerson:f2}$");

                }
                else if (package == "Platinum")
                {
                    double totalPrice = price + 1000;
                    double discount = totalPrice*0.85;
                    var pricePerPerson = (discount / person);

                    Console.WriteLine($"We can offer you the {hallName}");
                    Console.WriteLine($"The price per person is {pricePerPerson:f2}$");

                }
            }
            else if (person > 100 && person <= 120)
            {
                string hallName = "Great Hall";
                int price = 7500;

                if (package == "Gold")
                {
                    double totalPrice = price + 750;
                    double discount = totalPrice*0.9;
                    var pricePerPerson = (discount / person);

                    Console.WriteLine($"We can offer you the {hallName}");
                    Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
                }

                else if (package == "Normal")
                {
                    double totalPrice = price + 500;
                    double discount = totalPrice*0.95;
                    var pricePerPerson = (discount / person);

                    Console.WriteLine($"We can offer you the {hallName}");
                    Console.WriteLine($"The price per person is {pricePerPerson:f2}$");

                }
                else if (package == "Platinum")
                {
                    double totalPrice = price + 1000;
                    double discount = totalPrice*0.85;
                    var pricePerPerson = (discount / person);

                    Console.WriteLine($"We can offer you the {hallName}");
                    Console.WriteLine($"The price per person is {pricePerPerson:f2}$");

                }
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }

        }
    }
}
