using System;

namespace _03.Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int squareMetersVineyard = int.Parse(Console.ReadLine());
            double grapesOneSquareMeter = double.Parse(Console.ReadLine());
            int neededLitersWine = int.Parse(Console.ReadLine());
            int numWorkers = int.Parse(Console.ReadLine());

            double wine = squareMetersVineyard * grapesOneSquareMeter * 0.4 / 2.5;

            if (wine >= neededLitersWine)
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");
                Console.WriteLine($"{Math.Ceiling(wine - neededLitersWine)} liters left -> {Math.Ceiling((wine - neededLitersWine) / numWorkers)} liters per person.");
            }
            else
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(neededLitersWine - wine)} liters wine needed.");
            }
        }
    }
}
