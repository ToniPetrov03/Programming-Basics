using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.GodzillaVSKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double movieBudget = double.Parse(Console.ReadLine());
            int numberStatistics = int.Parse(Console.ReadLine());
            double priceOneClothing = double.Parse(Console.ReadLine());

            double priceDecor = movieBudget * 0.1;
            double priceAllClothing = numberStatistics * priceOneClothing;

            if (numberStatistics > 150)
            {
                priceAllClothing -= priceAllClothing * 0.1;
            }
            if (priceDecor + priceAllClothing > movieBudget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine("Wingard needs {0:F2} leva more.", priceDecor + priceAllClothing - movieBudget);
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine("Wingard starts filming with {0:F2} leva left.", movieBudget - (priceDecor + priceAllClothing));
            }
        }
    }
}
