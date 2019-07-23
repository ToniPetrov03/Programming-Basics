using System;

namespace _04.BachelorParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int estimatedSum = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int income = 0;
            int totalPeople = 0;

            while (command != "The restaurant is full")
            {
                int people = int.Parse(command);

                if (people < 5)
                {
                    income += people * 100;
                }
                else
                {
                    income += people * 70;
                }

                totalPeople += people;

                command = Console.ReadLine();
            }

            if (income >= estimatedSum)
            {
                Console.WriteLine($"You have {totalPeople} guests and {income - estimatedSum} leva left.");
            }
            else
            {
                Console.WriteLine($"You have {totalPeople} guests and {income} leva income, but no singer.");
            }
        }
    }
}
