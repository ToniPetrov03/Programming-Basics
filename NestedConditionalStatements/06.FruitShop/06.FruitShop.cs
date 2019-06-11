using System;

namespace _06.FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            const double priceBanana = 2.5;
            const double priceApple = 1.2;
            const double priceOrange = 0.85;
            const double priceGrapefruit = 1.45;
            const double priceKiwi = 2.7;
            const double pricePineapple = 5.5;
            const double priceGrapes = 3.85;

            const double higherpriceBanana = 2.7;
            const double higherpriceApple = 1.25;
            const double higherpriceOrange = 0.9;
            const double higherpriceGrapefruit = 1.60;
            const double higherpriceKiwi = 3;
            const double higherpricePineapple = 5.6;
            const double higherpriceGrapes = 4.2;

            switch (dayOfTheWeek)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    switch (fruit)
                    {
                        case "banana": Console.WriteLine("{0:F2}", priceBanana * quantity); break;
                        case "apple": Console.WriteLine("{0:F2}", priceApple * quantity); break;
                        case "orange": Console.WriteLine("{0:F2}", priceOrange * quantity); break;
                        case "grapefruit": Console.WriteLine("{0:F2}", priceGrapefruit * quantity); break;
                        case "kiwi": Console.WriteLine("{0:F2}", priceKiwi * quantity); break;
                        case "pineapple": Console.WriteLine("{0:F2}", pricePineapple * quantity); break;
                        case "grapes": Console.WriteLine("{0:F2}", priceGrapes * quantity); break;
                        default: Console.WriteLine("error"); break;
                    }
                    break;
                case "Saturday":
                case "Sunday":
                    switch (fruit)
                    {
                        case "banana": Console.WriteLine("{0:F2}", higherpriceBanana * quantity); break;
                        case "apple": Console.WriteLine("{0:F2}", higherpriceApple * quantity); break;
                        case "orange": Console.WriteLine("{0:F2}", higherpriceOrange * quantity); break;
                        case "grapefruit": Console.WriteLine("{0:F2}", higherpriceGrapefruit * quantity); break;
                        case "kiwi": Console.WriteLine("{0:F2}", higherpriceKiwi * quantity); break;
                        case "pineapple": Console.WriteLine("{0:F2}", higherpricePineapple * quantity); break;
                        case "grapes": Console.WriteLine("{0:F2}", higherpriceGrapes * quantity); break;
                        default: Console.WriteLine("error"); break;
                    }
                    break;
                default: Console.WriteLine("error"); break;
            }
        }
    }
}
