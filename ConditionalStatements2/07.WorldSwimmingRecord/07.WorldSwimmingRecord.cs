using System;

namespace _07.WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double timeMeter = double.Parse(Console.ReadLine());


            double timeSwim = meters * timeMeter;
            double timeLost = Math.Floor(meters / 15) * 12.5;
            double totalTime = timeSwim + timeLost;

            if (totalTime < record)
            {
                Console.WriteLine("Yes, he succeeded! The new world record is {0:F2} seconds.", totalTime);
            }
            else
            {
                Console.WriteLine("No, he failed! He was {0:F2} seconds slower.", totalTime - record);
            }
        }
    }
}
