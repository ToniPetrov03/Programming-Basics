using System;

namespace _03.StreamOfLetters
{
    class Program
    {
        static bool CheckIfLatin(char letter)
        {
            return (letter >= 'a' && letter <= 'z') || (letter >= 'A' && letter <= 'Z');
        }
        static void Main(string[] args)
        {
            string text = string.Empty;
            bool isCAppeared = false;
            bool isOAppeared = false;
            bool isNAppeared = false;
            string word = string.Empty;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                    break;

                char letter = char.Parse(command);

                if (CheckIfLatin(letter))
                {
                    string latinLetter = letter.ToString();

                    if (latinLetter == "c" && !isCAppeared)
                    {
                        isCAppeared = true;
                        latinLetter = string.Empty;
                    }
                    else if (latinLetter == "o" && !isOAppeared)
                    {
                        isOAppeared = true;
                        latinLetter = string.Empty;
                    }
                    else if (latinLetter == "n" && !isNAppeared)
                    {
                        isNAppeared = true;
                        latinLetter = string.Empty;
                    }

                    word += latinLetter;

                    if (isCAppeared && isOAppeared && isNAppeared)
                    {
                        text += word + " ";

                        isCAppeared = false;
                        isOAppeared = false;
                        isNAppeared = false;
                        word = string.Empty;
                    }
                }
            }

            Console.WriteLine(text);
        }
    }
}

