using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2025_10_07_b_strings_files.Drivers
{
    public static class FileDriver
    {
        public static void Run()
        {
            Console.WriteLine("File Driver Running...");
            WriteTextFile();
        } // end of Run()

        public static void WriteTextFile() {

            string [] lines = { "First line", "Second line", "Third line","Fourth Line" };
            string fileToWrite = "../../../Documents/output.txt";
            File.WriteAllLines(fileToWrite, lines);
            Console.WriteLine($"Wrote to file: {fileToWrite}");

        }
    }
}
