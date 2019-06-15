using System;

namespace _08.HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int numNights = int.Parse(Console.ReadLine());

            double studio = 0;
            double apartment = 0;
            const double nightMayOrOctStudio = 50;
            const double nightMayOrOctApartment = 65;
            const double nightJuneOrSepStudio = 75.2;
            const double nightJuneOrSepApartment = 68.7;
            const double nightJulyOrAugustStudio = 76;
            const double nightJulyOrAugustApartment = 77;

            if (month == "May" || month == "October")
            {
                studio = nightMayOrOctStudio * numNights;
                apartment = nightMayOrOctApartment * numNights;

                if (numNights > 7 && numNights < 14)
                {
                    studio -= studio * 0.05;
                }
                else if (numNights > 14)
                {
                    studio -= studio * 0.3;
                    apartment -= apartment * 0.1;
                }
            }
            else if (month == "June" || month == "September")
            {
                studio = nightJuneOrSepStudio * numNights;
                apartment = nightJuneOrSepApartment * numNights;

                if (numNights > 14)
                {
                    studio -= studio * 0.2;
                    apartment -= apartment * 0.1;
                }
            }
            else if (month == "July" || month == "August")
            {
                studio = nightJulyOrAugustStudio * numNights;
                apartment = nightJulyOrAugustApartment * numNights;

                if (numNights > 14)
                {
                    apartment -= apartment * 0.1;
                }
            }
            Console.WriteLine($"Apartment: {apartment:F2} lv.");
            Console.WriteLine($"Studio: {studio:F2} lv.");
        }
    }
}
