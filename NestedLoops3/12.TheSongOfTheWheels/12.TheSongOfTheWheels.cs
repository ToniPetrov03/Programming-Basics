using System;

namespace _12.TheSongOfTheWheels
{
    class Program
    {
        static void Main(string[] args)
        {
            int controlValue = int.Parse(Console.ReadLine());

            bool isFourthSpecialNumber = false;
            string fourtSpecialNumber = string.Empty;
            int counter = 0;

            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            if (a * b + c * d == controlValue && a < b && c > d)
                            {
                                Console.Write($"{a}{b}{c}{d} ");

                                counter++;

                                if (counter == 4)
                                {
                                    isFourthSpecialNumber = true;

                                    fourtSpecialNumber = $"Password: {a}{b}{c}{d}";
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine();

            if (isFourthSpecialNumber)
            {
                Console.WriteLine(fourtSpecialNumber);
            }
            else
            {
                Console.WriteLine("No!");
            }
        }
    }
}
