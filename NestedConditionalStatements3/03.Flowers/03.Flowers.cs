using System;

namespace _03.Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numChrysanthemums = int.Parse(Console.ReadLine());
            int numRoses = int.Parse(Console.ReadLine());
            int numTulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string yesOrNoHoliday = Console.ReadLine();

            const double arranging = 2;
            double chrysanthemumsSpringSummer = 2;
            double chrysanthemumsAutumnWinter = 3.75;
            double rosesSpringSummer = 4.1;
            double rosesAutumnWinter = 4.5;
            double tulipsSpringSummer = 2.5;
            double tulipsAutumnWinter = 4.15;
            double price = 0;

            if (season == "Spring" || season == "Summer")
            {
                price += numChrysanthemums * chrysanthemumsSpringSummer;
                price += numRoses * rosesSpringSummer;
                price += numTulips * tulipsSpringSummer;
            }
            else if (season == "Autumn" || season == "Winter")
            {
                price += numChrysanthemums * chrysanthemumsAutumnWinter;
                price += numRoses * rosesAutumnWinter;
                price += numTulips * tulipsAutumnWinter;
            }

            if (yesOrNoHoliday == "Y")
            {
                price += price * 0.15;
            }

            if (season == "Spring" && numTulips > 7)
            {
                price -= price * 0.05;
            }
            else if (season == "Winter" && numRoses >= 10)
            {
                price -= price * 0.1;
            }

            if (numChrysanthemums + numRoses + numTulips > 20)
            {
                price -= price * 0.2;
            }

            Console.WriteLine("{0:F2}", price + arranging);
        }
    }
}
