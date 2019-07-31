using System;

namespace Problem2
{
    class Problem2
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            double percentDiscout = double.Parse(Console.ReadLine());

            double a = price * 2 / 3;
            double b = a * 0.75;
            double c = (price + b) / 3;
            double totalSum = price + a + b + c;
            double sumWithDiscout = totalSum - totalSum * (percentDiscout / 100);

            if (budget >= sumWithDiscout)
            {
                Console.WriteLine($"Annie's sum is {sumWithDiscout:F2} lv. She has {budget - sumWithDiscout:F2} lv. left.");
            }
            else
            {
                Console.WriteLine($"Annie's sum is {sumWithDiscout:F2} lv. She needs {sumWithDiscout - budget:F2} lv. more.");
            }
        }
    }
}
