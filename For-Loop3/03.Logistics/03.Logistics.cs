using System;

namespace _03.Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int numGoods = int.Parse(Console.ReadLine());

            const int moneyForTonTo3tons = 200;
            const int moneyForTonTo11tons = 175;
            const int moneyForTonMoreThan11tons = 120;
            double totalTons = 0d;
            int money = 0;
            int totalTonsTo3tons = 0;
            int totalTonsTo11tons = 0;
            int totalTonsMoreThan11tons = 0;

            for (int i = 0; i < numGoods; i++)
            {
                int tons = int.Parse(Console.ReadLine());

                if (tons <= 3)
                {
                    money += tons * moneyForTonTo3tons;
                    totalTonsTo3tons += tons;
                }
                else if (tons <= 11)
                {
                    money += tons * moneyForTonTo11tons;
                    totalTonsTo11tons += tons;
                }
                else if (tons > 11)
                {
                    money += tons * moneyForTonMoreThan11tons;
                    totalTonsMoreThan11tons += tons;
                }

                totalTons += tons;
            }

            Console.WriteLine($"{money / totalTons:F2}");
            Console.WriteLine($"{totalTonsTo3tons / totalTons * 100:F2}%");
            Console.WriteLine($"{totalTonsTo11tons / totalTons * 100:F2}%");
            Console.WriteLine($"{totalTonsMoreThan11tons / totalTons * 100:F2}%");
        }
    }
}
