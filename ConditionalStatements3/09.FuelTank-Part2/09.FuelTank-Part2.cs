using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.FuelTank_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfFuel = Console.ReadLine();
            double litersOfFuel = double.Parse(Console.ReadLine());
            string YesOrNo = Console.ReadLine();

            const double priceOneLiterGasoline = 2.22;
            const double priceOneLiterDiesel = 2.33;
            const double priceOneLiterGas = 0.93;

            const double discountpriceOneLiterGasoline = 2.04;
            const double discountpriceOneLiterDiesel = 2.21;
            const double discountpriceOneLiterGas = 0.85;
            double price = 0;

            if (YesOrNo == "Yes")
            {
                if (typeOfFuel == "Gasoline")
                {
                    price += litersOfFuel * discountpriceOneLiterGasoline;
                }
                else if (typeOfFuel == "Diesel")
                {
                    price += litersOfFuel * discountpriceOneLiterDiesel;
                }
                else if (typeOfFuel == "Gas")
                {
                    price += litersOfFuel * discountpriceOneLiterGas;
                }
            }
            else
            {
                if (typeOfFuel == "Gasoline")
                {
                    price += litersOfFuel * priceOneLiterGasoline;
                }
                else if (typeOfFuel == "Diesel")
                {
                    price += litersOfFuel * priceOneLiterDiesel;
                }
                else if (typeOfFuel == "Gas")
                {
                    price += litersOfFuel * priceOneLiterGas;
                }
            }
            if (litersOfFuel >= 20 && litersOfFuel <= 25)
            {
                price -= price * 0.08;
            }
            else if (litersOfFuel > 25)
            {
                price -= price * 0.1;
            }
            Console.WriteLine($"{price:F2} lv.");
        }
    }
}
