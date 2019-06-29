using System;

namespace _03.OddOrEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int numNumbers = int.Parse(Console.ReadLine());

            double oddPositionSum = 0d;
            double oddPositionMin = double.MaxValue;
            double oddPositionMax = double.MinValue;
            double evenPositionSum = 0d;
            double evenPositionMin = double.MaxValue;
            double evenPositionMax = double.MinValue;
            bool hasEven = false;
            bool hasOdd = false;

            for (int i = 1; i <= numNumbers; i++)
            {
                double num = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    hasEven = true;
                    evenPositionSum += num;

                    if (num < evenPositionMin)
                    {
                        evenPositionMin = num;
                    }

                    if (num > evenPositionMax)
                    {
                        evenPositionMax = num;
                    }
                }
                else
                {
                    hasOdd = true;
                    oddPositionSum += num;

                    if (num < oddPositionMin)
                    {
                        oddPositionMin = num;
                    }

                    if (num > oddPositionMax)
                    {
                        oddPositionMax = num;
                    }
                }
            }

            Console.WriteLine($"OddSum={oddPositionSum:F2},");

            if (hasOdd)
            {
                Console.WriteLine($"OddMin={oddPositionMin:F2},");
                Console.WriteLine($"OddMax={oddPositionMax:F2},");
            }
            else
            {
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
            }

            Console.WriteLine($"EvenSum={evenPositionSum:F2},");

            if (hasEven)
            {
                Console.WriteLine($"EvenMin={evenPositionMin:F2},");
                Console.WriteLine($"EvenMax={evenPositionMax:F2}");
            }
            else
            {
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
        }
    }
}
