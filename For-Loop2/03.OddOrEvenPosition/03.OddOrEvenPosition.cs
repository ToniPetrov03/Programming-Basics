using System;

namespace _03.OddOrEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int numNumbers = int.Parse(Console.ReadLine());

            double oddPositionSum = 0.00;
            double? oddPositionMin = null;
            double? oddPositionMax = null;
            double evenPositionSum = 0.00;
            double? evenPositionMin = null;
            double? evenPositionMax = null;

            for (int i = 1; i <= numNumbers; i++)
            {
                double num = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenPositionSum += num;

                    if (num < evenPositionMin || evenPositionMin == null)
                    {
                        evenPositionMin = num;
                    }
                    if (num > evenPositionMax || evenPositionMax == null)
                    {
                        evenPositionMax = num;
                    }
                }
                else
                {
                    oddPositionSum += num;

                    if (num < oddPositionMin || oddPositionMin == null)
                    {
                        oddPositionMin = num;
                    }
                    if (num > oddPositionMax || oddPositionMax == null)
                    {
                        oddPositionMax = num;
                    }
                }
            }

            Console.WriteLine($"OddSum={oddPositionSum:F2},");

            if (oddPositionMin == null)
                Console.WriteLine("OddMin=No,");
            else
            Console.WriteLine($"OddMin={oddPositionMin:F2},");

            if (oddPositionMax == null)
                Console.WriteLine("OddMax=No,");
            else
            Console.WriteLine($"OddMax={oddPositionMax:F2},");

            Console.WriteLine($"EvenSum={evenPositionSum:F2},");

            if (evenPositionMin == null)
                Console.WriteLine("EvenMin=No,");
            else
                Console.WriteLine($"EvenMin={evenPositionMin:F2},");

            if (evenPositionMax == null)
                Console.WriteLine("EvenMax=No");
            else
                Console.WriteLine($"EvenMax={evenPositionMax:F2}");
        }
    }
}
