using System;

namespace _02.ReportSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int neededSum = int.Parse(Console.ReadLine());

            string priceOrEnd = string.Empty;
            int counter = 0;
            int counterCash = 0;
            int counterWithCard = 0;
            int cash = 0;
            int withCard = 0;
            int totalPrice = 0;

            while (neededSum > totalPrice)
            {
                priceOrEnd = Console.ReadLine();

                if (priceOrEnd == "End")
                    break;

                int price = int.Parse(priceOrEnd);

                if (counter == 0)
                {
                    if (price > 100)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        cash += price;
                        totalPrice += price;
                        counterCash++;
                        Console.WriteLine("Product sold!");
                    }
                }
                else
                {
                    if (price < 10)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        withCard += price;
                        totalPrice += price;
                        counterWithCard++;
                        Console.WriteLine("Product sold!");
                    }

                    counter -= 2;
                }

                counter++;
            }

            if (priceOrEnd == "End" && totalPrice < neededSum)
            {
                Console.WriteLine("Failed to collect required money for charity.");
            }
            else if (totalPrice >= neededSum)
            {
                Console.WriteLine($"Average CS: {(double)cash / counterCash:F2}");
                Console.WriteLine($"Average CC: {(double)withCard / counterWithCard:F2}");
            }
        }
    }
}
