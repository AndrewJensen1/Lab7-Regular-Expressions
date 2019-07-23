using System;
using System.Text.RegularExpressions;

namespace LAB7_regularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            bool vaildName = false;
            bool vaildEmail = false;
            bool vaildPhoneNumber = false;
            bool vaildDate = false;

            while (vaildName == false)
            {
                Console.WriteLine("What is your name?");
                string userInput = Console.ReadLine();
                vaildName = VerifyName(userInput);
            }
            while (vaildEmail == false)
            {
                Console.WriteLine("What is your Email?");
                string userInput = Console.ReadLine();
                vaildEmail = VerifyEmail(userInput);
            }
            while (vaildPhoneNumber == false)
            {
                Console.WriteLine("What is your Phone Number?");
                string userInput = Console.ReadLine();
                vaildPhoneNumber = VerifyPhoneNumber(userInput);
            }
            while (vaildDate == false)
            {
                Console.WriteLine("What is the Date?");
                string userInput = Console.ReadLine();
                vaildDate = VerifyDate(userInput);
            }
            Console.WriteLine("Good Bye!");

        }
        public static bool VerifyName(string userName)
        {
            bool works = Regex.IsMatch(userName, @"^(([A - Z]{1})[a-z]{2,30})$");
            return works;
        }
        public static bool VerifyEmail(string userEmail)
        {
            bool works = Regex.IsMatch(userEmail, @"^(([a-zA-Z0-9]{5,30})[@]{1}[a-zA-Z0-9]{5,10}\.[a-zA-Z]{3})$");
            return works;
        }
        public static bool VerifyPhoneNumber(string userPhone)
        {
            bool works = Regex.IsMatch(userPhone, @"^(([1-9]{3})([-])([1-9]{3})([-])([0-9]{4}))$");
            return works;
        }
        public static bool VerifyDate(string userDate)
        {
            bool works = Regex.IsMatch(userDate, @"^([0]?[1-9]|[1][0-2])[./-]([0]?[1-9]|[1|2][0-9]|[3][0|1])[./-]([0-9]{4}|[0-9]{2})$");
            return works;

        }
    }
}
