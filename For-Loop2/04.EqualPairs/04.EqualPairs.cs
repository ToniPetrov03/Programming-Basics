using System;

namespace _04.EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numNumbers = int.Parse(Console.ReadLine()) * 2;

            int sum = 0;
            int counter = 1;
            int maxPairSum = int.MinValue;
            int minPairSum = int.MaxValue;

            for (int i = 0; i < numNumbers; i++)
            {
                int num = int.Parse(Console.ReadLine());

                sum += num;

                if (counter == 2)
                {
                    if (maxPairSum < sum)
                    {
                        maxPairSum = sum;
                    }

                    if (minPairSum > sum)
                    {
                        minPairSum = sum;
                    }

                    sum = 0;
                    counter = 0;
                }

                counter++;
            }

            if (maxPairSum - minPairSum == 0)
            {
                Console.WriteLine($"Yes, value={maxPairSum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxPairSum - minPairSum}");
            }
        }
    }
}
