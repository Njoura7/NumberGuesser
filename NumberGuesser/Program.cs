using System;
//Name space
namespace NumberGuesser
{
    //Main Class
    class Program
    {
        //Entry point method
        static void Main(string[] args)
        {
            GetAppInfo(); //run GetAppinfo

            GreetUser();


            while (true)
            {
                //create a random new number
                Random random = new Random();
                int correctNumber = random.Next(1, 10);

                //init guess var 
                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    //make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        PrintColorMessage(ConsoleColor.DarkRed, "Please use an acutal number");
                        //keep going
                        continue;
                    }

                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        {
                            PrintColorMessage(ConsoleColor.Red, "Wrong number! Please try again");
                        }
                    }
                }


                PrintColorMessage(ConsoleColor.Yellow, "Nice work, you guessed it!!");

                //ask if user want to play again 
                Console.WriteLine("Play Again? [Y or N]");

                string answer = Console.ReadLine().ToUpper();

                if (answer=="Y")
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
            //Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Njoura";

            //change text color
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("{0}: version{1} by {2}", appName, appVersion, appAuthor);
            //Reset the console color
            Console.ResetColor();

        }

        static void GreetUser()
        {
            //ask for name
            Console.WriteLine("What is your name");

            //get input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0} Let's Play a Game", inputName);
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            //change text color
            Console.ForegroundColor = color;

            Console.WriteLine(message);
            //Reset the console color
            Console.ResetColor();
        }
    }
}
