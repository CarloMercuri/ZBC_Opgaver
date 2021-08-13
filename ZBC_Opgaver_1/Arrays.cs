using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ZBC_Opgaver_1
{
    public static class Arrays
    {
        public static void ArraysOne()
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


            ConsoleKey key = ConsoleTools.GetUserChoice(ConsoleKey.R, ConsoleKey.Q,
                "Press R to start the next Arrays assignment, or Q to quit");

            if (key == ConsoleKey.R)
            {
                Console.Clear();
                ArraysSortAssignment();
            }
        }

        public static void ArraysSortAssignment()
        {
            Console.WriteLine($"Arrays og Bubblesort assignment parts A, B, C");

            Console.WriteLine("Press any key to start...");

            Console.ReadKey();
            Console.Clear();

            int[] mainArray = new int[100];

            Random rand = new Random();

            // Fill the array with random numbers
            for (int i = 0; i < mainArray.Length; i++)
            {
                mainArray[i] = rand.Next(1, 500);
            }


            Console.WriteLine("Array before sorting: ");
            PrintArray(mainArray);

            // Sort it in ascending order
            SortArray(mainArray);

            Console.WriteLine();
            Console.WriteLine("Array AFTER sorting: ");
            PrintArray(mainArray);

            Console.WriteLine("---------------------------");

            // Reverse it
            Array.Reverse(mainArray);

            Console.WriteLine();
            Console.WriteLine("Array after reversing: ");
            PrintArray(mainArray);
            Console.WriteLine();

            ConsoleKey key = ConsoleTools.GetUserChoice(ConsoleKey.R, ConsoleKey.Q,
                   "Press R to start the next Arrays assignment, or Q to quit");

            if (key == ConsoleKey.R)
            {
                Console.Clear();
                ListPlay();
            }
        }

        public static void ListPlay()
        {
            Console.WriteLine("Array og Matematik Assignment. Press any key to start...");

            Console.ReadKey();
            Console.Clear();

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

        /// <summary>
        /// Prints the array in one long line
        /// </summary>
        /// <param name="array"></param>
        private static void PrintArray(int[] array)
        {
            // space it out
            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                if (i == array.Length - 1)
                {
                    // If it's the last one, don't add a comma at the end
                    Console.Write(array[i]);
                }
                else
                {
                    Console.Write(array[i] + ", ");
                }

            }

            Console.WriteLine();
        }

        /// <summary>
        /// Sorts an array in ascending order
        /// </summary>
        /// <param name="arr"></param>
        private static void SortArray(int[] arr)
        {

            int temp = 0;

            // Sort it out (bubble sort)
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    // If the number is higher than the next, swap them out
                    if (arr[j] > arr[j + 1])
                    {
                        // Assign the next to a temp variable
                        temp = arr[j + 1];

                        // Assign the current one to the next
                        arr[j + 1] = arr[j];

                        // Assign the stored temp number to the current one
                        arr[j] = temp;
                    }
                }
            }
        }

       
        /// <summary>
        /// Sorts a List in ascending order
        /// </summary>
        /// <param name="list"></param>
        private static void SortList(List<int> list)
        {

            int temp = 0;

            // Sort it out (bubble sort)
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count - 1; j++)
                {
                    // If the number is higher than the next, swap them out
                    if (list[j] > list[j + 1])
                    {
                        // Assign the next to a temp variable
                        temp = list[j + 1];

                        // Assign the current one to the next
                        list[j + 1] = list[j];

                        // Assign the stored temp number to the current one
                        list[j] = temp;
                    }
                }
            }
        }

    }
}
