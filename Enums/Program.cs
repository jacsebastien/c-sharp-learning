using System;

namespace Enums
{
    // Enum = new type => it needs to be defined at namespace level
    // By default: begin at 0, each value is incremented by 1
    // Best practice: Always set values of enum
    public enum ShippingMethod {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }

    class Program
    {
        static void Main(string[] args)
        {
            var selectedShippingMethod = ShippingMethod.Express;
            Console.WriteLine((int)selectedShippingMethod);  //  3
            Console.WriteLine(selectedShippingMethod.ToString());   // Express
            Console.WriteLine(selectedShippingMethod);  //  Express => Console.WriteLine always used the ToString method

            // Convert int to enum correspondentie
            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);    // Express

            // Convert string to enum correspondentie
            var methodName = "Express";
            // Parse a string to and object with the correspondance of the shippingMethod then cast it to ShippingMethod type
            var shippingMethodFromString = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine((int)shippingMethodFromString);    //  3
        }
    }
}
