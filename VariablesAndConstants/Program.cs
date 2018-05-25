using System;

namespace VariablesAndConstants
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number;
            int count = 10;
            // float totalPrice = 20.95;   // Error
            float totalPrice = 20.95f;   // Good
            char character = 'A';   // '' for char
            string pseudo = "Nash"; // "" for string
            bool isWorking = true;

            var numberAuto = 4;     // auto detect type like in js

            const float Pi = 3.14f;
            // Pi = 1; // Error

            // Console.WriteLine(number);  // Error
            number = 2;
            Console.WriteLine(number);  // Good

            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(pseudo);
            Console.WriteLine(isWorking);

            // Format string
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
        }
    }
}
