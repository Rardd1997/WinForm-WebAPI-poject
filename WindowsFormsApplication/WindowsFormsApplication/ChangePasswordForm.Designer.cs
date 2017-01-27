namespace WindowsFormsApplication
{
    partial class ChangePasswordForm
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelUserName = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelNewPass = new System.Windows.Forms.Label();
            this.textBoxNewPass = new System.Windows.Forms.TextBox();
            this.labelConfirmNewPass = new System.Windows.Forms.Label();
            this.textBoxConfirmNewPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(191, 156);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(90, 30);
            this.buttonSave.TabIndex = 38;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(67, 15);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(58, 13);
            this.labelUserName.TabIndex = 37;
            this.labelUserName.Text = "User name";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(131, 12);
            this.textBoxUserName.Multiline = true;
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(150, 30);
            this.textBoxUserName.TabIndex = 36;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(72, 51);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 13);
            this.labelPassword.TabIndex = 35;
            this.labelPassword.Text = "Password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(131, 48);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(150, 30);
            this.textBoxPassword.TabIndex = 34;
            // 
            // labelNewPass
            // 
            this.labelNewPass.AutoSize = true;
            this.labelNewPass.Location = new System.Drawing.Point(48, 87);
            this.labelNewPass.Name = "labelNewPass";
            this.labelNewPass.Size = new System.Drawing.Size(77, 13);
            this.labelNewPass.TabIndex = 41;
            this.labelNewPass.Text = "New password";
            // 
            // textBoxNewPass
            // 
            this.textBoxNewPass.Location = new System.Drawing.Point(131, 84);
            this.textBoxNewPass.Multiline = true;
            this.textBoxNewPass.Name = "textBoxNewPass";
            this.textBoxNewPass.Size = new System.Drawing.Size(150, 30);
            this.textBoxNewPass.TabIndex = 40;
            // 
            // labelConfirmNewPass
            // 
            this.labelConfirmNewPass.AutoSize = true;
            this.labelConfirmNewPass.Location = new System.Drawing.Point(12, 123);
            this.labelConfirmNewPass.Name = "labelConfirmNewPass";
            this.labelConfirmNewPass.Size = new System.Drawing.Size(113, 13);
            this.labelConfirmNewPass.TabIndex = 43;
            this.labelConfirmNewPass.Text = "Confirm new password";
            // 
            // textBoxConfirmNewPass
            // 
            this.textBoxConfirmNewPass.Location = new System.Drawing.Point(131, 120);
            this.textBoxConfirmNewPass.Multiline = true;
            this.textBoxConfirmNewPass.Name = "textBoxConfirmNewPass";
            this.textBoxConfirmNewPass.Size = new System.Drawing.Size(150, 30);
            this.textBoxConfirmNewPass.TabIndex = 42;
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 195);
            this.Controls.Add(this.labelConfirmNewPass);
            this.Controls.Add(this.textBoxConfirmNewPass);
            this.Controls.Add(this.labelNewPass);
            this.Controls.Add(this.textBoxNewPass);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Name = "ChangePasswordForm";
            this.Text = "ChangePasswordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelNewPass;
        private System.Windows.Forms.TextBox textBoxNewPass;
        private System.Windows.Forms.Label labelConfirmNewPass;
        private System.Windows.Forms.TextBox textBoxConfirmNewPass;
    }
}