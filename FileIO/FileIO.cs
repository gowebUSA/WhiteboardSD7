using System;
using System.IO;
using System.Linq;

namespace FileIO
{
    class FileIO
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("File IO");
            //-------------------------------------------------------------from online-------------------------------
            string text = File.ReadAllText(@"C:\Users\goric\OneDrive\Documents\MSSA\ASP NET\Exercise\Way Maker.txt");
            Console.WriteLine("\nContents of Way Maker.txt = {0}", text);
            Console.ReadKey();

            Console.WriteLine("\nSecond way of pulling file.");
            string[] lines = File.ReadAllLines(@"C:\Users\goric\OneDrive\Documents\MSSA\ASP NET\Exercise\Way Maker.txt");
            System.Console.WriteLine("\nContents of Way Maker.txt = ");
            foreach (string line in lines)
            {
                // Use a tab to indent each line of the file.
                Console.WriteLine("\t" + line);
            }
            Console.WriteLine(lines.Length);
            File.ReadLines(@"C:\Users\goric\OneDrive\Documents\MSSA\ASP NET\Exercise\Way Maker.txt").Count(lines => !lines.All(char.IsWhiteSpace));
            Console.ReadKey();
            //----------------------stackoverflow.com/questions/713986/how-to-get-number-of-rows-in-file-in-c-----------
            int counter = 0;
            string line2;

            // Read the file and display it line by line.
            StreamReader file = new StreamReader(@"C:\Users\goric\OneDrive\Documents\MSSA\ASP NET\Exercise\Way Maker.txt");
            while ((line2 = file.ReadLine()) != null)
            {
                Console.WriteLine(line2);
                counter++;
            }

            file.Close();
            Console.ReadKey();
        }

    }
}
