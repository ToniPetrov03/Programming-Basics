using System;

namespace _08.Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double averageSuccess = double.Parse(Console.ReadLine());
            double minWage = double.Parse(Console.ReadLine());

            if (minWage > income && averageSuccess >= 5.50)
            {
                if (averageSuccess * 25 >= minWage * 0.35)
                {
                    Console.WriteLine("You get a scholarship for exellent result {0} BGN", Math.Floor(averageSuccess * 25));
                }
                else
                {
                    Console.WriteLine("You get a Social scholarship {0} BGN", Math.Floor(minWage * 0.35));
                }
            }
            else if (minWage > income && averageSuccess > 4.50)
            {
                Console.WriteLine("You get a Social scholarship {0} BGN", Math.Floor(minWage * 0.35));
            }
            else if (averageSuccess >= 5.50)
            {
                Console.WriteLine("You get a scholarship for exellent result {0} BGN", Math.Floor(averageSuccess * 25));
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}
