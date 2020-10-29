using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMS_Logic.Public;
using TMS_Logic.Root_logic;
using TMS_UI.Form_MS_root;
using TMS_Model.Model;

namespace TMS_UI
{
    public partial class Form_TeacherMS_root : Form
    {
        public Form_TeacherMS_root()
        {
            InitializeComponent();
        }

        private void Btn_Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_TeacherMS_root_FormClosing(object sender, FormClosingEventArgs e)
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

        private void Form_TeacherMS_root_Load(object sender, EventArgs e)
        {
            SelectItemsT.ChB_name = true;
            SelectItemsT.ChB_id = true;


            TeacherMS_logic.CB_teacherCollege_Load(CB_College);
            TeacherMS_logic.CB_teacherNation_Load(CB_Nation);
            TeacherMS_logic.CB_teacherSex_Load(CB_Sex);
            TeacherMS_logic.DGV_teacherInfo_Load(DGV_TeacherInfo);
            Data_Load();
            FillObjectInfo();
            Status.BeforeIndex = this.DGV_TeacherInfo.CurrentRow.Index;



        }

        private void Btn_selectItems_Click(object sender, EventArgs e)
        {
            Form_SelectItemT form_SelectItemT = new Form_SelectItemT();
            form_SelectItemT.ShowDialog();
        }

        private void Check_timer_Tick(object sender, EventArgs e)
        {
            if (Status.SelectChangeStatus == true)
            {
                StudentMS_logic.DGV_studentInfo_Load(this.DGV_TeacherInfo);
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

        private void DGV_TeacherInfo_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            ///添加行号
            Rectangle rect = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y,
               DGV_TeacherInfo.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
                DGV_TeacherInfo.RowHeadersDefaultCellStyle.Font, rect,
                DGV_TeacherInfo.RowHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Right);

        }
        #region--逻辑函数--
        /// <summary>
        /// 从DGV加载数据
        /// </summary>
        public void Data_Load()
        {
            this.TB_name.Text = this.DGV_TeacherInfo["teacher_name", DGV_TeacherInfo.CurrentRow.Index].Value.ToString();
            this.TB_id.Text = this.DGV_TeacherInfo["teacher_id", DGV_TeacherInfo.CurrentRow.Index].Value.ToString();
            this.CB_Sex.SelectedItem = this.DGV_TeacherInfo["teacher_sex", DGV_TeacherInfo.CurrentRow.Index].Value.ToString();
            this.DTP_birthday.Value = Convert.ToDateTime(this.DGV_TeacherInfo["teacher_birthday", DGV_TeacherInfo.CurrentRow.Index].Value);
            this.TB_Age.Text = (DateTime.Now.Year - this.DTP_birthday.Value.Year).ToString();
            this.MTB_Phone.Text = this.DGV_TeacherInfo["phone_num", DGV_TeacherInfo.CurrentRow.Index].Value.ToString();
            this.TB_Email.Text = this.DGV_TeacherInfo["email", DGV_TeacherInfo.CurrentRow.Index].Value.ToString();
            this.CB_Nation.SelectedItem = this.DGV_TeacherInfo["nation_name", DGV_TeacherInfo.CurrentRow.Index].Value.ToString();
            this.CB_College.SelectedItem = this.DGV_TeacherInfo["college_name", DGV_TeacherInfo.CurrentRow.Index].Value.ToString();
            this.CB_Profession.SelectedItem = this.DGV_TeacherInfo["profession_name", DGV_TeacherInfo.CurrentRow.Index].Value.ToString();
            this.MTB_IDcard.Text = this.DGV_TeacherInfo["ID_card", DGV_TeacherInfo.CurrentRow.Index].Value.ToString();
            this.TB_Address.Text = this.DGV_TeacherInfo["house_address", DGV_TeacherInfo.CurrentRow.Index].Value.ToString(); 
        }
        TeacherExt teacherExt = new TeacherExt();
        public void FillObjectInfo()
        {
            teacherExt.Teacher_name = this.TB_name.Text;
            teacherExt.Teacher_id = this.TB_id.Text;
            teacherExt.Teacher_sex = this.CB_Sex.SelectedItem.ToString();
            teacherExt.Teacher_birthday = this.DTP_birthday.Value;
            teacherExt.Phone_num = this.MTB_Phone.Text.Replace("-","");
            teacherExt.Email = this.TB_Email.Text;
            teacherExt.Nation_name = this.CB_Nation.SelectedItem.ToString();
            teacherExt.College_name = this.CB_College.SelectedItem.ToString();
            teacherExt.Profession_name = this.CB_Profession.SelectedItem.ToString();
            teacherExt.ID_card = this.MTB_IDcard.Text.Replace("-","");
            teacherExt.House_address = this.TB_Address.Text;

        }
        public bool CheckTeaInfo()
        {
            if (TB_name.Text.Length == 0)
            {
                MessageBox.Show("姓名不可为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            if (!Check.CheckName(TB_name.Text))
            {
                MessageBox.Show("姓名错误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            if (TB_id.Text.Length != 12)
            {
                MessageBox.Show("学号错误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (DTP_birthday.Value > DateTime.Now)
            {
                MessageBox.Show("生日错误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (MTB_IDcard.Text.Replace("-", "").Length != 18)
            {
                MessageBox.Show("身份证长度错误错误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            if (MTB_IDcard.Text.Replace("-", "").Substring(6, 4) != DTP_birthday.Value.Year.ToString()
                || Convert.ToInt32(MTB_IDcard.Text.Replace("-", "").Substring(10, 2)) != Convert.ToInt32(DTP_birthday.Value.Month.ToString())
                || Convert.ToInt32(MTB_IDcard.Text.Replace("-", "").Substring(12, 2)) != Convert.ToInt32(DTP_birthday.Value.Day.ToString()))
            {
                MessageBox.Show("身份证与生日不符", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            if (MTB_Phone.Text.Length != 13)
            {
                MessageBox.Show("电话长度错误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            if (Check.CheckPhoneNum(MTB_Phone.Text.Replace("-", "")))
            {
                MessageBox.Show("电话格式错误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (TB_Email.Text.Length > 64 || TB_Email.Text.Length == 0)
            {
                MessageBox.Show("邮箱不可为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }

            if (Check.CheckEmail(TB_Email.Text))
            {
                MessageBox.Show("邮箱错误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (CB_Nation.SelectedItem.ToString().Trim() == "")
            {
                MessageBox.Show("民族不可为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            if (CB_College.SelectedItem.ToString().Trim() == "")
            {
                MessageBox.Show("学院不可为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            if (CB_Profession.SelectedItem.ToString().Trim() == "")
            {
                MessageBox.Show("专业不可为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            return true;
        }
        public void Con_ReadOnly()
        {
            if(Status.Form_StudentMS_rootEditStatus == false)
            {
                this.TB_name.ReadOnly = true;
                this.TB_id.ReadOnly = true;
                this.MTB_IDcard.ReadOnly = true;
                this.MTB_Phone.ReadOnly = true;
                this.TB_Address.ReadOnly = true;
                this.TB_Email.ReadOnly = true;
                this.TB_Age.ReadOnly = true;

                this.CB_Sex.Enabled = false;
                this.CB_Profession.Enabled = false;
                this.CB_Nation.Enabled = false;
                this.CB_College.Enabled = false;
                this.DTP_birthday.Enabled = false;
            }
            else
            {
                this.TB_name.ReadOnly = false;
                this.TB_id.ReadOnly = false;
                this.MTB_IDcard.ReadOnly = false;
                this.MTB_Phone.ReadOnly = false;
                this.TB_Address.ReadOnly = false;
                this.TB_Email.ReadOnly = false;
                this.TB_Age.ReadOnly = false;

                this.CB_Sex.Enabled = true;
                this.CB_Profession.Enabled = true;
                this.CB_Nation.Enabled = true;
                this.CB_College.Enabled = true;
                this.DTP_birthday.Enabled = true;

            }
        }
        public void Add_Clear()
        {
            this.TB_name.Text = "";
            this.TB_id.Text = "";
            this.CB_Sex.SelectedItem = "";
            this.DTP_birthday.Text = "";
            this.TB_Age.Text = "";
            this.MTB_Phone.Text = "";
            this.TB_Email.Text = "";
            this.CB_Nation.SelectedItem = "";
            this.CB_College.SelectedItem = "";
            this.CB_Profession.SelectedItem = "";
            this.MTB_IDcard.Text = "";
            this.TB_Address.Text = "";
        }
        public void EditCon_Load()
        {
            if (Status.IsAdding_Status == false)
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

        private void DGV_TeacherInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Status.EdittingStatus)
            {
                if (Status.IsAdding_Status)
                {
                    return;
                }
                else if (this.DGV_TeacherInfo.CurrentRow.Index != Status.BeforeIndex && this.DGV_TeacherInfo.SelectedRows.Count == 1 && Status.IsAdding_Status == false)
                {
                    if (!CheckTeaInfo())
                    {
                        Data_Load();
                        Status.BeforeIndex = this.DGV_TeacherInfo.CurrentRow.Index;

                        return;
                    }

                    if (MessageBox.Show("是否保存修改结果", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        //Data_Load();
                        //Status.BeforeIndex = this.DGV_studentInfo.CurrentRow.Index;
                        FillObjectInfo();

                        if(TeacherMS_logic.UpdateTeacherInfo(teacherExt))
                        {
                            MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Log.AddLog(Program.Current_root.Account_num, Do.Alter, Object_id.Teacher, teacherExt.Teacher_id);
                        }
                        else
                        {
                            MessageBox.Show("修改失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        TeacherMS_logic.DGV_teacherInfo_Load(DGV_TeacherInfo);
                        Data_Load();
                        Status.BeforeIndex = this.DGV_TeacherInfo.CurrentRow.Index;

                    }
                    else
                    {

                        Data_Load();
                        Status.BeforeIndex = this.DGV_TeacherInfo.CurrentRow.Index;

                    }

                }
            }
            else
            {
                if (this.DGV_TeacherInfo.CurrentRow.Index != Status.BeforeIndex && this.DGV_TeacherInfo.SelectedRows.Count == 1)
                {
                    Data_Load();
                    Status.BeforeIndex = this.DGV_TeacherInfo.CurrentRow.Index;
                }

            }
        }

        private void CB_College_SelectedIndexChanged(object sender, EventArgs e)
        {
            TeacherMS_logic.CB_teacher_Profession_Load(CB_Profession, CB_College.SelectedItem.ToString());
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
            if (!TeacherMS_logic.IsEditStatus())
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

            if (!TeacherMS_logic.IsEditStatus())
            {
                return;
            }
            else
            {
                if (!CheckTeaInfo())
                {
                    return;
                }

                if (MessageBox.Show("是否保存修改结果", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    FillObjectInfo();
                    if (TeacherMS_logic.UpdateTeacherInfo(teacherExt) == false)
                    {
                        MessageBox.Show("修改失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("修改成功", "提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        Log.AddLog(Program.Current_root.Account_num, Do.Alter, Object_id.Teacher, teacherExt.Teacher_id);
                        TeacherMS_logic.DGV_teacherInfo_Load(this.DGV_TeacherInfo);
                        Data_Load();
                        return;
                    }

                }
            }

        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否删除该数据，不可恢复？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                FillObjectInfo();
                if (TeacherMS_logic.DeleteTeacherInfo(teacherExt) == true)
                {
                    MessageBox.Show("删除成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Log.AddLog(Program.Current_root.Account_num, Do.Delete, Object_id.Teacher, teacherExt.Teacher_id);
                    TeacherMS_logic.DGV_teacherInfo_Load(this.DGV_TeacherInfo);
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

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            if (!TeacherMS_logic.IsEditStatus())
            {
                return;
            }
            else if (Status.IsAdding_Status == false)
            {
                if (MessageBox.Show("是否放弃修改？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    TeacherMS_logic.DGV_teacherInfo_Load(this.DGV_TeacherInfo);
                    Data_Load();
                }
            }
            else if (Status.IsAdding_Status == true)
            {
                if (MessageBox.Show("是否放弃添加", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    TeacherMS_logic.DGV_teacherInfo_Load(this.DGV_TeacherInfo);
                    Data_Load();
                    Status.IsAdding_Status = false;
                }
            }

        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (!CheckTeaInfo())
            {
                return;
            }
            if (!TeacherMS_logic.IsEditStatus())
            {
                return;
            }
            else if (Status.IsAdding_Status)
            {
                if (MessageBox.Show("是否保存新学生信息", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    FillObjectInfo();

                    if (TeacherMS_logic.AddTeacherInfo(teacherExt) == false)
                    {
                        return;
                    }
                    else
                    {
                        MessageBox.Show("保存成功","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        Log.AddLog(Program.Current_root.Account_num, Do.Add, Object_id.Teacher, teacherExt.Teacher_id);
                        TeacherMS_logic.DGV_teacherInfo_Load(this.DGV_TeacherInfo);
                        Data_Load();
                    }
                }
                else
                {
                    return;
                }
            }

        }
    }
}
