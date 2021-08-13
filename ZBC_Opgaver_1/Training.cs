using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace ZBC_Opgaver_1
{
    public class Training
    {
        public static void TrainingAssignment()
        {

        }

        public static void LetterToMyself()
        {
            int textEnd = 85;
            int leftBorderHeight = 15;

            for (int i = 0; i < 90; i++)
            {
                Console.Write("-");
            }

            // Left border
            for (int i = 0; i < leftBorderHeight; i++)
            {
                Console.SetCursorPosition(0, 1 + i);
                Console.Write("|");
            }

            // Bottom border
            Console.SetCursorPosition(0, leftBorderHeight + 1);
            for (int i = 0; i < 90; i++)
            {
                Console.Write("-");
            }

            // Date
            string date = $"Date: {DateTime.Now.ToString("dd‐MM‐yy")}";
            Console.SetCursorPosition(textEnd - date.Length, 3);
            Console.Write(date);

            string name = $"Carlo Mercuri";
            Console.SetCursorPosition(textEnd - name.Length, 5);
            Console.Write(name);

            string address = $"Skolevej 6c,1";
            Console.SetCursorPosition(textEnd - address.Length, 6);
            Console.Write(address);

            string city = $"2630, Taastrup";
            Console.SetCursorPosition(textEnd - city.Length, 7);
            Console.Write(city);

            string email = $"Email: cmercuri85@gmail.com";
            Console.SetCursorPosition(textEnd - email.Length, 9);
            Console.Write(email);

            // Right border
            for (int i = 0; i < leftBorderHeight; i++)
            {
                Console.SetCursorPosition(90, 1 + i);
                Console.Write("|");
            }

            Console.ReadKey();
        }

        public static void AmericanFlag()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;


            // Stripes
            int stripeMaxX = 90;
            int stripeHeight = 20;

            ConsoleColor stripeColor = ConsoleColor.Red;
            Console.BackgroundColor = stripeColor;

            // 13 stripes, 2 characters each stripe, 90 characters horizontal
            for (int stripes = 0; stripes < 13; stripes++)
            {
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < stripeMaxX; j++)
                    {
                        Console.Write(" ");
                    }

                    // Start another stripe
                    Console.WriteLine();
                }

                // Switch the colors
                stripeColor = stripeColor == ConsoleColor.Red ? ConsoleColor.White : ConsoleColor.Red;
                Console.BackgroundColor = stripeColor;
            }


            // BLUE STARS
            Console.SetCursorPosition(0, 0);

            int blueMaxX = 30;
            int blueMaxY = 10;

            bool oddLine = false;

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            int index = 0;

            for (int i = 0; i < blueMaxY; i++)
            {
                for (int j = 0; j < blueMaxX; j++)
                {
                    // Fancy two-liner version
                    index = oddLine == true ? j : j + 2;
                    Console.Write(index % 5 == 0 ? "*" : " ");

                    // Easier to read version

                    //if (oddLine)
                    //{
                    //    index = j;
                    //    if (index % 5 == 0)
                    //    {
                    //        Console.Write("*");
                    //    }
                    //    else
                    //    {
                    //        Console.Write(" ");
                    //    }
                    //}
                    //else
                    //{
                    //    index = j + 2;
                    //    if (index % 5 == 0)
                    //    {
                    //        Console.Write("*");
                    //    }
                    //    else
                    //    {
                    //        Console.Write(" ");

                    //    }
                    //}


                }

                // Reverse it every main loop
                oddLine = !oddLine;
                // Needs a spacing
                Console.WriteLine();
            }

            // Hide the cursor
            Console.CursorVisible = false;

            // Make it feel like the Superbowl half time           
            SoundPlayer player = new SoundPlayer(Path.Combine(Environment.CurrentDirectory, "Wave/Anthems/usa_anthem.wav"));
            player.PlaySync();

           
        }

        public static void CuriousQuestions()
        {
            string name;
            int age;
            int weight;

        }
    }
}
