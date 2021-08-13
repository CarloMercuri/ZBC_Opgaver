using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZBC_Opgaver_1
{
    public static class Betingelser
    {
        public static void Pythagoras()
        {
            double a = ConsoleTools.GetUserInputDouble("Insert a: ");

            double b = ConsoleTools.GetUserInputDouble("Insert b: ");

            // Apply pythagoras
            double c = Math.Sqrt(a * a + b * b);

            Console.WriteLine();

            if (a > b)
            {
                Console.WriteLine("a > b");
            }
            else if (a < b)
            {
                Console.WriteLine("a < b");
            }
            else
            {
                Console.WriteLine("a = b");
            }

            Console.WriteLine();

            Console.WriteLine($"c is: {string.Format("{0:0.00}", c)}");

            ConsoleKey key = ConsoleTools.GetUserChoice(ConsoleKey.R, ConsoleKey.Q,
             "Press R to go again, or Q to quit");

            if (key == ConsoleKey.R)
            {
                Console.Clear();
                Pythagoras();
            }

            // Else let the method end
        }


        public static void AgeGame()
        {
            Console.WriteLine($"Enter name: ");
            string name = Console.ReadLine();

            int age = ConsoleTools.GetUserInputInteger("Enter age:");

            if (age <= 0)
            {
                Console.WriteLine("Funny.");
            }
            else if(age < 3)
            {
                Console.WriteLine($"{name}, du må gå med ble");
            }
            else if (age >= 3 && age < 15)
            {
                Console.WriteLine($"{name}, du må ingenting");
            }
            else if (age >= 15 && age < 18)
            {
                Console.WriteLine($"{name}, du må drikke");
            }
            else if (age >= 18)
            {
                Console.WriteLine($"{name}, du må stemme og køre bil");
            }

            ConsoleKey key = ConsoleTools.GetUserChoice(ConsoleKey.R, ConsoleKey.Q,
                 "Press R to go again, or Q to quit");

            if (key == ConsoleKey.R)
            {
                Console.Clear();
                AgeGame();
            }

            // Else let the method end

        }

        
    }
}
