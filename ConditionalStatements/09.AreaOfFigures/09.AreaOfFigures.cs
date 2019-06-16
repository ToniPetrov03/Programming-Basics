using System;

namespace _09.AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string geometricShape = Console.ReadLine();
            double area = 0;

            if (geometricShape == "square")
            {
                double side = double.Parse(Console.ReadLine());
                area = side * side;
            }
            else if (geometricShape == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine()); 
                double sideB = double.Parse(Console.ReadLine());
                area = sideA * sideB;
            }
            else if (geometricShape == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                area = Math.PI * r * r;
            }
            else if (geometricShape == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                area = side * height / 2;
            }

            Console.WriteLine("{0:F3}", area);
        }
    }
}
