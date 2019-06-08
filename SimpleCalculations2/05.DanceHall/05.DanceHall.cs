using System;

namespace _05.DanceHall
{
    class Program
    {
        static void Main(string[] args)
        {
            float lenght = float.Parse(Console.ReadLine());
            float widht = float.Parse(Console.ReadLine());
            float sideWardrobe = float.Parse(Console.ReadLine());

            float sizeRoom = (lenght * 100) * (widht * 100);
            float sizeWardrobe = (sideWardrobe * 100) * (sideWardrobe * 100);
            float sizeBench = sizeRoom / 10;
            float freeSpace = sizeRoom - sizeWardrobe - sizeBench;

            Console.WriteLine(Math.Floor(freeSpace / 7040));
        }
    }
}
