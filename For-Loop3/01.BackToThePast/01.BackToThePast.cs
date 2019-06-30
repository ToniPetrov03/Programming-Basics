using System;

namespace _01.BackToThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            double inheritedMoney = double.Parse(Console.ReadLine());
            int untilTheYearLiving = int.Parse(Console.ReadLine());

            const int moneyForYear = 12000;
            double spentMoney = 0;
            int age = 18;

            for (int theYearInThePast = 1800; theYearInThePast <= untilTheYearLiving; theYearInThePast++)
            {
                if (theYearInThePast % 2 == 0)
                {
                    spentMoney += moneyForYear;
                }
                else if (theYearInThePast % 2 == 1)
                {
                    spentMoney += moneyForYear + 50 * age;
                }

                age++;
            }

            if (inheritedMoney >= spentMoney)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {inheritedMoney - spentMoney:F2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {spentMoney - inheritedMoney:F2} dollars to survive.");
            }
        }
    }
}
