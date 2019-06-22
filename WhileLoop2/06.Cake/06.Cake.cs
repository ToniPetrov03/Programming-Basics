using System;

namespace _06.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());

            int sizeOfCake = width * length;

            string stopOrPieceSize = string.Empty;
            int pieceSize;
            int takenSizeOfCake = 0;

            while (takenSizeOfCake <= sizeOfCake)
            {
                stopOrPieceSize = Console.ReadLine();

                if (stopOrPieceSize == "STOP")
                {
                    Console.WriteLine($"{sizeOfCake - takenSizeOfCake} pieces are left.");
                    break;
                }
                else
                {
                    pieceSize = int.Parse(stopOrPieceSize);
                }

                takenSizeOfCake += pieceSize;
            }

            if (takenSizeOfCake > sizeOfCake)
            {
                Console.WriteLine($"No more cake left! You need {takenSizeOfCake - sizeOfCake} pieces more.");
            }
        }
    }
}
