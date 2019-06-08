using System;

namespace _05.Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int neededHours = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int numWorkersOvertime = int.Parse(Console.ReadLine());

            double hoursWorkers = (days - days * 0.1) * 8;
            double hoursWorkersOvertime = numWorkersOvertime * 2 * days;
            double allHours = Math.Floor(hoursWorkers + hoursWorkersOvertime);

            if (allHours >= neededHours)
            {
                Console.WriteLine($"Yes!{allHours - neededHours} hours left.");
            }
            else
            {
                Console.WriteLine($"Not enough time!{neededHours - allHours} hours needed.");
            }
        }
    }
}
