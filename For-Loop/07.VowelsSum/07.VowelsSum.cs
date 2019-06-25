using System;

namespace _07.VowelsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            const int valueOfLetterA = 1;
            const int valueOfLetterE = 2;
            const int valueOfLetterI = 3;
            const int valueOfLetterO = 4;
            const int valueOfLetterU = 5;
            int vowelsSum = 0;

            for (int i = 0; i < text.Length; i++)
            {
                switch (text[i])
                {
                    case 'a':  vowelsSum += valueOfLetterA; break;
                    case 'e':  vowelsSum += valueOfLetterE; break;
                    case 'i':  vowelsSum += valueOfLetterI; break;
                    case 'o':  vowelsSum += valueOfLetterO; break;
                    case 'u':  vowelsSum += valueOfLetterU; break;
                }
            }

            Console.WriteLine(vowelsSum);
        }
    }
}
