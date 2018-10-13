// Encryptor
// A Program that allows users to encrypt/decrypt a given string using XOR Encryption.
// The user must enter a password in order to use this program.
//
// Author: Peter Forsling
// Version: 1.0 - October 8, 2018
//
// Version Log: 1.0 - October 8, 2018
//              * Implemented all front end: input string, output string, password prompting,
//                incorrect password error checking.
//              * Implemented all back end: Password Encryption, String Encryption.


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace EncryptorDecryptor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EncryptDecrypt_Click(object sender, EventArgs e)
        {
            //prompt for the password. If it's good, then encrypt/decrypt
            string userGivenPassword = Interaction.InputBox("Please enter the password:", "Password", "", -1, -1);

            //If password is incorrect, give an error prompt
            if (!EncryptorModel.PasswordKeeper.VerifyPassword(userGivenPassword))
            {
                MessageBox.Show("The password is incorrect.", "Incorrect Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else //If the password is correct
            {
                resultTextBox.Text = EncryptorModel.Encryptor.EncryptDecrypt(userGivenText.Text, 'g');
            }
        }
    }
}
