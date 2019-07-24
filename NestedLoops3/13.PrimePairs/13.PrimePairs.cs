using System;

namespace _13.PrimePairs
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
            int startValueOfFirstPair = int.Parse(Console.ReadLine());
            int startValueOfSecondPair = int.Parse(Console.ReadLine());
            int differenceOfStartAndEndValueOfFirstPair = int.Parse(Console.ReadLine());
            int differenceOfStartAndEndValueOfSecondPair = int.Parse(Console.ReadLine());

            for (int firstPair = startValueOfFirstPair; firstPair <= startValueOfFirstPair + differenceOfStartAndEndValueOfFirstPair; firstPair++)
            {
                for (int secondPair = startValueOfSecondPair; secondPair <= startValueOfSecondPair + differenceOfStartAndEndValueOfSecondPair; secondPair++)
                {
                    if (isPrime(firstPair) && isPrime(secondPair))
                    {
                        Console.WriteLine($"{firstPair}{secondPair}");
                    }
                }
            }
        }
    }
}
