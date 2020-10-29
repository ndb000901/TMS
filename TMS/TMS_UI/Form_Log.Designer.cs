namespace TMS_UI
{
    partial class Form_Log
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
            this.DGV_Log = new System.Windows.Forms.DataGridView();
            this.add_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Log)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Log
            // 
            this.DGV_Log.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGV_Log.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Log.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.add_date,
            this.details});
            this.DGV_Log.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DGV_Log.Location = new System.Drawing.Point(30, 36);
            this.DGV_Log.Name = "DGV_Log";
            this.DGV_Log.ReadOnly = true;
            this.DGV_Log.RowTemplate.Height = 30;
            this.DGV_Log.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Log.Size = new System.Drawing.Size(847, 421);
            this.DGV_Log.TabIndex = 0;
            this.DGV_Log.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DGV_Log_RowPostPaint);
            // 
            // add_date
            // 
            this.add_date.DataPropertyName = "add_date";
            this.add_date.HeaderText = "时间";
            this.add_date.Name = "add_date";
            this.add_date.ReadOnly = true;
            this.add_date.Width = 200;
            // 
            // details
            // 
            this.details.DataPropertyName = "details";
            this.details.HeaderText = "日志详情";
            this.details.Name = "details";
            this.details.ReadOnly = true;
            this.details.Width = 600;
            // 
            // Form_Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TMS_UI.Properties.Resources.form_selectItems_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(909, 486);
            this.Controls.Add(this.DGV_Log);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Log";
            this.Text = "操作日志";
            this.Load += new System.EventHandler(this.Form_Log_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Log)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Log;
        private System.Windows.Forms.DataGridViewTextBoxColumn add_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn details;
    }
}