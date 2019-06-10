using System;

namespace _02.SleepyTomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int holidays = int.Parse(Console.ReadLine());

            int minutesPlayHolidays = holidays * 127;
            int workingDays = 365 - holidays;
            int minutesPlayWorkingDays = workingDays * 63;

            const int minutesPerYear = 30000;

            if (minutesPerYear > minutesPlayHolidays + minutesPlayWorkingDays)
            {
                int allMinutesRemain = minutesPerYear - (minutesPlayHolidays + minutesPlayWorkingDays);
                int hours = allMinutesRemain / 60;
                int minutes = allMinutesRemain % 60;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
            }
            else if (minutesPerYear < minutesPlayHolidays + minutesPlayWorkingDays)
            {
                int allMinutesMore = minutesPlayHolidays + minutesPlayWorkingDays - minutesPerYear;
                int hours = allMinutesMore / 60;
                int minutes = allMinutesMore % 60;

                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
            }
        }
    }
}
