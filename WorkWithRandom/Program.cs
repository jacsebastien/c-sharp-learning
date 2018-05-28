using System;

namespace WorkWithRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            const int PASS_LENGTH = 10;

            var random = new Random();
            var buffer = new char[PASS_LENGTH];

            for(var i = 0; i< PASS_LENGTH; i++) {
                // Console.Write((char)random.Next(97, 122));
                buffer[i] = (char)('a' + random.Next(0, 26));    // get random number between 0 and 26, add it to a then cast it to a char
            }

            // Create a string from a char array
            var password = new string(buffer);
            Console.WriteLine(password);
        }
    }
}
