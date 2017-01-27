namespace WindowsFormsApplication
{
    partial class AddUserLevelForm
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
            this.buttonAddUserLevel = new System.Windows.Forms.Button();
            this.labelUserLevel = new System.Windows.Forms.Label();
            this.textBoxUserLevel = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.checkedListBoxUsrLvlAccessList = new System.Windows.Forms.CheckedListBox();
            this.labelSelectUsrLvlFunc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAddUserLevel
            // 
            this.buttonAddUserLevel.Location = new System.Drawing.Point(92, 297);
            this.buttonAddUserLevel.Name = "buttonAddUserLevel";
            this.buttonAddUserLevel.Size = new System.Drawing.Size(90, 30);
            this.buttonAddUserLevel.TabIndex = 13;
            this.buttonAddUserLevel.Text = "Add";
            this.buttonAddUserLevel.UseVisualStyleBackColor = true;
            // 
            // labelUserLevel
            // 
            this.labelUserLevel.AutoSize = true;
            this.labelUserLevel.Location = new System.Drawing.Point(60, 5);
            this.labelUserLevel.Name = "labelUserLevel";
            this.labelUserLevel.Size = new System.Drawing.Size(54, 13);
            this.labelUserLevel.TabIndex = 12;
            this.labelUserLevel.Text = "User level";
            // 
            // textBoxUserLevel
            // 
            this.textBoxUserLevel.Location = new System.Drawing.Point(127, 2);
            this.textBoxUserLevel.Multiline = true;
            this.textBoxUserLevel.Name = "textBoxUserLevel";
            this.textBoxUserLevel.Size = new System.Drawing.Size(150, 30);
            this.textBoxUserLevel.TabIndex = 11;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(52, 41);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(60, 13);
            this.labelDescription.TabIndex = 10;
            this.labelDescription.Text = "Description";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(127, 38);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(150, 30);
            this.textBoxDescription.TabIndex = 9;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(187, 297);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(90, 30);
            this.buttonCancel.TabIndex = 14;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxUsrLvlAccessList
            // 
            this.checkedListBoxUsrLvlAccessList.FormattingEnabled = true;
            this.checkedListBoxUsrLvlAccessList.Location = new System.Drawing.Point(9, 107);
            this.checkedListBoxUsrLvlAccessList.Name = "checkedListBoxUsrLvlAccessList";
            this.checkedListBoxUsrLvlAccessList.Size = new System.Drawing.Size(268, 184);
            this.checkedListBoxUsrLvlAccessList.TabIndex = 16;
            // 
            // labelSelectUsrLvlFunc
            // 
            this.labelSelectUsrLvlFunc.AutoSize = true;
            this.labelSelectUsrLvlFunc.Location = new System.Drawing.Point(74, 82);
            this.labelSelectUsrLvlFunc.Name = "labelSelectUsrLvlFunc";
            this.labelSelectUsrLvlFunc.Size = new System.Drawing.Size(126, 13);
            this.labelSelectUsrLvlFunc.TabIndex = 17;
            this.labelSelectUsrLvlFunc.Text = "Select user level function";
            // 
            // AddUserLevelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 328);
            this.Controls.Add(this.labelSelectUsrLvlFunc);
            this.Controls.Add(this.checkedListBoxUsrLvlAccessList);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAddUserLevel);
            this.Controls.Add(this.labelUserLevel);
            this.Controls.Add(this.textBoxUserLevel);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxDescription);
            this.Name = "AddUserLevelForm";
            this.Text = "Add user level";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddUserLevel;
        private System.Windows.Forms.Label labelUserLevel;
        private System.Windows.Forms.TextBox textBoxUserLevel;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.CheckedListBox checkedListBoxUsrLvlAccessList;
        private System.Windows.Forms.Label labelSelectUsrLvlFunc;
    }
}