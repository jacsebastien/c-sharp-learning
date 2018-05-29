using System;

namespace ArraysAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 3, 7, 9, 2, 14, 6 };  // create an array of int with auto detect type

            // Length
            Console.WriteLine("Length: " + numbers.Length);

            // IndexOf()
            Console.WriteLine("Index of 9: " + Array.IndexOf(numbers, 9));

            // Clear()
            Array.Clear(numbers, 0, 2); // reset 2 firsts elements
            Console.WriteLine("Effect of Clear(0, 2)");            
            foreach (var n in numbers)
                Console.WriteLine(n);
            
            // Copy()
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);

            Console.WriteLine("Effect of Copy(3)");            
            foreach (var n in another)
                Console.WriteLine(n);

            // Sort()
            Array.Sort(numbers);

            Console.WriteLine("Effect of Sort()");            
            foreach (var n in numbers)
                Console.WriteLine(n);

            // Reverse()
            Array.Reverse(numbers);

            Console.WriteLine("Effect of Reverse()");            
            foreach (var n in numbers)
                Console.WriteLine(n);
        }
    }
}
