using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EmailValidateDemo
{
    public class CheckEmail
    {
        //Chetana+des@gmail.com.in
        public static string EMAIL_REGEX = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}";
        //public static string EMAIL_REGEX = "^[a-z]{3,}$";
        //public static string EMAIL_REGEX = "^[a-z]{3,}[@][a-zA-Z]{6,}$";
        //public static string EMAIL_REGEX = "^[a-z]{3,}[@][a-zA-Z]{6,}[.][a-zA-Z]{2,3}$";
        //public static string EMAIL_REGEX = "^[a-z]{3,}+[.-+_]{0,1}[0-9a-zA-Z]+[@]+[a-zA-Z]{6,}[.][a-zA-Z]{2,3}+[.][a-zA-Z]{2,3}$";
        public bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, EMAIL_REGEX);
        }
    }
}
