using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZBC_Opgaver_1
{
    public static class DiceRoll
    {
        public static void RollDice()
        {
            int diceRoll = RandomDiceRoll();

            if (diceRoll == 1)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("You rolled a One!");
            }
            else if (diceRoll == 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You rolled a Two!");
            }
            else if (diceRoll == 3)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You rolled a Three!");
            }
            else if (diceRoll == 4)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("You rolled a Four!");
            }
            else if (diceRoll == 5)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("You rolled a Five!");
            }
            else if (diceRoll == 6)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("You rolled a Six!");
            }


            Console.ForegroundColor = ConsoleColor.Gray;

            ConsoleKey key = ConsoleTools.GetUserChoice(ConsoleKey.R, ConsoleKey.Q,
                 "Press R to play again, or Q to quit");

            if (key == ConsoleKey.R)
            {
                Console.WriteLine();
                RollDice();
            }

            // Else let the method end
        }

        private static int RandomDiceRoll()
        {
            Random rand = new Random();
            return rand.Next(1, 7);
        }
    }
}
