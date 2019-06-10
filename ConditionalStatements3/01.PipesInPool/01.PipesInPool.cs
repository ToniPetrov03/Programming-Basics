using System;

namespace _01.PipesInPool
{
    class Program
    {
        static void Main(string[] args)
        {
            double volume = double.Parse(Console.ReadLine());
            double debitFirstPipe = double.Parse(Console.ReadLine());
            double debitSecondPipe = double.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            double debitAllPipes = (debitFirstPipe + debitSecondPipe) * hours;

            if (volume >= debitAllPipes)
            {
                double percentFilled = debitAllPipes / volume * 100;
                double percentFirstPipe = debitFirstPipe * hours / debitAllPipes * 100;
                double percentSecondPipe = debitSecondPipe * hours / debitAllPipes * 100;
                Console.WriteLine("The pool is {0:F2}% full. Pipe 1: {1:F2}%. Pipe 2: {2:F2}%.", percentFilled, percentFirstPipe, percentSecondPipe);
            }
            else if (volume < debitAllPipes)
            {
                Console.WriteLine("For {0:F2} hours the pool overflows with {1:F2} liters.", hours, debitAllPipes - volume);
            }
        }
    }
}
