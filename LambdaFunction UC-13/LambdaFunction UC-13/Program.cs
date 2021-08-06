using System;
using System.Text.RegularExpressions;

namespace LambdaFunction_UC_13
{
   public class Program
    {
       public static void Main(string[] args)
        {

            Console.WriteLine("Enter Your Firstname Starts with Capital and it Have Minimum 3 Character");
            string firstName = Console.ReadLine();
            Func<string, bool> validation1 = FirstName => Regex.Match(firstName, "^[A-Z][A-Za-z]{2,}$").Success;
            Console.WriteLine(validation1(firstName));

            Console.WriteLine("Enter Your Lastname Starts with Capital and it Have Minimum 3 Character");
            string lastName = Console.ReadLine();
            Func<string, bool> validation2 = LastName => Regex.Match(lastName, "^[A-Z][A-Za-z]{2,}$").Success;
            Console.WriteLine(validation2(lastName));

            Console.WriteLine("Enter Your EMail Like (Eg:abc01@gmail.com)");
            string eMail = Console.ReadLine();
            Func<string, bool> validation3 = EMail => Regex.Match(eMail, "^[0-9a-z]{1,}[@][a-z]{5}[.][a-z]{3}$").Success;
            Console.WriteLine(validation3(eMail));

            Console.WriteLine("Enter Your Mobilenumber Like (Eg:91 9919819801)");
            string mobileNumber = Console.ReadLine();
            Func<string, bool> validation4 = MobileNumber => Regex.Match(mobileNumber, "^[0-9]{2} [0-9]{10}$").Success;
            Console.WriteLine(validation4(mobileNumber));

            Console.WriteLine("Enter Your Password Should Have Minimum 8 Characters, Atleast 1 Uppercase, Atleast 1 Numeric Number and Exactly 1 Special Character");
            string password = Console.ReadLine();
            Func<string, bool> validation5 = Password => Regex.Match(password, "^[A-Z0-9a-z~,`!@#$%^&*()_./?'+{}:;<>]{8,}$").Success;
            Console.WriteLine(validation5(password));
          
        }
    }
}
