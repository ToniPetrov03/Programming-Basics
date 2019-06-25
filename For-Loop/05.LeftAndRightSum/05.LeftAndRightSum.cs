using System;

namespace _05.LeftAndRightSum
{
    class Program
    {
        private static int SumUserInput(int n)
        {
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
            }

            return sum;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int leftSum = SumUserInput(n);
            int rightSum = SumUserInput(n);

            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightSum)}");
            }
        }
    }
}
