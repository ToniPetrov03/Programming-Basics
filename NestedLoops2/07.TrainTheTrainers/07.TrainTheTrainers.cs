using System;

namespace _07.TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numJury = int.Parse(Console.ReadLine());
            string presentationOrFinish = Console.ReadLine();

            double totalSumPresentationMarks = 0;
            int counter = 0;

            while (presentationOrFinish != "Finish")
            {
                double sumMarks = 0;

                for (int i = 0; i < numJury; i++)
                {
                    double mark = double.Parse(Console.ReadLine());

                    sumMarks += mark;
                }

                double averagePresentationMark = sumMarks / numJury;

                Console.WriteLine($"{presentationOrFinish} - {averagePresentationMark:F2}.");

                totalSumPresentationMarks += averagePresentationMark;
                counter++;

                presentationOrFinish = Console.ReadLine();
            }

            Console.WriteLine($"Student's final assessment is {totalSumPresentationMarks / counter:F2}.");
        }
    }
}
