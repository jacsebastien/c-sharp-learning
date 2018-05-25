using System;

namespace TypesConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 1;
            int i = b;  // Ok byte is shorten than int
            
            int a = 2;
            // byte c = a; // Error int is larger than byte

            byte c = (byte) a; // Ok because of cast but data can be lost if greater than byte

            var number = "1234";    // is detect as a string
            // int i = (int) number;    // cant cast string to int
            int intNumber = Convert.ToInt32(number);    // Ok
            // byte byteNumber = Convert.ToByte(number);   // Pass build process but app will crash because byte is too small to contain 1234
          
            // Console.WriteLine(intNumber);
            
            // Prevent from crashing
            try
            {
                var numberTry= "1234";    // is detect as a string
                byte byteNumberTry = Convert.ToByte(numberTry);   // Pass build process but app will crash because byte is too small to contain 1234
                Console.WriteLine(byteNumberTry);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte.");
                // throw;
            }

        }
    }
}
