using System;

//Namespace
namespace NumberPrediction
{

    //Main Class
    class Program
    {
        //Entry Point Method
        static void Main(string[] args)
        {
            GetAppInfo();
            GreetUser();

            while (true)
            {

                Random random = new Random();

                //Init correct number
                int correctNumber = random.Next(1, 20);

                //Init guess number
                int guess = 0;

                //Ask user for number
                Console.WriteLine("Guess a number between 1 and 20", guess);


                while (guess != correctNumber)
                {
                    //Get Users input
                    string input = Console.ReadLine();

                    //Make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        PrintColorMsg(ConsoleColor.Red, "This is not a number!");

                        //Keep going
                        continue;
                    }
                    //Cast to int and put into guess var
                    guess = Int32.Parse(input);

                    //Match guess to correct no.
                    if (guess != correctNumber)
                    {
                        PrintColorMsg(ConsoleColor.Red, "Incorrect number, please try again!");
                    }

                }

                //Success msg
                PrintColorMsg(ConsoleColor.Yellow, "CORRECT YOU WIN!!!!!");

                //Ask the user to play again
                Console.WriteLine("Play again? [Y or N]");

                //get answer
                string answer = Console.ReadLine().ToUpper();

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
            // Set app vars
            string appName = "Number Prediction";
            string appVersion = "1.0";
            string appAuthor = "Quentin Papera";

            //Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            //Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset text color
            Console.ResetColor();
        }

        static void GreetUser()
        {
            Console.WriteLine("What is your name?");

            //Get users input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, lets play a game!", inputName);
        }

        static void PrintColorMsg(ConsoleColor color, string msg)
        {
            //Change text color
            Console.ForegroundColor = color;

            //Write out app info
            Console.WriteLine(msg);

            //Reset text color
            Console.ResetColor();
        }
    }
}