using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;
using NAudio.Wave;

namespace ZBC_Opgaver_1
{
    public static class Mozart
    {
        private static int[,] MinuetArray;
        private static int[,] TrioArray;
        private static string FilesFolder = "C:/dev/hoved/ZBC_Opgaver_1/ZBC_Opgaver_1/bin/Debug/Wave";

        public static void MozartProgram()
        {
            InitializeArrays();

            // CODE THAT WORKS WITH NUGET PACKATE NAudio
            // and the method Concatenate. Merges all the wav
            // files selected into one big file, which plays
            // without delays

            // Creates the list with the 16 files we are going to play this time
            string[] filesList = CreateRandomMinuet();

           // the file that will contain the merged sounds
            string newFile = Path.Combine(FilesFolder, "Minuet.wav");

            // Merge the wav files in one big file. Avoids pauses between
            Concatenate(newFile, filesList);

            Console.WriteLine("Playing Minuet");
            SoundPlayer my_wave_file = new SoundPlayer(newFile);
            my_wave_file.PlaySync();

           
            // Repeat for trio
            filesList = CreateRandomTrio();

            // the file that will contain the merged sounds
             newFile = Path.Combine(FilesFolder, "Trio.wav");

            // Merge the wav files in one big file. Avoids pauses between
            Concatenate(newFile, filesList);

            Console.WriteLine("Playing Trio");
            my_wave_file = new SoundPlayer(newFile);
            my_wave_file.PlaySync();

            // CODE THAT WORKS WITHOUT NUGET PACKAGE
            // This plays the wav files one by one.
            // Works fine but there's a little delay between
            // each playback

            //string[] filesList = CreateRandomMinuet();

            //SoundPlayer my_wave_file = new SoundPlayer();

            //foreach (string wavFile in filesList)
            //{
            //    Console.WriteLine($"playing {wavFile}");
            //    my_wave_file.SoundLocation = wavFile;
            //    my_wave_file.PlaySync();
            //}



            ConsoleKey key = ConsoleTools.GetUserChoice(ConsoleKey.R, ConsoleKey.Q,
                "Press R to repeat, or Q to quit");

            if (key == ConsoleKey.R)
            {
                Console.Clear();
                MozartProgram();
            }
        }

        private static void InitializeArrays()
        {
            // Because we roll 2 dices, the minimum roll is 2. I could
            // just add +2 to the roll or something, but I'd rather
            // just make it longer and just put 0s in the first 2 positions


            MinuetArray = new int[16, 13] {                                          // Column number
                        { 0, 0, 96, 32, 69, 40, 148, 104, 152, 119, 98, 3, 54},      // 1
                        { 0, 0, 22, 6, 95, 17, 74, 157, 60, 84, 142, 87, 130},       // 2
                        { 0, 0, 141, 128, 158, 113, 163, 27, 171, 114, 42, 165, 10}, // 3
                        { 0, 0, 41, 63, 13, 85, 45, 167, 53, 50, 156, 61, 103},      // 4
                        { 0, 0, 105, 146, 153, 161, 80, 154, 99, 140, 75, 135, 28},  // 5
                        { 0, 0, 122, 46, 55, 2, 97, 68, 133, 86, 129, 47, 37},       // 6
                        { 0, 0, 11, 134, 110, 159, 36, 118, 21, 169, 62, 147, 106},  // 7
                        { 0, 0, 30, 81, 24, 100, 107, 91, 127, 94, 123, 33, 5},      // 8
                        { 0, 0, 70, 117, 66, 90, 25, 138, 16, 120, 65, 102, 35},     // 9
                        { 0, 0, 121, 39, 139, 176, 143, 71, 155, 88, 77, 4, 20},     // 10
                        { 0, 0, 26, 126, 15, 7, 64, 150, 57, 48, 19, 31, 108},       // 11
                        { 0, 0, 9, 56, 132, 34, 125, 29, 175, 166, 82, 164, 92},     // 12
                        { 0, 0, 112, 174, 73, 67, 76, 101, 43, 51, 137, 144, 12},    // 13
                        { 0, 0, 49, 18, 58, 160, 136, 162, 168, 115, 38, 59, 124},   // 14
                        { 0, 0, 109, 116, 145, 52, 1, 23, 89, 72, 149, 173, 44},     // 15
                        { 0, 0, 14, 83, 79, 170, 93, 151, 172, 111, 8, 78, 131},     // 16
                        };

            TrioArray = new int[16, 7] {                // Column number
                        { 0, 72, 56, 75, 40, 83, 18},   // 1
                        { 0, 6, 82, 39, 73, 3, 45},     // 2
                        { 0, 59, 42, 54, 16, 28, 62},   // 3
                        { 0, 25, 74, 1, 68, 53, 38},    // 4
                        { 0, 81, 14, 65, 29, 37, 4},    // 5
                        { 0, 41, 7, 43, 55, 17, 27},    // 6
                        { 0, 89, 26, 15, 2, 44, 52},    // 7
                        { 0, 13, 71, 80, 61, 70, 94},   // 8
                        { 0, 36, 76, 9, 22, 63, 11},    // 9
                        { 0, 5, 20, 34, 67, 85, 92},    // 10
                        { 0, 46, 64, 93, 49, 32, 24},   // 11
                        { 0, 79, 84, 48, 77, 96, 86},   // 12
                        { 0, 30, 8, 69, 57, 12, 51},    // 13
                        { 0, 95, 35, 58, 87, 23, 60},   // 14
                        { 0, 19, 47, 90, 33, 50, 78},   // 15
                        { 0, 66, 88, 21, 10, 91, 31},   // 16
                        };
        }

        /// <summary>
        /// Returns a list with 16 wav files for the Trio
        /// </summary>
        /// <returns></returns>
        private static string[] CreateRandomTrio()
        {
            string[] list = new string[16];
            int rnd, wav;
            int column = 0;

            for (int i = 0; i < list.Length; i++)
            {
                rnd = RollDices(1);
                // Roll 1 to 6 and combine the whole thing
                list[i] = Path.Combine(FilesFolder, "T" + TrioArray[column, rnd] + ".wav");
                column++;
            }

            return list;
        }

        /// <summary>
        /// Returns a list with 16 wav files for the Minuet
        /// </summary>
        /// <returns></returns>
        private static string[] CreateRandomMinuet()
        {
            string[] list = new string[16];
            int rnd, wav;
            int column = 0;

            for (int i = 0; i < list.Length; i++)
            {
                rnd = RollDices(2);
                list[i] = Path.Combine(FilesFolder, "M" + MinuetArray[column, rnd] + ".wav");
                column++;
            }

            return list;
        }

        // OUTSIDE METHOD. Merges all the specified files into one.
        // I was considering doing it myself, just need to skip the header
        // after the first wav file and just merge the data, but there are
        // issues with versions and so on, so I decided to just use a nuget
        // package instead
        
        public static void Concatenate(string outputFile, IEnumerable<string> sourceFiles)
        {
            byte[] buffer = new byte[1024];
            WaveFileWriter waveFileWriter = null;

            try
            {
                foreach (string sourceFile in sourceFiles)
                {
                    using (WaveFileReader reader = new WaveFileReader(sourceFile))
                    {
                        if (waveFileWriter == null)
                        {
                            // first time in create new Writer
                            waveFileWriter = new WaveFileWriter(outputFile, reader.WaveFormat);
                        }
                        else
                        {
                            if (!reader.WaveFormat.Equals(waveFileWriter.WaveFormat))
                            {
                                throw new InvalidOperationException("Can't concatenate WAV Files that don't share the same format");
                            }
                        }

                        int read;
                        while ((read = reader.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            waveFileWriter.WriteData(buffer, 0, read);
                        }
                    }
                }
            }
            finally
            {
                if (waveFileWriter != null)
                {
                    waveFileWriter.Dispose();
                }
            }

        }

        /// <summary>
        /// Rolls the specified number of 6 faced dice
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        private static int RollDices(int amount)
        {
            int result = 0;
            Random rand = new Random();

            for (int i = 0; i < amount; i++)
            {
                // roll a 6 face dice
                result += rand.Next(1, 7);
            }

            return result;
        }
    }
}
