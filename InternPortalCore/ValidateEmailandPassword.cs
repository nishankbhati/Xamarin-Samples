using System;

namespace InternPortalCore
{
    public class ValidateEmailandPassword
    {
        public bool validatePassword(string password)
        {
            Console.WriteLine("PASSWORD "+ password + " -- "+ password.Length);

            return true;
        }

        public bool validateEmail(string email)
        {
            bool validEmail = true;
            // Email Validation Logic 
            return validEmail;
        }
    }
}
