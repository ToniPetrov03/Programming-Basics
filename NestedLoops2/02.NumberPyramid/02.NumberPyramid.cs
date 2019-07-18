using System;

namespace _02.NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int numbersOnRow = 1;

            for (int i = 1; i <= num;)
            {
                for (int j = 1; j <= numbersOnRow; j++)
                {
                    if (i > num)
                    {
                        break;
                    }

                    Console.Write(i + " ");
                    i++;
                }

                Console.WriteLine();
                numbersOnRow++;
            }
        }
    }
}
