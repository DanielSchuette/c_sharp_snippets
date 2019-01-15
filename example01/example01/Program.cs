using System;

namespace example01
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string response;
            int solution;
            double magicNum, guess;
            double maxNum = 10.0;

            /* generate a random number and truncate */
            Random rand = new Random();
            magicNum = (rand.NextDouble() * maxNum);
            magicNum = Math.Truncate(magicNum * 10) / 10;

            /* check if user guessed the random double */
            do
            {
                /* get guess from user */
                do
                {
                    /* prompt user */
                    response = PromptForResponse();

                    /* try to convert response to double and truncate */
                    try
                    {
                        guess = Convert.ToDouble(response);
                        guess = Math.Truncate(guess * 10) / 10;
                    }
                    catch (FormatException e)
                    {
                        /* printing the exception returns the entire stack trace */
                        Console.WriteLine("error: '" + response +
                                          "' has bad format ({0})", e);
                        guess = -1.0;
                    }
                } while (!(guess >= 0.0 && guess <= 10.0));

                /* test if guess was the correct solution*/
                solution = CheckGuess(guess, magicNum);

            } while (solution != 1);
        }

        private static string PromptForResponse()
        {
            string response;

            Console.Write("Guess a value between 0.0 and 10.0: ");
            response = Console.ReadLine();

            return response;
        }

        private static int CompareNums(double a, double b)
        {
            /* compare values and return */
            if (a > b)
            {
                return 1;
            }
            else if (b > a)
            {
                return -1;
            }
            else if (a == b) /* values need to be truncated for this comp */
            {
                return 0;
            }

            /* should never be reached */
            return -2;
        }

        private static int CheckGuess(double guess, double answer)
        {
            switch (CompareNums(guess, answer))
            {
                case 0:
                    Console.WriteLine("Your guess was {0}, correct is {1}.",
                                      guess, answer);
                    return 1;
                case 1:
                    Console.WriteLine("Your guess was {0} and is too high.",
                                      guess);
                    return 0;
                case -1:
                    Console.WriteLine("Your guess was {0} and is too low.",
                                      guess);
                    return 0;
                default:
                    Console.WriteLine("An unknown error occured.");
                    return -1;
            }
        }
    }
}