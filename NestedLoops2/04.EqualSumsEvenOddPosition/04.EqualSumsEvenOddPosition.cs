using System;

namespace _04.EqualSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            for (int i = num; i < num2; i++)
            {
                num = i;
                int oddPositionSum = 0;
                int evenPositionSum = 0;

                for (int j = 1; j <= 6; j++)
                {
                    int n = num % 10;

                    if (j % 2 == 1)
                    {
                        oddPositionSum += n;
                    }
                    else
                    {
                        evenPositionSum += n;
                    }

                    num /= 10;
                }

                if (oddPositionSum == evenPositionSum)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
