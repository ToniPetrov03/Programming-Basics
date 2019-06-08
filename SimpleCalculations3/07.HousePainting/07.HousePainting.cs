using System;

namespace _07.HousePainting
{
    class Program
    {
        static void Main(string[] args)
        {
            double hightHouse = double.Parse(Console.ReadLine());
            double lenghtSideWall = double.Parse(Console.ReadLine());
            double hightTriangularWall = double.Parse(Console.ReadLine());

            double areaTwoSideWalls = 2 * hightHouse * lenghtSideWall - 4.5;
            double areafrontAndRearWall = 2 * hightHouse * hightHouse - 2.4;
            double generalAreaWalls = areaTwoSideWalls + areafrontAndRearWall;
            double greenPaint = generalAreaWalls / 3.4;

            double areaTworRectangleOfRoof = 2 * hightHouse * lenghtSideWall;
            double areaTwoTrianglesOfRoof = 2 * hightHouse * hightTriangularWall / 2;
            double generalAreaRoof = areaTworRectangleOfRoof + areaTwoTrianglesOfRoof;
            double redPaint = generalAreaRoof / 4.3;

            Console.WriteLine("{0:F2}", greenPaint);
            Console.WriteLine("{0:F2}", redPaint);
        }
    }
}
