using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZBC_Opgaver_1
{
    public static class Area
    {
       public static void CalculateArea()
        {

            DrawSolid();

            //
            // LENGHT
            //

            Console.WriteLine($"Input Lenght (L)");

            // No checks this time
            string lenghtRaw = Console.ReadLine();

            // Replace eventual dots with commas, so the user has a choice of which to use
            string lenghtFormatted = lenghtRaw.Replace('.', ',');

            double lenght = double.Parse(lenghtFormatted);

            //
            // HEIGHT
            //

            Console.WriteLine($"Input Height (H)");

            string heightRaw = Console.ReadLine();

            string heightFormatted = heightRaw.Replace('.', ',');

            double height = double.Parse(heightFormatted);
            
            //
            // DEPTH
            // 

            Console.WriteLine($"Input Depth: (D)");

            string depthRaw = Console.ReadLine();

            // Replace eventual dots with commas, so the user has a choice of which to use
            string depthFormatted = depthRaw.Replace('.', ',');

            double depth = double.Parse(depthFormatted);

            Console.WriteLine($"Solid: {lenght}x{height}x{depth}, Total area: {lenght*height*depth}");

            Console.ReadLine();
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
    }
}
