using System;

namespace _02.BikeRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int numJuniorsCyclist = int.Parse(Console.ReadLine());
            int numSeniorsCyclist = int.Parse(Console.ReadLine());
            string typeOfRoute = Console.ReadLine();

            const double trailFeeJunior = 5.5;
            double crosscountryFeeJunior = 8;
            const double downhillFeeJunior = 12.25;
            const double roadFeeJunior = 20;

            const double trailFeeSenior = 7;
            double crosscountryFeeSenior = 9.5;
            const double downhillFeeSenior = 13.75;
            const double roadFeeSenior = 21.5;

            double collectedAmount = 0;

            if (typeOfRoute == "trail")
            {
                collectedAmount += numJuniorsCyclist * trailFeeJunior;
                collectedAmount += numSeniorsCyclist * trailFeeSenior;
            }
            else if (typeOfRoute == "cross-country")
            {
                if (numJuniorsCyclist + numSeniorsCyclist >= 50)
                {
                    crosscountryFeeJunior -= crosscountryFeeJunior * 0.25;
                    crosscountryFeeSenior -= crosscountryFeeSenior * 0.25;
                }

                collectedAmount += numJuniorsCyclist * crosscountryFeeJunior;
                collectedAmount += numSeniorsCyclist * crosscountryFeeSenior;
            }
            else if (typeOfRoute == "downhill")
            {
                collectedAmount += numJuniorsCyclist * downhillFeeJunior;
                collectedAmount += numSeniorsCyclist * downhillFeeSenior;
            }
            else if (typeOfRoute == "road")
            {
                collectedAmount += numJuniorsCyclist * roadFeeJunior;
                collectedAmount += numSeniorsCyclist * roadFeeSenior;
            }

            collectedAmount -= collectedAmount * 0.05;

            Console.WriteLine("{0:F2}", collectedAmount);
        }
    }
}
