using System;

namespace UserRegistration
{
    class Program
    {
            static void Main(string[] args)
            {
                #region UC1 firstname
                FirstName uc1 = new FirstName();
                bool ucTest1 = uc1.validateFirstName("Shruti");
                bool ucTest2 = uc1.validateFirstName("12Shruti");
                bool ucTest3 = uc1.validateFirstName("shruti");
                Console.WriteLine("{0} {1} {2}", (ucTest1) ? "Valid" : "Invalid", (ucTest2) ? "Valid" : "Invalid", (ucTest3) ? "Valid" : "Invalid");
                #endregion

                #region UC2 lastname
                LastName uc2 = new LastName();
                bool uc2Test1 = uc2.validateLastName("Verma");
                bool uc2Test2 = uc2.validateLastName("12Verma");
                bool uc2Test3 = uc2.validateLastName("verma");
                Console.WriteLine("{0} {1} {2}", (uc2Test1) ? "Valid" : "Invalid", (uc2Test2) ? "Valid" : "Invalid", (uc2Test3) ? "Valid" : "Invalid");
                #endregion


                #region UC3 Email
                Email uc3 = new Email();
                bool uc3Test1 = uc3.validateEmail("abc.xyz@bl.co.in");
                bool uc3Test2 = uc3.validateEmail("abc.xyz@in");
                bool uc3Test3 = uc3.validateEmail("abc.@bl.co.in");
                Console.WriteLine("{0} {1} {2}", (uc3Test1) ? "Valid" : "Invalid", (uc3Test2) ? "Valid" : "Invalid", (uc3Test3) ? "Valid" : "Invalid");
                #endregion

                Console.ReadKey();
            }
    }
}