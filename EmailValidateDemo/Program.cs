using EmailValidateDemo;
using System;
class Program
{
    static void Main(String[] args)
    {
        CheckEmail pattern = new CheckEmail();
        //pattern.CheckEmail("Chetana+des@gmail.com.in");
        //pattern.CheckEmail("Chetanadesle1999@gmail.com.in");
        //pattern.CheckEmail("abc");
        // pattern.CheckEmail("abc@bridgelabz");
        // pattern.CheckEmail("abc@bridgelabz.co");
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
