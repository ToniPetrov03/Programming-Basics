using System;

namespace _05.Time_15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int startHour = int.Parse(Console.ReadLine());
            int startMinutes = int.Parse(Console.ReadLine());

            int timeInMinutes = startHour * 60 + startMinutes;
            int timePlus15 = timeInMinutes + 15;
            int finalHour = timePlus15 / 60;
            int finalMinutes = timePlus15 % 60;

            if (finalHour >= 24)
            {
                finalHour -= 24;
            }
            if (finalMinutes < 10)
            {
                Console.WriteLine("{0}:0{1}", finalHour, finalMinutes);
            }
            else
            {
                Console.WriteLine("{0}:{1}", finalHour, finalMinutes);
            }
        }
    }
}
