using System;

namespace _07.GraduationPt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            const int classes = 12;
            int counter = 0;
            double sumMarks = 0.0;
            int failedExams = 0;

            while (counter++ < classes)
            {
                double mark = double.Parse(Console.ReadLine());

                if (mark < 4)
                {
                    failedExams++;

                    if (failedExams > 1)
                    {
                        Console.WriteLine($"{name} has been excluded at {counter - 1} grade");
                        break;
                    }
                }

                sumMarks += mark;
            }

            double average = sumMarks / classes;

            if(failedExams < 2)
            Console.WriteLine($"{name} graduated. Average grade: {average:F2}");
        }
    }
}
