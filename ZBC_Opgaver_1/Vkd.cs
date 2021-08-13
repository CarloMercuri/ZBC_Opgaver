using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZBC_Opgaver_1
{
    public static class Vkd
    {
        public static void CelciusCalculator()
        {
            // Register input
            double userCelcius = ConsoleTools.GetUserInputDouble("Indtast grader i Celcius: ");

            // First print the value the user has given
            Console.WriteLine($"Input: {userCelcius} Celsius");


            // Print the conversions to console while
            // limiting it to 1 decimal place for visual pleasure

            Console.WriteLine($"Fahrenheit = {string.Format("{0:0.#}", userCelcius * 1.8 + 32)}");
            Console.WriteLine($"Reamur = {string.Format("{0:0.#}", userCelcius * 0.8)}");

            ConsoleKey key = ConsoleTools.GetUserChoice(ConsoleKey.R, ConsoleKey.Q,
                 "Press R to go again, or Q to quit");

            if (key == ConsoleKey.R)
            {
                Console.Clear();
                CelciusCalculator();
            }

            // Else let the method end
        }


        public static void RunCurrencyCalculator()
        {
            // Limit it to 2 decimals
            double danishCrowns = ConsoleTools.GetUserInputDouble("Input amount in DKK", 2);

            // Make a space
            Console.WriteLine("");

            double usd = danishCrowns * 0.15812;

            Console.WriteLine($"USD: = {string.Format("{0:0.00}", usd)}");

            double gpp = danishCrowns * 0.11383;

            Console.WriteLine($"GPP: = {string.Format("{0:0.00}", gpp)}");

            double euro = danishCrowns * 0.13446;

            Console.WriteLine($"EURO: = {string.Format("{0:0.00}", euro)}");

            double sek = danishCrowns * 1.3736;

            Console.WriteLine($"SEK: = {string.Format("{0:0.00}", sek)}");

            // End

            ConsoleKey key = ConsoleTools.GetUserChoice(ConsoleKey.R, ConsoleKey.Q,
                 "Press R to play again, or Q to quit");

            if (key == ConsoleKey.R)
            {
                Console.Clear();
                RunCurrencyCalculator();
            }

            // Else let the method end
        }

        public static void CalculateArea()
        {

            DrawSolid();

            //
            // LENGHT
            //

            double lenght =  ConsoleTools.GetUserInputDouble("Input Lenght (L)");

            //
            // HEIGHT
            //

            double height = ConsoleTools.GetUserInputDouble("Input Height (H)");

            //
            // DEPTH
            // 

            double depth = ConsoleTools.GetUserInputDouble("Input Depth (D)");
            Console.WriteLine();

            Console.WriteLine($"Solid: {lenght}x{height}x{depth}, Total area: {lenght * height * depth}");

            ConsoleKey key = ConsoleTools.GetUserChoice(ConsoleKey.R, ConsoleKey.Q,
              "Press R to input new dimensions, or Q to quit");

            if (key == ConsoleKey.R)
            {
                Console.Clear();
                CalculateArea();
            }

            // Else let the method end

        }

        private static void DrawSolid()
        {
            Console.WriteLine("    _____________________________");

            Console.WriteLine("   /                          /  |");
            Console.WriteLine("  /                          /   |");
            Console.WriteLine(" /                          /    |");
            Console.WriteLine("/__________________________/     |");
            Console.WriteLine("|                          |     | H");
            Console.WriteLine("|                          |     |");
            Console.WriteLine("|                          |     | ");
            Console.WriteLine("|                          |     |");
            Console.WriteLine("|                          |     |");
            Console.WriteLine("|                          |    /");
            Console.WriteLine("|                          |   /");
            Console.WriteLine("|                          |  /  D");
            Console.WriteLine("|                          | /");
            Console.WriteLine("|                          |/");

            Console.WriteLine("----------------------------");
            Console.WriteLine("              L");

            // Some spaces
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }

        public static void Mathematics()
        {
            int num1 = ConsoleTools.GetUserInputInteger("Insert first number:");

            int num2 = ConsoleTools.GetUserInputInteger("Insert second number:");

            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");

            Console.WriteLine($"Integer division {num1} / {num2}: {num1 / num2}");

            Console.WriteLine($"Floating point division {num1} / {num2} = {(double)num1 / num2}");

            Console.WriteLine($"{num1} to the power of {num2}: {Math.Pow(num1, num2)}");

            ConsoleKey key = ConsoleTools.GetUserChoice(ConsoleKey.R, ConsoleKey.Q,
                "Press R to go again, or Q to quit");

            if (key == ConsoleKey.R)
            {
                Console.Clear();
                Mathematics();
            }

            // Else let the method end
        }
    }
}
