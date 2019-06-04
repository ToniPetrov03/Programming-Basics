using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int numConfectioners = int.Parse(Console.ReadLine());
            int numCakes = int.Parse(Console.ReadLine());
            int numWaffles = int.Parse(Console.ReadLine());
            int numPancakes = int.Parse(Console.ReadLine());

            int sumCakes = numCakes * 45;
            double sumWaffles = numWaffles * 5.80;
            double sumPancakes = numPancakes * 3.20;
            double sumDay = (sumCakes + sumWaffles + sumPancakes) * numConfectioners;
            double sumCampaign = sumDay * days;

            Console.WriteLine(String.Format("{0:0.00}" ,sumCampaign - sumCampaign / 8));
        }
    }
}
