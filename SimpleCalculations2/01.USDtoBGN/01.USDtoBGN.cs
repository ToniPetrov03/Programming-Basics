using System;

namespace _01.USDtoBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double USD = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:F2}", USD * 1.79549);
        }
    }
}
