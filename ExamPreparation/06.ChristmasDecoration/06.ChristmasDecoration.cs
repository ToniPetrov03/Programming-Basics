using System;

namespace _06.ChristmasDecoration
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();

            int price = 0;

            while (text != "Stop")
            {
                for (int i = 0; i < text.Length; i++)
                {
                    price += text[i];
                }

                if (budget >= price)
                {
                    Console.WriteLine("Item successfully purchased!");
                }
                else
                {
                    Console.WriteLine("Not enough money!");
                    break;
                }

                text = Console.ReadLine();
            }

            if (text == "Stop")
            {
                Console.WriteLine($"Money left: {budget - price}");
            }
        }
    }
}
