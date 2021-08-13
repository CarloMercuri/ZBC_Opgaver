using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ZBC_Opgaver_1
{
    class Metoder
    {
        public static void RunMethods()
        {
            int opgave = ConsoleTools.GetUserInputInteger("Hvilke Opgave vil du køre? Indtast nummeren. (Fra .docx filen 'Metoder - Lette.docx')");

            switch (opgave)
            {
                case 1:
                    Method_1();
                    break;

                case 2:
                    Method_2();
                    break;

                case 3:
                    Method_3();
                    break;

                case 4:
                    Method_4();
                    break;

                case 5:
                    Method_4();
                    break;

                case 6:
                    Method_op6();
                    break;

                case 7:
                    ArrayOne();
                    break;

                case 8:
                    Method_6();
                    break;

                case 9:
                    Lotto.PlayLotto();
                    break;

                case 10:
                    Guesser.PlayGuesser();
                    break;

                case 11:
                    AboutAssignment11();
                    break;

            }


            Console.WriteLine();
            ConsoleKey key = ConsoleTools.GetUserChoice(ConsoleKey.R, ConsoleKey.Q,
                "Press R to make a new selection again, or Q to quit to main menu");

            if (key == ConsoleKey.R)
            {
                RunMethods();
            }

            // Else let the method end


        }

        private static void AboutAssignment11()
        {
            Console.Clear();

            Console.WriteLine($"Those methods are towards the end of this file (Metoder.cs), feel free to check them out :)");

            Console.WriteLine("\n\rPress any key to go back to Methods...");

            Console.ReadKey();
        }


        static void Method_1()
        {
            Console.WriteLine("-- Opgave nr.1 --");
            Console.WriteLine();

            Console.WriteLine("Insert first number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insert second number:");
            int num2 = int.Parse(Console.ReadLine());

            // Adder 
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");

            // Integer division
            Console.WriteLine($"Integer division {num1} / {num2}: {num1 / num2}");

            // Floating point division
            Console.WriteLine($"Floating point division {num1} / {num2} = {(double)num1 / num2}");

            // Som heltal
            Console.WriteLine($"HELTAL: {num1} gå {num2 / num1} gange op i {num2}");

            // Som Decimal
            Console.WriteLine($"DECIMAL: {num1} gå {(double)num2 / num1} gange op i {num2}");

            // Power
            Console.WriteLine($"{num1} to the power of {num2}: {Math.Pow(num1, num2)}");            
        }

        static void Method_2()
        {
            Console.WriteLine("-- Opgave nr.2 --");
            Console.WriteLine();

            // Get the a and b dimensions
            double a = ConsoleTools.GetUserInputDouble("Insert a:");
            double b = ConsoleTools.GetUserInputDouble("Insert b:");

            // Apply pythagoras
            double c = Math.Sqrt(a * a + b * b);

            // Check which is bigger
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

            Console.WriteLine($"c is: {string.Format("{0:0.000}", c)}");
        }

        static void Method_3()
        {
            Console.WriteLine("-- Opgave nr.3 --");

            Betingelser.AgeGame();


        }

        static void Method_4()
        {
            Console.WriteLine("-- Opgave nr. 4 & 5 --");
            Console.WriteLine();

            Console.Write("Going UP!      ");
            Console.Write("Going DOWN!");
            Console.WriteLine();

            // Making 2 columns side by side.

            string spacing = "              ";

            for (int i = 1, j = 10; i <= 10; i++, j--)
            {
                if (i >= 10)
                {
                    // Removing one space because of the extra space required by printing a double digit
                    Console.WriteLine($"{i}{spacing.Remove(spacing.Length - 1)}{j}");
                }
                else
                {
                    Console.WriteLine($"{i}{spacing}{j}");
                }

            }    
        }

        static void Method_op6()
        {
            Console.WriteLine("-- Opgave nr.6 --");
            Console.WriteLine();

            int num = ConsoleTools.GetUserInputInteger("Enter a whole number:");

            Console.WriteLine($"Your number: {num}");

            Console.WriteLine($"Press any key to start counting...");

            Console.ReadKey();

            // The string of empty chars we will use to make the wave effect
            string waveSpacing = "";

            // Going to the right
            for (int i = 0; i < 32; i++)
            {
                num++;
                Console.WriteLine($"{waveSpacing}{num}");

                // Add an empty space 
                waveSpacing += " ";

                // To make it go a bit slower
                Thread.Sleep(12);
            }

            waveSpacing = waveSpacing.Remove(waveSpacing.Length - 1);

            for (int i = 0; i < 16; i++)
            {
                num--;

                // Remove an empty space 
                waveSpacing = waveSpacing.Remove(waveSpacing.Length - 1);
                Console.WriteLine($"{waveSpacing}{num}");

                // To make it go a bit slower
                Thread.Sleep(12);
            }
        }


        public static void ArrayOne()
        {
            int[] array = new int[9];

            // Run through the array
            for (int i = 0; i < array.Length; i++)
            {
                // Insert numbers from 1 to 9
                array[i] = i + 1;

                // If index is 5, insert double the value of the previous
                if (i == 5)
                {
                    array[i] = array[i - 1] * 2;
                }
            }


            // Print it
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Array position {i}: {array[i]}");
            }
        }

        static void Method_6()
        {

            List<int> listeB = new List<int>();

            // Add only even numbers
            for (int i = 2; i <= 20; i += 2)
            {
                listeB.Add(i);
            }

            Console.WriteLine($"Created a new list. Elements in list: ");

            // Regular print
            for (int i = 0; i < listeB.Count; i++)
            {
                Console.WriteLine($"{i} - {listeB[i]}");
            }

            // Remove multiples of 3
            for (int i = 0; i < listeB.Count; i++)
            {
                if (listeB[i] % 3 == 0)
                {
                    listeB.RemoveAt(i);
                }
            }

            Console.WriteLine($"Elements in list after removing multiples of 3: {listeB.Count}");

            for (int i = 0; i < listeB.Count; i++)
            {
                Console.WriteLine($"{i} - {listeB[i]}");
            }

            // Inserting number 17 at index 3
            listeB.Insert(3, 17);

            Console.WriteLine($"Elements in list after inserting 17 on index 3: {listeB.Count}");

            for (int i = 0; i < listeB.Count; i++)
            {
                Console.WriteLine($"{i} - {listeB[i]}");
            }

            Console.WriteLine($"Ready to make a new list in reverse order? Press any key...");
            Console.ReadKey();

            List<int> newList = new List<int>();

            // Copying listeB in newList in reverse order
            for (int i = listeB.Count - 1; i >= 0; i--)
            {
                newList.Add(listeB[i]);
            }

            Console.WriteLine("New list: ");

            for (int i = 0; i < newList.Count; i++)
            {
                Console.WriteLine($"{i} - {newList[i]}");
            }

            Console.WriteLine("Press any key to go back to main menu...");
            Console.ReadKey();
        }

        // Selv definerede

        private static int AddNumbers(int a, int b)
        {
            return a + b;
        }

        private static int DivideIntegers(int a, int b)
        {
            return a / b;
        }

        private static double FloatingDivision(int a, int b)
        {
            return (double)a / b;
        }

        private static double FloatingDivision(double a, double b)
        {
            return a / b;
        }

        private static int CalculateDividend(int a, int b)
        {
            // Performing a simple integer division will give you the number
            // of times that a can be in b
            return b / a;
        }

        private static int FindBiggestNumberInList(List<int> list)
        {
            int temp = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > temp)
                {
                    temp = list[i];
                }
            }

            return temp;
        }

        private static bool ListContains(List<int> list, int x)
        {
            return list.Contains(x);

            // or

            for (int i = 0; i < list.Count; i++)
            {
                if(list[i] == x)
                {
                    return true;
                }
            }

            return false;
        }

        private static int FindAvarageInList(List<int> list)
        {
            int sum = 0;

            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }

            // Return integer division (whole number)
            
            return sum / list.Count;
        }

        private static double FindAvarageInListPrecise(List<int> list)
        {
            double sum = 0;

            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }

            // Return floating point division

            return sum / list.Count;
        }

    }
}
