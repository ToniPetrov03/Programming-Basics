using System;

namespace _05.Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            double numNumbers = double.Parse(Console.ReadLine());

            int numbersBiggerThan800 = 0;
            int numbersBiggerThan600 = 0;
            int numbersBiggerThan400 = 0;
            int numbersBiggerThan200 = 0;
            int numbersBiggerThan0 = 0;

            for (int i = 0; i < numNumbers; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num >= 800)
                {
                    numbersBiggerThan800++;
                }
                else if (num >= 600)
                {
                    numbersBiggerThan600++;
                }
                else if (num >= 400)
                {

                    numbersBiggerThan400++;
                }
                else if (num >= 200)
                {
                    numbersBiggerThan200++;
                }
                else if (num > 0)
                {
                    numbersBiggerThan0++;
                }
            }

            Console.WriteLine($"{numbersBiggerThan0 / numNumbers * 100:F2}%");
            Console.WriteLine($"{numbersBiggerThan200 / numNumbers * 100:F2}%");
            Console.WriteLine($"{numbersBiggerThan400 / numNumbers * 100:F2}%");
            Console.WriteLine($"{numbersBiggerThan600 / numNumbers * 100:F2}%");
            Console.WriteLine($"{numbersBiggerThan800 / numNumbers * 100:F2}%");
        }
    }
}
