using EmailValidateDemo;
using System;
class Program
{
    static void Main(String[] args)
    {
        CheckEmail pattern = new CheckEmail();
        //pattern.ValidateEmail("Chetana+des@gmail.com.in");
        //pattern.ValidateEmail("Chetanadesle1999@gmail.com.in");
        //pattern.ValidateEmail("abc");
        //pattern.ValidateEmail("abc@bridgelabz");
        //pattern.ValidateEmail("abc@bridgelabz.co");
        bool result = pattern.ValidateEmail("abc.xyz@bridgelabz.co.in");
        if (result == true)
        {
            Console.WriteLine("Email Matches");
        }
        else
        {
            Console.WriteLine("Verify Email Again");
        }
    }
}
