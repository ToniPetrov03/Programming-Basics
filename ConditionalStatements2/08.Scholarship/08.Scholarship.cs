using System;

namespace _08.Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double gradeAvg = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());
            double socScholarship = 0;
            double gradeScholarship = 0;

            if (income < minSalary && gradeAvg > 4.5)
            {
                socScholarship = minSalary * 0.35;
            }
            if (gradeAvg >= 5.5)
            {
                gradeScholarship = gradeAvg * 25;
            }

            if (socScholarship != 0 || gradeScholarship != 0)
            {
                if (gradeScholarship >= socScholarship)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(gradeScholarship)} BGN");
                }
                else
                {
                    Console.WriteLine($"You get a Social scholarship {Math.Floor(socScholarship)} BGN");
                }
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}
