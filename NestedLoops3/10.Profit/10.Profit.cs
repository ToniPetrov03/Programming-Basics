using System;

namespace _10.Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int numCoinsOfOneLeva = int.Parse(Console.ReadLine());
            int numCoinsOfTwoLeva = int.Parse(Console.ReadLine());
            int numCoinsOfFiveLeva = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());

            for (int i = 0; i <= numCoinsOfOneLeva; i++)
            {
                for (int j = 0; j <= numCoinsOfTwoLeva; j++)
                {
                    for (int k = 0; k <= numCoinsOfFiveLeva; k++)
                    {
                        if (sum == i + j * 2 + k * 5)
                        {
                            Console.WriteLine($"{i} * 1 lv. + {j} * 2 lv. + {k} * 5 lv. = {sum} lv.");
                        }
                    }
                }
            }
        }
    }
}
