using System;

namespace _09.MultiplyByTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());

            while (num >= 0)
            {
                Console.WriteLine($"Result: {num * 2:F2}");

                num = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Negative number!");
        }
    }
}
