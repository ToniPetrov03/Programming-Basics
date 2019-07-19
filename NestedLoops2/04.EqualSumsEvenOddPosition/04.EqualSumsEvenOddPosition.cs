using System;

namespace _04.EqualSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            for (int i = startNum; i <= endNum; i++)
            {
                int oddPositionSum = 0;
                int evenPositionSum = 0;
                int currentNum = i;

                for (int j = 1; j <= 6; j++)
                {
                    int n = currentNum % 10;
                    currentNum /= 10;

                    if (j % 2 == 1)
                    {
                        oddPositionSum += n;
                    }
                    else
                    {
                        evenPositionSum += n;
                    }
                }

                if (oddPositionSum == evenPositionSum)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
