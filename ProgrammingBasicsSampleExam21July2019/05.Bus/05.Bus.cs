using System;

namespace _05.Bus
{
    class Program
    {
        static void Main(string[] args)
        {
            int numPassengers = int.Parse(Console.ReadLine());
            int numStop = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numStop; i++)
            {
                int numPassengersDown = int.Parse(Console.ReadLine());
                int numPassengersGetUp = int.Parse(Console.ReadLine());

                if (i % 2 == 1)
                {
                    numPassengers += -numPassengersDown + numPassengersGetUp + 2;
                }
                else
                {
                    numPassengers += -numPassengersDown + numPassengersGetUp - 2;
                }
            }

            Console.WriteLine($"The final number of passengers is : {numPassengers}");
        }
    }
}
