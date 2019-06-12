using System;

namespace _02.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeProjection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            const double premiere = 12;
            const double normal = 7.5;
            const double discount = 5;
            double income = 0;

            if (typeProjection == "Premiere")
            {
                income = rows * columns * premiere;
            }
            else if (typeProjection == "Normal")
            {
                income = rows * columns * normal;
            }
            else if (typeProjection == "Discount")
            {
                income = rows * columns * discount;
            }
            Console.WriteLine("{0:F2}", income);
        }
    }
}
