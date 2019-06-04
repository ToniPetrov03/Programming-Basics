using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.TailoringWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int numTables = int.Parse(Console.ReadLine());
            double lenghtTable = double.Parse(Console.ReadLine());
            double widhtTable = double.Parse(Console.ReadLine());

            double areaCovers = numTables * (lenghtTable + 0.6) * (widhtTable + 0.6);
            double areaSquare = numTables * (lenghtTable / 2) * (lenghtTable / 2);
            double USD = areaCovers * 7 + areaSquare * 9;
            double BGN = USD * 1.85;

            Console.WriteLine(String.Format("{0:0.00}", USD) + " USD");
            Console.WriteLine(String.Format("{0:0.00}", BGN) + " BGN");
        }
    }
}
