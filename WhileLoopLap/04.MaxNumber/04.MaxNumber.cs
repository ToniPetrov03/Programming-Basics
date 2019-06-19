using System;

namespace _04.MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int numNumbers = int.Parse(Console.ReadLine());

            int counter = 0;
            int biggestNumber = int.MinValue;

            while (numNumbers > counter)
            {
                int num = int.Parse(Console.ReadLine());

                if (num > biggestNumber)
                {
                    biggestNumber = num;
                }

                counter++;
            }

            Console.WriteLine(biggestNumber);
        }
    }
}
