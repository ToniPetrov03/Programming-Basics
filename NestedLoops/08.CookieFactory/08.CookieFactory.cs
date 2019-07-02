using System;

namespace _08.CookieFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int numBatches = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numBatches; i++)
            {
                bool containsEggs = false;
                bool containsFlour = false;
                bool containsSugar = false;

                while (true)
                {
                    string ingredient = Console.ReadLine();

                    switch (ingredient)
                    {
                        case "eggs": containsEggs = true; break;
                        case "flour": containsFlour = true; break;
                        case "sugar": containsSugar = true; break;
                    }

                    if (ingredient == "Bake!")
                    {
                        if (containsEggs && containsFlour && containsSugar)
                        {
                            Console.WriteLine($"Baking batch number {i}...");
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"The batter should contain flour, eggs and sugar!");
                        }
                    }
                }
            }
        }
    }
}
