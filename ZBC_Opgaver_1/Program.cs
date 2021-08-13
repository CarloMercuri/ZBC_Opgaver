using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace ZBC_Opgaver_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Main body of the program
            //BasicProgramming.StartProgram();

            DriveInfo cDrive = new DriveInfo(System.Environment.CurrentDirectory);
            var driverPath = cDrive.RootDirectory;

            Console.WriteLine(Environment.CurrentDirectory);
            Console.WriteLine(driverPath);

            Console.WriteLine();
            Console.ReadLine();
        }

    }
}
