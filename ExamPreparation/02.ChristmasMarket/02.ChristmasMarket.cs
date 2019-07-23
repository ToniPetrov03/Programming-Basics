using System;

namespace _02.ChristmasMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            int numFantasyBooks = int.Parse(Console.ReadLine());
            int numHorrorBooks = int.Parse(Console.ReadLine());
            int numRomanceBooks = int.Parse(Console.ReadLine());

            const double fantasyBookPrice = 14.9;
            const double horrorBookPrice = 9.8;
            const double romanceBookPrice = 4.3;

            double amountOfTheSale = numFantasyBooks * fantasyBookPrice + numHorrorBooks * horrorBookPrice + numRomanceBooks * romanceBookPrice;
            double amountAfterPaymentOfDDS = amountOfTheSale * 0.8;

            if (amountAfterPaymentOfDDS >= neededMoney)
            {
                double remuneration = Math.Floor((amountAfterPaymentOfDDS - neededMoney) * 0.1);

                Console.WriteLine($"{amountAfterPaymentOfDDS - remuneration:F2} leva donated.");
                Console.WriteLine($"Sellers will receive {remuneration} leva.");
            }
            else
            {
                Console.WriteLine($"{neededMoney - amountAfterPaymentOfDDS:F2} money needed.");
            }
        }
    }
}
