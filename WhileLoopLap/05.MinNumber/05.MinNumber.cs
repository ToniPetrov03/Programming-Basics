using System;

namespace _04.MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int numNumbers = int.Parse(Console.ReadLine());

            int counter = 0;
            int smallestNumber = int.MaxValue;

            while (numNumbers > counter)
            {
                int num = int.Parse(Console.ReadLine());

                if (num < smallestNumber)
                {
                    smallestNumber = num;
                }

                counter++;
            }

            Console.WriteLine(smallestNumber);
        }
    }
}