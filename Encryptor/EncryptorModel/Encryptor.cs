// Encryptor
// This class encrypts/decrypts strings using XorEncryption as part of the Encryptor Model.
//
// Author: Peter Forsling
// Version: 1.0 - October 8, 2018
// 
// Version Log: 1.0 - October 8, 2018
//              Implemented EncryptDecrypt method

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptorModel
{
    public class Encryptor
    {
        /// <summary>
        /// Encrypts or Decrypts the user given string based on the user given key
        /// Using XOR Encryption.
        /// </summary>
        /// <param name="text">The string to be encrypted/decrypted</param>
        /// <param name="xorKey">The key to base the encryption/decryption off of</param>
        /// <returns>The encrypted/decrypted string</returns>
        public static string EncryptDecrypt(string text, char xorKey)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                //Get the ASCII values of each character in text
                int textCharAscii = (int)text[i];
                int keyCharAscii = (int)xorKey;
                
                //XOR the two ASCII values
                char xorChar = (char)(textCharAscii ^ keyCharAscii);

                //Add the result to the string builder
                result.Append(xorChar);
            }
            return result.ToString();
        }
    }
}
