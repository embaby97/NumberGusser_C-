using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();
            GreatUser();

            while (true)
            {
                // Init correct number randomly
                Random random = new Random();
                int correctNumber = random.Next(1, 10);

                // init guess var
                int guess = 0;

                // Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                // while guess is not correct
                while (guess != correctNumber)
                {
                    //
                    string input = Console.ReadLine();
                   
                    // make sure its a number 
                    if (!int.TryParse(input, out guess))
                    {
                        
                        PrintColorMessege(ConsoleColor.DarkRed, "Its not a number, please try again");
                        continue;
                    }
                    // cast to int and put in guess
                    guess = Int32.Parse(input);


                    //match guess to correct number
                    if (guess != correctNumber)
                    {
                        
                        PrintColorMessege(ConsoleColor.DarkRed, "Wrong number, please try again");
                    }

                }
                string messege = "Correct, congratulations ^.^ ";
                PrintColorMessege(ConsoleColor.Yellow, messege);

                Console.WriteLine("Play again? [Y or N]");
                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    continue;
                }
                else
                {
                    return;
                }

            }
        }
        static void GetAppInfo()
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";

            // change text color 
            Console.ForegroundColor = ConsoleColor.Blue;

            // write out app info 
            Console.WriteLine("{0}: Version {1}.", appName, appVersion);

            // reset text color 
            Console.ResetColor();
        }
        static void GreatUser()
        {
            // ask users name
            Console.WriteLine("What is your name?");

            // get user input
            string inputName = Console.ReadLine();
            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }
        static void PrintColorMessege(ConsoleColor color , string mes)
        {
            // change text color 
            Console.ForegroundColor = color;

            // write Wrong number
            Console.WriteLine(mes);

            // reset text color 
            Console.ResetColor();
        }
    }
}
