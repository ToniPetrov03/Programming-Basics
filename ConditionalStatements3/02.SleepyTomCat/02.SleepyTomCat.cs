using System;

namespace _02.SleepyTomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int holidays = int.Parse(Console.ReadLine());

            int minutesPlayHolidays = holidays * 127;
            int minutesPlayWorkingDays = (365 - holidays) * 63;

            if (30000 > minutesPlayHolidays + minutesPlayWorkingDays)
            {
                int allMinutesRemain = 30000 - (minutesPlayHolidays + minutesPlayWorkingDays);
                int hours = allMinutesRemain / 60;
                int minutes = allMinutesRemain % 60;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
            }
            else if (30000 < minutesPlayHolidays + minutesPlayWorkingDays)
            {
                int allMinutesMore = minutesPlayHolidays + minutesPlayWorkingDays - 30000;
                int hours = allMinutesMore / 60;
                int minutes = allMinutesMore % 60;

                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
            }
        }
    }
}
