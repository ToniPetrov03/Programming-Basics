using System;

namespace Problem1
{
    class Problem1
    {
        static void Main(string[] args)
        {
            double incomeForMonth = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double costs = double.Parse(Console.ReadLine());

            double a = incomeForMonth * 0.3;
            double b = incomeForMonth - (costs + a);
            double c = months * b;

            Console.WriteLine($"She can save {b/incomeForMonth * 100:F2}%");
            Console.WriteLine($"{c:F2}");
        }
    }
}
