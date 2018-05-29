using System;
using System.Collections.Generic;   // for Lists

namespace ListsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 2, 3, 4 };
            numbers.Add(1); // Lists don't have defined size unlike arrays
            numbers.AddRange(new int[3] {5, 6, 7}); // AddRange takes an IEnumerable as argument (array or list)

            foreach (var number in numbers)
                Console.WriteLine(number);

            
            Console.WriteLine("Index of 1: " + numbers.IndexOf(1)); // Return the first match
            Console.WriteLine("Last Index of 1: " + numbers.LastIndexOf(1));    // retuen the last match

            Console.WriteLine("Count: " + numbers.Count);   // 8

            Console.WriteLine("Remove()");
            // numbers.Remove(1);  // remove the first item that match with "1"
            // foreach (var number in numbers)
            //     Console.WriteLine(number);

            // foreach (var number in numbers) {
                // if(number == 1) {
                    // numbers.Remove(number); // Error: can not use remove inside a foreach loop
                // }
            // }

            for (int i = 0; i < numbers.Count; i++) {
                if(numbers[i] == 1) {
                    numbers.Remove(numbers[i]); // Ok inside a normal for loop
                }
            }

            foreach (var number in numbers)
                Console.WriteLine(number);

            Console.WriteLine("Clear()");

            numbers.Clear();
            Console.WriteLine("Count: " + numbers.Count);   // 0            
        }
    }
}
