using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZBC_Opgaver_1
{
    public static class Porto
    {
        private static int PackageType { get; set; } // 0 == Brev, 1 == Pakke

        /// <summary>
        /// Returns the correct name based on the type. Letter, Package
        /// </summary>
        private static string PackageName
        {
            get { return GetCorrectName(); }
        }

        /// <summary>
        /// Runs the Port program
        /// </summary>
        public static void CalculatePorto()
        {
            // Have the user choose the type (letter or package)
            ConsoleKey key = ConsoleTools.GetUserChoice(ConsoleKey.B, ConsoleKey.P,
                "Type B for Brev, P for Pakke");

                if (key == ConsoleKey.B)
                {
                    PackageType = 0;
                }
                else if (key == ConsoleKey.P)
                {
                    PackageType = 1;
                }
            

            // Get the weight from the user
            int weight = 0; // grams
            
            // Loop in case the weight exceeds the limit
            while (true)
            {
                if(PackageType == 0)
                {
                    weight = ConsoleTools.GetUserInputInteger($"Insert the weight of your {PackageName} in Grams. Max: 2000");
                } else
                {
                    weight = ConsoleTools.GetUserInputInteger($"Insert the weight of your {PackageName} in Grams.");
                }

                if (!IsWeightAllowed(weight))
                {
                    // If not allowed, repeat
                    continue;
                }

                // If it's allowed, exit the loop
                break;
            }

            // Get the package lenght from the user
            int lenght = 0; // cm
            int maxLenght;

            // Calculate the maximum allowed lenght
            if(PackageType == 0)
            {
                maxLenght = 60;
            } else
            {
                maxLenght = 300;
            }

            // Keep asking untill it's a valid lenght
            while (true)
            {
                lenght = ConsoleTools.GetUserInputInteger($"Insert the lenght of your {PackageName} in Centimeters. Max: {maxLenght}");
               
                if (!IsLenghtAllowed(lenght))
                {
                    // If not allowed, repeat
                    continue;
                }

                // If it's allowed, exit the loop
                break;
                
            }

            bool isInternational = false;

            ConsoleKey choiceKey = ConsoleTools.GetUserChoice(ConsoleKey.D, ConsoleKey.U,
               "Type D if you are sending it to Denmark, U if it's international");

            Console.WriteLine();

            if (choiceKey  == ConsoleKey.D)
            {
                isInternational = false;
            }
            else if (choiceKey == ConsoleKey.U)
            {
                isInternational = true;
            }

            Console.Clear();

            Console.WriteLine($"Type: {PackageName}");
            Console.WriteLine($"Weight: {weight}");
            Console.WriteLine($"Lenght: {lenght}");
            Console.WriteLine($"International: {isInternational}");
            Console.WriteLine($"Cost: {CalculateCost(weight, isInternational)} Dkk");
            Console.WriteLine();

            ConsoleKey endChoice = ConsoleTools.GetUserChoice(ConsoleKey.R, ConsoleKey.Q,
                "Press R to go again, or Q to quit");

            if (endChoice == ConsoleKey.R)
            {
                Console.Clear();
                CalculatePorto();
            }

            // Else let the method end

        }

        private static bool IsLenghtAllowed(int lenght)
        {
            if(PackageType == 0) // letter
            {
                if (lenght > 60)
                {
                    Console.WriteLine("Letters can only be up to 60cm!");
                    return false;
                }
            } else
            {
                if(lenght > 300)
                {
                    Console.WriteLine("Packages can only be up to 300cm!");
                    return false;
                }
            }

            return true;
        }

        private static bool IsWeightAllowed(int weight)
        {
            if(PackageType == 0) // Letter
            {
                if(weight > 2000)
                {
                    Console.WriteLine("Letter weight can only be up to 2kg (2000g)!");
                    return false;
                }
            }

            return true;
        }

        private static int CalculateCost(int weight, bool international)
        {
            if(PackageType == 0) // Letter
            {
                // round the weight to the breakpoints
                if (weight <= 50)
                {
                    weight = 50;
                } else if (weight <= 100)
                {
                    weight = 100;
                } else if (weight <= 250)
                {
                    weight = 250;
                } else if (weight <= 500 || weight > 500)
                {
                    weight = 500;
                } 

                // Calculate cost
                switch (weight)
                {
                    case 50:
                        return international ? 33 : 11;

                    case 100:
                        return international ? 33 : 22;

                    case 250:
                        return international ? 66 : 44;

                    case 500:
                        return international ? 99 : 66;

                }
            } else
            {
                // Round to breakpoints
                if (weight <= 1000)
                {
                    weight = 1000;
                } else if (weight <= 2000)
                {
                    weight = 2000;
                } else if (weight <= 5000)
                {
                    weight = 5000;
                } else if (weight <= 10000)
                {
                    weight = 10000;
                } else if (weight <= 15000 || weight > 15000)
                {
                    weight = 15000;
                }

                switch (weight)
                {
                    case 1000:
                        return international ? 190 : 50;

                    case 2000:
                        return international ? 275 : 50;

                    case 5000:
                        return international ? 275 : 60;

                    case 10000:
                        return international ? 445 : 80;

                    case 15000:
                        return international ? 530 : 100;
                }

            }

            // Let's make it happy
            return 0;
        }

        private static string GetCorrectName()
        {
            if(PackageType == 0)
            {
                return "Letter";
            }

            if(PackageType == 1)
            {
                return "Package";
            }

            return "Package";
        }
   
    }
}
