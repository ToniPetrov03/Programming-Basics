using System;

namespace _10.SpecialNumbers
{
    class Program
    {
        static bool IsSpecialNumber(int n, int num)
        {
            bool isSpecialNumber = true;

            for (int i = 0; i < 4; i++)
            {
                int digit = n % 10;

                if (digit == 0 || num % digit != 0)
                {
                    isSpecialNumber = false;
                    break;
                }

                n /= 10;
            }

            return isSpecialNumber;
        }

        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1111; i <= 9999; i++)
            {
                if (IsSpecialNumber(i, num))
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
