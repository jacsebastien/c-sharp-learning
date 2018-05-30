using System;
using System.IO;

namespace FileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = "/Users/me/folder1/file.txt";
            var pathCopy = "/Users/me/folder2/file.txt";
        
            // File =>  static methods
            // For a small number of operations on a file (security checking on each operation)
            File.Copy(path, pathCopy, true);    // copy and override if exists

            File.Delete(path);

            if(File.Exists(path)) {
                // Do something
            }

            var content = File.ReadAllText(path);

            // FileInfo => instance methods
            // For lot of operations on a file (security checking only on creation)
            var fileInfo = new FileInfo(path);
            
            fileInfo.CopyTo(pathCopy);
            fileInfo.Delete();
            if(fileInfo.Exists) {
                // ...
            }
        }
    }
}
