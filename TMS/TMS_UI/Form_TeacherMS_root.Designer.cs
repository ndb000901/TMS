namespace TMS_UI
{
    partial class Form_TeacherMS_root
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.DGV_TeacherInfo = new System.Windows.Forms.DataGridView();
            this.teacher_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacher_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacher_sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nation_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacher_birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.college_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profession_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_card = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.house_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_selectItems = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Btn_Quit = new System.Windows.Forms.Button();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_Alter = new System.Windows.Forms.Button();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Btn_ExportExcel = new System.Windows.Forms.Button();
            this.Btn_ExportWord = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_Find2 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Find1 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.Btn_EditStatus = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.TB_Address = new System.Windows.Forms.TextBox();
            this.label_address = new System.Windows.Forms.Label();
            this.CB_Profession = new System.Windows.Forms.ComboBox();
            this.MTB_IDcard = new System.Windows.Forms.MaskedTextBox();
            this.CB_College = new System.Windows.Forms.ComboBox();
            this.CB_Nation = new System.Windows.Forms.ComboBox();
            this.TB_Email = new System.Windows.Forms.TextBox();
            this.MTB_Phone = new System.Windows.Forms.MaskedTextBox();
            this.TB_Age = new System.Windows.Forms.TextBox();
            this.label1_profession = new System.Windows.Forms.Label();
            this.label_college = new System.Windows.Forms.Label();
            this.label_IDcard = new System.Windows.Forms.Label();
            this.label_nation = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label_phone = new System.Windows.Forms.Label();
            this.label_age = new System.Windows.Forms.Label();
            this.DTP_birthday = new System.Windows.Forms.DateTimePicker();
            this.label_birthday = new System.Windows.Forms.Label();
            this.CB_Sex = new System.Windows.Forms.ComboBox();
            this.TB_id = new System.Windows.Forms.TextBox();
            this.TB_name = new System.Windows.Forms.TextBox();
            this.label_id = new System.Windows.Forms.Label();
            this.label_sex = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.Btn_DeletePhoto = new System.Windows.Forms.Button();
            this.Btn_SelectPhoto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Check_timer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TeacherInfo)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.DGV_TeacherInfo);
            this.panel1.Controls.Add(this.Btn_selectItems);
            this.panel1.Location = new System.Drawing.Point(7, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 715);
            this.panel1.TabIndex = 0;
            // 
            // DGV_TeacherInfo
            // 
            this.DGV_TeacherInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_TeacherInfo.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGV_TeacherInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_TeacherInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teacher_name,
            this.teacher_id,
            this.teacher_sex,
            this.nation_name,
            this.teacher_birthday,
            this.college_name,
            this.profession_name,
            this.ID_card,
            this.email,
            this.phone_num,
            this.house_address});
            this.DGV_TeacherInfo.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DGV_TeacherInfo.Location = new System.Drawing.Point(15, 77);
            this.DGV_TeacherInfo.Name = "DGV_TeacherInfo";
            this.DGV_TeacherInfo.ReadOnly = true;
            this.DGV_TeacherInfo.RowTemplate.Height = 30;
            this.DGV_TeacherInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_TeacherInfo.Size = new System.Drawing.Size(376, 628);
            this.DGV_TeacherInfo.TabIndex = 1;
            this.DGV_TeacherInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_TeacherInfo_CellClick);
            this.DGV_TeacherInfo.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DGV_TeacherInfo_RowPostPaint);
            // 
            // teacher_name
            // 
            this.teacher_name.DataPropertyName = "teacher_name";
            this.teacher_name.HeaderText = "姓名";
            this.teacher_name.Name = "teacher_name";
            this.teacher_name.ReadOnly = true;
            // 
            // teacher_id
            // 
            this.teacher_id.DataPropertyName = "teacher_id";
            this.teacher_id.HeaderText = "工号";
            this.teacher_id.Name = "teacher_id";
            this.teacher_id.ReadOnly = true;
            // 
            // teacher_sex
            // 
            this.teacher_sex.DataPropertyName = "teacher_sex";
            this.teacher_sex.HeaderText = "性别";
            this.teacher_sex.Name = "teacher_sex";
            this.teacher_sex.ReadOnly = true;
            // 
            // nation_name
            // 
            this.nation_name.DataPropertyName = "nation_name";
            this.nation_name.HeaderText = "民族";
            this.nation_name.Name = "nation_name";
            this.nation_name.ReadOnly = true;
            // 
            // teacher_birthday
            // 
            this.teacher_birthday.DataPropertyName = "teacher_birthday";
            this.teacher_birthday.HeaderText = "生日";
            this.teacher_birthday.Name = "teacher_birthday";
            this.teacher_birthday.ReadOnly = true;
            // 
            // college_name
            // 
            this.college_name.DataPropertyName = "college_name";
            this.college_name.HeaderText = "学院";
            this.college_name.Name = "college_name";
            this.college_name.ReadOnly = true;
            // 
            // profession_name
            // 
            this.profession_name.DataPropertyName = "profession_name";
            this.profession_name.HeaderText = "专业";
            this.profession_name.Name = "profession_name";
            this.profession_name.ReadOnly = true;
            // 
            // ID_card
            // 
            this.ID_card.DataPropertyName = "ID_card";
            this.ID_card.HeaderText = "身份证";
            this.ID_card.Name = "ID_card";
            this.ID_card.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "邮箱";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // phone_num
            // 
            this.phone_num.DataPropertyName = "phone_num";
            this.phone_num.HeaderText = "电话";
            this.phone_num.Name = "phone_num";
            this.phone_num.ReadOnly = true;
            // 
            // house_address
            // 
            this.house_address.DataPropertyName = "house_address";
            this.house_address.HeaderText = "家庭住址";
            this.house_address.Name = "house_address";
            this.house_address.ReadOnly = true;
            // 
            // Btn_selectItems
            // 
            this.Btn_selectItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_selectItems.Location = new System.Drawing.Point(29, 28);
            this.Btn_selectItems.Name = "Btn_selectItems";
            this.Btn_selectItems.Size = new System.Drawing.Size(328, 33);
            this.Btn_selectItems.TabIndex = 0;
            this.Btn_selectItems.Text = "显示信息设置";
            this.Btn_selectItems.UseVisualStyleBackColor = true;
            this.Btn_selectItems.Click += new System.EventHandler(this.Btn_selectItems_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.groupBox);
            this.panel2.Location = new System.Drawing.Point(418, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(854, 715);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.Controls.Add(this.Btn_Quit);
            this.panel3.Controls.Add(this.Btn_Save);
            this.panel3.Controls.Add(this.Btn_Cancel);
            this.panel3.Controls.Add(this.Btn_Delete);
            this.panel3.Controls.Add(this.Btn_Alter);
            this.panel3.Controls.Add(this.Btn_Add);
            this.panel3.Controls.Add(this.Btn_ExportExcel);
            this.panel3.Controls.Add(this.Btn_ExportWord);
            this.panel3.Location = new System.Drawing.Point(15, 662);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(823, 44);
            this.panel3.TabIndex = 3;
            // 
            // Btn_Quit
            // 
            this.Btn_Quit.Location = new System.Drawing.Point(735, 8);
            this.Btn_Quit.Name = "Btn_Quit";
            this.Btn_Quit.Size = new System.Drawing.Size(75, 30);
            this.Btn_Quit.TabIndex = 7;
            this.Btn_Quit.Text = "退出";
            this.Btn_Quit.UseVisualStyleBackColor = true;
            this.Btn_Quit.Click += new System.EventHandler(this.Btn_Quit_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.Location = new System.Drawing.Point(644, 8);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(75, 30);
            this.Btn_Save.TabIndex = 6;
            this.Btn_Save.Text = "保存";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(544, 8);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(75, 30);
            this.Btn_Cancel.TabIndex = 5;
            this.Btn_Cancel.Text = "取消";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Location = new System.Drawing.Point(453, 8);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(75, 30);
            this.Btn_Delete.TabIndex = 4;
            this.Btn_Delete.Text = "删除";
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_Alter
            // 
            this.Btn_Alter.Location = new System.Drawing.Point(357, 8);
            this.Btn_Alter.Name = "Btn_Alter";
            this.Btn_Alter.Size = new System.Drawing.Size(75, 30);
            this.Btn_Alter.TabIndex = 3;
            this.Btn_Alter.Text = "修改";
            this.Btn_Alter.UseVisualStyleBackColor = true;
            this.Btn_Alter.Click += new System.EventHandler(this.Btn_Alter_Click);
            // 
            // Btn_Add
            // 
            this.Btn_Add.Location = new System.Drawing.Point(254, 8);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(75, 30);
            this.Btn_Add.TabIndex = 2;
            this.Btn_Add.Text = "添加";
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Btn_ExportExcel
            // 
            this.Btn_ExportExcel.Location = new System.Drawing.Point(129, 8);
            this.Btn_ExportExcel.Name = "Btn_ExportExcel";
            this.Btn_ExportExcel.Size = new System.Drawing.Size(100, 30);
            this.Btn_ExportExcel.TabIndex = 1;
            this.Btn_ExportExcel.Text = "导出Excel";
            this.Btn_ExportExcel.UseVisualStyleBackColor = true;
            // 
            // Btn_ExportWord
            // 
            this.Btn_ExportWord.Location = new System.Drawing.Point(10, 8);
            this.Btn_ExportWord.Name = "Btn_ExportWord";
            this.Btn_ExportWord.Size = new System.Drawing.Size(100, 30);
            this.Btn_ExportWord.TabIndex = 0;
            this.Btn_ExportWord.Text = "导出Word";
            this.Btn_ExportWord.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.Btn_Find2);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.comboBox6);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Font = new System.Drawing.Font("SimSun", 9F);
            this.groupBox2.Location = new System.Drawing.Point(16, 573);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(822, 79);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "高级查询";
            // 
            // Btn_Find2
            // 
            this.Btn_Find2.Font = new System.Drawing.Font("SimSun", 12F);
            this.Btn_Find2.Location = new System.Drawing.Point(707, 35);
            this.Btn_Find2.Name = "Btn_Find2";
            this.Btn_Find2.Size = new System.Drawing.Size(75, 36);
            this.Btn_Find2.TabIndex = 4;
            this.Btn_Find2.Text = "查找";
            this.Btn_Find2.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(452, 38);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(212, 28);
            this.textBox7.TabIndex = 3;
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(162, 39);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 26);
            this.comboBox6.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("SimSun", 12F);
            this.label16.Location = new System.Drawing.Point(327, 41);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 24);
            this.label16.TabIndex = 1;
            this.label16.Text = "查询条件";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("SimSun", 12F);
            this.label15.Location = new System.Drawing.Point(20, 41);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 24);
            this.label15.TabIndex = 0;
            this.label15.Text = "查询类型";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_Find1);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.comboBox5);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(16, 481);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(822, 80);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "普通查询";
            // 
            // Btn_Find1
            // 
            this.Btn_Find1.Font = new System.Drawing.Font("SimSun", 12F);
            this.Btn_Find1.Location = new System.Drawing.Point(707, 27);
            this.Btn_Find1.Name = "Btn_Find1";
            this.Btn_Find1.Size = new System.Drawing.Size(75, 36);
            this.Btn_Find1.TabIndex = 4;
            this.Btn_Find1.Text = "查找";
            this.Btn_Find1.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(452, 32);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(212, 28);
            this.textBox6.TabIndex = 3;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(162, 36);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 26);
            this.comboBox5.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("SimSun", 12F);
            this.label14.Location = new System.Drawing.Point(327, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 24);
            this.label14.TabIndex = 1;
            this.label14.Text = "查询条件";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("SimSun", 12F);
            this.label13.Location = new System.Drawing.Point(20, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 24);
            this.label13.TabIndex = 0;
            this.label13.Text = "查询类型";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.Btn_EditStatus);
            this.groupBox.Controls.Add(this.button4);
            this.groupBox.Controls.Add(this.button3);
            this.groupBox.Controls.Add(this.TB_Address);
            this.groupBox.Controls.Add(this.label_address);
            this.groupBox.Controls.Add(this.CB_Profession);
            this.groupBox.Controls.Add(this.MTB_IDcard);
            this.groupBox.Controls.Add(this.CB_College);
            this.groupBox.Controls.Add(this.CB_Nation);
            this.groupBox.Controls.Add(this.TB_Email);
            this.groupBox.Controls.Add(this.MTB_Phone);
            this.groupBox.Controls.Add(this.TB_Age);
            this.groupBox.Controls.Add(this.label1_profession);
            this.groupBox.Controls.Add(this.label_college);
            this.groupBox.Controls.Add(this.label_IDcard);
            this.groupBox.Controls.Add(this.label_nation);
            this.groupBox.Controls.Add(this.label_email);
            this.groupBox.Controls.Add(this.label_phone);
            this.groupBox.Controls.Add(this.label_age);
            this.groupBox.Controls.Add(this.DTP_birthday);
            this.groupBox.Controls.Add(this.label_birthday);
            this.groupBox.Controls.Add(this.CB_Sex);
            this.groupBox.Controls.Add(this.TB_id);
            this.groupBox.Controls.Add(this.TB_name);
            this.groupBox.Controls.Add(this.label_id);
            this.groupBox.Controls.Add(this.label_sex);
            this.groupBox.Controls.Add(this.label_name);
            this.groupBox.Controls.Add(this.Btn_DeletePhoto);
            this.groupBox.Controls.Add(this.Btn_SelectPhoto);
            this.groupBox.Controls.Add(this.pictureBox1);
            this.groupBox.Location = new System.Drawing.Point(15, 29);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(824, 442);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "基本信息";
            // 
            // Btn_EditStatus
            // 
            this.Btn_EditStatus.Location = new System.Drawing.Point(375, 389);
            this.Btn_EditStatus.Name = "Btn_EditStatus";
            this.Btn_EditStatus.Size = new System.Drawing.Size(100, 36);
            this.Btn_EditStatus.TabIndex = 29;
            this.Btn_EditStatus.Text = "浏览模式";
            this.Btn_EditStatus.UseVisualStyleBackColor = true;
            this.Btn_EditStatus.Click += new System.EventHandler(this.Btn_EditStatus_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(199, 389);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 36);
            this.button4.TabIndex = 28;
            this.button4.Text = "奖惩记录";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(25, 389);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 36);
            this.button3.TabIndex = 27;
            this.button3.Text = "授课";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // TB_Address
            // 
            this.TB_Address.Location = new System.Drawing.Point(128, 342);
            this.TB_Address.Name = "TB_Address";
            this.TB_Address.Size = new System.Drawing.Size(425, 28);
            this.TB_Address.TabIndex = 26;
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.Font = new System.Drawing.Font("SimSun", 12F);
            this.label_address.Location = new System.Drawing.Point(18, 342);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(106, 24);
            this.label_address.TabIndex = 25;
            this.label_address.Text = "家庭住址";
            // 
            // CB_Profession
            // 
            this.CB_Profession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Profession.FormattingEnabled = true;
            this.CB_Profession.Location = new System.Drawing.Point(544, 259);
            this.CB_Profession.Name = "CB_Profession";
            this.CB_Profession.Size = new System.Drawing.Size(175, 26);
            this.CB_Profession.TabIndex = 24;
            // 
            // MTB_IDcard
            // 
            this.MTB_IDcard.Location = new System.Drawing.Point(128, 298);
            this.MTB_IDcard.Mask = "000000-00000000-000A";
            this.MTB_IDcard.Name = "MTB_IDcard";
            this.MTB_IDcard.Size = new System.Drawing.Size(204, 28);
            this.MTB_IDcard.TabIndex = 22;
            // 
            // CB_College
            // 
            this.CB_College.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_College.FormattingEnabled = true;
            this.CB_College.Location = new System.Drawing.Point(290, 255);
            this.CB_College.Name = "CB_College";
            this.CB_College.Size = new System.Drawing.Size(158, 26);
            this.CB_College.TabIndex = 23;
            this.CB_College.SelectedIndexChanged += new System.EventHandler(this.CB_College_SelectedIndexChanged);
            // 
            // CB_Nation
            // 
            this.CB_Nation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Nation.FormattingEnabled = true;
            this.CB_Nation.Location = new System.Drawing.Point(544, 204);
            this.CB_Nation.Name = "CB_Nation";
            this.CB_Nation.Size = new System.Drawing.Size(175, 26);
            this.CB_Nation.TabIndex = 21;
            // 
            // TB_Email
            // 
            this.TB_Email.Location = new System.Drawing.Point(291, 204);
            this.TB_Email.Name = "TB_Email";
            this.TB_Email.Size = new System.Drawing.Size(157, 28);
            this.TB_Email.TabIndex = 20;
            // 
            // MTB_Phone
            // 
            this.MTB_Phone.Location = new System.Drawing.Point(544, 148);
            this.MTB_Phone.Mask = "000-0000-0000";
            this.MTB_Phone.Name = "MTB_Phone";
            this.MTB_Phone.Size = new System.Drawing.Size(206, 28);
            this.MTB_Phone.TabIndex = 19;
            // 
            // TB_Age
            // 
            this.TB_Age.Location = new System.Drawing.Point(291, 148);
            this.TB_Age.Name = "TB_Age";
            this.TB_Age.Size = new System.Drawing.Size(90, 28);
            this.TB_Age.TabIndex = 18;
            // 
            // label1_profession
            // 
            this.label1_profession.AutoSize = true;
            this.label1_profession.Font = new System.Drawing.Font("SimSun", 12F);
            this.label1_profession.Location = new System.Drawing.Point(467, 259);
            this.label1_profession.Name = "label1_profession";
            this.label1_profession.Size = new System.Drawing.Size(58, 24);
            this.label1_profession.TabIndex = 17;
            this.label1_profession.Text = "专业";
            // 
            // label_college
            // 
            this.label_college.AutoSize = true;
            this.label_college.Font = new System.Drawing.Font("SimSun", 12F);
            this.label_college.Location = new System.Drawing.Point(226, 259);
            this.label_college.Name = "label_college";
            this.label_college.Size = new System.Drawing.Size(58, 24);
            this.label_college.TabIndex = 16;
            this.label_college.Text = "学院";
            // 
            // label_IDcard
            // 
            this.label_IDcard.AutoSize = true;
            this.label_IDcard.Font = new System.Drawing.Font("SimSun", 12F);
            this.label_IDcard.Location = new System.Drawing.Point(18, 298);
            this.label_IDcard.Name = "label_IDcard";
            this.label_IDcard.Size = new System.Drawing.Size(82, 24);
            this.label_IDcard.TabIndex = 15;
            this.label_IDcard.Text = "身份证";
            // 
            // label_nation
            // 
            this.label_nation.AutoSize = true;
            this.label_nation.Font = new System.Drawing.Font("SimSun", 12F);
            this.label_nation.Location = new System.Drawing.Point(467, 206);
            this.label_nation.Name = "label_nation";
            this.label_nation.Size = new System.Drawing.Size(58, 24);
            this.label_nation.TabIndex = 14;
            this.label_nation.Text = "民族";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("SimSun", 12F);
            this.label_email.Location = new System.Drawing.Point(226, 206);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(58, 24);
            this.label_email.TabIndex = 13;
            this.label_email.Text = "邮箱";
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.Font = new System.Drawing.Font("SimSun", 12F);
            this.label_phone.Location = new System.Drawing.Point(467, 152);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(58, 24);
            this.label_phone.TabIndex = 12;
            this.label_phone.Text = "电话";
            // 
            // label_age
            // 
            this.label_age.AutoSize = true;
            this.label_age.Font = new System.Drawing.Font("SimSun", 12F);
            this.label_age.Location = new System.Drawing.Point(226, 152);
            this.label_age.Name = "label_age";
            this.label_age.Size = new System.Drawing.Size(58, 24);
            this.label_age.TabIndex = 11;
            this.label_age.Text = "年龄";
            // 
            // DTP_birthday
            // 
            this.DTP_birthday.Location = new System.Drawing.Point(544, 96);
            this.DTP_birthday.Name = "DTP_birthday";
            this.DTP_birthday.Size = new System.Drawing.Size(206, 28);
            this.DTP_birthday.TabIndex = 10;
            // 
            // label_birthday
            // 
            this.label_birthday.AutoSize = true;
            this.label_birthday.Font = new System.Drawing.Font("SimSun", 12F);
            this.label_birthday.Location = new System.Drawing.Point(467, 98);
            this.label_birthday.Name = "label_birthday";
            this.label_birthday.Size = new System.Drawing.Size(58, 24);
            this.label_birthday.TabIndex = 9;
            this.label_birthday.Text = "生日";
            // 
            // CB_Sex
            // 
            this.CB_Sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Sex.FormattingEnabled = true;
            this.CB_Sex.Location = new System.Drawing.Point(290, 96);
            this.CB_Sex.Name = "CB_Sex";
            this.CB_Sex.Size = new System.Drawing.Size(90, 26);
            this.CB_Sex.TabIndex = 8;
            // 
            // TB_id
            // 
            this.TB_id.Location = new System.Drawing.Point(544, 35);
            this.TB_id.Name = "TB_id";
            this.TB_id.Size = new System.Drawing.Size(206, 28);
            this.TB_id.TabIndex = 7;
            // 
            // TB_name
            // 
            this.TB_name.Location = new System.Drawing.Point(291, 37);
            this.TB_name.Name = "TB_name";
            this.TB_name.Size = new System.Drawing.Size(91, 28);
            this.TB_name.TabIndex = 6;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("SimSun", 12F);
            this.label_id.Location = new System.Drawing.Point(467, 39);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(58, 24);
            this.label_id.TabIndex = 5;
            this.label_id.Text = "工号";
            // 
            // label_sex
            // 
            this.label_sex.AutoSize = true;
            this.label_sex.Font = new System.Drawing.Font("SimSun", 12F);
            this.label_sex.Location = new System.Drawing.Point(226, 98);
            this.label_sex.Name = "label_sex";
            this.label_sex.Size = new System.Drawing.Size(58, 24);
            this.label_sex.TabIndex = 4;
            this.label_sex.Text = "性别";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("SimSun", 12F);
            this.label_name.Location = new System.Drawing.Point(226, 41);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(58, 24);
            this.label_name.TabIndex = 3;
            this.label_name.Text = "姓名";
            // 
            // Btn_DeletePhoto
            // 
            this.Btn_DeletePhoto.Location = new System.Drawing.Point(128, 251);
            this.Btn_DeletePhoto.Name = "Btn_DeletePhoto";
            this.Btn_DeletePhoto.Size = new System.Drawing.Size(75, 32);
            this.Btn_DeletePhoto.TabIndex = 2;
            this.Btn_DeletePhoto.Text = "删除";
            this.Btn_DeletePhoto.UseVisualStyleBackColor = true;
            // 
            // Btn_SelectPhoto
            // 
            this.Btn_SelectPhoto.Location = new System.Drawing.Point(20, 251);
            this.Btn_SelectPhoto.Name = "Btn_SelectPhoto";
            this.Btn_SelectPhoto.Size = new System.Drawing.Size(96, 32);
            this.Btn_SelectPhoto.TabIndex = 1;
            this.Btn_SelectPhoto.Text = "选择图片";
            this.Btn_SelectPhoto.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TMS_UI.Properties.Resources._default;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(22, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 202);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Check_timer
            // 
            this.Check_timer.Enabled = true;
            this.Check_timer.Tick += new System.EventHandler(this.Check_timer_Tick);
            // 
            // Form_TeacherMS_root
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TMS_UI.Properties.Resources.form_main_bg2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 805);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_TeacherMS_root";
            this.Text = "Form_TeacherMS_root";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_TeacherMS_root_FormClosing);
            this.Load += new System.EventHandler(this.Form_TeacherMS_root_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TeacherInfo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DGV_TeacherInfo;
        private System.Windows.Forms.Button Btn_selectItems;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button Btn_SelectPhoto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_DeletePhoto;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_sex;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox TB_Address;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.ComboBox CB_Profession;
        private System.Windows.Forms.MaskedTextBox MTB_IDcard;
        private System.Windows.Forms.ComboBox CB_College;
        private System.Windows.Forms.ComboBox CB_Nation;
        private System.Windows.Forms.TextBox TB_Email;
        private System.Windows.Forms.MaskedTextBox MTB_Phone;
        private System.Windows.Forms.TextBox TB_Age;
        private System.Windows.Forms.Label label1_profession;
        private System.Windows.Forms.Label label_college;
        private System.Windows.Forms.Label label_IDcard;
        private System.Windows.Forms.Label label_nation;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_phone;
        private System.Windows.Forms.Label label_age;
        private System.Windows.Forms.DateTimePicker DTP_birthday;
        private System.Windows.Forms.Label label_birthday;
        private System.Windows.Forms.ComboBox CB_Sex;
        private System.Windows.Forms.TextBox TB_id;
        private System.Windows.Forms.TextBox TB_name;
        private System.Windows.Forms.Button Btn_EditStatus;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_Find1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button Btn_Find2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button Btn_Alter;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Button Btn_ExportExcel;
        private System.Windows.Forms.Button Btn_ExportWord;
        private System.Windows.Forms.Button Btn_Quit;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacher_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacher_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacher_sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn nation_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacher_birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn college_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn profession_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_card;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn house_address;
        private System.Windows.Forms.Timer Check_timer;
    }
}