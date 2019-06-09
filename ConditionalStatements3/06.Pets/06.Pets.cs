using System;

namespace _06.Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int foodLeft = int.Parse(Console.ReadLine());
            double foodDogOneDay = double.Parse(Console.ReadLine());
            double foodCatOneDay = double.Parse(Console.ReadLine());
            double foodTurtleOneDayInGrams = double.Parse(Console.ReadLine());

            double foodTurtleOneDay = foodTurtleOneDayInGrams / 1000;
            double allFood = days * (foodDogOneDay + foodCatOneDay + foodTurtleOneDay);

            if (allFood <= foodLeft)
            {
                double leftFood = Math.Floor(foodLeft - allFood);
                Console.WriteLine($"{leftFood} kilos of food left.");
            }
            else
            {
                double neededFood = Math.Ceiling(allFood - foodLeft);
                Console.WriteLine($"{neededFood} more kilos of food are needed.");
            }
        }
    }
}
