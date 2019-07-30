using System;

namespace _09.SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int serialNumber = 0;
            int counterOfAllCombinations = 0;

            for (int firstNumber = startNumber; firstNumber <= endNumber; firstNumber++)
            {
                for (int secondNumber = startNumber; secondNumber <= endNumber; secondNumber++)
                {
                    serialNumber++;

                    if (firstNumber + secondNumber == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{serialNumber} ({firstNumber} + {secondNumber} = {magicNumber})");
                        Environment.Exit(0);
                    }

                    counterOfAllCombinations++;
                }
            }

            Console.WriteLine($"{counterOfAllCombinations} combinations - neither equals {magicNumber}");
        }
    }
}
