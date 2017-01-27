namespace WindowsFormsApplication
{
    partial class AddFuncForm
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelFuncName = new System.Windows.Forms.Label();
            this.textBoxFuncName = new System.Windows.Forms.TextBox();
            this.labelFuncCode = new System.Windows.Forms.Label();
            this.textBoxFuncCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(158, 93);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(90, 30);
            this.buttonCancel.TabIndex = 33;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(62, 93);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(90, 30);
            this.buttonAdd.TabIndex = 32;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // labelFuncName
            // 
            this.labelFuncName.AutoSize = true;
            this.labelFuncName.Location = new System.Drawing.Point(16, 15);
            this.labelFuncName.Name = "labelFuncName";
            this.labelFuncName.Size = new System.Drawing.Size(77, 13);
            this.labelFuncName.TabIndex = 31;
            this.labelFuncName.Text = "Function name";
            // 
            // textBoxFuncName
            // 
            this.textBoxFuncName.Location = new System.Drawing.Point(99, 12);
            this.textBoxFuncName.Multiline = true;
            this.textBoxFuncName.Name = "textBoxFuncName";
            this.textBoxFuncName.Size = new System.Drawing.Size(150, 30);
            this.textBoxFuncName.TabIndex = 30;
            // 
            // labelFuncCode
            // 
            this.labelFuncCode.AutoSize = true;
            this.labelFuncCode.Location = new System.Drawing.Point(21, 51);
            this.labelFuncCode.Name = "labelFuncCode";
            this.labelFuncCode.Size = new System.Drawing.Size(75, 13);
            this.labelFuncCode.TabIndex = 29;
            this.labelFuncCode.Text = "Function code";
            // 
            // textBoxFuncCode
            // 
            this.textBoxFuncCode.Location = new System.Drawing.Point(99, 48);
            this.textBoxFuncCode.Multiline = true;
            this.textBoxFuncCode.Name = "textBoxFuncCode";
            this.textBoxFuncCode.Size = new System.Drawing.Size(150, 30);
            this.textBoxFuncCode.TabIndex = 28;
            // 
            // AddFuncForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 134);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelFuncName);
            this.Controls.Add(this.textBoxFuncName);
            this.Controls.Add(this.labelFuncCode);
            this.Controls.Add(this.textBoxFuncCode);
            this.Name = "AddFuncForm";
            this.Text = "AddFuncForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelFuncName;
        private System.Windows.Forms.TextBox textBoxFuncName;
        private System.Windows.Forms.Label labelFuncCode;
        private System.Windows.Forms.TextBox textBoxFuncCode;
    }
}