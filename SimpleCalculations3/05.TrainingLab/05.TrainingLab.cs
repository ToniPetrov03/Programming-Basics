using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            double lines = Math.Floor(length / 1.2);
            double officesOnLine = Math.Floor((width - 1) / 0.7);

            Console.WriteLine(lines * officesOnLine - 3);
        }
    }
}
