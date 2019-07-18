using System;

namespace _01.Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            for (int firstRowFirstNum = a; firstRowFirstNum <= b; firstRowFirstNum++)
            {
                for (int firstRowSecondNum = a; firstRowSecondNum <= b; firstRowSecondNum++)
                {
                    for (int secondRowFirstNum = c; secondRowFirstNum <= d; secondRowFirstNum++)
                    {
                        for (int secondRowSecondNum = c; secondRowSecondNum <= d; secondRowSecondNum++)
                        {
                            bool isFirstAndSecondSumOfTheDiagonalsMatch = firstRowFirstNum + secondRowSecondNum == firstRowSecondNum + secondRowFirstNum;
                            bool isOnRowHasDifferentNumbers = firstRowFirstNum != firstRowSecondNum && secondRowFirstNum != secondRowSecondNum;

                            if (isFirstAndSecondSumOfTheDiagonalsMatch && isOnRowHasDifferentNumbers)
                            {
                                Console.WriteLine($"{firstRowFirstNum}{firstRowSecondNum}");
                                Console.WriteLine($"{secondRowFirstNum}{secondRowSecondNum}");
                                Console.WriteLine();
                            }
                        }
                    }
                }
            }
        }
    }
}
