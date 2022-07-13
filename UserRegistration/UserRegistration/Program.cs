using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            LastName uc2 = new LastName();
            bool uc2Test1 = uc2.validateLastName("Verma");
            bool uc2Test2 = uc2.validateLastName("12Verma");
            bool uc2Test3 = uc2.validateLastName("verma");
            Console.WriteLine("{0} {1} {2}", (uc2Test1) ? "Valid" : "Invalid", (uc2Test2) ? "Valid" : "Invalid", (uc2Test3) ? "Valid" : "Invalid");
            Console.ReadKey();
        }
    }
}
