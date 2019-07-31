using System;

namespace _03.WorldSnookerChampionship
{
    class Program
    {
        static void Main(string[] args)
        {
            string stageOfChampionship = Console.ReadLine();
            string typeOfTicket = Console.ReadLine();
            int numTickets = int.Parse(Console.ReadLine());
            char YesOrNo = char.Parse(Console.ReadLine());

            double priceTicket = 0.0;

            switch (stageOfChampionship)
            {
                case "Quarter final":
                    switch (typeOfTicket)
                    {
                        case "Standard": priceTicket = 55.5; break;
                        case "Premium": priceTicket = 105.2; break;
                        case "VIP": priceTicket = 118.9; break;
                    }
                    break;

                case "Semi final":
                    switch (typeOfTicket)
                    {
                        case "Standard": priceTicket = 75.88; break;
                        case "Premium": priceTicket = 125.22; break;
                        case "VIP": priceTicket = 300.4; break;
                    }
                    break;

                case "Final":
                    switch (typeOfTicket)
                    {
                        case "Standard": priceTicket = 110.1; break;
                        case "Premium": priceTicket = 160.66; break;
                        case "VIP": priceTicket = 400; break;
                    }
                    break;
            }

            double totalPrice = priceTicket * numTickets;
            bool isFreeTicket = false;

            if (totalPrice > 4000)
            {
                totalPrice *= 0.75;
                isFreeTicket = true;
            }
            else if (totalPrice > 2500)
            {
                totalPrice *= 0.9;
            }

            if (YesOrNo == 'Y' && !isFreeTicket)
            {
                totalPrice += numTickets * 40;
            }

            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
