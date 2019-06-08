using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            double foodTurtleOneDay = double.Parse(Console.ReadLine())/1000;

            double allFoods = days * (foodDogOneDay + foodCatOneDay + foodTurtleOneDay);

            if (allFoods <= foodLeft)
            {
                double leftFood = Math.Floor(foodLeft - allFoods);
                Console.WriteLine($"{leftFood} kilos of food left.");
            }
            else
            {
                double neededFood = Math.Ceiling(allFoods - foodLeft);
                Console.WriteLine($"{neededFood} more kilos of food are needed.");
            }
        }
    }
}
