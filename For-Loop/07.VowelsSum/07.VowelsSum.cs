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
                if (text[i] == 'a')
                {
                    vowelsSum += valueOfLetterA;
                }
                else if (text[i] == 'e')
                {
                    vowelsSum += valueOfLetterE;
                }
                else if (text[i] == 'i')
                {
                    vowelsSum += valueOfLetterI;
                }
                else if (text[i] == 'o')
                {
                    vowelsSum += valueOfLetterO;
                }
                else if (text[i] == 'u')
                {
                    vowelsSum += valueOfLetterU;
                }
            }

            Console.WriteLine(vowelsSum);
        }
    }
}
