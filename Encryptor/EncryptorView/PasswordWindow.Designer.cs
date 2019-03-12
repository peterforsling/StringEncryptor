namespace EncryptorView
{
    partial class PasswordWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordWindow));
            this.EnterPasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmPWButton = new System.Windows.Forms.Button();
            this.CancelPWButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EnterPasswordLabel
            // 
            this.EnterPasswordLabel.AutoSize = true;
            this.EnterPasswordLabel.Location = new System.Drawing.Point(38, 21);
            this.EnterPasswordLabel.Name = "EnterPasswordLabel";
            this.EnterPasswordLabel.Size = new System.Drawing.Size(182, 17);
            this.EnterPasswordLabel.TabIndex = 0;
            this.EnterPasswordLabel.Text = "Please Enter the Password:";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(41, 52);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '·';
            this.PasswordTextBox.Size = new System.Drawing.Size(365, 22);
            this.PasswordTextBox.TabIndex = 1;
            // 
            // ConfirmPWButton
            // 
            this.ConfirmPWButton.Location = new System.Drawing.Point(41, 91);
            this.ConfirmPWButton.Name = "ConfirmPWButton";
            this.ConfirmPWButton.Size = new System.Drawing.Size(92, 23);
            this.ConfirmPWButton.TabIndex = 2;
            this.ConfirmPWButton.Text = "Confirm";
            this.ConfirmPWButton.UseVisualStyleBackColor = true;
            this.ConfirmPWButton.Click += new System.EventHandler(this.ConfirmPWButton_Click);
            // 
            // CancelPWButton
            // 
            this.CancelPWButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelPWButton.Location = new System.Drawing.Point(156, 91);
            this.CancelPWButton.Name = "CancelPWButton";
            this.CancelPWButton.Size = new System.Drawing.Size(92, 23);
            this.CancelPWButton.TabIndex = 3;
            this.CancelPWButton.Text = "Cancel";
            this.CancelPWButton.UseVisualStyleBackColor = true;
            // 
            // PasswordWindow
            // 
            this.AcceptButton = this.ConfirmPWButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelPWButton;
            this.ClientSize = new System.Drawing.Size(448, 126);
            this.Controls.Add(this.CancelPWButton);
            this.Controls.Add(this.ConfirmPWButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.EnterPasswordLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(466, 173);
            this.Name = "PasswordWindow";
            this.Text = "Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EnterPasswordLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button ConfirmPWButton;
        private System.Windows.Forms.Button CancelPWButton;
    }
}