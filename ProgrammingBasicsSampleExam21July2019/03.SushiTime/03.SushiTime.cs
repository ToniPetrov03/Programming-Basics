using System;

namespace _03.SushiTime
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfSushi = Console.ReadLine();
            string resturante = Console.ReadLine();
            int numPortion = int.Parse(Console.ReadLine());
            char YesOrNo = char.Parse(Console.ReadLine());

            bool isRightRestorante = true;
            double totalPrice = 0;

            switch (typeOfSushi)
            {
                case "sashimi":
                    switch (resturante)
                    {
                        case "Sushi Zone": totalPrice += 4.99 * numPortion; break;
                        case "Sushi Time": totalPrice += 5.49 * numPortion; break;
                        case "Sushi Bar": totalPrice += 5.25 * numPortion; break;
                        case "Asian Pub": totalPrice += 4.5 * numPortion; break;
                        default: isRightRestorante = false; break;

                    }
                    break;

                case "maki":
                    switch (resturante)
                    {
                        case "Sushi Zone": totalPrice += 5.29 * numPortion; break;
                        case "Sushi Time": totalPrice += 4.69 * numPortion; break;
                        case "Sushi Bar": totalPrice += 5.55 * numPortion; break;
                        case "Asian Pub": totalPrice += 4.8 * numPortion; break;
                        default: isRightRestorante = false; break;
                    }
                    break;

                case "uramaki":
                    switch (resturante)
                    {
                        case "Sushi Zone": totalPrice += 5.99 * numPortion; break;
                        case "Sushi Time": totalPrice += 4.49 * numPortion; break;
                        case "Sushi Bar": totalPrice += 6.25 * numPortion; break;
                        case "Asian Pub": totalPrice += 5.5 * numPortion; break;
                        default: isRightRestorante = false; break;
                    }
                    break;

                case "temaki":
                    switch (resturante)
                    {
                        case "Sushi Zone": totalPrice += 4.29 * numPortion; break;
                        case "Sushi Time": totalPrice += 5.19 * numPortion; break;
                        case "Sushi Bar": totalPrice += 4.75 * numPortion; break;
                        case "Asian Pub": totalPrice += 5.5 * numPortion; break;
                        default: isRightRestorante = false; break;
                    }
                    break;
            }

            if (YesOrNo == 'Y')
            {
                totalPrice *= 1.2;
            }

            if (isRightRestorante)
            {
                Console.WriteLine($"Total price: {Math.Ceiling(totalPrice)} lv.");
            }
            else
            {
                Console.WriteLine($"{resturante} is invalid restaurant!");
            }
        }
    }
}
