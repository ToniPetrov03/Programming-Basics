using System;

namespace _09.Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double litersAquarium = (length * width * height) * 0.001;

            Console.WriteLine("{0:F3}", litersAquarium * (1 - percent * 0.01));
        }
    }
}
