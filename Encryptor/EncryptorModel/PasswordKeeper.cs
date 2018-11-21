// Password Keeper
// Holds onto the password and the encryption key to determine if the password is correct.
// Used as part of the Encryptor Model.
//
// Author: Peter Forsling
// Version: 1.0 - October 8, 2018
//
// Version Log: 1.0 - October 8, 2018
//              * Added Password and EncryptionKey fields, and VerifyPassword Method.
//
//              1.1 - November 17, 2018
//              * Removed XorKey instance variable, that gets handled in Encryptor now
//              * Updated Password to new XorKey

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
        /// The correct password, encrypted with the EncryptionKey variable
        /// </summary>
        private const string Password = "\t\u001a\r\f\u0016\u0010\u0011NQO";

        /// <summary>
        /// Verifies if the user given password is correct
        /// </summary>
        /// <param name="entered">The user given password</param>
        /// <returns>True if the password is correct, false otherwise</returns>
        public static bool VerifyPassword(string entered)
        {
            return Encryptor.EncryptDecrypt(entered) == Password;
        }

    }

}
