using System;

namespace _02.Spaceship
{
    class Program
    {
        static void Main(string[] args)
        {
            double widthOfSpaceship = double.Parse(Console.ReadLine());
            double lengthOfSpaceship = double.Parse(Console.ReadLine());
            double heightOfSpaceship = double.Parse(Console.ReadLine());
            double averageHeightOfAstronauts = double.Parse(Console.ReadLine());

            double volumeOfTheRocket = widthOfSpaceship * lengthOfSpaceship * heightOfSpaceship;
            double volumeOfOneRoom = (averageHeightOfAstronauts + 0.4) * 4;
            double rooms = Math.Floor(volumeOfTheRocket / volumeOfOneRoom);

            if (rooms > 10)
            {
                Console.WriteLine("The spacecraft is too big.");
            }
            else if (rooms >= 3)
            {
                Console.WriteLine($"The spacecraft holds {rooms} astronauts.");
            }
            else
            {
                Console.WriteLine("The spacecraft is too small.");
            }
        }
    }
}
