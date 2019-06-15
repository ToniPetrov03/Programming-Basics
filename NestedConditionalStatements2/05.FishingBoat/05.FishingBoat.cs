using System;

namespace _05.FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numFishermen = int.Parse(Console.ReadLine());

            const int priceRentShipSpring = 3000;
            const int priceRentShipSummerAndAutumn = 4200;
            const int priceRentShipWinter = 2600;
            double price = 0;

            if (season == "Spring")
            {
                price = priceRentShipSpring;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                price = priceRentShipSummerAndAutumn;
            }
            else if (season == "Winter")
            {
                price = priceRentShipWinter;
            }

            if (numFishermen <= 6)
            {
                price -= price * 0.1;
            }
            else if (numFishermen >= 7 && numFishermen <= 11)
            {
                price -= price * 0.15;
            }
            else if (numFishermen > 12)
            {
                price -= price * 0.25;
            }

            if (season != "Autumn" && numFishermen % 2 == 0)
            {
                price -= price * 0.05;
            }
            if (budget >= price)
            {
                Console.WriteLine($"Yes! You have {budget - price:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {price - budget:F2} leva.");
            }
        }
    }
}
