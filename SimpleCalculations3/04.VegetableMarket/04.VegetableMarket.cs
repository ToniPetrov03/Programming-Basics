using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.VegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceVegetables = double.Parse(Console.ReadLine());
            double priceFruits = double.Parse(Console.ReadLine());
            double kiloVegetables = double.Parse(Console.ReadLine());
            double kiloFruits = double.Parse(Console.ReadLine());

            double priceAllVegetables = priceVegetables * kiloVegetables;
            double priceAllFruits = priceFruits * kiloFruits;

            double allEU = (priceAllVegetables + priceAllFruits) / 1.94;

            Console.WriteLine("{0:F2}", allEU);
        }
    }
}
