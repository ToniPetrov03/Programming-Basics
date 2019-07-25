using System;

namespace _01.SeaTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyForFood = double.Parse(Console.ReadLine());
            double moneyForSouvenirs = double.Parse(Console.ReadLine());
            double moneyForHotel = double.Parse(Console.ReadLine());

            double sum = 54.39;

            sum += 3 * (moneyForFood + moneyForSouvenirs);
            sum += moneyForHotel * 0.9;
            sum += moneyForHotel * 0.85;
            sum += moneyForHotel * 0.8;

            Console.WriteLine($"Money needed: {sum:F2}");
        }
    }
}
