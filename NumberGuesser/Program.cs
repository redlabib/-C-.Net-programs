using System;

// Namespace
namespace NumberGuesser
{
    // Main class
    class Program
    {
        // Entry point method
        static void Main(string[] args)
        {
            GetAppInfo();                                                          // Runs GetAppInfo function
            GreetUser();                                                           // Asks for user name and greets

            while (true)                                                           // Continues the game if user wants to keep playing
            {
                Random rand = new Random();                                        // Init guess number
                int correctNumber = rand.Next(1, 10);                              // Correct no. between 1 and 10
                int guess = 0;                                                     // Init guess var

                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();
                    if (!int.TryParse(input, out guess))                          // Check if int
                    {
                        PrintColorMessage(ConsoleColor.Red, "Please use a number.");
                        continue;
                    }
                    guess = Int32.Parse(input);                                   // Converts string to int

                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again.");
                    }
                }
                PrintColorMessage(ConsoleColor.Yellow, "Well done! You have guessed the correct number!");

                Console.WriteLine("Do you want to play again? [Y or N]");        // Asks user if they want to continue
                string answer = Console.ReadLine().ToUpper();                    // Get answer and changes always to upper case

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        } 

        static void GetAppInfo()
        {
            // App vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Red Labib";

            Console.ForegroundColor = ConsoleColor.Green;                                       // Change text color
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);       // Outputs app info
            Console.ResetColor();
        }

        static void GreetUser()
        {
            Console.WriteLine("What is your name?");                            //Asks for user input
            string inputName = Console.ReadLine();
            Console.WriteLine("Hello {0}, let's play a game...", inputName);   //Prints message + user input
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;               // Change text color
            Console.WriteLine(message);
            Console.ResetColor();
        }

    }
}