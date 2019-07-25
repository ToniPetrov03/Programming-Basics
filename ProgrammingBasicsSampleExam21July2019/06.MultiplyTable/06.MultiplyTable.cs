using System;

namespace _06.MultiplyTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int firstDigit = num % 10;
            num /= 10;
            int secondDigit = num % 10;
            int thirdDigit = num / 10;

            for (int i = 1; i <= firstDigit; i++)
            {
                for (int j = 1; j <= secondDigit; j++)
                {
                    for (int k = 1; k <= thirdDigit; k++)
                    {
                        Console.WriteLine($"{i} * {j} * {k} = {i * j * k};");
                    }
                }
            }
        }
    }
}
