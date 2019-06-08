using System;

namespace _09.AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string geometricShape = Console.ReadLine();

            if (geometricShape == "square")
            {
                double side = double.Parse(Console.ReadLine());
                double area = side * side;

                Console.WriteLine("{0:F3}", area);
            }
            else if (geometricShape == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine()); 
                double sideB = double.Parse(Console.ReadLine());
                double area = sideA * sideB;

                Console.WriteLine("{0:F3}", area);
            }
            else if (geometricShape == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                double area = Math.PI * r * r;

                Console.WriteLine("{0:F3}", area);
            }
            else if (geometricShape == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double area = side * height / 2;

                Console.WriteLine("{0:F3}", area);
            }
        }
    }
}
