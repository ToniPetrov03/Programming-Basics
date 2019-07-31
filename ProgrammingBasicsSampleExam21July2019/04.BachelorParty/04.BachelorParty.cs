using System;

namespace _04.BachelorParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumForSinger = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int totalNumPeople = 0;
            int income = 0;

            while (command != "The restaurant is full")
            {
                int numPeople = int.Parse(command);

                totalNumPeople += numPeople;

                if (numPeople < 5)
                {
                    income += numPeople * 100;
                }
                else
                {
                    income += numPeople * 70;
                }

                command = Console.ReadLine();
            }

            if (income >= sumForSinger)
            {
                Console.WriteLine($"You have {totalNumPeople} guests and {income - sumForSinger} leva left.");
            }
            else
            {
                Console.WriteLine($"You have {totalNumPeople} guests and {income} leva income, but no singer.");
            }
        }
    }
}
