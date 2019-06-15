using System;

namespace _04.NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfFlower = Console.ReadLine();
            int numFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            const double rose = 5;
            const double dahlia = 3.8;
            const double tulip = 2.8;
            const double narcissus = 3;
            const double gladiolus = 2.5;
            double price = 0;

            if (typeOfFlower == "Roses")
            {
                price = rose * numFlowers;
                if (numFlowers > 80)
                {
                    price -= price * 0.1;
                }
            }
            else if (typeOfFlower == "Dahlias")
            {
                price = dahlia * numFlowers;
                if (numFlowers > 90)
                {
                    price -= price * 0.15;
                }
            }
            else if (typeOfFlower == "Tulips")
            {
                price = tulip * numFlowers;
                if (numFlowers > 80)
                {
                    price -= price * 0.15;
                }
            }
            else if (typeOfFlower == "Narcissus")
            {
                price = narcissus * numFlowers;
                if (numFlowers < 120)
                {
                    price += price * 0.15;
                }
            }
            else if (typeOfFlower == "Gladiolus")
            {
                price = gladiolus * numFlowers;
                if (numFlowers < 80)
                {
                    price += price * 0.2;
                }
            }

            if (budget >= price)
            {
                Console.WriteLine($"Hey, you have a great garden with {numFlowers} {typeOfFlower} and {budget - price:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {price - budget:F2} leva more.");
            }
        }
    }
}
