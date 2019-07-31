using System;

namespace _07.SafePasswordsGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int maxNumberOfGeneratedPasswords = int.Parse(Console.ReadLine());

            char firstSymbol = '#';
            char secondSymbol = '@';
            int counter = 0;

            for (int firstNumber = 1; firstNumber <= a; firstNumber++)
            {
                for (int secondNumber = 1; secondNumber <= b; secondNumber++)
                {
                    counter++;
                    Console.Write($"{firstSymbol}{secondSymbol}{firstNumber}{secondNumber}{secondSymbol}{firstSymbol}|");

                    if (maxNumberOfGeneratedPasswords == counter)
                    {
                        Environment.Exit(0);
                    }

                    firstSymbol++;
                    secondSymbol++;

                    if (firstSymbol > 55)
                    {
                        firstSymbol = '#';
                    }
                    if (secondSymbol > 96)
                    {
                        secondSymbol = '@';
                    }
                }
            }
        }
    }
}
