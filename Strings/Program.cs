using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Seb";
            String lastName = "Jcq"; // can call the class to create a string (or other types)

            var fullName = firstName + " " + lastName;

            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            var names = new string[3] {"John", "Jack", "Mary"};

            var formattedNames = string.Join(", ", names);

            Console.WriteLine(formattedNames);

            var text = "Hi John\nLook into the following paths:\nC:\\folder1\\folder2\nC:\\folder3\\folder4";
            Console.WriteLine(text);

            var betterText = @"Hi John
Look into the following paths:
C:\folder1\folder2
C:\folder3\folder4";

            Console.WriteLine(betterText);
        }
    }
}
