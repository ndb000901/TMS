namespace TMS_UI
{
    partial class Form_Login
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
            this.label_account_num = new System.Windows.Forms.Label();
            this.label_pwd = new System.Windows.Forms.Label();
            this.TB_account_num = new System.Windows.Forms.TextBox();
            this.TB_pwd = new System.Windows.Forms.TextBox();
            this.Bt_login = new System.Windows.Forms.Button();
            this.Bt_clear = new System.Windows.Forms.Button();
            this.Bt_exit = new System.Windows.Forms.Button();
            this.checkBox_Rem_pwd = new System.Windows.Forms.CheckBox();
            this.checkBox_Auto_login = new System.Windows.Forms.CheckBox();
            this.label_Id = new System.Windows.Forms.Label();
            this.RBtn_student = new System.Windows.Forms.RadioButton();
            this.RBtn_teacher = new System.Windows.Forms.RadioButton();
            this.RBtn_root = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label_account_num
            // 
            this.label_account_num.AutoSize = true;
            this.label_account_num.BackColor = System.Drawing.Color.Transparent;
            this.label_account_num.Font = new System.Drawing.Font("SimSun", 16F);
            this.label_account_num.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_account_num.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label_account_num.ImageKey = "(无)";
            this.label_account_num.Location = new System.Drawing.Point(183, 132);
            this.label_account_num.Name = "label_account_num";
            this.label_account_num.Size = new System.Drawing.Size(95, 33);
            this.label_account_num.TabIndex = 0;
            this.label_account_num.Text = "账号:";
            // 
            // label_pwd
            // 
            this.label_pwd.AutoSize = true;
            this.label_pwd.BackColor = System.Drawing.Color.Transparent;
            this.label_pwd.Font = new System.Drawing.Font("SimSun", 16F);
            this.label_pwd.Location = new System.Drawing.Point(183, 205);
            this.label_pwd.Name = "label_pwd";
            this.label_pwd.Size = new System.Drawing.Size(95, 33);
            this.label_pwd.TabIndex = 1;
            this.label_pwd.Text = "密码:";
            // 
            // TB_account_num
            // 
            this.TB_account_num.Font = new System.Drawing.Font("SimSun", 13F);
            this.TB_account_num.Location = new System.Drawing.Point(356, 128);
            this.TB_account_num.MaxLength = 32;
            this.TB_account_num.Name = "TB_account_num";
            this.TB_account_num.Size = new System.Drawing.Size(272, 37);
            this.TB_account_num.TabIndex = 2;
            this.TB_account_num.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_account_num_KeyDown);
            this.TB_account_num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_account_num_KeyPress);
            // 
            // TB_pwd
            // 
            this.TB_pwd.Font = new System.Drawing.Font("SimSun", 13F);
            this.TB_pwd.Location = new System.Drawing.Point(356, 201);
            this.TB_pwd.MaxLength = 32;
            this.TB_pwd.Name = "TB_pwd";
            this.TB_pwd.PasswordChar = '*';
            this.TB_pwd.Size = new System.Drawing.Size(272, 37);
            this.TB_pwd.TabIndex = 3;
            this.TB_pwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_pwd_KeyDown);
            // 
            // Bt_login
            // 
            this.Bt_login.Location = new System.Drawing.Point(189, 379);
            this.Bt_login.Name = "Bt_login";
            this.Bt_login.Size = new System.Drawing.Size(97, 37);
            this.Bt_login.TabIndex = 4;
            this.Bt_login.Text = "登录";
            this.Bt_login.UseVisualStyleBackColor = true;
            this.Bt_login.Click += new System.EventHandler(this.Bt_login_Click);
            this.Bt_login.MouseLeave += new System.EventHandler(this.Bt_login_MouseLeave);
            // 
            // Bt_clear
            // 
            this.Bt_clear.Location = new System.Drawing.Point(356, 380);
            this.Bt_clear.Name = "Bt_clear";
            this.Bt_clear.Size = new System.Drawing.Size(106, 36);
            this.Bt_clear.TabIndex = 5;
            this.Bt_clear.Text = "清空";
            this.Bt_clear.UseVisualStyleBackColor = true;
            this.Bt_clear.Click += new System.EventHandler(this.Bt_clear_Click);
            this.Bt_clear.MouseLeave += new System.EventHandler(this.Bt_clear_MouseLeave);
            // 
            // Bt_exit
            // 
            this.Bt_exit.Location = new System.Drawing.Point(526, 380);
            this.Bt_exit.Name = "Bt_exit";
            this.Bt_exit.Size = new System.Drawing.Size(102, 36);
            this.Bt_exit.TabIndex = 6;
            this.Bt_exit.Text = "退出";
            this.Bt_exit.UseVisualStyleBackColor = true;
            this.Bt_exit.Click += new System.EventHandler(this.Bt_exit_Click);
            this.Bt_exit.MouseLeave += new System.EventHandler(this.Bt_exit_MouseLeave);
            // 
            // checkBox_Rem_pwd
            // 
            this.checkBox_Rem_pwd.AutoSize = true;
            this.checkBox_Rem_pwd.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_Rem_pwd.Font = new System.Drawing.Font("SimSun", 12F);
            this.checkBox_Rem_pwd.Location = new System.Drawing.Point(358, 325);
            this.checkBox_Rem_pwd.Name = "checkBox_Rem_pwd";
            this.checkBox_Rem_pwd.Size = new System.Drawing.Size(132, 28);
            this.checkBox_Rem_pwd.TabIndex = 7;
            this.checkBox_Rem_pwd.Text = "记住密码";
            this.checkBox_Rem_pwd.UseVisualStyleBackColor = false;
            // 
            // checkBox_Auto_login
            // 
            this.checkBox_Auto_login.AutoSize = true;
            this.checkBox_Auto_login.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_Auto_login.Font = new System.Drawing.Font("SimSun", 12F);
            this.checkBox_Auto_login.Location = new System.Drawing.Point(496, 325);
            this.checkBox_Auto_login.Name = "checkBox_Auto_login";
            this.checkBox_Auto_login.Size = new System.Drawing.Size(132, 28);
            this.checkBox_Auto_login.TabIndex = 8;
            this.checkBox_Auto_login.Text = "自动登录";
            this.checkBox_Auto_login.UseVisualStyleBackColor = false;
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.BackColor = System.Drawing.Color.Transparent;
            this.label_Id.Font = new System.Drawing.Font("SimSun", 16F);
            this.label_Id.Location = new System.Drawing.Point(183, 264);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(95, 33);
            this.label_Id.TabIndex = 9;
            this.label_Id.Text = "身份:";
            // 
            // RBtn_student
            // 
            this.RBtn_student.AutoSize = true;
            this.RBtn_student.BackColor = System.Drawing.Color.Transparent;
            this.RBtn_student.Location = new System.Drawing.Point(356, 275);
            this.RBtn_student.Name = "RBtn_student";
            this.RBtn_student.Size = new System.Drawing.Size(69, 22);
            this.RBtn_student.TabIndex = 10;
            this.RBtn_student.TabStop = true;
            this.RBtn_student.Text = "学生";
            this.RBtn_student.UseVisualStyleBackColor = false;
            // 
            // RBtn_teacher
            // 
            this.RBtn_teacher.AutoSize = true;
            this.RBtn_teacher.BackColor = System.Drawing.Color.Transparent;
            this.RBtn_teacher.Location = new System.Drawing.Point(457, 275);
            this.RBtn_teacher.Name = "RBtn_teacher";
            this.RBtn_teacher.Size = new System.Drawing.Size(69, 22);
            this.RBtn_teacher.TabIndex = 11;
            this.RBtn_teacher.TabStop = true;
            this.RBtn_teacher.Text = "教师";
            this.RBtn_teacher.UseVisualStyleBackColor = false;
            // 
            // RBtn_root
            // 
            this.RBtn_root.AutoSize = true;
            this.RBtn_root.BackColor = System.Drawing.Color.Transparent;
            this.RBtn_root.Location = new System.Drawing.Point(559, 275);
            this.RBtn_root.Name = "RBtn_root";
            this.RBtn_root.Size = new System.Drawing.Size(69, 22);
            this.RBtn_root.TabIndex = 12;
            this.RBtn_root.TabStop = true;
            this.RBtn_root.Text = "root";
            this.RBtn_root.UseVisualStyleBackColor = false;
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TMS_UI.Properties.Resources.login_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.RBtn_root);
            this.Controls.Add(this.RBtn_teacher);
            this.Controls.Add(this.RBtn_student);
            this.Controls.Add(this.label_Id);
            this.Controls.Add(this.checkBox_Auto_login);
            this.Controls.Add(this.checkBox_Rem_pwd);
            this.Controls.Add(this.Bt_exit);
            this.Controls.Add(this.Bt_clear);
            this.Controls.Add(this.Bt_login);
            this.Controls.Add(this.TB_pwd);
            this.Controls.Add(this.TB_account_num);
            this.Controls.Add(this.label_pwd);
            this.Controls.Add(this.label_account_num);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Login_FormClosing);
            this.Load += new System.EventHandler(this.Form_Login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_Login_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_Login_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_Login_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_account_num;
        private System.Windows.Forms.Label label_pwd;
        private System.Windows.Forms.TextBox TB_account_num;
        private System.Windows.Forms.TextBox TB_pwd;
        private System.Windows.Forms.Button Bt_login;
        private System.Windows.Forms.Button Bt_clear;
        private System.Windows.Forms.Button Bt_exit;
        private System.Windows.Forms.CheckBox checkBox_Rem_pwd;
        private System.Windows.Forms.CheckBox checkBox_Auto_login;
        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.RadioButton RBtn_student;
        private System.Windows.Forms.RadioButton RBtn_teacher;
        private System.Windows.Forms.RadioButton RBtn_root;
    }
}