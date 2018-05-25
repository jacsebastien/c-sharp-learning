using System;
using Classes.CustomMath;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new Person();    // No need to import if it's in the same namespace
            user.FirstName = "John";
            user.LastName = "Doe";
            user.Introduce();

            var calc = new Calculator(); // use custom method from another namespace => need import from Classes.CustomMath

            Console.WriteLine(calc.Add(1, 2));
        }
    }
}
