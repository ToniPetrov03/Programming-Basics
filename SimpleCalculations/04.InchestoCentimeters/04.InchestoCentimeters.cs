using System;

namespace _04.InchestoCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            double inche = double.Parse(Console.ReadLine());
            double cen = inche * 2.54;

            Console.WriteLine("{0:F2}", cen);
        }
    }
}
