// Password Keeper
// Holds onto the password and the encryption key to determine if the password is correct.
// Used as part of the Encryptor Model.
//
// Author: Peter Forsling
// Version: 1.0 - October 8, 2018
//
// Version Log: 1.0 - October 8, 2018
//              Added Password and EncryptionKey fields, and VerifyPassword Method.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptorModel
{
    public class PasswordKeeper
    {
        /// <summary>
        /// The key to use to encrypt password attempts
        /// </summary>
        private const char EncryptionKey = '6';

        /// <summary>
        /// The correct password, encrypted with the EncryptionKey variable
        /// </summary>
        private const string Password = "@SDE_YX\a\u0018\u0006";

        /// <summary>
        /// Verifies if the user given password is correct
        /// </summary>
        /// <param name="entered">The user given password</param>
        /// <returns>True if the password is correct, false otherwise</returns>
        public static bool VerifyPassword(string entered)
        {
            return Encryptor.EncryptDecrypt(entered, EncryptionKey) == Password;
        }

    }

}
