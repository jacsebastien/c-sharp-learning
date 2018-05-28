using System;

namespace ReferenceTypesAndValueTypes
{
    public class Person {
        public int Age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = a;
            b++;    
            Console.WriteLine(string.Format("a: {0}, b: {1}", a, b)); // int is value type: a = 10 and b = 11

            var array1 = new int[3] {1, 2, 3};
            var array2 = array1;
            array2[0] = 0;  
            Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {0}", array1[0], array2[0])); // array is reference type so both are edited

            var number = 1;
            Increment(number);  // number is passed by value
            Console.WriteLine(number); // 1

            var person = new Person() { Age = 20 };
            MakeOld(person);    // person is passed by reference
            Console.WriteLine(person.Age);  // 30
        }

        // Don't return any value
        public static void Increment(int number) {
            number +=10;
        }

        // Don't return any value
        public static void MakeOld(Person person) {
            person.Age +=10;
        }
    }
}
