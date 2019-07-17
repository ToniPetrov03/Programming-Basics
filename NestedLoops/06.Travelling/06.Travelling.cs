using System;

namespace _06.Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();

            while (destination != "End")
            {
                double neededMoney = double.Parse(Console.ReadLine());
                double savedMoney = 0;

                while (savedMoney < neededMoney)
                {
                    double money = double.Parse(Console.ReadLine());
                    savedMoney += money;
                }

                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();
            }
        }
    }
}
