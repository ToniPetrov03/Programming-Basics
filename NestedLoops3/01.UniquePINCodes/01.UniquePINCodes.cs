using System;

namespace _01.UniquePINCodes
{
    class Program
    {
        static bool isPrime(int number)
        {
            bool result = true;

            if (number == 1)
            {
                return false;
            }

            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    break;
                }
            }

            return result;
        }
        static void Main(string[] args)
        {
            int theUpperLimitOfTheFirstNumber = int.Parse(Console.ReadLine());
            int theUpperLimitOfTheSecondNumber = int.Parse(Console.ReadLine());
            int theUpperLimitOfTheThirdNumber = int.Parse(Console.ReadLine());

            for (int firstNumber = 2; firstNumber <= theUpperLimitOfTheFirstNumber; firstNumber += 2)
            {
                for (int secondNumber = 2; secondNumber <= theUpperLimitOfTheSecondNumber; secondNumber++)
                {
                    if (!isPrime(secondNumber))
                    {
                        continue;
                    }

                    for (int thirdNumber = 2; thirdNumber <= theUpperLimitOfTheThirdNumber; thirdNumber += 2)
                    {
                        Console.WriteLine($"{firstNumber} {secondNumber} {thirdNumber}");
                    }
                }
            }
        }
    }
}
