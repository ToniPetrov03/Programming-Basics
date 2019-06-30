using System;

namespace _03.Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int numGoods = int.Parse(Console.ReadLine());

            const int moneyForTonTo3Tons = 200;
            const int moneyForTonTo11Tons = 175;
            const int moneyForTonMoreThan11Tons = 120;

            int money = 0;
            double totalTons = 0d;
            int totalTonsTo3Tons = 0;
            int totalTonsTo11Tons = 0;
            int totalTonsMoreThan11Tons = 0;

            for (int i = 0; i < numGoods; i++)
            {
                int tons = int.Parse(Console.ReadLine());

                if (tons <= 3)
                {
                    money += tons * moneyForTonTo3Tons;
                    totalTonsTo3Tons += tons;
                }
                else if (tons <= 11)
                {
                    money += tons * moneyForTonTo11Tons;
                    totalTonsTo11Tons += tons;
                }
                else
                {
                    money += tons * moneyForTonMoreThan11Tons;
                    totalTonsMoreThan11Tons += tons;
                }

                totalTons += tons;
            }

            Console.WriteLine($"{money / totalTons:F2}");
            Console.WriteLine($"{totalTonsTo3Tons / totalTons * 100:F2}%");
            Console.WriteLine($"{totalTonsTo11Tons / totalTons * 100:F2}%");
            Console.WriteLine($"{totalTonsMoreThan11Tons / totalTons * 100:F2}%");
        }
    }
}
