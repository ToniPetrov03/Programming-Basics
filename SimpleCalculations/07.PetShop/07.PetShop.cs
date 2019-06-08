using System;
namespace _07.PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int numDogs = int.Parse(Console.ReadLine());
            int numOthers = int.Parse(Console.ReadLine());

            decimal price = numDogs * 2.5m + numOthers * 4;

            Console.WriteLine("{0:F2} lv.", price);
        }
    }
}
