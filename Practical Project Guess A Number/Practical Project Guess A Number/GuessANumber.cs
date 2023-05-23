using System;

namespace Practical_Project_Guess_A_Number
{
    internal class GuessANumber
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();
            int x = 1;
            int y = 101;
            int computerNumber = randomNumber.Next(x, y);
            int triesCount = 0;
            bool restart = false;

            while (triesCount <= 5 || restart == false)
            {
                Console.Write("Guess a number (1-100): ");

                string playerInput = Console.ReadLine();
                bool isValid = int.TryParse(playerInput, out int playerNumber);

                triesCount++;

                if (isValid)
                {
                    if (playerNumber == computerNumber)
                    {
                        Console.WriteLine("You guessed it!");
                        Console.WriteLine("Do you want to restart the game?");
                        string question = Console.ReadLine();
                        if (question == "yes" || question == "Yes")
                        {
                            restart = true;
                            triesCount = 0;
                            x += 100;
                            y += 100;
                            computerNumber = randomNumber.Next(x, y);
                            continue;
                        }
                        else if (question == "no" || question == "No")
                        {
                            break;
                        }

                    }
                    else if (playerNumber > computerNumber)
                    {
                        Console.WriteLine("Too High");
                    }
                    else
                    {
                        Console.WriteLine("Too Low");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
            }

            if (triesCount == 5)
            {
                Console.WriteLine("You have no more tries!");
            }

        }
    }
}
