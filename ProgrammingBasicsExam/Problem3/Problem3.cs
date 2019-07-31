using System;

namespace Problem3
{
    class Problem3
    {
        static void Main(string[] args)
        {
            string cruise = Console.ReadLine();
            string cabin = Console.ReadLine();
            int numNights = int.Parse(Console.ReadLine());

            double totalSum = 0.0;

            switch (cruise)
            {
                case "Mediterranean":
                    switch (cabin)
                    {
                        case "standard cabin": totalSum += 27.5 * 4 * numNights; break;
                        case "cabin with balcony": totalSum += 30.2 * 4 * numNights; break;
                        case "apartment": totalSum += 40.5 * 4 * numNights; break;
                    }
                    break;

                case "Adriatic":
                    switch (cabin)
                    {
                        case "standard cabin": totalSum += 22.99 * 4 * numNights; break;
                        case "cabin with balcony": totalSum += 25 * 4 * numNights; break;
                        case "apartment": totalSum += 34.99 * 4 * numNights; break;
                    }
                    break;

                case "Aegean":
                    switch (cabin)
                    {
                        case "standard cabin": totalSum += 23 * 4 * numNights; break;
                        case "cabin with balcony": totalSum += 26.6 * 4 * numNights; break;
                        case "apartment": totalSum += 39.8 * 4 * numNights; break;
                    }
                    break;
            }

            if (numNights > 7)
            {
                totalSum *= 0.75;
            }

            Console.WriteLine($"Annie's holiday in the {cruise} sea costs {totalSum:F2} lv.");
        }
    }
}
