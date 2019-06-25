using System;

namespace _06.OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numNumbers = int.Parse(Console.ReadLine());

            int sumOddPositions = 0;
            int sumEvenPositions = 0;

            for (int i = 1; i <= numNumbers; i++)
            {
                int num =  int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    sumEvenPositions += num;
                }
                else
                {
                    sumOddPositions += num;
                }
            }

            if (sumOddPositions == sumEvenPositions)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sumOddPositions}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sumOddPositions - sumEvenPositions)}");
            }
        }
    }
}
