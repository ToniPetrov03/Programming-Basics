﻿using System;

namespace _03.Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            while (num != 0)
            {
                int n = num % 10;
                num /= 10;

                if (n == 0)
                {
                    Console.WriteLine("ZERO");
                    continue;
                }

                char symbol = (char)(n + 33);

                for (int j = 0; j < n; j++)
                {
                    Console.Write(symbol);
                }

                Console.WriteLine();
            }
        }
    }
}
