﻿using System;
using System.Text.RegularExpressions;

namespace LambdaFunction_UC_13
{
   public class Program
    {
       public static void Main(string[] args)
        {

            Func<string, string> validation1 = (firstName) => firstName;
            Console.WriteLine("Enter Your Firstname Starts with Capital and it Have Minimum 3 Character");
            string firstName = Console.ReadLine();
            Console.WriteLine(Regex.Match(firstName, "^[A-Z][A-Za-z]{2,}$").Success);

            Func<string, string> validation2 = (lastName) => lastName;
            Console.WriteLine("Enter Your Lastname Starts with Capital and it Have Minimum 3 Character");
            string lastName = Console.ReadLine();
            Console.WriteLine(Regex.Match(lastName, "^[A-Z][A-Za-z]{2,}$").Success);

            Func<string, string> validation3 = (email) => email;
            Console.WriteLine("Enter Your EMail Like (Eg:abc01@gmail.com)");
            string email = Console.ReadLine();
            Console.WriteLine(Regex.Match(email, "^[0-9a-z]{1,}[@][a-z]{5}[.][a-z]{3}$").Success);

            Func<string, string> validation4 = (mobileNumber) => mobileNumber;
            Console.WriteLine("Enter Your Mobilenumber Like (Eg:91 9919819801)");
            string mobileNumber = Console.ReadLine();
            Console.WriteLine(Regex.Match(mobileNumber, "^[0-9]{2} [0-9]{10}$").Success);

            Func<string, string> validation5 = (password) => password;
            Console.WriteLine("Enter Your Password Should Have Minimum 8 Characters, Atleast 1 Uppercase, Atleast 1 Numeric Number and Exactly 1 Special Character");
            string password = Console.ReadLine();
            Console.WriteLine(Regex.Match(password, "^[A-Z0-9a-z~,`!@#$%^&*()_./?'+{}:;<>]{8,}$").Success);

        }
    }
}