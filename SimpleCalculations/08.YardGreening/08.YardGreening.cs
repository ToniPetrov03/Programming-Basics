using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double meters = double.Parse(Console.ReadLine());

            double price = (meters * 7.61) - (meters * 7.61) * 18 / 100;
            double discount = (meters * 7.61) * 18 / 100;

            Console.WriteLine("The final price is: {0:F2} lv.", price);
            Console.WriteLine("The discount is: {0:F2} lv.", discount);
        }
    }
}
