using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptorView
{
    public partial class PasswordWindow : Form
    {
        /// <summary>
        /// Delegate to handle correct passwords.
        /// </summary>
        public delegate void CorrectPasswordHandler();

        /// <summary>
        /// Event to be called when the correct password is given
        /// </summary>
        public static event CorrectPasswordHandler Correct;

        public PasswordWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Determines if the user given password is correct. If it is, call the event handler.
        /// Otherwise, display an error window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConfirmPWButton_Click(object sender, EventArgs e)
        {
            string userGivenPassword = PasswordTextBox.Text;

            //If the password is correct, Encrypt/Decrypt.
            if(EncryptorModel.PasswordKeeper.VerifyPassword(userGivenPassword))
            {
                Correct();
                this.Close();
            }
            else //Otherwise, show an error message
            {
                MessageBox.Show("The password is incorrect.", "Incorrect Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
