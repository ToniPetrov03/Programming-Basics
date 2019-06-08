using System;

namespace _04.TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int kilometers = int.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();
            double price = 0.00;

            if (kilometers < 20)
            {
                if (dayOrNight == "day")
                {
                    price = kilometers * 0.79 + 0.7;
                }
                else
                {
                    price = kilometers * 0.9 + 0.7;
                }
            }
            else if (kilometers >= 20 && kilometers < 100)
            {
                price = kilometers * 0.09;
            }
            else if (kilometers >= 100)
            {
                price = kilometers * 0.06;
            }
            Console.WriteLine("{0:F2}", price);
        }
    }
}
