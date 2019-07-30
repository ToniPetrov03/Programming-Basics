using System;

namespace _09.PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            int biggerDigit = 0;

            for (int firstDigit = 1; firstDigit < n; firstDigit++)
            {
                for (int secondDigit = 1; secondDigit < n; secondDigit++)
                {
                    for (int firtsLetter = 97; firtsLetter < 97 + l; firtsLetter++)
                    {
                        for (int secondLetter = 97; secondLetter < 97 + l; secondLetter++)
                        {
                            if (firstDigit > secondDigit)
                            {
                                biggerDigit = firstDigit;
                            }
                            else
                            {
                                biggerDigit = secondDigit;
                            }

                            for (int lastDigit = biggerDigit; lastDigit < n; lastDigit++)
                            {
                                Console.Write($"{firstDigit}{secondDigit}{(char)firtsLetter}{(char)secondLetter}{++biggerDigit} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
