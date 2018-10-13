// Password Encryptor and Decryptor
//
// Implementation of a program that encrypts and decrypts a string using XOR Encryption
// This program has the same encryption algorithm, but is in a console app for testing and
// debugging purposes.
//
// Author: Peter Forsling
// Version: 1.0 - October 8, 2018
//          * Implemented to basic functionality

using EncryptorModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PasswordEncryptor
{
    class ConsoleEncryptor
    {
        static void Main(string[] args)
        {
            char key = '6';
            string s = "version1.0";
            string t = Encryptor.EncryptDecrypt(s, key);
            Console.WriteLine(t);
            Console.WriteLine(PasswordKeeper.VerifyPassword(t));
            Console.ReadLine();

        }

        /// <summary>
        /// Encrypts/Decrypts a string using XOR Encryption
        /// </summary>
        /// <param name="text">The string to be encrypted/decrypted</param>
        /// <param name="key">The XOR key</param>
        /// <returns>An Encrypted/Decrypted version of the given string</returns>
        public static string EncryptDecrypt(string text, char key)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                int textCharAscii = (int)text[i];
                int keyCharAscii = (int)key;

                char xorChar = (char)(textCharAscii ^ keyCharAscii);
                result.Append(xorChar);
            }
           



            return result.ToString();
        }
    }
}
