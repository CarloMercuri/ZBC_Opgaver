using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZBC_Opgaver_1
{
    public static class Lotto
    {
        public static void PlayLotto()
        {
            Random rand = new Random();

            // Create and fill up the winning numbers array
            int[] winningNumbers = new int[7];

            for (int i = 0; i < winningNumbers.Length; i++)
            {
                int rnd = 0;

                // No duplicates allowed
                do
                {
                    rnd = rand.Next(1, 21);
                } while (winningNumbers.Contains(rnd));

                winningNumbers[i] = rnd;
            }

            int[] userNumbers = new int[7];

            ConsoleKey choiceKey =  ConsoleTools.GetUserChoice(ConsoleKey.R, ConsoleKey.S,
                "Type R if you want your numbers to be random, or S if you want to input them yourself.");
            
            Console.WriteLine();


            // Pretty clear I hope
            if (choiceKey == ConsoleKey.R)
            {
                userNumbers = GenerateRandomUserNumbers();
            }
            else if (choiceKey == ConsoleKey.S)
            {
                userNumbers = GetUserNumbers();
            }
           
            
           

            DisplayNumbers(userNumbers);

            Console.WriteLine("Are you ready to check if you won? Press any key!");
            Console.ReadLine();

            // Check how many numbers you got right
            int matches = CheckMatches(userNumbers, winningNumbers);

            // Calculate winnings
            if(matches <= 2)
            {
                Console.WriteLine($"Sorry, you only got {matches} matches. Not enough.");
            } else
            {
                Console.WriteLine($"Congratulations! You got {matches} numbers right!");

                // Let's automate this and make the win exponential
                // instead of having a specific case for each
                int win = 150;

                for (int i = 0; i < matches; i++)
                {
                    win *= matches;
                }

                Console.WriteLine($"You just won {win} pirate slaps!");
            }

            ConsoleKey key =  ConsoleTools.GetUserChoice(ConsoleKey.R, ConsoleKey.Q,
                "Press R to play again, or Q to quit");

            if(key == ConsoleKey.R)
            {
                PlayLotto();
            }

            // Else let the method end
          
            
        }

        /// <summary>
        /// Returns the number of matches between two int arrays
        /// </summary>
        /// <param name="userNumbers"></param>
        /// <param name="winningNumbers"></param>
        /// <returns></returns>
        private static int CheckMatches(int[] userNumbers, int[] winningNumbers)
        {
            int matches = 0;

            foreach(int i in userNumbers)
            {
                // Check if there's a match and increase the match counter
                if (winningNumbers.Contains(i))
                {
                    matches++;
                }
            }

            return matches;
        }

        /// <summary>
        /// Returns an array with randomly generated numbers between 1 and 20
        /// </summary>
        /// <returns></returns>
        private static int[] GenerateRandomUserNumbers()
        {
            int[] userNumbers = new int[7];
                
            Random rand = new Random();

            // Goes over every array index and generates a new unique random number
            // Uses loop to keep attempting until it gets a number that's not been
            // assigned before to other indexes
            for (int i = 0; i < 7; i++)
            {
                int rnd;

                // No duplicates allowed
                do
                {
                    rnd = rand.Next(1, 21);
                } while (userNumbers.Contains(rnd));

                userNumbers[i] = rnd;
            }

            return userNumbers;
        }

        /// <summary>
        /// Requires the user to input their numbers
        /// </summary>
        /// <returns></returns>
        private static int[] GetUserNumbers()
        {
            Console.Clear();

            // Initialize at -1, useful later
            int[] userNumbers = new int[7];

            // Force to till it up
            for (int i = 0; i < 7; i++)
            {
                DisplayNumbers(userNumbers); // eye candy

                Console.WriteLine();
                Console.WriteLine("Insert a new (unique) number");

                double val = 0;

                // Gets an integer from the user
                while (true)
                {
                    string userInput = Console.ReadLine();

                    if (userInput.Length <= 0)
                    {
                        Console.WriteLine("Invalid input");
                        continue;
                    }

                    // Check that it only contains numbers
                    if (!IsInputOnlyDigits(userInput))
                    {
                        Console.WriteLine("Invalid input: must only contain numbers");
                    }

                    // See if the input is valid
                    if (double.TryParse(userInput, out val))
                    {
                        if (val < 1 || val > 20)
                        {
                            Console.WriteLine("Invalid! Number must be between 1 and 20.");
                            continue;
                        }

                        // No duplicates
                        if (userNumbers.Contains((int)val))
                        {
                            Console.WriteLine("You already have that number! Choose a new one...");
                        }
                        else
                        {
                            userNumbers[i] = (int)val;
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input! Try again..");
                    }
                }


                Console.Clear();
            }


            return userNumbers;
           


        }

        /// <summary>
        /// Checks that an input ( a string) only contains digits
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private static bool IsInputOnlyDigits(string input)
        {
            foreach (char c in input)
            {
                // check that it's a number (unicode)
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        /// <summary>
        /// Displays the chosen numbers on the screen
        /// </summary>
        /// <param name="userNumbers"></param>
        private static void DisplayNumbers(int[] userNumbers)
        {
            Console.Write("Your numbers: ");

            for (int i = 0; i < 7; i++)
            {
                if(userNumbers[i] != -1)
                {
                    Console.Write(userNumbers[i] + " ");
                }
                else
                {
                    Console.Write("x ");
                }
                              
            }

            Console.WriteLine();
        }
    }
}
