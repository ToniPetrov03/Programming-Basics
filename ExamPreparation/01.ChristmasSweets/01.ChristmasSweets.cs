using System;

namespace _01.ChristmasSweets
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceOfBaklavaPerKilogram = double.Parse(Console.ReadLine());
            double priceOfMuffinsPerKilogram = double.Parse(Console.ReadLine());
            double stollenKilograms = double.Parse(Console.ReadLine());
            double candyKilograms = double.Parse(Console.ReadLine());
            int biscuitsKilograms = int.Parse(Console.ReadLine());

            const double priceOfBiscuitsPerKilogram = 7.5;

            double priceOfStollen = priceOfBaklavaPerKilogram + priceOfBaklavaPerKilogram * 0.6;
            double sumOfStollen = priceOfStollen * stollenKilograms;
            double priceOfCandy = priceOfMuffinsPerKilogram + priceOfMuffinsPerKilogram * 0.8;
            double sumOfCandy = priceOfCandy * candyKilograms;
            double sumOfBiscuits = priceOfBiscuitsPerKilogram * biscuitsKilograms;

            double bill = sumOfStollen + sumOfCandy + sumOfBiscuits;

            Console.WriteLine($"{bill:F2}");
        }
    }
}
