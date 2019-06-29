using System;

namespace _06.DivideWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            double numNumbers = double.Parse(Console.ReadLine());

            int numbersDividedBy2 = 0;
            int numbersDividedBy3 = 0;
            int numbersDividedBy4 = 0;

            for (int i = 0; i < numNumbers; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    numbersDividedBy2++;
                }

                if (num % 3 == 0)
                {
                    numbersDividedBy3++;
                }

                if (num % 4 == 0)
                {
                    numbersDividedBy4++;
                }
            }

            Console.WriteLine($"{numbersDividedBy2 / numNumbers * 100:F2}%");
            Console.WriteLine($"{numbersDividedBy3 / numNumbers * 100:F2}%");
            Console.WriteLine($"{numbersDividedBy4 / numNumbers * 100:F2}%");
        }
    }
}
