using System;

namespace _05.EqualSumsLeftRightPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            for (int i = startNum; i <= endNum; i++)
            {
                int leftPositionSum = 0;
                int rightPositionSum = 0;
                int middleNumber = 0;
                int currentNum = i;

                for (int j = 1; j <= 5; j++)
                {
                    int n = currentNum % 10;
                    currentNum /= 10;

                    if (j % 5 == 0 || j % 4 == 0)
                    {
                        leftPositionSum += n;
                    }
                    else if (j % 3 == 0)
                    {
                        middleNumber = n;
                    }
                    else if (j % 2 == 0 || j % 1 == 0)
                    {
                        rightPositionSum += n;
                    }
                }

                if (leftPositionSum == rightPositionSum)
                {
                    Console.Write(i + " ");
                }
                else
                {
                    if (leftPositionSum > rightPositionSum)
                    {
                        rightPositionSum += middleNumber;
                    }
                    else
                    {
                        leftPositionSum += middleNumber;
                    }
                    if (leftPositionSum == rightPositionSum)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
        }
    }
}
