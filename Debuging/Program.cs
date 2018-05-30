using System;
using System.Collections.Generic;

namespace Debuging
{
    class Program
    {
        public static void Main(string[] args)
        {
            // var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };    // Works fine
            var numbers = new List<int> { 1, 2 };   // Ooops ... Too small
            // var smallests = GetSmallests(numbers, 3);
            // var smallests = GetSmallests(numbers, -1);  // Oops not valid
            var smallests = GetSmallests(null, 1);  // Oops not valid

            foreach (var number in smallests)
                Console.WriteLine(number);
        }

        public static List<int> GetSmallests(List<int> list, int count)
        {
            if(list == null) {
                throw new ArgumentNullException("list");
            }
            if(count > list.Count || count <= 0) {
                throw new ArgumentOutOfRangeException(
                    "count",
                    "Count should be between 1 and the number of elements in the list"
                );
            }

            var smallests = new List<int>();

            while (smallests.Count < count)
            {
                var min = GetSmallest(list);
                smallests.Add(min);
                list.Remove(min);
            }

            return smallests;
        }

        public static int GetSmallest(List<int> list)
        {
            // Assume the first number is the smallest
            var min = list[0];
            for (var i = 1; i < list.Count; i++)
            {
                if (list[i] > min)
                    min = list[i];
            }
            return min;
        }
    }
}
