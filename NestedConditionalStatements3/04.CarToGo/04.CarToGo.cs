using System;

namespace _04.CarToGo
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string summerOrWinter = Console.ReadLine();

            string Class = string.Empty;
            string car = string.Empty;
            double price = 0;

            if (budget > 0 && budget <= 100)
            {
                Class = "Economy class";

                if (summerOrWinter == "Summer")
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
                Class = "Compact class";

                if (summerOrWinter == "Summer")
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
                Class = "Luxury class";
                car = "Jeep";
                price = budget * 0.9;
            }

            Console.WriteLine(Class);
            Console.WriteLine($"{car} - {price:F2}");
        }
    }
}
