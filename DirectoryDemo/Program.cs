using System;
using System.IO;

namespace DirectoryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            const string PATH = "/Users/me/www/c-sharp-training";

            // Directory.CreateDirectory(PATH);

            // var files = Directory.GetFiles(PATH, ".cs", SearchOption.AllDirectories); // return all files in the selected directory and sub directories
            // foreach (var file in files)
            //     Console.WriteLine(file);

            var directories = Directory.GetDirectories(PATH, "*.*", SearchOption.AllDirectories);
            foreach (var dir in directories)
                Console.WriteLine(dir);

            Directory.Exists("...");

            var directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();
        }
    }
}
