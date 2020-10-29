namespace TMS_UI
{
    partial class Form_alterPwd
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Pwd1 = new System.Windows.Forms.TextBox();
            this.TB_Pwd2 = new System.Windows.Forms.TextBox();
            this.TB_Pwd3 = new System.Windows.Forms.TextBox();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("SimSun", 12F);
            this.label1.Location = new System.Drawing.Point(79, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "输入原密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("SimSun", 12F);
            this.label2.Location = new System.Drawing.Point(79, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "输入新密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("SimSun", 12F);
            this.label3.Location = new System.Drawing.Point(42, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "再次输入新密码";
            // 
            // TB_Pwd1
            // 
            this.TB_Pwd1.Location = new System.Drawing.Point(231, 84);
            this.TB_Pwd1.MaxLength = 32;
            this.TB_Pwd1.Name = "TB_Pwd1";
            this.TB_Pwd1.PasswordChar = '*';
            this.TB_Pwd1.Size = new System.Drawing.Size(253, 28);
            this.TB_Pwd1.TabIndex = 3;
            // 
            // TB_Pwd2
            // 
            this.TB_Pwd2.Location = new System.Drawing.Point(231, 141);
            this.TB_Pwd2.MaxLength = 32;
            this.TB_Pwd2.Name = "TB_Pwd2";
            this.TB_Pwd2.PasswordChar = '*';
            this.TB_Pwd2.Size = new System.Drawing.Size(253, 28);
            this.TB_Pwd2.TabIndex = 4;
            // 
            // TB_Pwd3
            // 
            this.TB_Pwd3.Location = new System.Drawing.Point(231, 207);
            this.TB_Pwd3.MaxLength = 32;
            this.TB_Pwd3.Name = "TB_Pwd3";
            this.TB_Pwd3.PasswordChar = '*';
            this.TB_Pwd3.Size = new System.Drawing.Size(253, 28);
            this.TB_Pwd3.TabIndex = 5;
            // 
            // Btn_Save
            // 
            this.Btn_Save.Location = new System.Drawing.Point(231, 271);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(82, 35);
            this.Btn_Save.TabIndex = 6;
            this.Btn_Save.Text = "保存";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(400, 271);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(84, 35);
            this.Btn_Cancel.TabIndex = 7;
            this.Btn_Cancel.Text = "取消";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Form_alterPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TMS_UI.Properties.Resources.form_selectItems_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(537, 348);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.TB_Pwd3);
            this.Controls.Add(this.TB_Pwd2);
            this.Controls.Add(this.TB_Pwd1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_alterPwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_alterPwd";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form_alterPwd_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_alterPwd_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_alterPwd_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_alterPwd_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_Pwd1;
        private System.Windows.Forms.TextBox TB_Pwd2;
        private System.Windows.Forms.TextBox TB_Pwd3;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Button Btn_Cancel;
    }
}