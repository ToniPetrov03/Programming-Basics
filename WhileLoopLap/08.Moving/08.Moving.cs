using System;

namespace _08.Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int widthOfFreeSpace = int.Parse(Console.ReadLine());
            int lengthOfFreeSpace = int.Parse(Console.ReadLine());
            int heightOfFreeSpace = int.Parse(Console.ReadLine());

            int freeSpace = widthOfFreeSpace * lengthOfFreeSpace * heightOfFreeSpace;

            int placeWithCartons = 0;

            while (freeSpace >= placeWithCartons)
            {
                string numCartonsOrDone = Console.ReadLine();

                if (numCartonsOrDone == "Done")
                {
                    Console.WriteLine($"{freeSpace - placeWithCartons} Cubic meters left.");
                    break;
                }
                else
                {
                    int numCartons = int.Parse(numCartonsOrDone);
                    placeWithCartons += numCartons;
                }

                if (placeWithCartons > freeSpace)
                {
                    Console.WriteLine($"No more free space! You need {placeWithCartons - freeSpace} Cubic meters more.");
                }
            }
        }
    }
}
