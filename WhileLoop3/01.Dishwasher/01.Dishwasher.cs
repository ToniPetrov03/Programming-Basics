using System;

namespace _01.Dishwasher
{
    class Program
    {
        static void Main(string[] args)
        {
            int numBottlesOfDetergent = int.Parse(Console.ReadLine());

            const int mlOfOneDetergent = 750;
            const int mlForOnePlate = 5;
            const int mlForOneSaucepan = 15;

            int totalMlDetergent = mlOfOneDetergent * numBottlesOfDetergent;
            int usedDetergent = 0;
            int counter = 0;
            int numWashedDishes = 0;
            int numWashedPots = 0;

            while (totalMlDetergent >= usedDetergent)
            {
                string numberOrEnd = Console.ReadLine();

                if (numberOrEnd == "End")
                {
                    Console.WriteLine("Detergent was enough!");
                    Console.WriteLine($"{numWashedDishes} dishes and {numWashedPots} pots were washed.");
                    Console.WriteLine($"Leftover detergent {totalMlDetergent - usedDetergent} ml.");
                    break;
                }

                int numDishesOrNumPots = int.Parse(numberOrEnd);

                if (counter == 2)
                {
                    usedDetergent += numDishesOrNumPots * mlForOneSaucepan;
                    numWashedPots += numDishesOrNumPots;
                    counter -= 3;
                }
                else
                {
                    usedDetergent += numDishesOrNumPots * mlForOnePlate;
                    numWashedDishes += numDishesOrNumPots;
                }

                counter++;
            }

            if (totalMlDetergent < usedDetergent)
            {
                Console.WriteLine($"Not enough detergent, {usedDetergent - totalMlDetergent} ml. more necessary!");
            }
        }
    }
}
