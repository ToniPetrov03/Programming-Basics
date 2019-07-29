using System;

namespace Problem6
{
    class Problem6
    {
        static void Main(string[] args)
        {
            int numPlayers = int.Parse(Console.ReadLine());

            double totalSum = 0.0;
            int totalNumSweets = 0;

            for (int i = 0; i < numPlayers; i++)
            {
                string name = Console.ReadLine();
                string sweets = Console.ReadLine();
                int numCookies = 0;
                int numCakes = 0;
                int numWaffles = 0;

                while (sweets != "Stop baking!")
                {
                    int numSweets = int.Parse(Console.ReadLine());

                    switch (sweets)
                    {
                        case "cookies": totalSum += numSweets * 1.5; numCookies += numSweets; break;
                        case "cakes": totalSum += numSweets * 7.8; numCakes += numSweets; break;
                        case "waffles": totalSum += numSweets * 2.3; numWaffles += numSweets; break;
                    }

                    totalNumSweets += numSweets;

                    sweets = Console.ReadLine();
                }

                Console.WriteLine($"{name} baked {numCookies} cookies, {numCakes} cakes and {numWaffles} waffles.");
            }

            Console.WriteLine($"All bakery sold: {totalNumSweets}");
            Console.WriteLine($"Total sum for charity: {totalSum:F2} lv.");
        }
    }
}
