namespace TMS_UI
{
    partial class Form_Main_root
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main_root));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.StudentM_MS = new System.Windows.Forms.ToolStripMenuItem();
            this.TeacherM_MS = new System.Windows.Forms.ToolStripMenuItem();
            this.CourseM_MS = new System.Windows.Forms.ToolStripMenuItem();
            this.用户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tools_MS = new System.Windows.Forms.ToolStripMenuItem();
            this.Notepad_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Calc_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Cmd_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Help_MS = new System.Windows.Forms.ToolStripMenuItem();
            this.AmendPwd_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.SoftwareInfo_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Quit_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Form_Main_panel = new System.Windows.Forms.Panel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Status_timer = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_dateTime = new System.Windows.Forms.Label();
            this.label_userInfo = new System.Windows.Forms.Label();
            this.Log_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.Form_Main_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StudentM_MS,
            this.TeacherM_MS,
            this.CourseM_MS,
            this.用户管理ToolStripMenuItem,
            this.Tools_MS,
            this.Help_MS});
            this.menuStrip1.Location = new System.Drawing.Point(0, 1);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(543, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // StudentM_MS
            // 
            this.StudentM_MS.Name = "StudentM_MS";
            this.StudentM_MS.Size = new System.Drawing.Size(104, 28);
            this.StudentM_MS.Text = "学生管理&S";
            this.StudentM_MS.Click += new System.EventHandler(this.StudentM_MS_Click);
            // 
            // TeacherM_MS
            // 
            this.TeacherM_MS.Name = "TeacherM_MS";
            this.TeacherM_MS.Size = new System.Drawing.Size(104, 28);
            this.TeacherM_MS.Text = "教师管理&T";
            this.TeacherM_MS.Click += new System.EventHandler(this.TeacherM_MS_Click);
            // 
            // CourseM_MS
            // 
            this.CourseM_MS.Name = "CourseM_MS";
            this.CourseM_MS.Size = new System.Drawing.Size(94, 28);
            this.CourseM_MS.Text = "课程管理";
            // 
            // 用户管理ToolStripMenuItem
            // 
            this.用户管理ToolStripMenuItem.Name = "用户管理ToolStripMenuItem";
            this.用户管理ToolStripMenuItem.Size = new System.Drawing.Size(94, 28);
            this.用户管理ToolStripMenuItem.Text = "用户管理";
            // 
            // Tools_MS
            // 
            this.Tools_MS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Notepad_TSMI,
            this.Calc_TSMI,
            this.Cmd_TSMI});
            this.Tools_MS.Name = "Tools_MS";
            this.Tools_MS.Size = new System.Drawing.Size(67, 28);
            this.Tools_MS.Text = "工具&L";
            // 
            // Notepad_TSMI
            // 
            this.Notepad_TSMI.Name = "Notepad_TSMI";
            this.Notepad_TSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.Notepad_TSMI.Size = new System.Drawing.Size(252, 30);
            this.Notepad_TSMI.Text = "记事本";
            this.Notepad_TSMI.Click += new System.EventHandler(this.Notepad_TSMI_Click);
            // 
            // Calc_TSMI
            // 
            this.Calc_TSMI.Name = "Calc_TSMI";
            this.Calc_TSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.Calc_TSMI.Size = new System.Drawing.Size(252, 30);
            this.Calc_TSMI.Text = "计算器";
            this.Calc_TSMI.Click += new System.EventHandler(this.Clac_TSMI_Click);
            // 
            // Cmd_TSMI
            // 
            this.Cmd_TSMI.Name = "Cmd_TSMI";
            this.Cmd_TSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.J)));
            this.Cmd_TSMI.Size = new System.Drawing.Size(252, 30);
            this.Cmd_TSMI.Text = "cmd";
            this.Cmd_TSMI.Click += new System.EventHandler(this.Cmd_TSMI_Click);
            // 
            // Help_MS
            // 
            this.Help_MS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Log_TSMI,
            this.AmendPwd_TSMI,
            this.SoftwareInfo_TSMI,
            this.Quit_TSMI});
            this.Help_MS.Name = "Help_MS";
            this.Help_MS.Size = new System.Drawing.Size(72, 28);
            this.Help_MS.Text = "帮助&H";
            // 
            // AmendPwd_TSMI
            // 
            this.AmendPwd_TSMI.Name = "AmendPwd_TSMI";
            this.AmendPwd_TSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.AmendPwd_TSMI.Size = new System.Drawing.Size(252, 30);
            this.AmendPwd_TSMI.Text = "修改密码";
            this.AmendPwd_TSMI.Click += new System.EventHandler(this.AmendPwd_TSMI_Click);
            // 
            // SoftwareInfo_TSMI
            // 
            this.SoftwareInfo_TSMI.Name = "SoftwareInfo_TSMI";
            this.SoftwareInfo_TSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.SoftwareInfo_TSMI.Size = new System.Drawing.Size(252, 30);
            this.SoftwareInfo_TSMI.Text = "关于软件";
            this.SoftwareInfo_TSMI.Click += new System.EventHandler(this.SoftwareInfo_TSMI_Click);
            // 
            // Quit_TSMI
            // 
            this.Quit_TSMI.Name = "Quit_TSMI";
            this.Quit_TSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.Quit_TSMI.Size = new System.Drawing.Size(252, 30);
            this.Quit_TSMI.Text = "退出";
            this.Quit_TSMI.Click += new System.EventHandler(this.Quit_TSMI_Click);
            // 
            // Form_Main_panel
            // 
            this.Form_Main_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Form_Main_panel.BackColor = System.Drawing.SystemColors.Control;
            this.Form_Main_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Form_Main_panel.Controls.Add(this.monthCalendar1);
            this.Form_Main_panel.Location = new System.Drawing.Point(14, 53);
            this.Form_Main_panel.Name = "Form_Main_panel";
            this.Form_Main_panel.Size = new System.Drawing.Size(1090, 685);
            this.Form_Main_panel.TabIndex = 2;
            this.Form_Main_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Form_Main_panel_Paint);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.Info;
            this.monthCalendar1.Location = new System.Drawing.Point(9, 9);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1119, 46);
            this.panel1.TabIndex = 5;
            // 
            // Status_timer
            // 
            this.Status_timer.Enabled = true;
            this.Status_timer.Tick += new System.EventHandler(this.Status_timer_Tick);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label_dateTime);
            this.panel2.Controls.Add(this.label_userInfo);
            this.panel2.Location = new System.Drawing.Point(0, 744);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1119, 30);
            this.panel2.TabIndex = 6;
            // 
            // label_dateTime
            // 
            this.label_dateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_dateTime.AutoSize = true;
            this.label_dateTime.Location = new System.Drawing.Point(918, 5);
            this.label_dateTime.Name = "label_dateTime";
            this.label_dateTime.Size = new System.Drawing.Size(62, 18);
            this.label_dateTime.TabIndex = 1;
            this.label_dateTime.Text = "label2";
            // 
            // label_userInfo
            // 
            this.label_userInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_userInfo.AutoSize = true;
            this.label_userInfo.Location = new System.Drawing.Point(11, 6);
            this.label_userInfo.Name = "label_userInfo";
            this.label_userInfo.Size = new System.Drawing.Size(134, 18);
            this.label_userInfo.TabIndex = 0;
            this.label_userInfo.Text = "label_userInfo";
            // 
            // Log_TSMI
            // 
            this.Log_TSMI.Name = "Log_TSMI";
            this.Log_TSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.Log_TSMI.Size = new System.Drawing.Size(252, 30);
            this.Log_TSMI.Text = "操作日志";
            this.Log_TSMI.Click += new System.EventHandler(this.Log_TSMI_Click);
            // 
            // Form_Main_root
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 777);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Form_Main_panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Main_root";
            this.Text = "教学管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Form_Main_panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem StudentM_MS;
        private System.Windows.Forms.ToolStripMenuItem TeacherM_MS;
        private System.Windows.Forms.ToolStripMenuItem CourseM_MS;
        private System.Windows.Forms.ToolStripMenuItem Tools_MS;
        private System.Windows.Forms.ToolStripMenuItem Notepad_TSMI;
        private System.Windows.Forms.ToolStripMenuItem Calc_TSMI;
        private System.Windows.Forms.Panel Form_Main_panel;
        private System.Windows.Forms.ToolStripMenuItem Cmd_TSMI;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer Status_timer;
        private System.Windows.Forms.ToolStripMenuItem Help_MS;
        private System.Windows.Forms.ToolStripMenuItem Quit_TSMI;
        private System.Windows.Forms.ToolStripMenuItem SoftwareInfo_TSMI;
        private System.Windows.Forms.ToolStripMenuItem AmendPwd_TSMI;
        private System.Windows.Forms.ToolStripMenuItem 用户管理ToolStripMenuItem;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_dateTime;
        private System.Windows.Forms.Label label_userInfo;
        private System.Windows.Forms.ToolStripMenuItem Log_TSMI;
    }
}