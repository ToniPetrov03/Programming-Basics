using System;

namespace _04.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int numStudents = int.Parse(Console.ReadLine());

            double marksLessThan3 = 0;
            double marksLessThan4 = 0;
            double marksLessThan5 = 0;
            double marksMoreThan5 = 0;
            double sumMarks = 0;

            for (int i = 0; i < numStudents; i++)
            {
                double mark = double.Parse(Console.ReadLine());

                if (mark < 3)
                {
                    marksLessThan3++;
                }
                else if (mark < 4)
                {
                    marksLessThan4++;
                }
                else if (mark < 5)
                {
                    marksLessThan5++;
                }
                else
                {
                    marksMoreThan5++;
                }

                sumMarks += mark;
            }

            Console.WriteLine($"Top students: {marksMoreThan5 / numStudents * 100:F2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {marksLessThan5 / numStudents * 100:F2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {marksLessThan4 / numStudents * 100:F2}%");
            Console.WriteLine($"Fail: {marksLessThan3 / numStudents * 100:F2}%");
            Console.WriteLine($"Average: {sumMarks / numStudents:F2}");
        }
    }
}
