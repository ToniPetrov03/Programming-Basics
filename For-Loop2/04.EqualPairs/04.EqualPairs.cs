using System;

namespace _04.EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int maxDiff = 0;
            int diff = 0;
            int oldSum = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());

                int sum = num + num2;

                if (i > 0)
                {
                    diff = Math.Abs(sum - oldSum);
                }

                if (maxDiff < diff)
                {
                    maxDiff = diff;
                }

                oldSum = sum;
            }

            if (maxDiff == 0)
            {
                Console.WriteLine($"Yes, value={oldSum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxDiff}");
            }
        }
    }
}
