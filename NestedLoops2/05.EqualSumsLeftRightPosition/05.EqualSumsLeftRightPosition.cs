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

                    switch (j)
                    {
                        case 1:
                        case 2: rightPositionSum += n; break;
                        case 3: middleNumber = n; break;
                        case 4:
                        case 5: leftPositionSum += n; break;
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
