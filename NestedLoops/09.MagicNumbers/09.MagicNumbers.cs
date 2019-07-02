using System;

namespace _09.MagicNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int magicNumber = int.Parse(Console.ReadLine());

            for (int firstDigit = 1; firstDigit <= 9; firstDigit++)
            {
                for (int secondDigit = 1; secondDigit <= 9; secondDigit++)
                {
                    for (int thirdDigit = 1; thirdDigit <= 9; thirdDigit++)
                    {
                        for (int fourthDigit = 1; fourthDigit <= 9; fourthDigit++)
                        {
                            for (int fifthDigit = 1; fifthDigit <= 9; fifthDigit++)
                            {
                                for (int sixthDigit = 1; sixthDigit <= 9; sixthDigit++)
                                {
                                    int product = firstDigit * secondDigit * thirdDigit * fourthDigit * fifthDigit * sixthDigit;

                                    if (magicNumber == product)
                                    {
                                        Console.WriteLine($"{firstDigit}{secondDigit}{thirdDigit}{fourthDigit}{fifthDigit}{sixthDigit}");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
