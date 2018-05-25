using System;
using Classes.CustomMath;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new Person();
            user.FirstName = "John";
            user.LastName = "Doe";
            user.Introduce();

            var calc = new Calculator(); // use custom method from another namespace

            Console.WriteLine(calc.Add(1, 2));
        }
    }
}
