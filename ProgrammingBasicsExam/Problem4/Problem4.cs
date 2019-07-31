using System;

namespace Problem4
{
    class Problem4
    {
        static void Main(string[] args)
        {
            int points = int.Parse(Console.ReadLine());
            string sector = string.Empty;

            int moves = 0;

            while (points > 0)
            {
                sector = Console.ReadLine();

                moves++;

                if (sector == "bullseye")
                {
                    break;
                }

                int p = int.Parse(Console.ReadLine());

                switch (sector)
                {
                    case "number section": points -= p; break;
                    case "double ring": points -= p * 2; break;
                    case "triple ring": points -= p * 3; break;
                }
            }

            if (points == 0)
            {
                Console.WriteLine($"Congratulations! You won the game in {moves} moves!");
            }
            else if (sector == "bullseye")
            {
                Console.WriteLine($"Congratulations! You won the game with a bullseye in {moves} moves!");
            }
            else
            {
                Console.WriteLine($"Sorry, you lost. Score difference: {-points}.");
            }
        }
    }
}
