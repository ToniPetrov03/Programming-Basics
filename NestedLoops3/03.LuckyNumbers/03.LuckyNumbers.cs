using System;

namespace _03.LuckyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int firstNumber = 1; firstNumber <= 9; firstNumber++)
            {
                int sumOfFirstTwoNumbers = 0;

                for (int secondNumber = 1; secondNumber <= 9; secondNumber++)
                {
                    sumOfFirstTwoNumbers = firstNumber + secondNumber;

                    for (int thirdNumber = 1; thirdNumber <= 9; thirdNumber++)
                    {
                        int sumOfSecondTwoNumbers = 0;

                        for (int fourthNumber = 1; fourthNumber <= 9; fourthNumber++)
                        {
                            sumOfSecondTwoNumbers = thirdNumber + fourthNumber;

                            if (sumOfFirstTwoNumbers == sumOfSecondTwoNumbers && n % sumOfFirstTwoNumbers == 0)
                            {
                                Console.Write($"{firstNumber}{secondNumber}{thirdNumber}{fourthNumber} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
