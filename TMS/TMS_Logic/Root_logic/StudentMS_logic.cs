using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMS_Data_Access;
using System.Data.SqlClient;
using System.Data;
using TMS_Logic.Public;
using TMS_Model.Model;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace TMS_Logic.Root_logic
{
    public class StudentMS_logic
    {
        #region--加载UI--
        public static void CB_studentSex_Load(ComboBox comboBox)
        {
            comboBox.Items.Add("");
            comboBox.Items.Add("男");
            comboBox.Items.Add("女");
        }
        /// <summary>
        /// 加载民族
        /// </summary>
        /// <param name="comboBox"></param>
        public static void CB_studentNation_Load(ComboBox comboBox)
        {
            comboBox.Items.Add("");
            SqlHelper.GetConn();
            string sqlStr = "select * from nation";
            SqlDataReader reader = SqlHelper.CreateCommand(sqlStr).ExecuteReader();
            try
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        comboBox.Items.Add(reader["nation_name"].ToString());
                    }
                }
            }
            catch
            {
                throw new Exception("学生管理界面民族下拉框加载错误！");
            }
            SqlHelper.CloseConn();


        }
        /// <summary>
        /// 加载学院
        /// </summary>
        /// <param name="comboBox"></param>
        public static void CB_studentCollege_Load(ComboBox comboBox)
        {
            comboBox.Items.Add("");
            SqlHelper.GetConn();
            string sqlStr = "select * from college";
            SqlDataReader reader = SqlHelper.CreateCommand(sqlStr).ExecuteReader();
            try
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        comboBox.Items.Add(reader["college_name"].ToString());
                    }
                }
            }
            catch
            {
                throw new Exception("学生管理界面学院下拉框加载错误！");
            }
            SqlHelper.CloseConn();

        }
        /// <summary>
        /// 加载学院
        /// </summary>
        /// <param name="comboBox"></param>
        /// <param name="college"></param>
        public static void CB_stduent_Profession_Load(ComboBox comboBox,string college)
        {
            comboBox.Items.Clear();
            comboBox.Text = "";
            comboBox.Items.Add("");
            SqlHelper.GetConn();
            string sqlStr = "select * from profession where college_id in (select college_id from college where college_name = '{0}')";
            sqlStr = string.Format(sqlStr, college);
            SqlDataReader reader = SqlHelper.CreateCommand(sqlStr).ExecuteReader();
            try
            {
                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        comboBox.Items.Add(reader["profession_name"].ToString());
                    }
                }
            }
            catch
            {
                throw new Exception("学生管理界面专业下拉框加载错误!");
            }
            SqlHelper.CloseConn();
        }
        /// <summary>
        /// 加载班级
        /// </summary>
        /// <param name="comboBox"></param>
        /// <param name="profession"></param>
        public static void CB_studentClass_Load(ComboBox comboBox,string profession)
        {
            comboBox.Items.Clear();
            comboBox.Text = "";
            SqlHelper.GetConn();
            string sqlStr = "select * from class where profession_id in (select profession_id from profession where profession_name = '{0}')";
            sqlStr = string.Format(sqlStr, profession);
            SqlDataReader reader = SqlHelper.CreateCommand(sqlStr).ExecuteReader();
            try
            {
                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        comboBox.Items.Add(reader["class_name"].ToString());
                    }
                }
            }
            catch
            {
                throw new Exception("学生管理界面班级下拉框加载错误");

            }
            SqlHelper.CloseConn();
        }
        public static void DGV_studentInfo_Load(DataGridView dataGridView)
        {
            SqlHelper.GetConn();
            DataSet dataSet = new DataSet();
            string sqlStr = "select student_name,student_id,student_sex,nation_name,student_birthday,ID_card,college_name,profession_name,class_name,phone_num,email,reward_punish_id,house_address from student as s,class as c,nation as n,college as co ,profession where c.class_id = s.class_id and co.college_id = s.college_id and n.nation_id = s.nation_id and s.profession_id = profession.profession_id";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(SqlHelper.CreateCommand(sqlStr));
            sqlDataAdapter.Fill(dataSet);
            dataGridView.DataSource = dataSet.Tables[0];
            dataGridView.AllowUserToAddRows = false;

            #region--设置显示列--
            dataGridView.Columns[0].Visible = SelectItems.ChB_name;
            dataGridView.Columns[1].Visible = SelectItems.ChB_id;
            dataGridView.Columns[2].Visible = SelectItems.ChB_sex;
            dataGridView.Columns[3].Visible = SelectItems.ChB_nation;
            dataGridView.Columns[4].Visible = SelectItems.ChB_birthday;
            dataGridView.Columns[5].Visible = SelectItems.ChB_ID_card;
            dataGridView.Columns[6].Visible = SelectItems.ChB_college;
            dataGridView.Columns[7].Visible = SelectItems.ChB_profession;
            dataGridView.Columns[8].Visible = SelectItems.ChB_class;
            dataGridView.Columns[9].Visible = SelectItems.ChB_phone;
            dataGridView.Columns[10].Visible = SelectItems.ChB_email;
            dataGridView.Columns[11].Visible = SelectItems.ChB_reward_punish;
            dataGridView.Columns[12].Visible = SelectItems.ChB_address;


            #endregion

            SqlHelper.CloseConn();
        }
        #endregion


        #region--界面操作--
        /// <summary>
        /// 判断是否可以编辑
        /// </summary>
        /// <returns></returns>
        public static bool IsEditStatus()
        {
            if(Status.Form_StudentMS_rootEditStatus == false)
            {
                MessageBox.Show("请切换至编辑模式", "提示");
                return false;
            }
            return true;
        }
        #endregion

        #region--增删改查数据导出--
        public static bool AddStudentInfo(StudentExt studentExt)
        {
            SqlHelper.GetConn();
            string sqlStr = "insert into student values('{0}','{1}','{2}',(select college_id from college where college_name = '{3}'),(select profession_id from profession where profession_name = '{4}'),(select class_id from class where class_name = '{5}' and profession_id = (select profession_id from profession where profession_name = '{6}')),'{7}','{8}','{9}',{10},'{11}',(select nation_id from nation where nation_name = '{12}'),null,'{13}')";
            sqlStr = string.Format(sqlStr, studentExt.Student_id, studentExt.Student_name, studentExt.Student_sex, studentExt.College_name, studentExt.Profession_name, studentExt.Class_name, studentExt.Profession_name, studentExt.ID_card, studentExt.Phone_num, studentExt.Email, "0", studentExt.House_address, studentExt.Nation_name, studentExt.Student_birthday.ToString());
            if(SqlHelper.CreateCommand(sqlStr).ExecuteNonQuery() == 0)
            {
                MessageBox.Show("添加失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SqlHelper.CloseConn();
                return false;
            }
            else
            {
                SqlHelper.CloseConn();
                return true;
            }
        }
        public static bool DeleteStudentInfo(StudentExt studentExt)
        {
            SqlHelper.GetConn();
            string sqlStr = "delete from student where student_id = '{0}'";
            sqlStr = string.Format(sqlStr, studentExt.Student_id);
            if(SqlHelper.CreateCommand(sqlStr).ExecuteNonQuery() == 1)
            {
                SqlHelper.CloseConn();
                return true;
            }
            else
            {
                SqlHelper.CloseConn();
                return false;
            }
        }
        public static bool UpdateStudentInfo(StudentExt studentExt)
        {
            SqlHelper.GetConn();
            string sqlCheck = "select * from student where student_id = '{0}'";
            sqlCheck = string.Format(sqlCheck, studentExt.Student_id);
            SqlDataReader reader = SqlHelper.CreateCommand(sqlCheck).ExecuteReader();
            try
            {
                if (reader.HasRows)
                {
                    string sqlStr = "update student set student_id = '{0}',student_name = '{1}',student_sex = '{2}',college_id = (select college_id from college where college_name = '{3}'),profession_id = (select profession_id from profession where profession_name = '{4}'),class_id = (select class_id from class where class_name = '{5}' and profession_id = (select profession_id from profession where profession_name = '{6}')),ID_card = '{7}',phone_num = '{8}',email = '{9}',house_address = '{10}',nation_id = (select nation_id from nation where nation_name = '{11}'),student_birthday = '{12}' where student_id = '{13}'";
                    sqlStr = string.Format(sqlStr, studentExt.Student_id, studentExt.Student_name, studentExt.Student_sex, studentExt.College_name, studentExt.Profession_name,studentExt.Class_name,studentExt.Profession_name, studentExt.ID_card, studentExt.Phone_num, studentExt.Email, studentExt.House_address, studentExt.Nation_name, studentExt.Student_birthday.Date.ToString(), studentExt.Student_id);
                    if(SqlHelper.CreateCommand(sqlStr).ExecuteNonQuery() == 0)
                    {
                        MessageBox.Show("修改失败", "提示",MessageBoxButtons.OK,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button1);
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    if(MessageBox.Show("不存在该学号学生，是否在数据库中添加此学生？","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        AddStudentInfo(studentExt);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch
            {
                throw new Exception("修改学生信息失败！");
            }
            finally
            {
                SqlHelper.CloseConn();
            }
        }
        public static bool ExportWord()
        {
            
            return false;
        }
        public static bool ExportExcel()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Filter = "xlsx files(*.xlsx)|*.xlsx"
            };
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.Create(saveFileDialog.FileName);
                //FileStream file = new FileStream(saveFileDialog.FileName, FileMode.Open);
                //file.Close();
            }
            
            Excel.Application excel = new Excel.Application();
            Excel.Workbook wb = null;
            excel.Visible = true;
            wb = excel.Workbooks.Open(null);
            return false;

        }
        #endregion
    }
}
