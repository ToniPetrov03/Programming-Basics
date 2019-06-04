using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._2DRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double lenght = Math.Abs(x1 - x2);
            double width = Math.Abs(y1 - y2);

            Console.WriteLine(String.Format("{0:0.00}", lenght * width));
            Console.WriteLine(String.Format("{0:0.00}", 2 * (lenght + width)));
        }
    }
}
