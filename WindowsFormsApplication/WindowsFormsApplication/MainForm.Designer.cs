namespace WindowsFormsApplication
{
    partial class MainForm
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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageUser = new System.Windows.Forms.TabPage();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.buttonViewUser = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dataGridViewUserList = new System.Windows.Forms.DataGridView();
            this.tabPageUserLevel = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonAddUserLevelList = new System.Windows.Forms.Button();
            this.buttonView = new System.Windows.Forms.Button();
            this.dataGridViewUserLevel = new System.Windows.Forms.DataGridView();
            this.tabPageUserLevelFunc = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RecordRef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuncCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuncName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserLevelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserLevelDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastUpdated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastAccessed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlMain.SuspendLayout();
            this.tabPageUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserList)).BeginInit();
            this.tabPageUserLevel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserLevel)).BeginInit();
            this.tabPageUserLevelFunc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageUser);
            this.tabControlMain.Controls.Add(this.tabPageUserLevel);
            this.tabControlMain.Controls.Add(this.tabPageUserLevelFunc);
            this.tabControlMain.Location = new System.Drawing.Point(-2, -4);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(617, 307);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageUser
            // 
            this.tabPageUser.Controls.Add(this.buttonAddUser);
            this.tabPageUser.Controls.Add(this.buttonViewUser);
            this.tabPageUser.Controls.Add(this.textBoxSearch);
            this.tabPageUser.Controls.Add(this.buttonSearch);
            this.tabPageUser.Controls.Add(this.dataGridViewUserList);
            this.tabPageUser.Location = new System.Drawing.Point(4, 24);
            this.tabPageUser.Name = "tabPageUser";
            this.tabPageUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUser.Size = new System.Drawing.Size(609, 279);
            this.tabPageUser.TabIndex = 0;
            this.tabPageUser.Text = "User";
            this.tabPageUser.UseVisualStyleBackColor = true;
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Location = new System.Drawing.Point(102, 6);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(90, 30);
            this.buttonAddUser.TabIndex = 4;
            this.buttonAddUser.Text = "Add";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            // 
            // buttonViewUser
            // 
            this.buttonViewUser.Location = new System.Drawing.Point(6, 6);
            this.buttonViewUser.Name = "buttonViewUser";
            this.buttonViewUser.Size = new System.Drawing.Size(90, 30);
            this.buttonViewUser.TabIndex = 3;
            this.buttonViewUser.Text = "View";
            this.buttonViewUser.UseVisualStyleBackColor = true;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(357, 6);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(150, 30);
            this.textBoxSearch.TabIndex = 2;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(513, 6);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(90, 30);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Find";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridViewUserList
            // 
            this.dataGridViewUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUserList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.FirstName,
            this.LastName,
            this.Status,
            this.UserLevel,
            this.LastUpdated,
            this.LastAccessed});
            this.dataGridViewUserList.Location = new System.Drawing.Point(6, 42);
            this.dataGridViewUserList.Name = "dataGridViewUserList";
            this.dataGridViewUserList.Size = new System.Drawing.Size(597, 234);
            this.dataGridViewUserList.TabIndex = 0;
            // 
            // tabPageUserLevel
            // 
            this.tabPageUserLevel.Controls.Add(this.textBox1);
            this.tabPageUserLevel.Controls.Add(this.button3);
            this.tabPageUserLevel.Controls.Add(this.buttonAddUserLevelList);
            this.tabPageUserLevel.Controls.Add(this.buttonView);
            this.tabPageUserLevel.Controls.Add(this.dataGridViewUserLevel);
            this.tabPageUserLevel.Location = new System.Drawing.Point(4, 24);
            this.tabPageUserLevel.Name = "tabPageUserLevel";
            this.tabPageUserLevel.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUserLevel.Size = new System.Drawing.Size(609, 279);
            this.tabPageUserLevel.TabIndex = 1;
            this.tabPageUserLevel.Text = "UserLevel";
            this.tabPageUserLevel.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(357, 6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 30);
            this.textBox1.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(513, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 30);
            this.button3.TabIndex = 10;
            this.button3.Text = "Find";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // buttonAddUserLevelList
            // 
            this.buttonAddUserLevelList.Location = new System.Drawing.Point(102, 6);
            this.buttonAddUserLevelList.Name = "buttonAddUserLevelList";
            this.buttonAddUserLevelList.Size = new System.Drawing.Size(90, 30);
            this.buttonAddUserLevelList.TabIndex = 8;
            this.buttonAddUserLevelList.Text = "Add";
            this.buttonAddUserLevelList.UseVisualStyleBackColor = true;
            // 
            // buttonView
            // 
            this.buttonView.Location = new System.Drawing.Point(6, 6);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(90, 30);
            this.buttonView.TabIndex = 3;
            this.buttonView.Text = "View";
            this.buttonView.UseVisualStyleBackColor = true;
            // 
            // dataGridViewUserLevel
            // 
            this.dataGridViewUserLevel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUserLevel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserLevelName,
            this.UserLevelDesc});
            this.dataGridViewUserLevel.Location = new System.Drawing.Point(6, 42);
            this.dataGridViewUserLevel.Name = "dataGridViewUserLevel";
            this.dataGridViewUserLevel.Size = new System.Drawing.Size(597, 234);
            this.dataGridViewUserLevel.TabIndex = 2;
            // 
            // tabPageUserLevelFunc
            // 
            this.tabPageUserLevelFunc.Controls.Add(this.textBox2);
            this.tabPageUserLevelFunc.Controls.Add(this.button4);
            this.tabPageUserLevelFunc.Controls.Add(this.button2);
            this.tabPageUserLevelFunc.Controls.Add(this.dataGridView1);
            this.tabPageUserLevelFunc.Location = new System.Drawing.Point(4, 24);
            this.tabPageUserLevelFunc.Name = "tabPageUserLevelFunc";
            this.tabPageUserLevelFunc.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUserLevelFunc.Size = new System.Drawing.Size(609, 279);
            this.tabPageUserLevelFunc.TabIndex = 2;
            this.tabPageUserLevelFunc.Text = "UserLevelAccess";
            this.tabPageUserLevelFunc.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(357, 6);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 30);
            this.textBox2.TabIndex = 20;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(513, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 30);
            this.button4.TabIndex = 19;
            this.button4.Text = "Find";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 30);
            this.button2.TabIndex = 17;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RecordRef,
            this.FuncCode,
            this.FuncName});
            this.dataGridView1.Location = new System.Drawing.Point(6, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(597, 234);
            this.dataGridView1.TabIndex = 13;
            // 
            // RecordRef
            // 
            this.RecordRef.HeaderText = "RecordRef";
            this.RecordRef.Name = "RecordRef";
            this.RecordRef.ReadOnly = true;
            // 
            // FuncCode
            // 
            this.FuncCode.HeaderText = "Function code";
            this.FuncCode.Name = "FuncCode";
            this.FuncCode.ReadOnly = true;
            // 
            // FuncName
            // 
            this.FuncName.HeaderText = "FunctionName";
            this.FuncName.Name = "FuncName";
            this.FuncName.ReadOnly = true;
            // 
            // UserLevelName
            // 
            this.UserLevelName.HeaderText = "User level";
            this.UserLevelName.Name = "UserLevelName";
            // 
            // UserLevelDesc
            // 
            this.UserLevelDesc.HeaderText = "Description";
            this.UserLevelDesc.Name = "UserLevelDesc";
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First name";
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last name";
            this.LastName.Name = "LastName";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // UserLevel
            // 
            this.UserLevel.HeaderText = "User level";
            this.UserLevel.Name = "UserLevel";
            // 
            // LastUpdated
            // 
            this.LastUpdated.HeaderText = "Last updated";
            this.LastUpdated.Name = "LastUpdated";
            // 
            // LastAccessed
            // 
            this.LastAccessed.HeaderText = "Last accessed";
            this.LastAccessed.Name = "LastAccessed";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 301);
            this.Controls.Add(this.tabControlMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabControlMain.ResumeLayout(false);
            this.tabPageUser.ResumeLayout(false);
            this.tabPageUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserList)).EndInit();
            this.tabPageUserLevel.ResumeLayout(false);
            this.tabPageUserLevel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserLevel)).EndInit();
            this.tabPageUserLevelFunc.ResumeLayout(false);
            this.tabPageUserLevelFunc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageUser;
        private System.Windows.Forms.TabPage tabPageUserLevel;
        private System.Windows.Forms.TabPage tabPageUserLevelFunc;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Button buttonViewUser;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridView dataGridViewUserList;
        private System.Windows.Forms.DataGridView dataGridViewUserLevel;
        private System.Windows.Forms.Button buttonAddUserLevelList;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecordRef;
        private System.Windows.Forms.DataGridViewTextBoxColumn FuncCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn FuncName;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastUpdated;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastAccessed;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserLevelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserLevelDesc;
    }
}

