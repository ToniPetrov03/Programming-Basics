using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double value = double.Parse(Console.ReadLine());
            string inputUnit = Console.ReadLine();
            string outputUnit = Console.ReadLine();

            if (inputUnit == "mm")
            {
                value /= 1000;
            }
            else if (inputUnit == "cm")
            {
                value /= 100;
            }
            if (outputUnit == "mm")
            {
                value *= 1000;
            }
            else if (outputUnit == "cm")
            {
                value *= 100;
            }

            Console.WriteLine("{0:f3}", value);
        }
    }
}
