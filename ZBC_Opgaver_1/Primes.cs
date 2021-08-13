using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZBC_Opgaver_1
{
    public static class Primes
    {
        public static void FindPrimesInRange(int max)
        {
            // from 0 to max INCLUSIVE
            for (int i = 0; i <= max; i++)
            {
                if (IsPrime(i))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                } else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                }

                Console.WriteLine(i);
            }

            ConsoleKey endChoice = ConsoleTools.GetUserChoice(ConsoleKey.R, ConsoleKey.Q,
               "Press R to go again, or Q to quit");

            if (endChoice == ConsoleKey.R)
            {
                Console.Clear();
                FindPrimesInRange(100);
            }

            // Else let the method end
        }

        private static bool IsPrime(int value)
        {
            // First two basic checks
            if (value == 2) return true;
            if (value <= 1) return false;
            if (value == 5) return true;

            // Check if it's divisible by 2 and 5 to weed out the easy ones
            if (value % 2 == 0) return false;
            if (value % 5 == 0) return false;

            // Only need to test numbers up to the square root of the value being tested
            var limit = (int)Math.Floor(Math.Sqrt(value));

            // Check values up to square root   
            for (int i = 3; i <= limit; i += 2)
            {
                if (value % i == 0)
                    return false;
            }

            // At this point, the number is prime
            return true;
                

        }
    }
}
