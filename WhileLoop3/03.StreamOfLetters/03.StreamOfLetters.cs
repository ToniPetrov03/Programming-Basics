using System;

namespace _03.StreamOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            string text = string.Empty;
            int couterOfC = 0;
            int couterOfO = 0;
            int couterOfN = 0;
            int couterOfSecretCommands = 0;
            bool isSecretLetter = false;

            while (command != "End")
            {
                char letter = char.Parse(command);

                if ((letter >= 'a' && letter <= 'z') || (letter >= 'A' && letter <= 'Z'))
                {
                    if (letter == 'c' && couterOfC < 1)
                    {
                        couterOfC++;
                        couterOfSecretCommands++;
                        isSecretLetter = true;
                    }
                    else if (letter == 'o' && couterOfO < 1)
                    {
                        couterOfO++;
                        couterOfSecretCommands++;
                        isSecretLetter = true;
                    }
                    else if (letter == 'n' && couterOfN < 1)
                    {
                        couterOfN++;
                        couterOfSecretCommands++;
                        isSecretLetter = true;
                    }

                    if (couterOfSecretCommands == 3)
                    {
                        Console.Write($"{text} ");

                        couterOfSecretCommands = 0;
                        couterOfC = 0;
                        couterOfO = 0;
                        couterOfN = 0;
                        text = string.Empty;
                    }
                    else if (isSecretLetter == false)
                    {
                        text += letter;
                    }

                    isSecretLetter = false;
                }

                command = Console.ReadLine();
            }

            if (command == "End" && couterOfSecretCommands == 3)
            {
                Console.WriteLine(text);
            }

        }
    }
}

