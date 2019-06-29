using System;

namespace _04.EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int counter = 0;
            int firstPairSum = 0;
            int secondPairSum = 0;
            int maxDiff = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());

                if (counter == 0)
                {
                    firstPairSum = num + num2;
                }
                else if (counter == 1)
                {
                    secondPairSum = num + num2;

                    if (Math.Abs(firstPairSum - secondPairSum) > maxDiff)
                    {
                        maxDiff = Math.Abs(firstPairSum - secondPairSum);
                    }

                    firstPairSum = secondPairSum;
                    counter = 0;
                }

                counter++;
            }

            if (maxDiff == 0)
            {
                Console.WriteLine($"Yes, value={firstPairSum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxDiff}");
            }
        }
    }
}
