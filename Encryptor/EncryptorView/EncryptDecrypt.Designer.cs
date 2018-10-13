namespace EncryptorDecryptor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.userGivenText = new System.Windows.Forms.TextBox();
            this.userGivenTextLabel = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userGivenText
            // 
            this.userGivenText.Location = new System.Drawing.Point(12, 56);
            this.userGivenText.Multiline = true;
            this.userGivenText.Name = "userGivenText";
            this.userGivenText.Size = new System.Drawing.Size(334, 349);
            this.userGivenText.TabIndex = 0;
            // 
            // userGivenTextLabel
            // 
            this.userGivenTextLabel.AutoSize = true;
            this.userGivenTextLabel.Location = new System.Drawing.Point(12, 36);
            this.userGivenTextLabel.Name = "userGivenTextLabel";
            this.userGivenTextLabel.Size = new System.Drawing.Size(186, 17);
            this.userGivenTextLabel.TabIndex = 1;
            this.userGivenTextLabel.Text = "To be Encrypted/Decrypted:";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(428, 56);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(334, 349);
            this.resultTextBox.TabIndex = 2;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(425, 36);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(52, 17);
            this.resultLabel.TabIndex = 3;
            this.resultLabel.Text = "Result:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "Encrypt/Decrypt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.EncryptDecrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.userGivenTextLabel);
            this.Controls.Add(this.userGivenText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userGivenText;
        private System.Windows.Forms.Label userGivenTextLabel;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button button1;
    }
}

