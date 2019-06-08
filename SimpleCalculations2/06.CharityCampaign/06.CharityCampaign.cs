using System;

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

            Console.WriteLine("{0:F2}", sumCampaign - sumCampaign / 8);
        }
    }
}
