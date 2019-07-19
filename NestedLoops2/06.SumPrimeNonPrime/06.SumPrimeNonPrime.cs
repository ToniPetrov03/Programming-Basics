using System;

namespace _06.SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            string numOrStop = Console.ReadLine();

            int sumPrime = 0;
            int sumNonPrime = 0;

            while (numOrStop != "stop")
            {
                int num = int.Parse(numOrStop);

                bool isPrime = true;

                if (num < 0)
                {
                    Console.WriteLine("Number is negative.");
                    numOrStop = Console.ReadLine();
                    continue;
                }

                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        sumNonPrime += num;
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    sumPrime += num;
                }

                numOrStop = Console.ReadLine();
            }

            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");
        }
    }
}
