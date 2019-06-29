using System;

namespace _02.HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int numNumbers = int.Parse(Console.ReadLine());

            int maxNum = int.MinValue;
            int sum = 0;

            for (int i = 0; i < numNumbers; i++)
            {
                int num = int.Parse(Console.ReadLine());

                sum += num;

                if (num > maxNum)
                {
                    maxNum = num;
                }
            }

            sum -= maxNum;

            if (sum == maxNum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(maxNum - sum)}");
            }
        }
    }
}
