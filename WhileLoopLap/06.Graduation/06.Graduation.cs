using System;

namespace _06.Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            const int classes = 12;
            int counter = 0;
            double sumMarks = 0;

            while (counter < classes)
            {
                double mark = double.Parse(Console.ReadLine());

                if (mark >= 4)
                {
                    sumMarks += mark;
                    counter++;
                }
            }

            double average = sumMarks / classes;

            Console.WriteLine($"{name} graduated. Average grade: {average:F2}");
        }
    }
}
