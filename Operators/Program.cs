using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 1;
            var b = 2;
            var c = 3;

            Console.WriteLine(a + b);
            Console.WriteLine(a / b); // a and b are int sor the result is int
            Console.WriteLine((float) a / (float) b);   // cast in float so result is in float 

            Console.WriteLine(a + b * c);   // c# take care of operations priority (first b*c, then + a)
            Console.WriteLine((a + b) * c);   // use () like in math to change priorities
            
            Console.WriteLine(a > b);   // false
            Console.WriteLine(a == b);   // false
            Console.WriteLine(a != b);   // true
            Console.WriteLine(!(a != b));   // false  => a == b

            Console.WriteLine(c > b && c > a);   // true & true == true

            Console.WriteLine(c > b || c == a);   // true || false == true
        }
    }
}
