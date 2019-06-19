using System;

namespace _06.Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int counter = 0;
            double sumMarks = 0;

            while (counter < 12)
            {
                double mark = double.Parse(Console.ReadLine());

                if (mark >= 4)
                {
                    sumMarks += mark;
                    counter++;
                }
            }

            double average = sumMarks / 12;

            Console.WriteLine($"{name} graduated. Average grade: {average:F2}");
        }
    }
}
