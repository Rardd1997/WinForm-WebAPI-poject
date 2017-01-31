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
            this.buttonFindUser = new System.Windows.Forms.Button();
            this.dataGridViewUserList = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastUpdated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastAccessed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageUserLevel = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonFindUserLevel = new System.Windows.Forms.Button();
            this.buttonAddUserLevel = new System.Windows.Forms.Button();
            this.buttonViewUserLevel = new System.Windows.Forms.Button();
            this.dataGridViewUserLevel = new System.Windows.Forms.DataGridView();
            this.UserLevelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserLevelDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageUserLevelFunc = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonFindUserLevelAccess = new System.Windows.Forms.Button();
            this.buttonAddUserLevelAccess = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RecordRef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuncCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuncName = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tabPageUser.Controls.Add(this.buttonFindUser);
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
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // buttonViewUser
            // 
            this.buttonViewUser.Location = new System.Drawing.Point(6, 6);
            this.buttonViewUser.Name = "buttonViewUser";
            this.buttonViewUser.Size = new System.Drawing.Size(90, 30);
            this.buttonViewUser.TabIndex = 3;
            this.buttonViewUser.Text = "View";
            this.buttonViewUser.UseVisualStyleBackColor = true;
            this.buttonViewUser.Click += new System.EventHandler(this.buttonViewUser_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(357, 6);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(150, 30);
            this.textBoxSearch.TabIndex = 2;
            // 
            // buttonFindUser
            // 
            this.buttonFindUser.Location = new System.Drawing.Point(513, 6);
            this.buttonFindUser.Name = "buttonFindUser";
            this.buttonFindUser.Size = new System.Drawing.Size(90, 30);
            this.buttonFindUser.TabIndex = 1;
            this.buttonFindUser.Text = "Find";
            this.buttonFindUser.UseVisualStyleBackColor = true;
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
            // tabPageUserLevel
            // 
            this.tabPageUserLevel.Controls.Add(this.textBox1);
            this.tabPageUserLevel.Controls.Add(this.buttonFindUserLevel);
            this.tabPageUserLevel.Controls.Add(this.buttonAddUserLevel);
            this.tabPageUserLevel.Controls.Add(this.buttonViewUserLevel);
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
            // buttonFindUserLevel
            // 
            this.buttonFindUserLevel.Location = new System.Drawing.Point(513, 6);
            this.buttonFindUserLevel.Name = "buttonFindUserLevel";
            this.buttonFindUserLevel.Size = new System.Drawing.Size(90, 30);
            this.buttonFindUserLevel.TabIndex = 10;
            this.buttonFindUserLevel.Text = "Find";
            this.buttonFindUserLevel.UseVisualStyleBackColor = true;
            // 
            // buttonAddUserLevel
            // 
            this.buttonAddUserLevel.Location = new System.Drawing.Point(102, 6);
            this.buttonAddUserLevel.Name = "buttonAddUserLevel";
            this.buttonAddUserLevel.Size = new System.Drawing.Size(90, 30);
            this.buttonAddUserLevel.TabIndex = 8;
            this.buttonAddUserLevel.Text = "Add";
            this.buttonAddUserLevel.UseVisualStyleBackColor = true;
            this.buttonAddUserLevel.Click += new System.EventHandler(this.buttonAddUserLevel_Click);
            // 
            // buttonViewUserLevel
            // 
            this.buttonViewUserLevel.Location = new System.Drawing.Point(6, 6);
            this.buttonViewUserLevel.Name = "buttonViewUserLevel";
            this.buttonViewUserLevel.Size = new System.Drawing.Size(90, 30);
            this.buttonViewUserLevel.TabIndex = 3;
            this.buttonViewUserLevel.Text = "View";
            this.buttonViewUserLevel.UseVisualStyleBackColor = true;
            this.buttonViewUserLevel.Click += new System.EventHandler(this.buttonViewUserLevel_Click);
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
            // tabPageUserLevelFunc
            // 
            this.tabPageUserLevelFunc.Controls.Add(this.textBox2);
            this.tabPageUserLevelFunc.Controls.Add(this.buttonFindUserLevelAccess);
            this.tabPageUserLevelFunc.Controls.Add(this.buttonAddUserLevelAccess);
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
            // buttonFindUserLevelAccess
            // 
            this.buttonFindUserLevelAccess.Location = new System.Drawing.Point(513, 6);
            this.buttonFindUserLevelAccess.Name = "buttonFindUserLevelAccess";
            this.buttonFindUserLevelAccess.Size = new System.Drawing.Size(90, 30);
            this.buttonFindUserLevelAccess.TabIndex = 19;
            this.buttonFindUserLevelAccess.Text = "Find";
            this.buttonFindUserLevelAccess.UseVisualStyleBackColor = true;
            // 
            // buttonAddUserLevelAccess
            // 
            this.buttonAddUserLevelAccess.Location = new System.Drawing.Point(6, 6);
            this.buttonAddUserLevelAccess.Name = "buttonAddUserLevelAccess";
            this.buttonAddUserLevelAccess.Size = new System.Drawing.Size(90, 30);
            this.buttonAddUserLevelAccess.TabIndex = 17;
            this.buttonAddUserLevelAccess.Text = "Add";
            this.buttonAddUserLevelAccess.UseVisualStyleBackColor = true;
            this.buttonAddUserLevelAccess.Click += new System.EventHandler(this.buttonAddUserLevelAccess_Click);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 301);
            this.Controls.Add(this.tabControlMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
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
        private System.Windows.Forms.Button buttonFindUser;
        private System.Windows.Forms.DataGridView dataGridViewUserList;
        private System.Windows.Forms.DataGridView dataGridViewUserLevel;
        private System.Windows.Forms.Button buttonAddUserLevel;
        private System.Windows.Forms.Button buttonViewUserLevel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAddUserLevelAccess;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonFindUserLevel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonFindUserLevelAccess;
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

