using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[3];   // create an array of int with a length of 3 items
            numbers[0] = 1;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);  // 0 = default value
            Console.WriteLine(numbers[2]);

            var flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);  // false = default value
            Console.WriteLine(flags[2]);

            // declare array and initialize it in same line
            var names = new string[3] {"Jack", "John", "Mary"};
        }
    }
}
