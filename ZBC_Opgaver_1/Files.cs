using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZBC_Opgaver_1
{
    public static class Files
    {
        private static string textFile = "StarWars.txt";
        private static string directoryName = "Droids";

        public static void RunAssignment()
        {
            

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Choose assignment:");
                Console.WriteLine();
                Console.WriteLine("1 = Write text to file.");
                Console.WriteLine("2 = Read all text from file");
                Console.WriteLine("3 = Delete File");
                Console.WriteLine("4 = Create new Directory");
                Console.WriteLine("5 = Delete Directory");
                Console.WriteLine("6 = Enumerate files");

                Console.WriteLine();

                int opgave = ConsoleTools.GetUserInputInteger("Hvilke Opgave vil du køre? Indtast nummeren.");

                switch (opgave)
                {
                    case 1:
                        WriteTextToFile("Han shot first");
                        break;

                    case 2:
                        ReadAllText(textFile);
                        break;

                    case 3:
                        DeleteFile(textFile);
                        break;

                    case 4:
                        CreateNewDirectory(directoryName);
                        break;

                    case 5:
                        CreateNewDirectory(directoryName);
                        
                        DeleteDirectory(directoryName, true); // delete recursively
                        break;

                    case 6:
                        EnumerateFiles();
                        break;
                }


                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("End of assignment. Are you ready for a new selection? Press any key...");

                Console.ReadKey();
            }

           
        }

        private static void WriteTextToFile(string content)
        {
            File.WriteAllText(@".\" + textFile, content);
            Console.WriteLine($"Written '{content}' to file {Path.GetFullPath(@".\" + textFile)}");
        }

        private static void ReadAllText(string fileName)
        {
            string content = File.ReadAllText(@".\" + fileName);
            Console.WriteLine($"Reading from file: {Path.GetFullPath(@".\" + fileName)}");
            Console.WriteLine();
            Console.WriteLine("Content:");
            Console.WriteLine(content);
        }

        private static void DeleteFile(string fileName)
        {
            File.Delete(@".\" + fileName);
            Console.WriteLine($"Deleted : {Path.GetFullPath(@".\" + fileName)}");
        }

        private static void CreateNewDirectory(string dirName)
        {
            Directory.CreateDirectory(@".\" + dirName);
            Console.WriteLine($"Created new directory: {Path.GetFullPath(@".\" + dirName)}");

        }

        private static void DeleteDirectory(string dirName, bool recursive)
        {
            Directory.Delete(@".\" + dirName, recursive);
            Console.WriteLine($"Deleted directory recursively: {Path.GetFullPath(@".\" + dirName)}");
        }

        private static void EnumerateFiles()
        {
            Directory.CreateDirectory(@".\Droids\Astromech");
            Directory.CreateDirectory(@".\Droids\Protocol");
            File.WriteAllText(@".\Droids\Astromech\R2D2.txt", "beep bop");
            File.WriteAllText(@".\Droids\Protocol\C3P0.txt", "sir!");


            string[] files = Directory.GetFiles(@".\Droids", "*", SearchOption.AllDirectories);

            Console.WriteLine($"Reading all files (including in subdirectories from:");
            Console.WriteLine($"{Path.GetFullPath(@".\Droids")}");

            for (int i = 0; i < files.Length; i++)
            {
                Console.WriteLine(files[i]);
            }
        }

    }
}
