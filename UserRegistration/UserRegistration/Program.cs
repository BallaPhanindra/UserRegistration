using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstName uc1 = new FirstName();
            bool ucTest1 = uc1.validateFirstName("Balla");
            bool ucTest2 = uc1.validateFirstName("12Balla");
            bool ucTest3 = uc1.validateFirstName("Balla");
            Console.WriteLine("{0} {1} {2}", (ucTest1) ? "Valid" : "Invalid", (ucTest2) ? "Valid" : "Invalid", (ucTest3) ? "Valid" : "Invalid");
        

            LastName uc2 = new LastName();
            bool uc2Test1 = uc2.validateLastName("Phani");
            bool uc2Test2 = uc2.validateLastName("12Phani");
            bool uc2Test3 = uc2.validateLastName("verma");
            Console.WriteLine("{0} {1} {2}", (uc2Test1) ? "Valid" : "Invalid", (uc2Test2) ? "Valid" : "Invalid", (uc2Test3) ? "Valid" : "Invalid");
            Console.ReadKey();
        }
    }
}
