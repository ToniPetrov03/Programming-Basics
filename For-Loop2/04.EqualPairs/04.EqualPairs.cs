using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.EqualPairs
{
    class Program
    {
        private static int PairSum(int n)
        {
            int sum = 0;
            int pairSum = 0;
            int counter = 0;
            int maxPairSum = 0;
            int minPairSum = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (counter < 2)
                {
                    sum += num;
                    pairSum = sum;
                    if (true)
                    {

                    }
                }
                else
                {
                    sum = 0;
                    sum += num;
                    counter = 0;
                }

                if (pairSum == sum)
                {
                    pairSum = 0;
                    sum = 0;
                }
                else
                {
                    Console.WriteLine($"No, maxdiff ");
                    break;
                }
                counter++;
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
        }
    }
}
