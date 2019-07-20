using System;

namespace _10.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1111; i <= 9999; i++)
            {
                int n = i;
                bool isSpecialNumber = true;

                for (int j = 0; j < 4; j++)
                {
                    int digit = n % 10;

                    if (digit == 0 || num % digit != 0)
                    {
                        isSpecialNumber = false;
                        break;
                    }

                    n /= 10;
                }

                if (isSpecialNumber)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
