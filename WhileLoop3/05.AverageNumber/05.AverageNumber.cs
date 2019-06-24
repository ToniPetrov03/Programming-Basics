using System;

namespace _05.AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfNumber = int.Parse(Console.ReadLine());
            double sum = 0;

            for (int i = 0; i < numOfNumber; i++)
            {
                int num = int.Parse(Console.ReadLine());

                sum += num;
            }

            Console.WriteLine("{0:F2}", sum / numOfNumber);
        }
    }
}
