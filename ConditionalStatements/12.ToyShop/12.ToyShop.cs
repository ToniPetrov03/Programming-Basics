using System;

namespace _11.AnimalType
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceExcursion = double.Parse(Console.ReadLine());
            int numPuzzles = int.Parse(Console.ReadLine());
            int numDolls = int.Parse(Console.ReadLine());
            int numBears = int.Parse(Console.ReadLine());
            int numMignons = int.Parse(Console.ReadLine());
            int numTrucks = int.Parse(Console.ReadLine());

            int numAll = numPuzzles + numDolls + numBears + numMignons + numTrucks;

            double sumPuzzles = numPuzzles * 2.6;
            int sumDoll = numDolls * 3;
            double sumBear = numBears * 4.1;
            double sumMignon = numMignons * 8.2;
            int sumTruck = numTrucks * 2;
            double gain = 0;

            double finalPrice = sumPuzzles + sumDoll + sumBear + sumMignon + sumTruck;

            if (numAll >= 50)
            {
                gain = (finalPrice - finalPrice * 0.25) - (finalPrice - finalPrice * 0.25) * 0.1;
            }
            else
            {
                gain = finalPrice - finalPrice * 0.1;
            }

            if (gain >= priceExcursion)
            {
                double remain = gain - priceExcursion;
                Console.WriteLine("Yes! {0:F2} lv left.", remain);
            }
            else
            {
                double need = priceExcursion - gain;
                Console.WriteLine("Not enough money! {0:F2} lv needed.", need);
            }
        }
    }
}
