﻿using System;

namespace _02.Sequence2kPlus1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int k = 1;

            while (k <= num)
            {
                Console.WriteLine(k);

                k = k * 2 + 1;
            }
        }
    }
}
