using System;

namespace _07.SchoolCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string typeGroup = Console.ReadLine();
            int numStudents = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());

            const double nightBoysAndGirlsWinter = 9.6;
            const double nightBoysAndGirlsSpring = 7.2;
            const double nightBoysAndGirlsSummer = 15;
            const double nightMixedWinter = 10;
            const double nightMixedSpring = 9.5;
            const double nightMixedSummer = 20;

            string typeVacation = string.Empty;
            double price = 0;

            if (season == "Winter")
            {
                if (typeGroup == "girls")
                {
                    typeGroup = "Gymnastics";
                    price = nightBoysAndGirlsWinter * nights * numStudents;
                }
                else if (typeGroup == "boys")
                {
                    typeGroup = "Judo";
                    price = nightBoysAndGirlsWinter * nights * numStudents;
                }
                else if (typeGroup == "mixed")
                {
                    typeGroup = "Ski";
                    price = nightMixedWinter * nights * numStudents;
                }
            }
            else if (season == "Spring")
            {
                if (typeGroup == "girls")
                {
                    typeGroup = "Athletics";
                    price = nightBoysAndGirlsSpring * nights * numStudents;
                }
                else if (typeGroup == "boys")
                {
                    typeGroup = "Tennis";
                    price = nightBoysAndGirlsSpring * nights * numStudents;
                }
                else if (typeGroup == "mixed")
                {
                    typeGroup = "Cycling";
                    price = nightMixedSpring * nights * numStudents;
                }
            }
            else if (season == "Summer")
            {
                if (typeGroup == "girls")
                {
                    typeGroup = "Volleyball";
                    price = nightBoysAndGirlsSummer * nights * numStudents;
                }
                else if (typeGroup == "boys")
                {
                    typeGroup = "Football";
                    price = nightBoysAndGirlsSummer * nights * numStudents;
                }
                else if (typeGroup == "mixed")
                {
                    typeGroup = "Swimming";
                    price = nightMixedSummer * nights * numStudents;
                }
            }

            if (numStudents >= 50)
            {
                price -= price * 0.5;
            }
            else if (numStudents >= 20)
            {
                price -= price * 0.15;
            }
            else if (numStudents >= 10)
            {
                price -= price * 0.05;
            }

            Console.WriteLine($"{typeGroup} {price:F2} lv.");
        }
    }
}
