using System;

namespace _05.GameOfIntervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int moves = int.Parse(Console.ReadLine());

            double score = 0;
            double numNumbersFrom0to9 = 0;
            double numNumbersFrom10to19 = 0;
            double numNumbersFrom20to29 = 0;
            double numNumbersFrom30to39 = 0;
            double numNumbersFrom40to50 = 0;
            double numInvalidNumbers = 0;

            for (int i = 0; i < moves; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num < 0 || num > 50)
                {
                    score /= 2;
                    numInvalidNumbers++;
                }
                else if (num < 10)
                {
                    score += num * 0.2;
                    numNumbersFrom0to9++;
                }
                else if (num < 20)
                {
                    score += num * 0.3;
                    numNumbersFrom10to19++;
                }
                else if (num < 30)
                {
                    score += num * 0.4;
                    numNumbersFrom20to29++;
                }
                else if (num < 40)
                {
                    score += 50;
                    numNumbersFrom30to39++;
                }
                else if (num <= 50)
                {
                    score += 100;
                    numNumbersFrom40to50++;
                }
            }

            Console.WriteLine($"{score:F2}");
            Console.WriteLine($"From 0 to 9: {numNumbersFrom0to9 / moves * 100:F2}%");
            Console.WriteLine($"From 10 to 19: {numNumbersFrom10to19 / moves * 100:F2}%");
            Console.WriteLine($"From 20 to 29: {numNumbersFrom20to29 / moves * 100:F2}%");
            Console.WriteLine($"From 30 to 39: {numNumbersFrom30to39 / moves * 100:F2}%");
            Console.WriteLine($"From 40 to 50: {numNumbersFrom40to50 / moves * 100:F2}%");
            Console.WriteLine($"Invalid numbers: {numInvalidNumbers / moves * 100:F2}%");
        }
    }
}
