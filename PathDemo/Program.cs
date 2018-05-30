using System;
using System.IO;

namespace PathDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = "/Users/sebastien/www/c-sharp-training/HelloWorld/HelloWorld.csproj";
            
            Console.WriteLine("Path: " + path);
            Console.WriteLine("Extension: " + Path.GetExtension(path));
            Console.WriteLine("File name: " + Path.GetFileName(path));
            Console.WriteLine("File name without extension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory Name: " + Path.GetDirectoryName(path));
        }
    }
}
