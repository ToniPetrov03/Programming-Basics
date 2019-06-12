using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string summerOrWinter = Console.ReadLine();

            string place = string.Empty;
            string campOrHotel = string.Empty;
            double spentAmount = 0;

            if (budget <= 100)
            {
                place = "Bulgaria";
                if (summerOrWinter == "summer")
                {
                    spentAmount = budget * 0.3;
                    campOrHotel = "Camp";
                }
                else
                {
                    spentAmount = budget * 0.7;
                    campOrHotel = "Hotel";
                }
            }
            else if (budget <= 1000)
            {
                place = "Balkans";
                if (summerOrWinter == "summer")
                {
                    spentAmount = budget * 0.4;
                    campOrHotel = "Camp";
                }
                else
                {
                    spentAmount = budget * 0.8;
                    campOrHotel = "Hotel";
                }
            }
            else if (budget > 1000)
            {
                place = "Europe";
                campOrHotel = "Hotel";
                spentAmount = budget * 0.9;
            }
            Console.WriteLine($"Somewhere in {place}");
            Console.WriteLine($"{campOrHotel} - {spentAmount:F2}");
        }
    }
}
