using System;

namespace _08.SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOfStaying = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string positiveOrNegative = Console.ReadLine();

            int nigthsOfStaying = daysOfStaying - 1;
            const int pricePerNightRoomForOnePerson = 18;
            const int pricePerNightRoomApartment = 25;
            const int pricePerNightRoomPresidentApartment = 35;
            double priceOfStaying = 0;

            if (roomType == "room for one person")
            {
                priceOfStaying += pricePerNightRoomForOnePerson * nigthsOfStaying;
            }
            else if (roomType == "apartment")
            {
                if (nigthsOfStaying < 10)
                {
                    priceOfStaying += pricePerNightRoomApartment * nigthsOfStaying - pricePerNightRoomApartment * nigthsOfStaying * 0.3;
                }
                else if (nigthsOfStaying >= 10 && nigthsOfStaying <= 15)
                {
                    priceOfStaying += pricePerNightRoomApartment * nigthsOfStaying - pricePerNightRoomApartment * nigthsOfStaying * 0.35;
                }
                else if (nigthsOfStaying > 15)
                {
                    priceOfStaying += pricePerNightRoomApartment * nigthsOfStaying - pricePerNightRoomApartment * nigthsOfStaying * 0.5;
                }
            }
            else if (roomType == "president apartment")
            {
                if (nigthsOfStaying < 10)
                {
                    priceOfStaying += pricePerNightRoomPresidentApartment * nigthsOfStaying - pricePerNightRoomPresidentApartment * nigthsOfStaying * 0.1; 
                }
                else if (nigthsOfStaying >= 10 && nigthsOfStaying <= 15)
                {
                    priceOfStaying += pricePerNightRoomPresidentApartment * nigthsOfStaying - pricePerNightRoomPresidentApartment * nigthsOfStaying * 0.15;
                }
                else if (nigthsOfStaying > 15)
                {
                    priceOfStaying += pricePerNightRoomPresidentApartment * nigthsOfStaying - pricePerNightRoomPresidentApartment * nigthsOfStaying * 0.2;
                }
            }
            if (positiveOrNegative == "positive")
            {
                priceOfStaying += priceOfStaying * 0.25;
            }
            else
            {
                priceOfStaying -= priceOfStaying * 0.1;
            }
            Console.WriteLine("{0:F2}", priceOfStaying);
        }
    }
}
