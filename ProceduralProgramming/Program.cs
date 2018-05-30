using System;

namespace ProceduralProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name? ");
            var name = Console.ReadLine();

            var array = new char[name.Length];

            for (int i = name.Length; i > 0; i--) {
                array[name.Length -i] = name[i - 1];
            }

            var reversed = new string(array);
            Console.WriteLine("Reversed name: " + reversed);
        }
    }
}
