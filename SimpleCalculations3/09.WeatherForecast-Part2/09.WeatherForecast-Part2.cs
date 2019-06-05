using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.WeatherForecast_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            float degrees = float.Parse(Console.ReadLine());

            if (degrees < 5 || degrees > 35)
            {
                Console.WriteLine("unknown");
            }
            if (degrees >= 5 & degrees <= 11.9)
            {
                Console.WriteLine("Cold");
            }
            if (degrees >= 12 & degrees <= 14.9)
            {
                Console.WriteLine("Cool");
            }
            if (degrees >= 15 & degrees <= 20)
            {
                Console.WriteLine("Mild");
            }
            if (degrees >= 20.1 & degrees <= 25.9)
            {
                Console.WriteLine("Warm");
            }
            if (degrees >= 26 & degrees <= 35)
            {
                Console.WriteLine("Hot");
            }
        }
    }
}
