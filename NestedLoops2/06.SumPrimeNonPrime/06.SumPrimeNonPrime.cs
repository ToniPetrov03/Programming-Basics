using System;

namespace _06.SumPrimeNonPrime
{
    class Program
    {
        static bool IsPrime(int num)
        {
            bool isPrime = true;

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            return isPrime;
        }
        static void Main(string[] args)
        {
            int sumPrime = 0;
            int sumNonPrime = 0;

            while (true)
            {
                string numOrStop = Console.ReadLine();

                if (numOrStop == "stop")
                {
                    break;
                }

                int num = int.Parse(numOrStop);

                if (num < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }

                if (IsPrime(num))
                {
                    sumPrime += num;
                }
                else
                {
                    sumNonPrime += num;
                }
            }

            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");
        }
    }
}