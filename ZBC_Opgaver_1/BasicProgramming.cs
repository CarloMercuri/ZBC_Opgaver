using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZBC_Opgaver_1
{
    public static class BasicProgramming
    {
        public static void StartProgram()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\n\r/////////  Variables, Konstants og Datatyper  ////////\n\r");

                Console.WriteLine("1 - Celciusomregner");
                Console.WriteLine("2 - Valutaomregner");
                Console.WriteLine("3 - Rumfanget");
                Console.WriteLine("4 - Lidt Matematik");
                Console.WriteLine();

                Console.WriteLine("\n\r/////////  BETINGELSER  ////////\n\r");
                Console.WriteLine("5 - Terningkastet");
                Console.WriteLine("6 - Pythagoras");
                Console.WriteLine("7 - Alder");
                Console.WriteLine("8 - Gæt et tal");
                Console.WriteLine("9 - Porto");
                Console.WriteLine("10 - Morsekoden");

                Console.WriteLine("\n\r/////////  LøKKER  ////////\n\r");

                Console.WriteLine("11 - Igang med løkker");
                Console.WriteLine("12 - Primtal");

                Console.WriteLine("\n\r/////////  ARRAYS  ////////\n\r");
                Console.WriteLine("13 - Arrays");
                Console.WriteLine("14 - Arrays og Bubblesort");
                Console.WriteLine("15 - Array og Matematik");
                Console.WriteLine("16 - Lotto");
                Console.WriteLine("17 - Mozard");

                Console.WriteLine("\n\r/////////  METHODS  ////////\n\r");

                Console.WriteLine("18 - Go to Methods assignment");
                Console.WriteLine("19 - Go to Methods(Files) assignment");

                Console.WriteLine();

                int choice = ConsoleTools.GetUserInputInteger("Make a selection:");

                RunAssignment(choice);


            }


        }

        private static void RunAssignment(int selection)
        {
            Console.Clear();

            // De er i rækkefølge

            switch (selection)
            {
                // Variable, konstanter og datatype //

                case 1: Vkd.CelciusCalculator(); break;       // Calciusomregner
                case 2: Vkd.RunCurrencyCalculator(); break;   // Valutaomregner
                case 3: Vkd.CalculateArea();  break;          // Rumfanget
                case 4: Vkd.Mathematics(); break;             // Lidt matematik
                    // ASK ABOUT GAR GANGE (metoder 1)


                        // Betingelser //

                case 5: DiceRoll.RollDice(); break;            // Terningkastet
                case 6: Betingelser.Pythagoras(); break;       // Pythagoras
                case 7: Betingelser.AgeGame(); break;          // Alder
                case 8: Guesser.PlayGuesser(); break;          // Gæt et tal
                case 9: Porto.CalculatePorto(); break;         // Porto
                case 10: Morse.PlayMorse(); break;             // Morsekoden

                          // Løkker //

                case 11: Loops.LoopsAssignment(); break;        // Igang med løkker
                case 12: Primes.FindPrimesInRange(100); break;  // Primtal

                         // Arrays //

                case 13: Arrays.ArraysOne(); break;             // Array
                case 14: Arrays.ArraysSortAssignment(); break;  // Arrays og Bubblesort
                case 15: Arrays.ListPlay(); break;              // Array og Matematik
                case 16: Lotto.PlayLotto(); break;              // Lotto
                case 17: Mozart.MozartProgram(); break;         // Mozart

                    // Metoder - Lette // 

                case 18: Metoder.RunMethods(); break;           

                    // Metoder - Filer //

                case 19: Files.RunAssignment(); break;          
                    

            }
        }
    }
}
