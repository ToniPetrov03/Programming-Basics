using System;

namespace _08.CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceWashingMachine = double.Parse(Console.ReadLine());
            int priceToy = int.Parse(Console.ReadLine());

            int moneyForYear = 10;
            int sumMoney = 0;
            int totalToys = 0;
            int takenMoney = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    sumMoney += moneyForYear;
                    moneyForYear += 10;
                    takenMoney++;
                }
                else
                {
                    totalToys++;
                }
            }

            int totalSum = sumMoney + totalToys * priceToy - takenMoney;

            if (totalSum >= priceWashingMachine)
            {
                Console.WriteLine($"Yes! {totalSum - priceWashingMachine:F2}");
            }
            else
            {
                Console.WriteLine($"No! {priceWashingMachine - totalSum:F2}");
            }
        }
    }
}
