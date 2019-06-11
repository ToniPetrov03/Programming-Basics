using System;

namespace _05.InvalidNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (num == 0)
            {
            }
            else if (num < 100 || num > 200)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
