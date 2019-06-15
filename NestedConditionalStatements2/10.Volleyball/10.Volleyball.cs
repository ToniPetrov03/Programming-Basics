using System;

namespace _10.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string leapOrNormal = Console.ReadLine();
            int celebrationDays = int.Parse(Console.ReadLine());
            int daysInHometown = int.Parse(Console.ReadLine());

            int gameDaysInSofia = 48 - daysInHometown;
            double gameSaturdaysInSofia = gameDaysInSofia * 3.0 / 4;
            double gameInCelebrationDays = celebrationDays * 2.0 / 3;
            double totalGamesInCelebrationAndHometown = gameSaturdaysInSofia + gameInCelebrationDays + daysInHometown;

            if (leapOrNormal == "leap")
            {
                totalGamesInCelebrationAndHometown += totalGamesInCelebrationAndHometown * 0.15;
            }
            Console.WriteLine(Math.Floor(totalGamesInCelebrationAndHometown));
        }
    }
}
