using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

                Console.WriteLine(String.Format("{0:0.000}", area));
            }
            if (geometricShape == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine()); 
                double sideB = double.Parse(Console.ReadLine());
                double area = sideA * sideB;

                Console.WriteLine(String.Format("{0:0.000}", area));
            }
            if (geometricShape == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                double area = Math.PI * r * r;

                Console.WriteLine(String.Format("{0:0.000}", area));
            }
            if (geometricShape == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double area = side * height / 2;

                Console.WriteLine(String.Format("{0:0.000}", area));
            }
        }
    }
}
