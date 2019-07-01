using System;

namespace _06.Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());

            const int waterBill = 20;
            const int internetBill = 15;

            double totalelectricityBill = 0;
            double totalWaterBill = 0;
            double totalInternetBill = 0;
            double totalOtherBill = 0;


            for (int i = 0; i < months; i++)
            {
                double electricityBill = double.Parse(Console.ReadLine());

                totalelectricityBill += electricityBill;
                totalWaterBill += waterBill;
                totalInternetBill += internetBill;
                totalOtherBill += (electricityBill + waterBill + internetBill) * 1.2;
            }

            Console.WriteLine($"Electricity: {totalelectricityBill:F2} lv");
            Console.WriteLine($"Water: {totalWaterBill:F2} lv");
            Console.WriteLine($"Internet: {totalInternetBill:F2} lv");
            Console.WriteLine($"Other: {totalOtherBill:F2} lv");
            Console.WriteLine($"Average: {(totalelectricityBill + totalWaterBill + totalInternetBill + totalOtherBill) / months:F2} lv");
        }
    }
}
