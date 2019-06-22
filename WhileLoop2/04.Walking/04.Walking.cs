using System;

namespace _04.Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            const int stepsEveryDay = 10000;

            string stepsOrGoingHome = string.Empty;
            int steps = 0;
            int allSteps = 0;

            while (allSteps < stepsEveryDay)
            {
                stepsOrGoingHome = Console.ReadLine();

                if (stepsOrGoingHome == "Going home")
                {
                    steps = int.Parse(Console.ReadLine());

                    allSteps += steps;
                    break;
                }
                else
                {
                    steps = int.Parse(stepsOrGoingHome); 
                }

                allSteps += steps;
            }

            if (allSteps >= stepsEveryDay)
            {
                Console.WriteLine("Goal reached! Good job!");
            }
            else
            {
                Console.WriteLine($"{stepsEveryDay - allSteps} more steps to reach goal.");
            }
        }
    }
}