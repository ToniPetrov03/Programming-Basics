using System;

namespace _05.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string summerOrWinter = Console.ReadLine();

            string place = string.Empty;
            string location = string.Empty;
            double price = 0;

            if (summerOrWinter == "Summer")
            {
                location = "Alaska";
            }
            else
            {
                location = "Morocco";
            }

            if (budget > 0 && budget <= 1000)
            {
                place = "Camp";

                if (summerOrWinter == "Summer")
                {
                    price = budget * 0.65;
                }
                else
                {
                    price = budget * 0.45;
                }
            }
            else if (budget > 1000 && budget <= 3000)
            {
                place = "Hut";

                if (summerOrWinter == "Summer")
                {
                    price = budget * 0.8;
                }
                else
                {
                    price = budget * 0.6;
                }
            }
            else if (budget > 3000)
            {
                place = "Hotel";
                price = budget * 0.9;
            }

            Console.WriteLine($"{location} - {place} - {price:F2}");
        }
    }
}
