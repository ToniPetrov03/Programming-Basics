using System;

namespace _04.CarNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());

            for (int firstNumber = startNumber; firstNumber <= endNumber; firstNumber++)
            {
                for (int secondNumber = startNumber; secondNumber <= endNumber; secondNumber++)
                {
                    for (int thirdNumber = startNumber; thirdNumber <= endNumber; thirdNumber++)
                    {
                        int sumOfSecondAndThirdNumbers = secondNumber + thirdNumber;

                        if (sumOfSecondAndThirdNumbers % 2 != 0)
                        {
                            continue;
                        }

                        for (int fourthNumber = startNumber; fourthNumber <= endNumber; fourthNumber++)
                        {
                            if (firstNumber % 2 == 0 && fourthNumber % 2 == 0)
                            {
                                continue;
                            }
                            else if (firstNumber % 2 == 1 && fourthNumber % 2 == 1)
                            {
                                continue;
                            }
                            else if (fourthNumber >= firstNumber)
                            {
                                continue;
                            }

                            Console.Write($"{firstNumber}{secondNumber}{thirdNumber}{fourthNumber} ");
                        }
                    }
                }
            }
        }
    }
}
