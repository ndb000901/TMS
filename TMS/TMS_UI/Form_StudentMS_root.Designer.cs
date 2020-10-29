namespace TMS_UI
{
     public partial class Form_StudentMS_root
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_StudentMS_root));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_selectItems = new System.Windows.Forms.Button();
            this.DGV_studentInfo = new System.Windows.Forms.DataGridView();
            this.student_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nation_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_card = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.college_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profession_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reward_punish_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.house_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_EditStatus = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.Btn_Find2 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Find1 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Btn_rewardPunish = new System.Windows.Forms.Button();
            this.Btn_ScoreInfo = new System.Windows.Forms.Button();
            this.Btn_CourseInfo = new System.Windows.Forms.Button();
            this.CB_studentNation = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.CB_studentClass = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.CB_stduent_Profession = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TB_studentAddress = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CB_studentCollege = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TB_studentEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MTB_phoneNum = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Btn_deletePhoto = new System.Windows.Forms.Button();
            this.Btn_selectPhoto = new System.Windows.Forms.Button();
            this.TB_studentAge = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MTB_idNum = new System.Windows.Forms.MaskedTextBox();
            this.DTP_studentBday = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.CB_studentSex = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_student_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_studentName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PB_student = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Btn_ExportExcel = new System.Windows.Forms.Button();
            this.Btn_ExportWord = new System.Windows.Forms.Button();
            this.Btn_Quit = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_Alter = new System.Windows.Forms.Button();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Check_timer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_studentInfo)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_student)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.Btn_selectItems);
            this.panel1.Controls.Add(this.DGV_studentInfo);
            this.panel1.Location = new System.Drawing.Point(11, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 710);
            this.panel1.TabIndex = 0;
            // 
            // Btn_selectItems
            // 
            this.Btn_selectItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_selectItems.Location = new System.Drawing.Point(28, 14);
            this.Btn_selectItems.Name = "Btn_selectItems";
            this.Btn_selectItems.Size = new System.Drawing.Size(345, 33);
            this.Btn_selectItems.TabIndex = 1;
            this.Btn_selectItems.Text = "显示信息设置";
            this.Btn_selectItems.UseVisualStyleBackColor = true;
            this.Btn_selectItems.Click += new System.EventHandler(this.Btn_selectItems_Click);
            // 
            // DGV_studentInfo
            // 
            this.DGV_studentInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_studentInfo.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGV_studentInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_studentInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.student_name,
            this.student_id,
            this.student_sex,
            this.nation_name,
            this.student_birthday,
            this.ID_card,
            this.college_name,
            this.profession_name,
            this.class_name,
            this.phone_num,
            this.email,
            this.reward_punish_id,
            this.house_address});
            this.DGV_studentInfo.Location = new System.Drawing.Point(15, 55);
            this.DGV_studentInfo.Name = "DGV_studentInfo";
            this.DGV_studentInfo.ReadOnly = true;
            this.DGV_studentInfo.RowHeadersWidth = 62;
            this.DGV_studentInfo.RowTemplate.Height = 30;
            this.DGV_studentInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_studentInfo.Size = new System.Drawing.Size(370, 643);
            this.DGV_studentInfo.TabIndex = 0;
            this.DGV_studentInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_studentInfo_CellClick);
            this.DGV_studentInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_studentInfo_CellContentClick);
            this.DGV_studentInfo.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DGV_studentInfo_RowPostPaint);
            // 
            // student_name
            // 
            this.student_name.DataPropertyName = "student_name";
            this.student_name.HeaderText = "姓名";
            this.student_name.MinimumWidth = 8;
            this.student_name.Name = "student_name";
            this.student_name.ReadOnly = true;
            this.student_name.Width = 150;
            // 
            // student_id
            // 
            this.student_id.DataPropertyName = "student_id";
            this.student_id.HeaderText = "学号";
            this.student_id.MinimumWidth = 8;
            this.student_id.Name = "student_id";
            this.student_id.ReadOnly = true;
            this.student_id.Width = 150;
            // 
            // student_sex
            // 
            this.student_sex.DataPropertyName = "student_sex";
            this.student_sex.HeaderText = "性别";
            this.student_sex.MinimumWidth = 8;
            this.student_sex.Name = "student_sex";
            this.student_sex.ReadOnly = true;
            this.student_sex.Width = 150;
            // 
            // nation_name
            // 
            this.nation_name.DataPropertyName = "nation_name";
            this.nation_name.HeaderText = "民族";
            this.nation_name.MinimumWidth = 8;
            this.nation_name.Name = "nation_name";
            this.nation_name.ReadOnly = true;
            this.nation_name.Width = 150;
            // 
            // student_birthday
            // 
            this.student_birthday.DataPropertyName = "student_birthday";
            this.student_birthday.HeaderText = "生日";
            this.student_birthday.MinimumWidth = 8;
            this.student_birthday.Name = "student_birthday";
            this.student_birthday.ReadOnly = true;
            this.student_birthday.Width = 150;
            // 
            // ID_card
            // 
            this.ID_card.DataPropertyName = "ID_card";
            this.ID_card.HeaderText = "身份证";
            this.ID_card.MinimumWidth = 8;
            this.ID_card.Name = "ID_card";
            this.ID_card.ReadOnly = true;
            this.ID_card.Width = 150;
            // 
            // college_name
            // 
            this.college_name.DataPropertyName = "college_name";
            this.college_name.HeaderText = "学院";
            this.college_name.MinimumWidth = 8;
            this.college_name.Name = "college_name";
            this.college_name.ReadOnly = true;
            this.college_name.Width = 150;
            // 
            // profession_name
            // 
            this.profession_name.DataPropertyName = "profession_name";
            this.profession_name.HeaderText = "专业";
            this.profession_name.MinimumWidth = 8;
            this.profession_name.Name = "profession_name";
            this.profession_name.ReadOnly = true;
            this.profession_name.Width = 150;
            // 
            // class_name
            // 
            this.class_name.DataPropertyName = "class_name";
            this.class_name.HeaderText = "班级";
            this.class_name.MinimumWidth = 8;
            this.class_name.Name = "class_name";
            this.class_name.ReadOnly = true;
            this.class_name.Width = 150;
            // 
            // phone_num
            // 
            this.phone_num.DataPropertyName = "phone_num";
            this.phone_num.HeaderText = "电话";
            this.phone_num.MinimumWidth = 8;
            this.phone_num.Name = "phone_num";
            this.phone_num.ReadOnly = true;
            this.phone_num.Width = 150;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "邮箱";
            this.email.MinimumWidth = 8;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 150;
            // 
            // reward_punish_id
            // 
            this.reward_punish_id.DataPropertyName = "reward_punish_id";
            this.reward_punish_id.HeaderText = "奖惩";
            this.reward_punish_id.MinimumWidth = 8;
            this.reward_punish_id.Name = "reward_punish_id";
            this.reward_punish_id.ReadOnly = true;
            this.reward_punish_id.Width = 150;
            // 
            // house_address
            // 
            this.house_address.DataPropertyName = "house_address";
            this.house_address.HeaderText = "家庭住址";
            this.house_address.MinimumWidth = 8;
            this.house_address.Name = "house_address";
            this.house_address.ReadOnly = true;
            this.house_address.Width = 150;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.Btn_EditStatus);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.Btn_rewardPunish);
            this.panel2.Controls.Add(this.Btn_ScoreInfo);
            this.panel2.Controls.Add(this.Btn_CourseInfo);
            this.panel2.Controls.Add(this.CB_studentNation);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.CB_studentClass);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.CB_stduent_Profession);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.TB_studentAddress);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.CB_studentCollege);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.TB_studentEmail);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.MTB_phoneNum);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.Btn_deletePhoto);
            this.panel2.Controls.Add(this.Btn_selectPhoto);
            this.panel2.Controls.Add(this.TB_studentAge);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.MTB_idNum);
            this.panel2.Controls.Add(this.DTP_studentBday);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.CB_studentSex);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.TB_student_id);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.TB_studentName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.PB_student);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(427, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(845, 710);
            this.panel2.TabIndex = 1;
            // 
            // Btn_EditStatus
            // 
            this.Btn_EditStatus.Font = new System.Drawing.Font("宋体", 12F);
            this.Btn_EditStatus.Location = new System.Drawing.Point(577, 343);
            this.Btn_EditStatus.Name = "Btn_EditStatus";
            this.Btn_EditStatus.Size = new System.Drawing.Size(121, 36);
            this.Btn_EditStatus.TabIndex = 35;
            this.Btn_EditStatus.Text = "浏览模式";
            this.Btn_EditStatus.UseVisualStyleBackColor = true;
            this.Btn_EditStatus.Click += new System.EventHandler(this.Btn_EditStatus_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.button18);
            this.groupBox2.Controls.Add(this.button17);
            this.groupBox2.Controls.Add(this.Btn_Find2);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 12F);
            this.groupBox2.Location = new System.Drawing.Point(18, 513);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(793, 131);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "高级查询";
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(191, 61);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(84, 36);
            this.button18.TabIndex = 6;
            this.button18.Text = "帮助";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(9, 61);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(168, 36);
            this.button17.TabIndex = 5;
            this.button17.Text = "选择查询类型";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // Btn_Find2
            // 
            this.Btn_Find2.Location = new System.Drawing.Point(646, 62);
            this.Btn_Find2.Name = "Btn_Find2";
            this.Btn_Find2.Size = new System.Drawing.Size(75, 36);
            this.Btn_Find2.TabIndex = 4;
            this.Btn_Find2.Text = "查找";
            this.Btn_Find2.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(414, 62);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(214, 35);
            this.textBox7.TabIndex = 3;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(290, 66);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(106, 24);
            this.label17.TabIndex = 2;
            this.label17.Text = "查询条件";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_Find1);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.comboBox6);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F);
            this.groupBox1.Location = new System.Drawing.Point(18, 400);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(793, 113);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "普通查询";
            // 
            // Btn_Find1
            // 
            this.Btn_Find1.Location = new System.Drawing.Point(647, 52);
            this.Btn_Find1.Name = "Btn_Find1";
            this.Btn_Find1.Size = new System.Drawing.Size(75, 36);
            this.Btn_Find1.TabIndex = 4;
            this.Btn_Find1.Text = "查找";
            this.Btn_Find1.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(412, 51);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(216, 35);
            this.textBox6.TabIndex = 3;
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "姓名",
            "学号",
            "身份证",
            "民族",
            "生日",
            "年龄",
            "性别",
            "学院",
            "专业"});
            this.comboBox6.Location = new System.Drawing.Point(126, 54);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 32);
            this.comboBox6.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(286, 57);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 24);
            this.label15.TabIndex = 1;
            this.label15.Text = "查询条件";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 12F);
            this.label14.Location = new System.Drawing.Point(16, 59);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 24);
            this.label14.TabIndex = 0;
            this.label14.Text = "查询类型";
            // 
            // Btn_rewardPunish
            // 
            this.Btn_rewardPunish.Font = new System.Drawing.Font("宋体", 12F);
            this.Btn_rewardPunish.Location = new System.Drawing.Point(382, 343);
            this.Btn_rewardPunish.Name = "Btn_rewardPunish";
            this.Btn_rewardPunish.Size = new System.Drawing.Size(140, 36);
            this.Btn_rewardPunish.TabIndex = 32;
            this.Btn_rewardPunish.Text = "奖惩记录";
            this.Btn_rewardPunish.UseVisualStyleBackColor = true;
            // 
            // Btn_ScoreInfo
            // 
            this.Btn_ScoreInfo.Font = new System.Drawing.Font("宋体", 12F);
            this.Btn_ScoreInfo.Location = new System.Drawing.Point(199, 343);
            this.Btn_ScoreInfo.Name = "Btn_ScoreInfo";
            this.Btn_ScoreInfo.Size = new System.Drawing.Size(100, 36);
            this.Btn_ScoreInfo.TabIndex = 31;
            this.Btn_ScoreInfo.Text = "成绩";
            this.Btn_ScoreInfo.UseVisualStyleBackColor = true;
            // 
            // Btn_CourseInfo
            // 
            this.Btn_CourseInfo.Font = new System.Drawing.Font("宋体", 12F);
            this.Btn_CourseInfo.Location = new System.Drawing.Point(15, 343);
            this.Btn_CourseInfo.Name = "Btn_CourseInfo";
            this.Btn_CourseInfo.Size = new System.Drawing.Size(100, 36);
            this.Btn_CourseInfo.TabIndex = 30;
            this.Btn_CourseInfo.Text = "课表";
            this.Btn_CourseInfo.UseVisualStyleBackColor = true;
            // 
            // CB_studentNation
            // 
            this.CB_studentNation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_studentNation.FormattingEnabled = true;
            this.CB_studentNation.Location = new System.Drawing.Point(553, 159);
            this.CB_studentNation.Name = "CB_studentNation";
            this.CB_studentNation.Size = new System.Drawing.Size(118, 26);
            this.CB_studentNation.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 12F);
            this.label13.Location = new System.Drawing.Point(487, 161);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 24);
            this.label13.TabIndex = 28;
            this.label13.Text = "民族";
            // 
            // CB_studentClass
            // 
            this.CB_studentClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_studentClass.FormattingEnabled = true;
            this.CB_studentClass.Location = new System.Drawing.Point(625, 296);
            this.CB_studentClass.Name = "CB_studentClass";
            this.CB_studentClass.Size = new System.Drawing.Size(72, 26);
            this.CB_studentClass.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 12F);
            this.label12.Location = new System.Drawing.Point(563, 299);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 24);
            this.label12.TabIndex = 26;
            this.label12.Text = "班级";
            // 
            // CB_stduent_Profession
            // 
            this.CB_stduent_Profession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_stduent_Profession.FormattingEnabled = true;
            this.CB_stduent_Profession.Location = new System.Drawing.Point(374, 297);
            this.CB_stduent_Profession.Name = "CB_stduent_Profession";
            this.CB_stduent_Profession.Size = new System.Drawing.Size(175, 26);
            this.CB_stduent_Profession.TabIndex = 25;
            this.CB_stduent_Profession.SelectedIndexChanged += new System.EventHandler(this.CB_stduent_Profession_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 12F);
            this.label11.Location = new System.Drawing.Point(310, 296);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 24);
            this.label11.TabIndex = 24;
            this.label11.Text = "专业";
            // 
            // TB_studentAddress
            // 
            this.TB_studentAddress.Location = new System.Drawing.Point(322, 245);
            this.TB_studentAddress.Name = "TB_studentAddress";
            this.TB_studentAddress.Size = new System.Drawing.Size(376, 28);
            this.TB_studentAddress.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 12F);
            this.label10.Location = new System.Drawing.Point(217, 246);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 24);
            this.label10.TabIndex = 22;
            this.label10.Text = "家庭住址";
            // 
            // CB_studentCollege
            // 
            this.CB_studentCollege.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_studentCollege.FormattingEnabled = true;
            this.CB_studentCollege.Location = new System.Drawing.Point(79, 298);
            this.CB_studentCollege.Name = "CB_studentCollege";
            this.CB_studentCollege.Size = new System.Drawing.Size(220, 26);
            this.CB_studentCollege.TabIndex = 21;
            this.CB_studentCollege.SelectedIndexChanged += new System.EventHandler(this.CB_studentCollege_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 12F);
            this.label9.Location = new System.Drawing.Point(11, 300);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 24);
            this.label9.TabIndex = 20;
            this.label9.Text = "学院";
            // 
            // TB_studentEmail
            // 
            this.TB_studentEmail.Location = new System.Drawing.Point(290, 159);
            this.TB_studentEmail.Name = "TB_studentEmail";
            this.TB_studentEmail.Size = new System.Drawing.Size(172, 28);
            this.TB_studentEmail.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 12F);
            this.label8.Location = new System.Drawing.Point(220, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 24);
            this.label8.TabIndex = 18;
            this.label8.Text = "邮箱";
            // 
            // MTB_phoneNum
            // 
            this.MTB_phoneNum.Location = new System.Drawing.Point(480, 115);
            this.MTB_phoneNum.Mask = "000-0000-0000";
            this.MTB_phoneNum.Name = "MTB_phoneNum";
            this.MTB_phoneNum.Size = new System.Drawing.Size(217, 28);
            this.MTB_phoneNum.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F);
            this.label7.Location = new System.Drawing.Point(407, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "电话";
            // 
            // Btn_deletePhoto
            // 
            this.Btn_deletePhoto.Location = new System.Drawing.Point(127, 240);
            this.Btn_deletePhoto.Name = "Btn_deletePhoto";
            this.Btn_deletePhoto.Size = new System.Drawing.Size(68, 36);
            this.Btn_deletePhoto.TabIndex = 15;
            this.Btn_deletePhoto.Text = "删除";
            this.Btn_deletePhoto.UseVisualStyleBackColor = true;
            // 
            // Btn_selectPhoto
            // 
            this.Btn_selectPhoto.Location = new System.Drawing.Point(15, 240);
            this.Btn_selectPhoto.Name = "Btn_selectPhoto";
            this.Btn_selectPhoto.Size = new System.Drawing.Size(96, 36);
            this.Btn_selectPhoto.TabIndex = 14;
            this.Btn_selectPhoto.Text = "选择图片";
            this.Btn_selectPhoto.UseVisualStyleBackColor = true;
            this.Btn_selectPhoto.Click += new System.EventHandler(this.Btn_selectPhoto_Click);
            // 
            // TB_studentAge
            // 
            this.TB_studentAge.Location = new System.Drawing.Point(292, 116);
            this.TB_studentAge.Name = "TB_studentAge";
            this.TB_studentAge.Size = new System.Drawing.Size(91, 28);
            this.TB_studentAge.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F);
            this.label6.Location = new System.Drawing.Point(217, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "年龄";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F);
            this.label5.Location = new System.Drawing.Point(220, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "身份证";
            // 
            // MTB_idNum
            // 
            this.MTB_idNum.Location = new System.Drawing.Point(321, 204);
            this.MTB_idNum.Mask = "000000-00000000-000A";
            this.MTB_idNum.Name = "MTB_idNum";
            this.MTB_idNum.Size = new System.Drawing.Size(201, 28);
            this.MTB_idNum.TabIndex = 10;
            // 
            // DTP_studentBday
            // 
            this.DTP_studentBday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_studentBday.Location = new System.Drawing.Point(478, 75);
            this.DTP_studentBday.Name = "DTP_studentBday";
            this.DTP_studentBday.Size = new System.Drawing.Size(219, 28);
            this.DTP_studentBday.TabIndex = 9;
            this.DTP_studentBday.Value = new System.DateTime(1900, 1, 1, 21, 50, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F);
            this.label4.Location = new System.Drawing.Point(409, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "生日";
            // 
            // CB_studentSex
            // 
            this.CB_studentSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_studentSex.FormattingEnabled = true;
            this.CB_studentSex.Location = new System.Drawing.Point(290, 73);
            this.CB_studentSex.Name = "CB_studentSex";
            this.CB_studentSex.Size = new System.Drawing.Size(93, 26);
            this.CB_studentSex.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(220, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "性别";
            // 
            // TB_student_id
            // 
            this.TB_student_id.Font = new System.Drawing.Font("宋体", 9F);
            this.TB_student_id.Location = new System.Drawing.Point(478, 26);
            this.TB_student_id.Name = "TB_student_id";
            this.TB_student_id.Size = new System.Drawing.Size(219, 28);
            this.TB_student_id.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(408, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "学号";
            // 
            // TB_studentName
            // 
            this.TB_studentName.Font = new System.Drawing.Font("宋体", 9F);
            this.TB_studentName.Location = new System.Drawing.Point(290, 28);
            this.TB_studentName.Name = "TB_studentName";
            this.TB_studentName.Size = new System.Drawing.Size(96, 28);
            this.TB_studentName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(221, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "姓名";
            // 
            // PB_student
            // 
            this.PB_student.BackgroundImage = global::TMS_UI.Properties.Resources._default;
            this.PB_student.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_student.InitialImage = ((System.Drawing.Image)(resources.GetObject("PB_student.InitialImage")));
            this.PB_student.Location = new System.Drawing.Point(15, 26);
            this.PB_student.Name = "PB_student";
            this.PB_student.Size = new System.Drawing.Size(181, 202);
            this.PB_student.TabIndex = 1;
            this.PB_student.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.Btn_Save);
            this.panel3.Controls.Add(this.Btn_ExportExcel);
            this.panel3.Controls.Add(this.Btn_ExportWord);
            this.panel3.Controls.Add(this.Btn_Quit);
            this.panel3.Controls.Add(this.Btn_Cancel);
            this.panel3.Controls.Add(this.Btn_Delete);
            this.panel3.Controls.Add(this.Btn_Alter);
            this.panel3.Controls.Add(this.Btn_Add);
            this.panel3.Location = new System.Drawing.Point(12, 654);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(822, 42);
            this.panel3.TabIndex = 0;
            // 
            // Btn_Save
            // 
            this.Btn_Save.Location = new System.Drawing.Point(632, 7);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(75, 30);
            this.Btn_Save.TabIndex = 7;
            this.Btn_Save.Text = "保存";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_ExportExcel
            // 
            this.Btn_ExportExcel.Location = new System.Drawing.Point(135, 7);
            this.Btn_ExportExcel.Name = "Btn_ExportExcel";
            this.Btn_ExportExcel.Size = new System.Drawing.Size(100, 30);
            this.Btn_ExportExcel.TabIndex = 6;
            this.Btn_ExportExcel.Text = "导出Excel";
            this.Btn_ExportExcel.UseVisualStyleBackColor = true;
            this.Btn_ExportExcel.Click += new System.EventHandler(this.Btn_ExportExcel_Click);
            // 
            // Btn_ExportWord
            // 
            this.Btn_ExportWord.Location = new System.Drawing.Point(11, 7);
            this.Btn_ExportWord.Name = "Btn_ExportWord";
            this.Btn_ExportWord.Size = new System.Drawing.Size(100, 30);
            this.Btn_ExportWord.TabIndex = 5;
            this.Btn_ExportWord.Text = "导出Word";
            this.Btn_ExportWord.UseVisualStyleBackColor = true;
            this.Btn_ExportWord.Click += new System.EventHandler(this.Btn_ExportWord_Click);
            // 
            // Btn_Quit
            // 
            this.Btn_Quit.Location = new System.Drawing.Point(724, 7);
            this.Btn_Quit.Name = "Btn_Quit";
            this.Btn_Quit.Size = new System.Drawing.Size(75, 30);
            this.Btn_Quit.TabIndex = 4;
            this.Btn_Quit.Text = "退出";
            this.Btn_Quit.UseVisualStyleBackColor = true;
            this.Btn_Quit.Click += new System.EventHandler(this.Btn_Quit_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(541, 7);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(75, 30);
            this.Btn_Cancel.TabIndex = 3;
            this.Btn_Cancel.Text = "取消";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Location = new System.Drawing.Point(448, 7);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(75, 30);
            this.Btn_Delete.TabIndex = 2;
            this.Btn_Delete.Text = "删除";
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_Alter
            // 
            this.Btn_Alter.Location = new System.Drawing.Point(360, 7);
            this.Btn_Alter.Name = "Btn_Alter";
            this.Btn_Alter.Size = new System.Drawing.Size(75, 30);
            this.Btn_Alter.TabIndex = 1;
            this.Btn_Alter.Text = "修改";
            this.Btn_Alter.UseVisualStyleBackColor = true;
            this.Btn_Alter.Click += new System.EventHandler(this.Btn_Alter_Click);
            // 
            // Btn_Add
            // 
            this.Btn_Add.Location = new System.Drawing.Point(261, 7);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(75, 30);
            this.Btn_Add.TabIndex = 0;
            this.Btn_Add.Text = "添加";
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Check_timer
            // 
            this.Check_timer.Enabled = true;
            this.Check_timer.Tick += new System.EventHandler(this.Check_timer_Tick);
            // 
            // Form_StudentMS_root
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TMS_UI.Properties.Resources.form_main_bg2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 805);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_StudentMS_root";
            this.Text = "Form_StudentMS_root";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_StudentMS_root_FormClosing);
            this.Load += new System.EventHandler(this.Form_StudentMS_root_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_studentInfo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_student)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Btn_ExportWord;
        private System.Windows.Forms.Button Btn_Quit;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button Btn_Alter;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Button Btn_selectItems;
        private System.Windows.Forms.Button Btn_ExportExcel;
        private System.Windows.Forms.ComboBox CB_studentSex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_student_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_studentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PB_student;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DTP_studentBday;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox MTB_idNum;
        private System.Windows.Forms.MaskedTextBox MTB_phoneNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Btn_deletePhoto;
        private System.Windows.Forms.Button Btn_selectPhoto;
        private System.Windows.Forms.TextBox TB_studentAge;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CB_studentClass;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox CB_stduent_Profession;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TB_studentAddress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CB_studentCollege;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TB_studentEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CB_studentNation;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_Find1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button Btn_rewardPunish;
        private System.Windows.Forms.Button Btn_ScoreInfo;
        private System.Windows.Forms.Button Btn_CourseInfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btn_EditStatus;
        private System.Windows.Forms.Button Btn_Find2;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.DataGridView DGV_studentInfo;
        private System.Windows.Forms.Timer Check_timer;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn nation_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_card;
        private System.Windows.Forms.DataGridViewTextBoxColumn college_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn profession_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn class_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn reward_punish_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn house_address;
        private System.Windows.Forms.Button Btn_Save;
    }
}