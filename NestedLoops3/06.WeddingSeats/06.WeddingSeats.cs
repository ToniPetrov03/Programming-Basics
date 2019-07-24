using System;

namespace _06.WeddingSeats
{
    class Program
    {
        static void Main(string[] args)
        {
            char sector = char.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());
            int places = int.Parse(Console.ReadLine());

            int counterOfPlaces = 0;

            for (char firstLetter = 'A'; firstLetter <= sector; firstLetter++)
            {
                for (int number = 1; number <= rows; number++)
                {
                    int p = places;

                    if (number % 2 == 0)
                    {
                        p += 2;
                    }

                    for (char smallLetter = 'a'; smallLetter < 'a' + p; smallLetter++)
                    {
                        counterOfPlaces++;
                        Console.WriteLine($"{firstLetter}{number}{smallLetter}");
                    }
                }

                rows++;
            }

            Console.WriteLine(counterOfPlaces);
        }
    }
}
