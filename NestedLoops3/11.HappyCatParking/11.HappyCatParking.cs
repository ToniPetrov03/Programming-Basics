using System;

namespace _11.HappyCatParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int numDays = int.Parse(Console.ReadLine());
            int numOfHoursForEachOfTheDays = int.Parse(Console.ReadLine());

            const double priceForEvenDayAndOddHour = 2.5;
            const double priceForOddDayAndEvenHour = 1.25;
            const double priceForAllOtherCases = 1;

            double totalSumForAllDays = 0;

            for (int day = 1; day <= numDays; day++)
            {
                double totalSumForTheDay = 0;

                for (int hour = 1; hour <= numOfHoursForEachOfTheDays; hour++)
                {
                    if (day % 2 == 0 && hour % 2 == 1)
                    {
                        totalSumForTheDay += priceForEvenDayAndOddHour;
                    }
                    else if (day % 2 == 1 && hour % 2 == 0)
                    {
                        totalSumForTheDay += priceForOddDayAndEvenHour;
                    }
                    else
                    {
                        totalSumForTheDay += priceForAllOtherCases;
                    }
                }

                Console.WriteLine($"Day: {day} - {totalSumForTheDay:F2} leva");

                totalSumForAllDays += totalSumForTheDay;
            }

            Console.WriteLine($"Total: {totalSumForAllDays:F2} leva");
        }
    }
}
