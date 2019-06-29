using System;

namespace _07.Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOpenTabBrowser = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            const int fineFacebook = 150;
            const int fineInstagram = 100;
            const int fineReddit = 50;
            int fine = 0;

            for (int i = 0; i < numOpenTabBrowser; i++)
            {
                string site = Console.ReadLine(); 

                if (site == "Facebook")
                {
                    fine += fineFacebook;
                }
                else if (site == "Instagram")
                {
                    fine += fineInstagram;
                }
                else if (site == "Reddit")
                {
                    fine += fineReddit;
                }

                if (fine >= salary)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }

            if (salary > fine)
            {
                Console.WriteLine(salary - fine);
            }
        }
    }
}
