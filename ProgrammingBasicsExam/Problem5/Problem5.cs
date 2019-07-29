using System;

namespace Problem5
{
    class Problem5
    {
        static void Main(string[] args)
        {
            int numTickets = int.Parse(Console.ReadLine());

            for (int i = 0; i < numTickets; i++)
            {
                string ticketNumber = Console.ReadLine();

                if (ticketNumber.Length == 4)
                {
                    if (ticketNumber[0] >= 'A' && ticketNumber[0] <= 'Z')
                    {
                        Console.WriteLine($"Seat decoded: {ticketNumber[0]}{ticketNumber[1]}{ticketNumber[2]}");
                    }
                    else
                    {
                        Console.WriteLine($"Seat decoded: {ticketNumber[3]}{ticketNumber[1]}{ticketNumber[2]}");
                    }
                }
                else
                {
                    Console.WriteLine($"Seat decoded: {ticketNumber[0]}{(int)ticketNumber[1]}");
                }
            }
        }
    }
}
