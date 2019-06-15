using System;

namespace _07.OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            char sign = char.Parse(Console.ReadLine());

            string evenOrOdd = string.Empty;

            if (sign == '+')
            {
                if ((num1 + num2) % 2 == 0)
                {
                    evenOrOdd = "even";
                }
                else
                {
                    evenOrOdd = "odd";
                }
                Console.WriteLine($"{num1} + {num2} = {num1 + num2} - {evenOrOdd}");
            }
            else if (sign == '-')
            {
                if ((num1 - num2) % 2 == 0)
                {
                    evenOrOdd = "even";
                }
                else
                {
                    evenOrOdd = "odd";
                }
                Console.WriteLine($"{num1} - {num2} = {num1 - num2} - {evenOrOdd}");
            }
            else if (sign == '*')
            {
                if (num1 * num2 % 2 == 0)
                {
                    evenOrOdd = "even";
                }
                else
                {
                    evenOrOdd = "odd";
                }
                Console.WriteLine($"{num1} * {num2} = {num1 * num2} - {evenOrOdd}");
            }
            else if (sign == '/')
            {
                if (num2 == 0)
                {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                }
                else
                {
                    Console.WriteLine($"{num1} / {num2} = {num1 / num2:F2}");
                }
            }
            else if (sign == '%')
            {
                if (num2 == 0)
                {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                }
                else
                {
                    Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
                }
            }
        }
    }
}
