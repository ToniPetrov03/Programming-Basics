using System;

namespace _07.FootballLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacityOfStadium = int.Parse(Console.ReadLine());
            double numFans = double.Parse(Console.ReadLine());

            double fansOfSectorA = 0;
            double fansOfSectorB = 0;
            double fansOfSectorV = 0;
            double fansOfSectorG = 0;

            for (int i = 0; i < numFans; i++)
            {
                char sector = char.Parse(Console.ReadLine());

                switch (sector)
                {
                    case 'A': fansOfSectorA++; break;
                    case 'B': fansOfSectorB++; break;
                    case 'V': fansOfSectorV++; break;
                    case 'G': fansOfSectorG++; break;
                }
            }

            Console.WriteLine($"{fansOfSectorA / numFans * 100:F2}%");
            Console.WriteLine($"{fansOfSectorB / numFans * 100:F2}%");
            Console.WriteLine($"{fansOfSectorV / numFans * 100:F2}%");
            Console.WriteLine($"{fansOfSectorG / numFans * 100:F2}%");
            Console.WriteLine($"{numFans / capacityOfStadium * 100:F2}%");
        }
    }
}
