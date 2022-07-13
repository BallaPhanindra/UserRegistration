using System;

namespace UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        { 

            #region UC4 Mobile Number
            MobileNumber uc4 = new MobileNumber();
            bool uc4Test1 = uc4.validateMobileNumber("91 9876543210");
            bool uc4Test2 = uc4.validateMobileNumber("12345678");
            bool uc4Test3 = uc4.validateMobileNumber("123abcd");
            Console.WriteLine("{0} {1} {2}", (uc4Test1) ? "Valid" : "Invalid", (uc4Test2) ? "Valid" : "Invalid", (uc4Test3) ? "Valid" : "Invalid");
            #endregion

            Console.ReadKey();
        }
    }

}