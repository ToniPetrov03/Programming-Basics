using System;

namespace _05.Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double change = double.Parse(Console.ReadLine());

            int allStotinki = (int)Math.Round(change * 100);
            int numCoins = 0;

            while (allStotinki > 0)
            {
                if (allStotinki >= 200)
                {
                    numCoins++;
                    allStotinki -= 200;
                }
                else if (allStotinki >= 100)
                {
                    numCoins++;
                    allStotinki -= 100;
                }
                else if (allStotinki >= 50)
                {
                    numCoins++;
                    allStotinki -= 50;
                }
                else if (allStotinki >= 20)
                {
                    numCoins++;
                    allStotinki -= 20;
                }
                else if (allStotinki >= 10)
                {
                    numCoins++;
                    allStotinki -= 10;
                }
                else if (allStotinki >= 5)
                {
                    numCoins++;
                    allStotinki -= 5;
                }
                else if (allStotinki >= 2)
                {
                    numCoins++;
                    allStotinki -= 2;
                }
                else if (allStotinki == 1)
                {
                    numCoins++;
                    allStotinki -= 1;
                }
            }

            Console.WriteLine(numCoins);
        }
    }
}
