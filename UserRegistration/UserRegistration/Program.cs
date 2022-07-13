using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstName uc1 = new FirstName();
            bool ucTest1 = uc1.validateFirstName("Shruti");
            bool ucTest2 = uc1.validateFirstName("12Shruti");
            bool ucTest3 = uc1.validateFirstName("shruti");
            Console.WriteLine("{0} {1} {2}", (ucTest1) ? "Valid" : "Invalid", (ucTest2) ? "Valid" : "Invalid", (ucTest3) ? "Valid" : "Invalid");
          

            Console.ReadKey();
        }
    }
}