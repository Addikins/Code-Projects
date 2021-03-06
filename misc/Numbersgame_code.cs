using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Numbers_Game
{
    class NumbersGame
    {
        public static string GetYesNo()
        {
                String receivedResponse = Console.ReadLine();
                if (string.Equals(receivedResponse, "yes", StringComparison.CurrentCultureIgnoreCase) || string.Equals(receivedResponse, "y", StringComparison.CurrentCultureIgnoreCase))
                {
                    return "y";
                }
                else if (string.Equals(receivedResponse, "no", StringComparison.CurrentCultureIgnoreCase) || string.Equals(receivedResponse, "n", StringComparison.CurrentCultureIgnoreCase))
                {
                    return "n";
                }
                else
                {
                    Console.WriteLine("I don't understand, please tell me yes or no.");
                    return "error";
                }
        }
            public static int GetNumber()
        {
            bool correctInput = true;
            int returnedNumber;
            do
            {
                string receivedNumber = Console.ReadLine();
                correctInput = int.TryParse(receivedNumber, out returnedNumber);
                if (!correctInput)
                {
                    Console.WriteLine("Incorrect Input");
                }
                else
                {
                    Console.WriteLine("You gave me " + receivedNumber + "!");
                }
                   
            } while (!correctInput);
            return returnedNumber;
        }
        static void Main(string[] args)
        {
            bool playAgain = true;
            bool correctAnswer = true;
            /*
            bool lowRangeSuccess = true;
            bool highRangeSuccess = true;
            bool rangeAquire = false;
            */
            int high;
            int low;
            do
            {
                Console.WriteLine("Let's play a game! I want you to guess a number for me.");
                Console.WriteLine("First off, give me a low number:");
                /*
                do {
                    string lowInput = Console.ReadLine();
                    lowRangeSuccess = int.TryParse(lowInput, out low);
                    if (!int.TryParse(lowInput, out low))
                    {
                        Console.WriteLine("Please input a low number:");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Thanks!");
                        Console.WriteLine();
                        rangeAquire = true;
                    }
                } while (rangeAquire == false);
                */
                low = GetNumber();
                do
                {
                    Console.WriteLine("Now, please give me a high number:");
                    high = GetNumber();
                    if (high <= low)
                    {
                        Console.WriteLine("This number needs to be higher than the last or we can't play!");
                    }
                } while (high <= low);
                /*
                   do
                   {
                       string highInput = Console.ReadLine();
                       highRangeSuccess = int.TryParse(highInput, out high);
                       if (!int.TryParse(highInput, out high) || low >= high)
                       {
                           Console.WriteLine("Please input a high number:");
                           rangeAquire = false;
                       }
                       else
                       {
                           Console.WriteLine("Thank you again!");
                           Console.WriteLine();
                           rangeAquire = true;
                       }
                   } while (rangeAquire == false);
                       */
                Random random = new Random();
                int returnedValue = random.Next(low, high);
                int Guess;
                int g = 0;
                bool error = false;
                string guessstring;
                Console.WriteLine("I'm thinking of a number between " + low + " and " + high + ", guess it for a cookie!");
                do
                {
                    /*
                     guessstring = (Console.ReadLine());
                    bool success = int.TryParse(guessstring, out Guess);
                    */
                    Guess = GetNumber();
                    g++;
                    if (Guess > high || Guess < low)
                    {
                        g--;
                        Console.WriteLine("Guess a number between " + low + " and " + high + ", ya dork.");
                        Console.WriteLine();
                    }
                    else if (Guess < returnedValue)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Higher than " + Guess);
                        Console.WriteLine("You've made " + g + " guesses! Guess again!");
                        Console.WriteLine();
                    }
                    else if (Guess > returnedValue)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Lower than " + Guess);
                        Console.WriteLine("You've made " + g + " guesses! Guess again!");
                        Console.WriteLine();
                    }
                } while (Guess != returnedValue);
                if (Guess == returnedValue)
                {
                    Console.WriteLine();
                    Console.WriteLine("Good job, you guessed " + returnedValue + " and after " + g + " guesses, you were correct!");
                    Console.WriteLine("Have a cookie <3");
                    Console.WriteLine();
                }
                /*
                String playAgainanswer = Console.ReadLine();
                if (string.Equals(playAgainanswer, "yes", StringComparison.CurrentCultureIgnoreCase) || string.Equals(playAgainanswer, "y", StringComparison.CurrentCultureIgnoreCase))
                {
                                    correctAnswer = true;
                                    }
                */
                do
                {
                    Console.WriteLine("Would you like to play again?");
                    Console.WriteLine();
                    switch (GetYesNo())
                    {
                        case "y":
                            playAgain = true;
                            error = false;
                            break;
                        case "n":
                            playAgain = false;
                            error = false;
                            break;
                        case "error" :
                            error = true;
                            break;
                    }

                } while (error == true);
                if (playAgain == true)
                {
                    Console.WriteLine();
                    Console.WriteLine("Great, let's do this!");
                    Console.WriteLine();
                }
                /*
                else if (string.Equals(playAgainanswer, "no", StringComparison.CurrentCultureIgnoreCase) || string.Equals(playAgainanswer, "n", StringComparison.CurrentCultureIgnoreCase))
                {
                    correctAnswer = true;
                    } 
                    */
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Thanks for playing!");
                    Console.WriteLine();
                }
                /*
                 else
                {
                    correctAnswer = false;
                    Console.WriteLine("I don't understand, please tell me yes or no.");
                }
                */
             
                } while (playAgain == true) ;
            }
        
    }
}
