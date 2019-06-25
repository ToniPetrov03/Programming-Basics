using System;

namespace _05.LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int numNumbers = 2 * n;
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < numNumbers; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (i < n)
                {
                    leftSum += num;
                }
                else
                {
                    rightSum += num;
                }
            }

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
