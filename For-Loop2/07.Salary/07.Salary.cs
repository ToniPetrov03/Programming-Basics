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

                switch (site)
                {
                    case "Facebook": fine += fineFacebook; break;
                    case "Instagram": fine += fineInstagram; break;
                    case "Reddit": fine += fineReddit; break;
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
