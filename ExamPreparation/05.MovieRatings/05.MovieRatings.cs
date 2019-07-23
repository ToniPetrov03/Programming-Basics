using System;

namespace _05.MovieRatings
{
    class Program
    {
        static void Main(string[] args)
        {
            int numFilms = int.Parse(Console.ReadLine());

            double highestRaiting = 1.0;
            string highestRaitingName = string.Empty;
            double lowestRaiting = 10.0;
            string lowestRaitingName = string.Empty;
            double sumRaitings = 0.0;

            for (int i = 0; i < numFilms; i++)
            {
                string filmName = Console.ReadLine();
                double filmRaiting = double.Parse(Console.ReadLine());

                if (filmRaiting > highestRaiting)
                {
                    highestRaitingName = filmName;
                    highestRaiting = filmRaiting;
                }
                if (filmRaiting < lowestRaiting)
                {
                    lowestRaitingName = filmName;
                    lowestRaiting = filmRaiting;
                }

                sumRaitings += filmRaiting;
            }

            Console.WriteLine($"{highestRaitingName} is with highest rating: {highestRaiting:F1}");
            Console.WriteLine($"{lowestRaitingName} is with lowest rating: {lowestRaiting:F1}");
            Console.WriteLine($"Average rating: {sumRaitings / numFilms:F1}");
        }
    }
}
