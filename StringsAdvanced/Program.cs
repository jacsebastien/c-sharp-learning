using System;

namespace StringsAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            // Strings are immutable so all methods return a new string
            var fullName = "Seb Jcqs ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());   // remove space at begining/end of string
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper()); 

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);   // from 0 to the index of space
            var lastName = fullName.Substring(index + 1);   // after space to the end of the string

            Console.WriteLine("FirstName: " + firstName);
            Console.WriteLine("LastName: " + lastName);

            var nameParts = fullName.Split(' ');
            Console.WriteLine("FirstName: " + nameParts[0]);
            Console.WriteLine("LastName: " + nameParts[1]);

            Console.WriteLine(fullName.Replace("Seb", "Seba"));
            Console.WriteLine(fullName.Replace('e', 'E'));
            Console.WriteLine(fullName.Replace(' ', '_'));

            // if(String.IsNullOrEmpty(null))   // null
            // if(String.IsNullOrEmpty(" "))   // Not null
            if(String.IsNullOrEmpty(" ".Trim()))   // null
                Console.WriteLine("Invalid");

            if(String.IsNullOrWhiteSpace(" "))   // null
                Console.WriteLine("Invalid");

            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 29.95f;
            Console.WriteLine(price.ToString("C")); // convert to currency string
        }
    }
}
