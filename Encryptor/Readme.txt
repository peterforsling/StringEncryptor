Simple String Encryptor
Author: Peter Forsling
Version 1.1 - October 12, 2018

General Description:
This program will take in user given strings and return an encrypted version of the given string, after typing in the correct password.
The user can also supply the encrypted version of the string and the program will decrypt it.

How to Use:
Enter the string you would like to encrypt in the left text box, and once you click that Encrypt/Decrypt button, it will ask for a 
password. The password right now is "version1.0". Please note if you change the passwordkey you will not be able to  enter the right 
password for the Encryptor. Once you enter the correct password, the output will be displayed in the right textbox.
Another important note is that this will only work on strings up to 32 characters long. If you enter a string with a length greater
than 32 characters, the output will be the first 32 encrypted characters of the string.

What this program is built on:

EncryptorView
Author: Peter Forsling
Version 1.0 - October 8, 2018
EncryptorView is the front end of this program. The GUI consists of a WindowsFormApp called EncryptDecrypt. It contains a text box for
users to input their string to encrypt/decrypt, a button to do so, and an output textbox after the encryption algorithm has been applied
to the string. When the Encrypt/Decrypt button has been pressed, it will open a MessageBox and ask for a password. If the password is 
correct, then the given string will be Encrypted/Decrypted through the EncryptorModel and the output will be displayed in the other
text box.

EncryptorModel
Author: Peter Forsling
EncryptorModel is a Class Library that contains the actual Encryption algorithm, and handles the password for the program.
EncryptorModel contains the following classes:
	Encryptor
	Author: Peter Forsling
	Version 1.0 - October 8, 2018
	Encryptor contains a single method called EncryptDecrypt, which does the actual encryption process of the user given string. The
	string is processed through XOR Encryption and is used with a literal key value. Because it's XOR Encryption with the same key
	every time, You can Encrypt the string and Decrypt it back to its original form.

	PasswordKeeper
	Author: Peter Forsling
	Version 1.0 - October 8, 2018
	PasswordKeeper has a Password data member that is encrypted with a constant key. The class has one method called VerifyPassword 
	and it works by running the Encryptor on the user given password, and checking if it is equal to the password data member. This
	is used to ensure that only people who know the password can Encrypt/Decrypt.

Other Files Found in this Solution:
Readme.txt - Provides information about the project.

ConsoleEncryptor
Author: Peter Forsling
Version 1.0 - October 8, 2018
This program contains the same encryption algorithm as the Encryptor in EncryptorModel, but is a ConsoleApp and is used for testing and
debugging purposes.

Version Log:
1.0 - October 8, 2018
Built to basic functionality, treats the user given string as one string. Currently has hard-coded key values for the XOR key. Only 
seems to work on strings with a length of up to 32.

1.1 - October 12, 2018
Fixed a bug involving incorrect decryption with 'g'

To Do List:
[] - Rebuild the password window so the characters are hidden
[] - Figure out why it only works up to 32 characters
		* Perhaps make the user input an array of strings and encrypt each string?
[] - Combine the multiple model classes into one?
[] -  Make it take in a file and encrypt/decrypt every string
[] - Allow the user to supply the key value
[] - Allow the user to set up the password