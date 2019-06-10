using System;

namespace _07.FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int numMagnolia = int.Parse(Console.ReadLine());
            int numHyacinths = int.Parse(Console.ReadLine());
            int numRoses = int.Parse(Console.ReadLine());
            int numCactuses = int.Parse(Console.ReadLine());
            double priceGift = double.Parse(Console.ReadLine());

            const double priceMagnolia = 3.25;
            const int priceHyacinth = 4;
            const double priceRose = 3.5;
            const int priceCactus = 8;

            double sum = numMagnolia * priceMagnolia + numHyacinths * priceHyacinth + numRoses * priceRose + numCactuses * priceCactus;
            double tax = sum * 0.05;
            double profit = sum - tax;

            if (profit >= priceGift)
            {
                double leftMoney = Math.Floor(profit - priceGift);
                Console.WriteLine($"She is left with {leftMoney} leva.");
            }
            else
            {
                double neededMoney = Math.Ceiling(priceGift - profit);
                Console.WriteLine($"She will have to borrow {neededMoney} leva.");
            }
        }
    }
}
    