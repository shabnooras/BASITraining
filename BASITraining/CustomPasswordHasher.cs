using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;

namespace BASITraining
{
    public class CustomPasswordHasher : PasswordHasher
    {
        public string HashPassword(string password)
        {
            return Encrypt.GetMD5Hash(password);
        }
        public PasswordVerificationResult VerifHashedPassword(string hashedPassword, string providedPassword)
        {
            if (hashedPassword == HashPassword(providedPassword))
                return PasswordVerificationResult.Success;
            else
                return PasswordVerificationResult.Failed;
        }
    }
}