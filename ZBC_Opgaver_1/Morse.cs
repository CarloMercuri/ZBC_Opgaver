using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZBC_Opgaver_1
{
    public static class Morse
    {
        public static Dictionary<char, string> morseDictionary { get; set; }

        public static void PlayMorse()
        {
            // Initialize the dictionary containing the morse code correspondents to the chars
            InitializeMorseDictionary();


            Console.WriteLine("Input a text to convert...");

            string userInput = Console.ReadLine(); // Get user input

            // all lower case for matching with dictionary
            userInput = userInput.ToLower();

            // Use a string builder
            StringBuilder morseString = new StringBuilder();

            // Go through each char in the string and replace with the morse equivalent and a space
            foreach (char c in userInput)
            {
                if (morseDictionary.ContainsKey(c))
                {
                    morseString.Append(morseDictionary[c] + " "); // Add a space after every character
                }
                else if (c == ' ')
                {
                    // So I've ready about it and apparently you are supposed to write a slash when it's a space between words
                    // Shrug
                    morseString.Append("/ ");
                    continue;
                }
                else
                {
                    // If the dictionary does not contain the character, display unknown
                    // Thought about ignoring it if it's a dot, comma or things like that,
                    // but i'll leave it like this.
                    morseString.Append("UNKNOWN ");
                }



            }

            // Display it back to the user
            Console.WriteLine(morseString.ToString());

            ConsoleKey endChoice = ConsoleTools.GetUserChoice(ConsoleKey.R, ConsoleKey.Q,
               "Press R to go again, or Q to quit");

            if (endChoice == ConsoleKey.R)
            {
                Console.Clear();
                PlayMorse();
            }

            // Else let the method end
        }

        /// <summary>
        /// Fills the dictionary with the Morse code correspondent to each letter / number
        /// </summary>
        static void InitializeMorseDictionary()
        {
            morseDictionary = new Dictionary<char, string>()
                                   {
                                       {'a', ".-"},
                                       {'b', "-..."},
                                       {'c', "-.-."},
                                       {'d', "-.."},
                                       {'e', "."},
                                       {'f', "..-."},
                                       {'g', "--."},
                                       {'h', "...."},
                                       {'i', ".."},
                                       {'j', ".---"},
                                       {'k', "-.-"},
                                       {'l', ".-.."},
                                       {'m', "--"},
                                       {'n', "-."},
                                       {'o', "---"},
                                       {'p', ".--."},
                                       {'q', "--.-"},
                                       {'r', ".-."},
                                       {'s', "..."},
                                       {'t', "-"},
                                       {'u', "..-"},
                                       {'v', "...-"},
                                       {'w', ".--"},
                                       {'x', "-..-"},
                                       {'y', "-.--"},
                                       {'z', "--.."},
                                       {'æ', ".-.-"},
                                       {'ø', "---."},
                                       {'å', ".--.-"},
                                       {'0', "-----"},
                                       {'1', ".----"},
                                       {'2', "..---"},
                                       {'3', "...--"},
                                       {'4', "....-"},
                                       {'5', "....."},
                                       {'6', "-...."},
                                       {'7', "--..."},
                                       {'8', "---.."},
                                       {'9', "----."}
                                   };
        }
    }
}
