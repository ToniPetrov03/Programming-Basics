using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CelsiustoFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:F2}", celsius * 9 / 5 + 32);
        }
    }
}
