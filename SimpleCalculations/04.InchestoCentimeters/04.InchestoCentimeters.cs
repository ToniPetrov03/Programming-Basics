using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.InchestoCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            double inche = double.Parse(Console.ReadLine());
            double cen = inche * 2.54;

            Console.WriteLine("{0:F2}", cen);
        }
    }
}
