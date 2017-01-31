namespace WindowsFormsApplication
{
    partial class ViewUserLevelForm
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
            this.labelSelectUsrLvlFunc = new System.Windows.Forms.Label();
            this.checkedListBoxUsrLvlAccessList = new System.Windows.Forms.CheckedListBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelUserLevel = new System.Windows.Forms.Label();
            this.textBoxUserLevel = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSelectUsrLvlFunc
            // 
            this.labelSelectUsrLvlFunc.AutoSize = true;
            this.labelSelectUsrLvlFunc.Location = new System.Drawing.Point(73, 89);
            this.labelSelectUsrLvlFunc.Name = "labelSelectUsrLvlFunc";
            this.labelSelectUsrLvlFunc.Size = new System.Drawing.Size(126, 13);
            this.labelSelectUsrLvlFunc.TabIndex = 25;
            this.labelSelectUsrLvlFunc.Text = "Select user level function";
            // 
            // checkedListBoxUsrLvlAccessList
            // 
            this.checkedListBoxUsrLvlAccessList.FormattingEnabled = true;
            this.checkedListBoxUsrLvlAccessList.Location = new System.Drawing.Point(8, 114);
            this.checkedListBoxUsrLvlAccessList.Name = "checkedListBoxUsrLvlAccessList";
            this.checkedListBoxUsrLvlAccessList.Size = new System.Drawing.Size(283, 184);
            this.checkedListBoxUsrLvlAccessList.TabIndex = 24;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(201, 304);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(90, 30);
            this.buttonCancel.TabIndex = 23;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(104, 304);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(90, 30);
            this.buttonSave.TabIndex = 22;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelUserLevel
            // 
            this.labelUserLevel.AutoSize = true;
            this.labelUserLevel.Location = new System.Drawing.Point(74, 14);
            this.labelUserLevel.Name = "labelUserLevel";
            this.labelUserLevel.Size = new System.Drawing.Size(54, 13);
            this.labelUserLevel.TabIndex = 21;
            this.labelUserLevel.Text = "User level";
            // 
            // textBoxUserLevel
            // 
            this.textBoxUserLevel.Location = new System.Drawing.Point(141, 11);
            this.textBoxUserLevel.Multiline = true;
            this.textBoxUserLevel.Name = "textBoxUserLevel";
            this.textBoxUserLevel.Size = new System.Drawing.Size(150, 30);
            this.textBoxUserLevel.TabIndex = 20;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(66, 50);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(60, 13);
            this.labelDescription.TabIndex = 19;
            this.labelDescription.Text = "Description";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(141, 47);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(150, 30);
            this.textBoxDescription.TabIndex = 18;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(8, 304);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(90, 30);
            this.buttonDelete.TabIndex = 26;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // ViewUserLevelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 343);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelSelectUsrLvlFunc);
            this.Controls.Add(this.checkedListBoxUsrLvlAccessList);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelUserLevel);
            this.Controls.Add(this.textBoxUserLevel);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxDescription);
            this.Name = "ViewUserLevelForm";
            this.Text = "View user level";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewUserLevelForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSelectUsrLvlFunc;
        private System.Windows.Forms.CheckedListBox checkedListBoxUsrLvlAccessList;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelUserLevel;
        private System.Windows.Forms.TextBox textBoxUserLevel;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button buttonDelete;
    }
}