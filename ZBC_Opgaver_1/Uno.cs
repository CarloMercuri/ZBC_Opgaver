using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ZBC_Opgaver_1
{
    public static class Uno
    {
        private const int MF_BYCOMMAND = 0x00000000;
        public const int SC_CLOSE = 0xF060;
        public const int SC_MINIMIZE = 0xF020;
        public const int SC_MAXIMIZE = 0xF030;
        public const int SC_SIZE = 0xF000;

        [DllImport("user32.dll")]
        public static extern int DeleteMenu(IntPtr hMenu, int nPosition, int wFlags);

        [DllImport("user32.dll")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();


        public static List<string[]> cardsList = new List<string[]>();

        public static void PlayUno()
        {
            // Size and lock the console. No scrolling, no resizing
            Console.SetWindowSize(140, 40);
            Console.SetBufferSize(140, 40);

            Console.Title = "UNO";

            LockConsole();

            string[] card = new string[15] {new string("________________________"),
                                            new string("| 3                   3 |"),
                                            new string("|                       |"),
                                            new string("|         ####          |"),
                                            new string("|        #     #        |"),
                                            new string("|       #      #        |"),
                                            new string("|             #         |"),
                                            new string("|            #          |"),
                                            new string("|              #        |"),
                                            new string("|               #       |"),
                                            new string("|         #     #       |"),
                                            new string("|          ####         |"),
                                            new string("|                       |"),
                                            new string("| 3                   3 |"),
                                            new string("-------------------------"),
                                            };

            cardsList.Add(card);

            Console.ForegroundColor = ConsoleColor.Black;

            Console.BackgroundColor = ConsoleColor.Yellow;

            PerformanceTests();

            //for (int i = 1; i < card.Length; i++)
            //{
            //    Console.WriteLine(card[i]);
            //}


        }

        private static void PerformanceTests()
        {
            int startX = 5;
            int startY = 5;

            string[] card = cardsList[0];

            for (int i = 0; i < 15; i++)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(startX, startY);
                Console.WriteLine(card[0]);

                for (int j = 1; j < card.Length; j++)
                {
                    Console.WriteLine(card[j]);
                }

                Thread.Sleep(50);

                startX += 2;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
            }
        }

        private static void LockConsole()
        {
            IntPtr handle = GetConsoleWindow();
            IntPtr sysMenu = GetSystemMenu(handle, false);

            if (handle != IntPtr.Zero)
            {
                DeleteMenu(sysMenu, SC_MAXIMIZE, MF_BYCOMMAND);
                DeleteMenu(sysMenu, SC_SIZE, MF_BYCOMMAND);
            }
        }
    }
}
