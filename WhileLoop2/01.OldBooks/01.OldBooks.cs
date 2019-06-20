using System;

namespace _01.OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string searchableBook = Console.ReadLine();
            int booksInLibrary = int.Parse(Console.ReadLine());

            string book = string.Empty;
            int counter = 0;

            while (counter < booksInLibrary)
            {
                book = Console.ReadLine();

                if (book == searchableBook)
                {
                    Console.WriteLine($"You checked {counter} books and found it.");
                    break;
                }

                counter++;
            }

            if (book != searchableBook)
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }
        }
    }
}
