using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMS_Logic.Root_logic;
using TMS_UI.Form_MS_root;
using TMS_Logic.Public;
using TMS_Model.Model;

namespace TMS_UI
{
    public partial class Form_StudentMS_root : Form
    {
        public Form_StudentMS_root()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_StudentMS_root_Load(object sender, EventArgs e)
        {
            ///初始化信息显示设置
            SelectItems.ChB_id = true;  
            SelectItems.ChB_name = true;
            ///
            StudentMS_logic.CB_studentSex_Load(CB_studentSex);
            StudentMS_logic.CB_studentNation_Load(CB_studentNation);
            StudentMS_logic.CB_studentCollege_Load(CB_studentCollege);
            StudentMS_logic.DGV_studentInfo_Load(DGV_studentInfo);

            Data_Load();

            FillObjectInfo();
            Status.BeforeIndex = this.DGV_studentInfo.CurrentRow.Index;

        }

        /// <summary>
        /// 加载学院
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CB_studentCollege_SelectedIndexChanged(object sender, EventArgs e)
        {
            StudentMS_logic.CB_stduent_Profession_Load(CB_stduent_Profession, CB_studentCollege.SelectedItem.ToString());
        }
        /// <summary>
        /// 加载专业
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CB_stduent_Profession_SelectedIndexChanged(object sender, EventArgs e)
        {
            StudentMS_logic.CB_studentClass_Load(CB_studentClass, CB_stduent_Profession.SelectedItem.ToString());
        }
        /// <summary>
        /// 显示行号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DGV_studentInfo_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            ///添加行号
            Rectangle rect = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y,
               DGV_studentInfo.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
                DGV_studentInfo.RowHeadersDefaultCellStyle.Font, rect,
                DGV_studentInfo.RowHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Right);

        }

        private void Btn_selectItems_Click(object sender, EventArgs e)
        {
            if (Status.Form_selectItemsCreateStatus)
            {
                MessageBox.Show("窗体已经存在，请勿重复创建！", "警告");
                return;
            }
            Form_SelectItems form_SelectItems = new Form_SelectItems();
            Status.Form_selectItemsCreateStatus = true;//标识窗体已创建
            form_SelectItems.ShowDialog();

        }

        private void Check_timer_Tick(object sender, EventArgs e)
        {

            if (Status.SelectChangeStatus == true)
            {
                StudentMS_logic.DGV_studentInfo_Load(this.DGV_studentInfo);
                Status.SelectChangeStatus = false;
            }
            if (Status.Form_StudentMS_rootEditStatus)
            {
                Btn_ExportExcel.Enabled = false;
                Btn_ExportWord.Enabled = false;
                Btn_Delete.Enabled = false;
                this.Btn_EditStatus.Text = "编辑模式";
            }
            else
            {
                Btn_ExportExcel.Enabled = true;
                Btn_ExportWord.Enabled = true;
                Btn_Delete.Enabled = true;
                this.Btn_EditStatus.Text = "浏览模式";
            }
            EditCon_Load();
            Con_ReadOnly();

        }

        private void Btn_Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_StudentMS_root_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("确定退出？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            else
            {
                Status.Form_RootCreateStatus = false;
                Status.Form_StudentMS_rootEditStatus = false;
                Status.IsAdding_Status = false;
                Status.EdittingStatus = false;

            }
        }

        private void Btn_EditStatus_Click(object sender, EventArgs e)
        {
            if (Status.Form_SelectEditStatus)
            {
                MessageBox.Show("窗体已经存在，请勿重复创建！", "警告");
                return;

            }
            else if (Status.Form_StudentMS_rootEditStatus == false)
            {
                Form_SelectEditStatus form_SelectEditStatus = new Form_SelectEditStatus();
                Status.Form_SelectEditStatus = true;
                form_SelectEditStatus.ShowDialog();
            }
            else if (Status.Form_StudentMS_rootEditStatus)
            {
                if (MessageBox.Show("是否退回浏览模式", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    Status.Form_SelectEditStatus = false;
                    Status.Form_StudentMS_rootEditStatus = false;
                    Status.EdittingStatus = false;
                }
            }
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            if (!StudentMS_logic.IsEditStatus())
            {
                return;
            }
            else
            {
                Add_Clear();
                Status.EdittingStatus = true;
                Status.IsAdding_Status = true;
                EditCon_Load();
            }
        }

        private void Btn_Alter_Click(object sender, EventArgs e)
        {

            if (!StudentMS_logic.IsEditStatus())
            {
                return;
            }
            else
            {
                if (!CheckStuInfo())
                {
                    return;
                }

                if (MessageBox.Show("是否保存修改结果","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    FillObjectInfo();
                    if(StudentMS_logic.UpdateStudentInfo(studentExt) == false)
                    {
                        MessageBox.Show("修改失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("修改成功","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        Log.AddLog(Program.Current_root.Account_num, Do.Alter, Object_id.Student, studentExt.Student_id);
                        StudentMS_logic.DGV_studentInfo_Load(this.DGV_studentInfo);
                        Data_Load();
                        return;
                    }

                }
            }
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("是否删除该数据，不可恢复？","警告",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                FillObjectInfo();
                if (StudentMS_logic.DeleteStudentInfo(studentExt) == true)
                {
                    MessageBox.Show("删除成功！", "提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Log.AddLog(Program.Current_root.Account_num, Do.Delete, Object_id.Student, studentExt.Student_id);
                    StudentMS_logic.DGV_studentInfo_Load(this.DGV_studentInfo);
                    Data_Load();

                }
                else
                {
                    MessageBox.Show("删除失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                return;
            }
        }

        private void DGV_studentInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Status.EdittingStatus)
            {
                if (Status.IsAdding_Status)
                {
                    return;
                }
                else if (this.DGV_studentInfo.CurrentRow.Index != Status.BeforeIndex && this.DGV_studentInfo.SelectedRows.Count == 1 && Status.IsAdding_Status == false)
                {
                    if (!CheckStuInfo())
                    {
                        Data_Load();
                        Status.BeforeIndex = this.DGV_studentInfo.CurrentRow.Index;

                        return;
                    }

                    if (MessageBox.Show("是否保存修改结果", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        //Data_Load();
                        //Status.BeforeIndex = this.DGV_studentInfo.CurrentRow.Index;
                        FillObjectInfo();

                        if(StudentMS_logic.UpdateStudentInfo(studentExt))
                        {
                            MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Log.AddLog(Program.Current_root.Account_num, Do.Alter, Object_id.Student, studentExt.Student_id);

                        }
                        else
                        {
                            MessageBox.Show("修改失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        StudentMS_logic.DGV_studentInfo_Load(this.DGV_studentInfo);
                        Data_Load();
                        Status.BeforeIndex = this.DGV_studentInfo.CurrentRow.Index;

                    }
                    else
                    {

                        Data_Load();
                        Status.BeforeIndex = this.DGV_studentInfo.CurrentRow.Index;

                    }

                }
            }
            else
            {
                if (this.DGV_studentInfo.CurrentRow.Index != Status.BeforeIndex && this.DGV_studentInfo.SelectedRows.Count == 1)
                {
                    Data_Load();
                    Status.BeforeIndex = this.DGV_studentInfo.CurrentRow.Index;
                }

            }




        }

        #region--逻辑函数--
        /// <summary>
        /// 从DGV加载数据
        /// </summary>
        private void Data_Load()
        {
            #region--加载数据--
            this.TB_studentName.Text = this.DGV_studentInfo["student_name", DGV_studentInfo.CurrentRow.Index].Value.ToString();
            this.TB_student_id.Text = this.DGV_studentInfo["student_id", DGV_studentInfo.CurrentRow.Index].Value.ToString();
            this.CB_studentSex.SelectedItem = this.DGV_studentInfo["student_sex", DGV_studentInfo.CurrentRow.Index].Value.ToString();
            this.CB_studentNation.SelectedItem = this.DGV_studentInfo["nation_name", DGV_studentInfo.CurrentRow.Index].Value.ToString();
            this.DTP_studentBday.Value = Convert.ToDateTime(this.DGV_studentInfo["student_birthday", DGV_studentInfo.CurrentRow.Index].Value);
            this.TB_studentAge.Text = (DateTime.Now.Year - this.DTP_studentBday.Value.Year).ToString();
            this.MTB_idNum.Text = this.DGV_studentInfo["ID_card", DGV_studentInfo.CurrentRow.Index].Value.ToString();
            this.CB_studentCollege.SelectedItem = this.DGV_studentInfo["college_name", DGV_studentInfo.CurrentRow.Index].Value.ToString();
            this.CB_stduent_Profession.SelectedItem = this.DGV_studentInfo["profession_name", DGV_studentInfo.CurrentRow.Index].Value.ToString();
            this.CB_studentClass.SelectedItem = this.DGV_studentInfo["class_name", DGV_studentInfo.CurrentRow.Index].Value.ToString();
            this.MTB_phoneNum.Text = this.DGV_studentInfo["phone_num", DGV_studentInfo.CurrentRow.Index].Value.ToString();
            this.TB_studentEmail.Text = this.DGV_studentInfo["email", DGV_studentInfo.CurrentRow.Index].Value.ToString();
            this.TB_studentAddress.Text = this.DGV_studentInfo["house_address", DGV_studentInfo.CurrentRow.Index].Value.ToString();

            #endregion


        }
        /// <summary>
        /// 修改控件是否可编辑
        /// </summary>
        private void Con_ReadOnly()
        {
            if (Status.Form_StudentMS_rootEditStatus == false)
            {
                this.TB_studentName.ReadOnly = true;
                this.TB_student_id.ReadOnly = true;
                this.TB_studentAge.ReadOnly = true;
                this.TB_studentEmail.ReadOnly = true;
                this.TB_studentAddress.ReadOnly = true;
                this.MTB_idNum.ReadOnly = true;
                this.MTB_phoneNum.ReadOnly = true;
                this.CB_studentSex.Enabled = false;
                this.CB_studentNation.Enabled = false;
                this.CB_stduent_Profession.Enabled = false;
                this.CB_studentCollege.Enabled = false;
                this.CB_studentClass.Enabled = false;
                this.DTP_studentBday.Enabled = false;

            }
            else
            {
                this.TB_studentName.ReadOnly = false;
                this.TB_student_id.ReadOnly = false;
                this.TB_studentAge.ReadOnly = false;
                this.TB_studentEmail.ReadOnly = false;
                this.TB_studentAddress.ReadOnly = false;
                this.MTB_idNum.ReadOnly = false;
                this.MTB_phoneNum.ReadOnly = false;

                this.CB_studentSex.Enabled = true;
                this.CB_studentNation.Enabled = true;
                this.CB_stduent_Profession.Enabled = true;
                this.CB_studentClass.Enabled = true;
                this.DTP_studentBday.Enabled = true;
                this.CB_studentCollege.Enabled = true;



            }
        }
        /// <summary>
        /// 点击清理编辑区
        /// </summary>
        private void Add_Clear()
        {
            this.TB_studentAddress.Text = "";
            this.TB_studentAge.Text = "";
            this.TB_studentEmail.Text = "";
            this.TB_studentName.Text = "";
            this.TB_student_id.Text = "";
            this.MTB_idNum.Text = "";
            this.MTB_phoneNum.Text = "";
            this.CB_stduent_Profession.SelectedItem = "";
            this.CB_studentClass.SelectedItem = "";
            this.CB_studentCollege.SelectedItem = "";
            this.CB_studentNation.SelectedItem = "";
            this.CB_studentSex.SelectedItem = "";
            this.DTP_studentBday.Text = "";

        }
        /// <summary>
        /// 编辑区按钮状态
        /// </summary>
        private void EditCon_Load()
        {
            if(Status.IsAdding_Status == false)
            {
                this.Btn_Save.Enabled = false;
                this.Btn_Alter.Enabled = true;
                this.Btn_Add.Enabled = true;

            }
            else
            {
                this.Btn_Save.Enabled = true;
                this.Btn_Alter.Enabled = false;
                this.Btn_Add.Enabled = false;
            }

        }
        #endregion

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            if (!StudentMS_logic.IsEditStatus())
            {
                return;
            }
            else if(Status.IsAdding_Status == false)
            {
                if(MessageBox.Show("是否放弃修改？","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    StudentMS_logic.DGV_studentInfo_Load(this.DGV_studentInfo);
                    Data_Load();
                }
            }
            else if(Status.IsAdding_Status == true)
            {
                if(MessageBox.Show("是否放弃添加","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    StudentMS_logic.DGV_studentInfo_Load(this.DGV_studentInfo);
                    Data_Load();
                    Status.IsAdding_Status = false;
                }
            }

        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if(!CheckStuInfo())
            {
                return;
            }
            if (!StudentMS_logic.IsEditStatus())
            {
                return;
            }
            else if(Status.IsAdding_Status)
            {
                if(MessageBox.Show("是否保存新学生信息","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    FillObjectInfo();

                    if (StudentMS_logic.AddStudentInfo(studentExt) == false)
                    {
                        return;
                    }
                    else
                    {
                        MessageBox.Show("保存成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Log.AddLog(Program.Current_root.Account_num, Do.Add, Object_id.Student, studentExt.Student_id);
                        StudentMS_logic.DGV_studentInfo_Load(this.DGV_studentInfo);
                        Data_Load();
                    }
                }
                else
                {
                    return;
                }
            }

        }

        private void Btn_selectPhoto_Click(object sender, EventArgs e)
        {

        }

        #region--封装页面对象数据--
        StudentExt studentExt = new StudentExt();
        public void FillObjectInfo()
        {
            studentExt.Student_name = this.TB_studentName.Text;
            studentExt.Student_id = this.TB_student_id.Text;
            studentExt.Student_sex = this.CB_studentSex.SelectedItem.ToString();
            studentExt.Student_birthday = this.DTP_studentBday.Value;
            studentExt.Student_age = Convert.ToInt32(this.TB_studentAge.Text);
            studentExt.Phone_num = this.MTB_phoneNum.Text.Replace("-", "");
            studentExt.Email = this.TB_studentEmail.Text;
            studentExt.Nation_name = this.CB_studentNation.SelectedItem.ToString();
            studentExt.ID_card = this.MTB_idNum.Text.Replace("-","");
            studentExt.House_address = this.TB_studentAddress.Text;
            studentExt.Class_name = this.CB_stduent_Profession.SelectedItem.ToString();
            studentExt.Profession_name = this.CB_stduent_Profession.SelectedItem.ToString();
            studentExt.Class_name = this.CB_studentClass.SelectedItem.ToString();
            studentExt.College_name = this.CB_studentCollege.SelectedItem.ToString();
        }

        #endregion

        private void Btn_ExportWord_Click(object sender, EventArgs e)
        {

        }

        private void Btn_ExportExcel_Click(object sender, EventArgs e)
        {
            StudentMS_logic.ExportExcel();
        }
        public bool CheckStuInfo()
        {
            if (TB_studentName.Text.Length == 0)
            {
                MessageBox.Show("姓名不可为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            if (!Check.CheckName(TB_studentName.Text))
            {
                MessageBox.Show("姓名错误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            if (TB_student_id.Text.Length != 12)
            {
                MessageBox.Show("学号错误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (DTP_studentBday.Value > DateTime.Now)
            {
                MessageBox.Show("生日错误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (MTB_idNum.Text.Replace("-","").Length != 18)
            {
                MessageBox.Show("身份证长度错误错误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            if (MTB_idNum.Text.Replace("-", "").Substring(6, 4) != DTP_studentBday.Value.Year.ToString()
                || Convert.ToInt32(MTB_idNum.Text.Replace("-", "").Substring(10, 2)) != Convert.ToInt32(DTP_studentBday.Value.Month.ToString())
                || Convert.ToInt32(MTB_idNum.Text.Replace("-", "").Substring(12, 2)) != Convert.ToInt32(DTP_studentBday.Value.Day.ToString()))
            {
                MessageBox.Show("身份证与生日不符", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            if (MTB_phoneNum.Text.Length != 13)
            {
                MessageBox.Show("电话长度错误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            if (Check.CheckPhoneNum(MTB_phoneNum.Text.Replace("-","")))
            {
                MessageBox.Show("电话格式错误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (TB_studentEmail.Text.Length > 64 || TB_studentEmail.Text.Length == 0)
            {
                MessageBox.Show("邮箱不可为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            
            if (Check.CheckEmail(TB_studentEmail.Text))
            {
                MessageBox.Show("邮箱错误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (CB_studentNation.SelectedItem.ToString().Trim() == "")
            {
                MessageBox.Show("民族不可为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            if (CB_studentCollege.SelectedItem.ToString().Trim() == "")
            {
                MessageBox.Show("学院不可为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            if (CB_stduent_Profession.SelectedItem.ToString().Trim() == "")
            {
                MessageBox.Show("专业不可为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            if (CB_studentClass.SelectedItem.ToString().Trim() == "")
            {
                MessageBox.Show("班级不可为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void DGV_studentInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
