using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string vipOrNormal = Console.ReadLine();
            int numPeople = int.Parse(Console.ReadLine());

            const double normalTicket = 249.99;
            const double vipTicket = 499.99;
            double priceTickets = 0;

            if (numPeople >= 1 && numPeople <= 4)
            {
                budget -= budget * 0.75;
            }
            else if (numPeople >= 5 && numPeople <= 9)
            {
                budget -= budget * 0.6;
            }
            else if (numPeople >= 10 && numPeople <= 24)
            {
                budget -= budget * 0.5;
            }
            else if (numPeople >= 25 && numPeople <= 49)
            {
                budget -= budget * 0.4;
            }
            else if (numPeople >= 50)
            {
                budget -= budget * 0.25;
            }

            if (vipOrNormal == "Normal")
            {
                priceTickets = normalTicket * numPeople;
            }
            else if (vipOrNormal == "VIP")
            {
                priceTickets = vipTicket * numPeople;
            }

            if (budget >= priceTickets)
            {
                Console.WriteLine($"Yes! You have {budget - priceTickets:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {priceTickets - budget:F2} leva.");
            }
        }
    }
}
