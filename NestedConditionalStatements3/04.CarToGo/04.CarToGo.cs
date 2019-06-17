using System;

namespace _04.CarToGo
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string summerOrWinter = Console.ReadLine();

            string category = string.Empty;
            string car = string.Empty;
            double price = 0;
            bool isSummer = summerOrWinter == "Summer";
            if (budget > 0 && budget <= 100)
            {
                category = "Economy class";

                if (isSummer)
                {
                    car = "Cabrio";
                    price = budget * 0.35;
                }
                else
                {
                    car = "Jeep";
                    price = budget * 0.65;
                }
            }
            else if (budget > 100 && budget <= 500)
            {
                category = "Compact class";

                if (isSummer)
                {
                    car = "Cabrio";
                    price = budget * 0.45;
                }
                else
                {
                    car = "Jeep";
                    price = budget * 0.8;
                }
            }
            else if (budget > 500)
            {
                category = "Luxury class";
                car = "Jeep";
                price = budget * 0.9;
            }

            Console.WriteLine(category);
            Console.WriteLine($"{car} - {price:F2}");
        }
    }
}
