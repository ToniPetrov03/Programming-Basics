using System;

namespace _08.Fishing
{
    class Program
    {
        static void Main(string[] args)
        {
            int dailyQuota = int.Parse(Console.ReadLine());
            string nameFishOrStop = Console.ReadLine();

            int fishes = 0;
            double recivedMoney = 0;
            double givenMoney = 0;

            while (nameFishOrStop != "Stop" && dailyQuota > fishes)
            {
                double kg = double.Parse(Console.ReadLine());

                fishes++;

                int sumOfSymbols = 0;

                for (int i = 0; i < nameFishOrStop.Length; i++)
                {
                    int valueOfSymbol = nameFishOrStop[i];
                    sumOfSymbols += valueOfSymbol;
                }

                if (fishes % 3 == 0)
                {
                    recivedMoney += sumOfSymbols / kg;
                }
                else
                {
                    givenMoney += sumOfSymbols / kg;
                }

                nameFishOrStop = Console.ReadLine();
            }

            if (nameFishOrStop != "Stop")
            {
                Console.WriteLine("Lyubo fulfilled the quota!");
            }

            if (recivedMoney >= givenMoney)
            {
                Console.WriteLine($"Lyubo's profit from {fishes} fishes is {recivedMoney - givenMoney:F2} leva.");
            }
            else
            {
                Console.WriteLine($"Lyubo lost {givenMoney - recivedMoney:F2} leva today.");
            }
        }
    }
}
