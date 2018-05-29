using System;

namespace StringsAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Seb Jcqs ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());   // remove space at begining/end of string
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper()); 
        }
    }
}
