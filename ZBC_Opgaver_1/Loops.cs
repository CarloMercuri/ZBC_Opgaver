using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZBC_Opgaver_1
{
    public static class Loops
    {
        public static void LoopsAssignment()
        {
            Console.WriteLine("Press any key to start Opgave A");
            Console.ReadKey();

            // Count up from 0 to 99
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Press any key to start Opgave B");
            Console.ReadKey();
            // Clear the console
            Console.Clear();

            // Count up from 0 to 99 and print i < 50
            for (int i = 0; i < 100; i++)
            {
                if (i < 50) Console.WriteLine(i);
            }

            Console.WriteLine("Press any key to start Opgave C");
            Console.ReadKey();
            // Clear the console
            Console.Clear();

            int count = 0;

            // Count up from 0 to 99 with while loop
            while (count < 100)
            {
                Console.WriteLine(count);
                count++;
            }

            Console.WriteLine("Press any key to start Opgave D");
            Console.ReadKey();
            // Clear the console
            Console.Clear();

            // count from 100 to 0
            for (int i = 100; i >= 0; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Press any key to go back to main menu...");
            Console.ReadKey();
        }


    }
}
