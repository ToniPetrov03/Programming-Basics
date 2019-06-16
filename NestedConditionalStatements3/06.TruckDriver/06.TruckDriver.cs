using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.TruckDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kilometersPerMonth = double.Parse(Console.ReadLine());

            const double priceKmSpringAutumnLess5000 = 0.75;
            const double priceKmSpringAutumnLess10000 = 0.95;
            const double priceKmSummerLess5000 = 0.9;
            const double priceKmSummerLess10000 = 1.1;
            const double priceKmWinterLess5000 = 1.05;
            const double priceKmWinterLess10000 = 1.25;
            const double priceKmLess20000 = 1.45;
            const int month = 4;
            const double tax = 0.9;
            double salary = 0;

            if (kilometersPerMonth > 0 && kilometersPerMonth <= 5000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    salary = priceKmSpringAutumnLess5000 * kilometersPerMonth * month * tax;
                }
                else if (season == "Summer")
                {
                    salary = priceKmSummerLess5000 * kilometersPerMonth * month * tax;
                }
                else if (season == "Winter")
                {
                    salary = priceKmWinterLess5000 * kilometersPerMonth * month * tax;
                }
            }
            else if (kilometersPerMonth > 5000 && kilometersPerMonth <= 10000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    salary = priceKmSpringAutumnLess10000 * kilometersPerMonth * month * tax;
                }
                else if (season == "Summer")
                {
                    salary = priceKmSummerLess10000 * kilometersPerMonth * month * tax;
                }
                else if (season == "Winter")
                {
                    salary = priceKmWinterLess10000 * kilometersPerMonth * month * tax;
                }
            }
            else if (kilometersPerMonth > 10000 && kilometersPerMonth <= 20000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    salary = priceKmLess20000 * kilometersPerMonth * month * tax;
                }
                else if (season == "Summer")
                {
                    salary = priceKmLess20000 * kilometersPerMonth * month * tax;
                }
                else if (season == "Winter")
                {
                    salary = priceKmLess20000 * kilometersPerMonth * month * tax;
                }
            }

            Console.WriteLine("{0:F2}", salary);
        }
    }
}
