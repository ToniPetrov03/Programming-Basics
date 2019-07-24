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

            for (char firstLetter = startLetter; firstLetter <= endLetter; firstLetter++)
            {
                if (firstLetter == specialLetter)
                {
                    continue;
                }

                for (char secondLetter = startLetter; secondLetter <= endLetter; secondLetter++)
                {
                    if (secondLetter == specialLetter)
                    {
                        continue;
                    }

                    for (char thirdLetter = startLetter; thirdLetter <= endLetter; thirdLetter++)
                    {
                        if (thirdLetter == specialLetter)
                        {
                            continue;
                        }

                        counter++;

                        Console.Write($"{firstLetter}{secondLetter}{thirdLetter} ");
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
