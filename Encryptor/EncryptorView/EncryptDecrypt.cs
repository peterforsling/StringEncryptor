// Encryptor
// A Program that allows users to encrypt/decrypt a given string using XOR Encryption.
// The user must enter a password in order to use this program.
//
// Author: Peter Forsling
// Version: 1.1 - October 12, 2018
//
// Version Log: 1.0 - October 8, 2018
//              * Implemented all front end: input string, output string, password prompting,
//                incorrect password error checking.
//              * Implemented all back end: Password Encryption, String Encryption.
//
//              1.1 - October 12, 2018
//              * Fixed a decryption bug involving lower case g by updating the key.


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EncryptorView;
using Microsoft.VisualBasic;

namespace EncryptorDecryptor
{
    public partial class Form1 : Form
    {
        private PasswordWindow pw;
        public Form1()
        {
            pw = new PasswordWindow();
            PasswordWindow.Correct += DisplayResult;
            InitializeComponent();
            
        }

        private void EncryptDecrypt_Click(object sender, EventArgs e)
        {
            //prompt for the password. If it's good, then encrypt/decrypt
            PromptPassword();
        }

        /// <summary>
        /// Creates a new PasswordWindow and shows
        /// the dialog of the PasswordWindow
        /// </summary>
        private void PromptPassword()
        {
            pw = new PasswordWindow();
            pw.ShowDialog();
        }

        /// <summary>
        /// Prints out the result to the resultTextBox, occurs after the correct password was given
        /// </summary>
        private void DisplayResult()
        {
            resultTextBox.Text = EncryptorModel.Encryptor.EncryptDecrypt(userGivenText.Text);
        }
    }
}
