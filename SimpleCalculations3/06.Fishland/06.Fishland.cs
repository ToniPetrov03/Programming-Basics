using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceKiloMackerel = double.Parse(Console.ReadLine());
            double priceKiloSprat = double.Parse(Console.ReadLine());
            double kiloPalm = double.Parse(Console.ReadLine());
            double kiloScad = double.Parse(Console.ReadLine());
            double kiloClam = double.Parse(Console.ReadLine());

            double priceAllPalm = (priceKiloMackerel + priceKiloMackerel * 0.6) * kiloPalm;
            double priceAllScad = (priceKiloSprat + priceKiloSprat * 0.8) * kiloScad;
            double priceAllClam = kiloClam * 7.5;
            double priceAll = priceAllPalm + priceAllScad + priceAllClam;

            Console.WriteLine(String.Format("{0:0.00}", priceAll));
        }
    }
}
