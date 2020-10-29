namespace TMS_UI.Form_MS_root
{
    partial class Form_SelectEditStatus
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
            this.label_InputPwdTip = new System.Windows.Forms.Label();
            this.TB_Pwd = new System.Windows.Forms.TextBox();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_Ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_InputPwdTip
            // 
            this.label_InputPwdTip.AutoSize = true;
            this.label_InputPwdTip.BackColor = System.Drawing.Color.Transparent;
            this.label_InputPwdTip.Font = new System.Drawing.Font("SimSun", 12F);
            this.label_InputPwdTip.Location = new System.Drawing.Point(29, 99);
            this.label_InputPwdTip.Name = "label_InputPwdTip";
            this.label_InputPwdTip.Size = new System.Drawing.Size(130, 24);
            this.label_InputPwdTip.TabIndex = 0;
            this.label_InputPwdTip.Text = "请输入密码";
            // 
            // TB_Pwd
            // 
            this.TB_Pwd.Location = new System.Drawing.Point(167, 97);
            this.TB_Pwd.Name = "TB_Pwd";
            this.TB_Pwd.PasswordChar = '*';
            this.TB_Pwd.Size = new System.Drawing.Size(243, 28);
            this.TB_Pwd.TabIndex = 1;
            this.TB_Pwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Pwd_KeyPress);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(166, 151);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(82, 32);
            this.Btn_Cancel.TabIndex = 2;
            this.Btn_Cancel.Text = "取消";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_Ok
            // 
            this.Btn_Ok.Location = new System.Drawing.Point(334, 149);
            this.Btn_Ok.Name = "Btn_Ok";
            this.Btn_Ok.Size = new System.Drawing.Size(76, 32);
            this.Btn_Ok.TabIndex = 3;
            this.Btn_Ok.Text = "确定";
            this.Btn_Ok.UseVisualStyleBackColor = true;
            this.Btn_Ok.Click += new System.EventHandler(this.Btn_Ok_Click);
            // 
            // Form_SelectEditStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TMS_UI.Properties.Resources.form_selectItems_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(534, 228);
            this.Controls.Add(this.Btn_Ok);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.TB_Pwd);
            this.Controls.Add(this.label_InputPwdTip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_SelectEditStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_SelectEditStatus";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form_SelectEditStatus_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_SelectEditStatus_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_SelectEditStatus_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_SelectEditStatus_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_InputPwdTip;
        private System.Windows.Forms.TextBox TB_Pwd;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Button Btn_Ok;
    }
}