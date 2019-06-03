using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int numDogs = int.Parse(Console.ReadLine());
            int numOthers = int.Parse(Console.ReadLine());

            decimal price = numDogs * 2.5m + numOthers * 4;

            string s = price.ToString("N2");
            decimal pricE = Convert.ToDecimal(s);

            Console.WriteLine(pricE + " lv.");
        }
    }
}
