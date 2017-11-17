using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZPIT
{
    class Program
    {
        static void Main(string[] args)
        {
            int brojUchastnici = int.Parse(Console.ReadLine());
            int miles = 0;
            int cargo = 0;
            string specifications=String.Empty;
            Dictionary<string, double> finalPrice=new Dictionary<string, double>();

            double fuel = 0.7;
            double cargoPerKilos = 1.5;
            double fuelPrice = 2.5;

            for (int i = 0; i < brojUchastnici; i++)
            {
                miles = int.Parse(Console.ReadLine());
                cargo = int.Parse(Console.ReadLine());
                specifications = Console.ReadLine();

                double result = 0.7 * miles * 1600 * 2.5;
                double cargoIncome = 1.5 * cargo*1000;
                double teamMoney = cargoIncome - result;

                if (!finalPrice.ContainsKey(specifications))
                {
                    finalPrice[specifications]=0;
                }

                finalPrice[specifications] += teamMoney;



                //finalPrice[specifications] += teamMoney;
#if DEBUG

                Console.WriteLine(teamMoney);

#endif

            }

            string teamFinal=String.Empty;
            double priceFinal =double.MinValue;

            foreach (KeyValuePair<string, double> item in finalPrice)
            {


                if (item.Value>=priceFinal)
                {
                    priceFinal = item.Value;
                    teamFinal = item.Key;
                }
            }

            Console.WriteLine($"The {teamFinal} Trainers win with ${priceFinal:f3}.");

        }
    }
}
