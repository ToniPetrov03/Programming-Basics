using System;

namespace _05.ChallengeTheWedding
{
    class Program
    {
        static void Main(string[] args)
        {
            int numMan = int.Parse(Console.ReadLine());
            int numWoman = int.Parse(Console.ReadLine());
            int maxNumTables = int.Parse(Console.ReadLine());

            int counter = 0; 

            for (int i = 1; i <= numMan; i++)
            {
                for (int j = 1; j <= numWoman; j++)
                {
                    Console.Write($"({i} <-> {j}) ");

                    counter++;

                    if (maxNumTables == counter)
                    {
                        return;
                    }
                }
            }
        }
    }
}
