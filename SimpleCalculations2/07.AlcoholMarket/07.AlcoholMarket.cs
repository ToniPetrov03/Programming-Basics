using System;

namespace _07.AlcoholMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceWhiskey = double.Parse(Console.ReadLine());
            double litersBeer = double.Parse(Console.ReadLine());
            double litersWine = double.Parse(Console.ReadLine());
            double litersRaki = double.Parse(Console.ReadLine());
            double litersWhiskey = double.Parse(Console.ReadLine());

            double priceRaki = priceWhiskey / 2;
            double priceWine = priceRaki - priceRaki * 0.4;
            double priceBeer = priceRaki - priceRaki * 0.8;

            double sumAll = priceWhiskey * litersWhiskey + priceRaki * litersRaki + priceWine * litersWine + priceBeer * litersBeer;

            Console.WriteLine("{0:F2}", sumAll);
        }
    }
}
