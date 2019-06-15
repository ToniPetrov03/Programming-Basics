using System;

namespace _09.OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursOfExam = int.Parse(Console.ReadLine());
            int minutesOfExam = int.Parse(Console.ReadLine());
            int hoursOfArrival = int.Parse(Console.ReadLine());
            int minutesOfArrival = int.Parse(Console.ReadLine());

            int allMinutesOfExam = hoursOfExam * 60 + minutesOfExam;
            int allMinutesOfArrival = hoursOfArrival * 60 + minutesOfArrival;

            if (allMinutesOfExam - allMinutesOfArrival == 0)
            {
                Console.WriteLine("On time");
            }
            else if (allMinutesOfExam - allMinutesOfArrival > 0 && allMinutesOfExam - allMinutesOfArrival <= 30)
            {
                Console.WriteLine("On time");
                Console.WriteLine($"{allMinutesOfExam - allMinutesOfArrival} minutes before the start");
            }
            else if (allMinutesOfExam - allMinutesOfArrival > 30 && allMinutesOfExam - allMinutesOfArrival < 60)
            {
                Console.WriteLine("Early");
                Console.WriteLine($"{allMinutesOfExam - allMinutesOfArrival} minutes before the start");
            }
            else if (allMinutesOfExam - allMinutesOfArrival >= 60)
            {
                Console.WriteLine("Early");

                int hoursEarlier = (allMinutesOfExam - allMinutesOfArrival) / 60;
                int minutesEarlier = (allMinutesOfExam - allMinutesOfArrival) % 60;

                if (minutesEarlier < 10)
                {
                    Console.WriteLine($"{hoursEarlier}:0{minutesEarlier} hours before the start");
                }
                else
                {
                    Console.WriteLine($"{hoursEarlier}:{minutesEarlier} hours before the start");
                }
            }
            else if (allMinutesOfArrival - allMinutesOfExam > 0 && allMinutesOfArrival - allMinutesOfExam < 60)
            {
                Console.WriteLine("Late");
                Console.WriteLine($"{allMinutesOfArrival - allMinutesOfExam} minutes after the start");
            }
            else if (allMinutesOfArrival - allMinutesOfExam >= 60)
            {
                Console.WriteLine("Late");

                int hoursLater = (allMinutesOfArrival - allMinutesOfExam) / 60;
                int minutesLater = (allMinutesOfArrival - allMinutesOfExam) % 60;

                if (minutesLater < 10)
                {
                    Console.WriteLine($"{hoursLater}:0{minutesLater} hours after the start");
                }
                else
                {
                    Console.WriteLine($"{hoursLater}:{minutesLater} hours after the start");
                }
            }
        }
    }
}
