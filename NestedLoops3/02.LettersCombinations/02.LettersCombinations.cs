using System;

namespace _02.LettersCombinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char startLetter = char.Parse(Console.ReadLine());
            char endLetter = char.Parse(Console.ReadLine());
            char specialLetter = char.Parse(Console.ReadLine());

            int counter = 0;

            for (int firstLetter = startLetter; firstLetter <= endLetter; firstLetter++)
            {
                if (firstLetter == specialLetter)
                {
                    continue;
                }

                for (int secondLetter = startLetter; secondLetter <= endLetter; secondLetter++)
                {
                    if (secondLetter == specialLetter)
                    {
                        continue;
                    }

                    for (int thirdLetter = startLetter; thirdLetter <= endLetter; thirdLetter++)
                    {
                        if (thirdLetter == specialLetter)
                        {
                            continue;
                        }

                        counter++;

                        Console.Write($"{(char)firstLetter}{(char)secondLetter}{(char)thirdLetter} ");
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
