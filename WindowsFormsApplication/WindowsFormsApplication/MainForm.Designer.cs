namespace WindowsFormsApplication
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.OverviewTabPage = new System.Windows.Forms.TabPage();
            this.AddNewUserTabPage = new System.Windows.Forms.TabPage();
            this.dataGridViewUserList = new System.Windows.Forms.DataGridView();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.buttonAddUserLevel = new System.Windows.Forms.Button();
            this.buttonFind = new System.Windows.Forms.Button();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelSecondName = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelUserLevel = new System.Windows.Forms.Label();
            this.comboBoxUserLevel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonRestore = new System.Windows.Forms.Button();
            this.MainTabControl.SuspendLayout();
            this.OverviewTabPage.SuspendLayout();
            this.AddNewUserTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserList)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.OverviewTabPage);
            this.MainTabControl.Controls.Add(this.AddNewUserTabPage);
            this.MainTabControl.Location = new System.Drawing.Point(0, -2);
            this.MainTabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(731, 421);
            this.MainTabControl.TabIndex = 0;
            // 
            // OverviewTabPage
            // 
            this.OverviewTabPage.Controls.Add(this.textBoxFind);
            this.OverviewTabPage.Controls.Add(this.buttonFind);
            this.OverviewTabPage.Controls.Add(this.buttonAddUserLevel);
            this.OverviewTabPage.Controls.Add(this.buttonAddUser);
            this.OverviewTabPage.Controls.Add(this.dataGridViewUserList);
            this.OverviewTabPage.Location = new System.Drawing.Point(4, 25);
            this.OverviewTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OverviewTabPage.Name = "OverviewTabPage";
            this.OverviewTabPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OverviewTabPage.Size = new System.Drawing.Size(723, 392);
            this.OverviewTabPage.TabIndex = 0;
            this.OverviewTabPage.Text = "Overview";
            this.OverviewTabPage.UseVisualStyleBackColor = true;
            // 
            // AddNewUserTabPage
            // 
            this.AddNewUserTabPage.Controls.Add(this.buttonRestore);
            this.AddNewUserTabPage.Controls.Add(this.buttonSave);
            this.AddNewUserTabPage.Controls.Add(this.label5);
            this.AddNewUserTabPage.Controls.Add(this.label3);
            this.AddNewUserTabPage.Controls.Add(this.textBoxEmail);
            this.AddNewUserTabPage.Controls.Add(this.label2);
            this.AddNewUserTabPage.Controls.Add(this.textBoxPassword);
            this.AddNewUserTabPage.Controls.Add(this.label1);
            this.AddNewUserTabPage.Controls.Add(this.textBoxLogin);
            this.AddNewUserTabPage.Controls.Add(this.comboBoxUserLevel);
            this.AddNewUserTabPage.Controls.Add(this.labelUserLevel);
            this.AddNewUserTabPage.Controls.Add(this.labelSurname);
            this.AddNewUserTabPage.Controls.Add(this.textBox3);
            this.AddNewUserTabPage.Controls.Add(this.labelSecondName);
            this.AddNewUserTabPage.Controls.Add(this.textBox2);
            this.AddNewUserTabPage.Controls.Add(this.labelFirstName);
            this.AddNewUserTabPage.Controls.Add(this.textBox1);
            this.AddNewUserTabPage.Location = new System.Drawing.Point(4, 25);
            this.AddNewUserTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddNewUserTabPage.Name = "AddNewUserTabPage";
            this.AddNewUserTabPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddNewUserTabPage.Size = new System.Drawing.Size(723, 392);
            this.AddNewUserTabPage.TabIndex = 1;
            this.AddNewUserTabPage.Text = "Manage";
            this.AddNewUserTabPage.UseVisualStyleBackColor = true;
            // 
            // dataGridViewUserList
            // 
            this.dataGridViewUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUserList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstName,
            this.secondName,
            this.surname,
            this.userLevel});
            this.dataGridViewUserList.Location = new System.Drawing.Point(4, 62);
            this.dataGridViewUserList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewUserList.Name = "dataGridViewUserList";
            this.dataGridViewUserList.Size = new System.Drawing.Size(716, 336);
            this.dataGridViewUserList.TabIndex = 0;
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Location = new System.Drawing.Point(4, 7);
            this.buttonAddUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(137, 47);
            this.buttonAddUser.TabIndex = 1;
            this.buttonAddUser.Text = "Add new user";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            // 
            // buttonAddUserLevel
            // 
            this.buttonAddUserLevel.Location = new System.Drawing.Point(149, 7);
            this.buttonAddUserLevel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddUserLevel.Name = "buttonAddUserLevel";
            this.buttonAddUserLevel.Size = new System.Drawing.Size(137, 47);
            this.buttonAddUserLevel.TabIndex = 2;
            this.buttonAddUserLevel.Text = "Add new user level";
            this.buttonAddUserLevel.UseVisualStyleBackColor = true;
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(583, 8);
            this.buttonFind.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(137, 47);
            this.buttonFind.TabIndex = 3;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            // 
            // textBoxFind
            // 
            this.textBoxFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFind.Location = new System.Drawing.Point(296, 8);
            this.textBoxFind.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFind.Multiline = true;
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(277, 46);
            this.textBoxFind.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(149, 25);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 43);
            this.textBox1.TabIndex = 0;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirstName.Location = new System.Drawing.Point(32, 37);
            this.labelFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(87, 17);
            this.labelFirstName.TabIndex = 1;
            this.labelFirstName.Text = "First name* :";
            // 
            // labelSecondName
            // 
            this.labelSecondName.AutoSize = true;
            this.labelSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSecondName.Location = new System.Drawing.Point(16, 103);
            this.labelSecondName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSecondName.Name = "labelSecondName";
            this.labelSecondName.Size = new System.Drawing.Size(103, 17);
            this.labelSecondName.TabIndex = 3;
            this.labelSecondName.Text = "Second name :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(149, 95);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(216, 43);
            this.textBox2.TabIndex = 2;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurname.Location = new System.Drawing.Point(46, 167);
            this.labelSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(73, 17);
            this.labelSurname.TabIndex = 5;
            this.labelSurname.Text = "Surname :";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(149, 164);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(216, 43);
            this.textBox3.TabIndex = 4;
            // 
            // labelUserLevel
            // 
            this.labelUserLevel.AutoSize = true;
            this.labelUserLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUserLevel.Location = new System.Drawing.Point(35, 232);
            this.labelUserLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUserLevel.Name = "labelUserLevel";
            this.labelUserLevel.Size = new System.Drawing.Size(84, 17);
            this.labelUserLevel.TabIndex = 7;
            this.labelUserLevel.Text = "User level* :";
            // 
            // comboBoxUserLevel
            // 
            this.comboBoxUserLevel.FormattingEnabled = true;
            this.comboBoxUserLevel.IntegralHeight = false;
            this.comboBoxUserLevel.ItemHeight = 16;
            this.comboBoxUserLevel.Location = new System.Drawing.Point(149, 232);
            this.comboBoxUserLevel.Name = "comboBoxUserLevel";
            this.comboBoxUserLevel.Size = new System.Drawing.Size(216, 24);
            this.comboBoxUserLevel.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(533, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Login*";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(447, 96);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLogin.Multiline = true;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(216, 43);
            this.textBoxLogin.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(521, 164);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Password*";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(447, 185);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(216, 43);
            this.textBoxPassword.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(64, 314);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Email* :";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(149, 302);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEmail.Multiline = true;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(216, 43);
            this.textBoxEmail.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "* - mandatory fields";
            // 
            // firstName
            // 
            this.firstName.HeaderText = "First name";
            this.firstName.Name = "firstName";
            // 
            // secondName
            // 
            this.secondName.HeaderText = "Second name";
            this.secondName.Name = "secondName";
            // 
            // surname
            // 
            this.surname.HeaderText = "Surname";
            this.surname.Name = "surname";
            // 
            // userLevel
            // 
            this.userLevel.HeaderText = "User Level";
            this.userLevel.Name = "userLevel";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(574, 337);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(137, 47);
            this.buttonSave.TabIndex = 17;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonRestore
            // 
            this.buttonRestore.Location = new System.Drawing.Point(429, 337);
            this.buttonRestore.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRestore.Name = "buttonRestore";
            this.buttonRestore.Size = new System.Drawing.Size(137, 47);
            this.buttonRestore.TabIndex = 18;
            this.buttonRestore.Text = "Restore";
            this.buttonRestore.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 423);
            this.Controls.Add(this.MainTabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "WinFormProject";
            this.MainTabControl.ResumeLayout(false);
            this.OverviewTabPage.ResumeLayout(false);
            this.OverviewTabPage.PerformLayout();
            this.AddNewUserTabPage.ResumeLayout(false);
            this.AddNewUserTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage OverviewTabPage;
        private System.Windows.Forms.TabPage AddNewUserTabPage;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Button buttonAddUserLevel;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.DataGridView dataGridViewUserList;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelSecondName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.ComboBox comboBoxUserLevel;
        private System.Windows.Forms.Label labelUserLevel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondName;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn userLevel;
        private System.Windows.Forms.Button buttonRestore;
        private System.Windows.Forms.Button buttonSave;
    }
}

