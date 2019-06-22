using System;

namespace _02.ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numBadGrades = int.Parse(Console.ReadLine());

            string nameTask = string.Empty;
            int grade;
            int badGrades = 0;
            int numGrades = 0;
            double sumGrades = 0.0;
            string lastTask = string.Empty;

            while (badGrades < numBadGrades)
            {
                nameTask = Console.ReadLine();

                if (nameTask == "Enough")
                {
                    Console.WriteLine($"Average score: {sumGrades / numGrades:F2}");
                    Console.WriteLine($"Number of problems: {numGrades}");
                    Console.WriteLine($"Last problem: {lastTask}");
                    break;
                }

                lastTask = nameTask;

                grade = int.Parse(Console.ReadLine());

                numGrades++;
                sumGrades += grade;

                if (grade <= 4)
                    badGrades++;
            }

            if (badGrades == numBadGrades)
                Console.WriteLine($"You need a break, {badGrades} poor grades.");
        }
    }
}
