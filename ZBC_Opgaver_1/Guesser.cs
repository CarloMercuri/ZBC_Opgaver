using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZBC_Opgaver_1
{
    public static class Guesser
    {
        public static void PlayGuesser()
        {
            bool guessed = false;
            Random rand = new Random();

            // The secret number
            int secret = rand.Next(1, 101);
            // Start at one because it's updated at the end of the loop, and if you get 
            // it right on the first attempt, it still took 1 attempts
            int userAttempts = 1;

            Console.WriteLine("Guess a number from 1 to 100.");

            do
            {
                int userGuess = ConsoleTools.GetUserInputInteger();

                if(userGuess == secret)
                {
                    // SUCCESS
                    string risros = GetRightResponse(userAttempts);
                    Console.WriteLine(risros);
                    guessed = true; // this will make it exit the loop
                } else if(userGuess < secret)
                {
                    Console.WriteLine("Not correct! You need to go higher...");
                } else if(userGuess > secret)
                {
                    Console.WriteLine("Not correct! You need to go lower...");
                }

                // Increment the attempts counter
                userAttempts++;

            } while (guessed == false);

            // Standard end subroutine
            ConsoleKey key = ConsoleTools.GetUserChoice(ConsoleKey.R, ConsoleKey.Q,
                "Press R to go again, or Q to quit");

            if (key == ConsoleKey.R)
            {
                Console.Clear();
                PlayGuesser();
            }

            // Else let the method end
        }
        

        /// <summary>
        /// Returns the appropriate response based on the number of attempts
        /// </summary>
        /// <param name="attempts"></param>
        /// <returns></returns>
        private static string GetRightResponse(int attempts)
        {
            if(attempts <= 1)
            {
                return "CONGRATULATIONS! You got it right on the FIRST attempts!";
            } else if(attempts > 1 && attempts < 10)
            {
                return $"Amazing job! You got it right in {attempts} attempts. Did you use Binary search??";
            } else
            {
                return $"Good job! You got it right in {attempts} attempts";
            }

            
        }



    }
}
