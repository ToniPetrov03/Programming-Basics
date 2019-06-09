using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfFuel = Console.ReadLine();
            int litersOfFuel = int.Parse(Console.ReadLine());
            if (typeOfFuel == "Diesel" || typeOfFuel == "Gasoline" || typeOfFuel == "Gas")
            {

                if (litersOfFuel >= 25)
                {
                    Console.WriteLine($"You have enough {typeOfFuel.ToLower()}.");
                }
                else
                {
                    Console.WriteLine($"Fill your tank with {typeOfFuel.ToLower()}!");
                }
            }
            else
            {
                Console.WriteLine("Invalid fuel!");
            }
        }
    }
}
