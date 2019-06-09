using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string productName = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0;

            if (city == "Sofia")
            {
                if (productName == "coffee")
                {
                    price = quantity * 0.5;
                }
                else if (productName == "water")
                {
                    price = quantity * 0.8;
                }
                else if (productName == "beer")
                {
                    price = quantity * 1.2;
                }
                else if (productName == "sweets")
                {
                    price = quantity * 1.45;
                }
                else if (productName == "peanuts")
                {
                    price = quantity * 1.6;
                }
            }
            else if (city == "Plovdiv")
            {
                if (productName == "coffee")
                {
                    price = quantity * 0.4;
                }
                else if (productName == "water")
                {
                    price = quantity * 0.7;
                }
                else if (productName == "beer")
                {
                    price = quantity * 1.15;
                }
                else if (productName == "sweets")
                {
                    price = quantity * 1.3;
                }
                else if (productName == "peanuts")
                {
                    price = quantity * 1.5;
                }
            }
            else if (city == "Varna")
            {
                if (productName == "coffee")
                {
                    price = quantity * 0.45;
                }
                else if (productName == "water")
                {
                    price = quantity * 0.7;
                }
                else if (productName == "beer")
                {
                    price = quantity * 1.1;
                }
                else if (productName == "sweets")
                {
                    price = quantity * 1.35;
                }
                else if (productName == "peanuts")
                {
                    price = quantity * 1.55;
                }
            }
            Console.WriteLine(price);
        }
    }
}
