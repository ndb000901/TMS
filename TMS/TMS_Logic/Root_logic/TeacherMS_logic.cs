using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_Data_Access;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using TMS_Logic.Public;
using TMS_Model.Model;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace TMS_Logic.Root_logic
{
    public class TeacherMS_logic
    {
        #region--加载UI--
        /// <summary>
        /// 加载性别
        /// </summary>
        /// <param name="comboBox"></param>
        public static void CB_teacherSex_Load(ComboBox comboBox)
        {
            comboBox.Items.Add("");
            comboBox.Items.Add("男");
            comboBox.Items.Add("女");
        }
        /// <summary>
        /// 加载民族
        /// </summary>
        /// <param name="comboBox"></param>
        public static void CB_teacherNation_Load(ComboBox comboBox)
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
        public static void CB_teacherCollege_Load(ComboBox comboBox)
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
        /// 加载专业
        /// </summary>
        /// <param name="comboBox"></param>
        /// <param name="college"></param>
        public static void CB_teacher_Profession_Load(ComboBox comboBox, string college)
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
                if (reader.HasRows)
                {
                    while (reader.Read())
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
        /// 加载教师信息
        /// </summary>
        /// <param name="dataGridView"></param>
        public static void DGV_teacherInfo_Load(DataGridView dataGridView)
        {
            SqlHelper.GetConn();
            DataSet dataSet = new DataSet();
            string sqlStr = "select t.teacher_name,t.teacher_id,t.teacher_sex,n.nation_name,t.teacher_birthday,c.college_name,p.profession_name,t.ID_card,t.email,t.phone_num,t.house_address from teacher as t,nation as n,college as c,profession as p where t.nation_id = n.nation_id and t.college_id = c.college_id and t.profession_id = p.profession_id";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(SqlHelper.CreateCommand(sqlStr));
            sqlDataAdapter.Fill(dataSet);
            dataGridView.DataSource = dataSet.Tables[0];
            dataGridView.AllowUserToAddRows = false;

            #region--设置显示列--
            dataGridView.Columns[0].Visible = SelectItemsT.ChB_name;
            dataGridView.Columns[1].Visible = SelectItemsT.ChB_id;
            dataGridView.Columns[2].Visible = SelectItemsT.ChB_sex;
            dataGridView.Columns[3].Visible = SelectItemsT.ChB_nation;
            dataGridView.Columns[4].Visible = SelectItemsT.ChB_birthday;
            dataGridView.Columns[5].Visible = SelectItemsT.ChB_college;
            dataGridView.Columns[6].Visible = SelectItemsT.ChB_profession;
            dataGridView.Columns[7].Visible = SelectItemsT.ChB_IDcard;
            dataGridView.Columns[8].Visible = SelectItemsT.ChB_email;
            dataGridView.Columns[9].Visible = SelectItemsT.ChB_phone;
            dataGridView.Columns[10].Visible = SelectItemsT.ChB_house_address;

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
            if (Status.Form_StudentMS_rootEditStatus == false)
            {
                MessageBox.Show("请切换至编辑模式", "提示");
                return false;
            }
            return true;
        }
        #endregion

        #region--增删改查数据导出--
        public static bool AddTeacherInfo(TeacherExt teacherExt)
        {
            SqlHelper.GetConn();
            string sqlStr = "insert into teacher values('{0}','{1}','{2}',(select college_id from college where college_name = '{3}'),(select nation_id from nation where nation_name = '{4}'),'{5}','{6}','{7}','{8}','{9}',null,(select profession_id from profession where profession_name = '{10}'))";
            sqlStr = string.Format(sqlStr, teacherExt.Teacher_id, teacherExt.Teacher_name, teacherExt.Teacher_sex, teacherExt.College_name, teacherExt.Nation_name, teacherExt.Email, teacherExt.Phone_num, teacherExt.House_address, teacherExt.ID_card, teacherExt.Teacher_birthday.ToString(), teacherExt.Profession_name);
            if (SqlHelper.CreateCommand(sqlStr).ExecuteNonQuery() == 0)
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
        public static bool DeleteTeacherInfo(TeacherExt teacherExt)
        {
            SqlHelper.GetConn();
            string sqlStr = "delete from teacher where teacher_id = '{0}'";
            sqlStr = string.Format(sqlStr, teacherExt.Teacher_id);
            if (SqlHelper.CreateCommand(sqlStr).ExecuteNonQuery() == 1)
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
        public static bool UpdateTeacherInfo(TeacherExt teacherExt)
        {
            SqlHelper.GetConn();
            string sqlCheck = "select * from teacher where teacher_id = '{0}'";
            sqlCheck = string.Format(sqlCheck, teacherExt.Teacher_id);
            SqlDataReader reader = SqlHelper.CreateCommand(sqlCheck).ExecuteReader();
            try
            {
                if (reader.HasRows)
                {
                    string sqlStr = "update teacher set teacher_id = '{0}',teacher_name = '{1}',teacher_sex = '{2}',college_id = (select college_id from college where college_name = '{3}'),nation_id = (select nation_id from nation where nation_name = '{4}'),email = '{5}',phone_num = '{6}',house_address = '{7}',ID_card = '{8}',teacher_birthday = '{9}',profession_id = (select profession_id from profession where profession_name = '{10}') where teacher_id = '{11}'";
                    sqlStr = string.Format(sqlStr, teacherExt.Teacher_id, teacherExt.Teacher_name, teacherExt.Teacher_sex, teacherExt.College_name, teacherExt.Nation_name, teacherExt.Email, teacherExt.Phone_num, teacherExt.House_address, teacherExt.ID_card, teacherExt.Teacher_birthday.ToString(), teacherExt.Profession_name,teacherExt.Teacher_id);
                    if (SqlHelper.CreateCommand(sqlStr).ExecuteNonQuery() == 0)
                    {
                        MessageBox.Show("修改失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    if (MessageBox.Show("不存在该工号教师，是否在数据库中添加此教师？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        AddTeacherInfo(teacherExt);
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
                throw new Exception("修改教师信息失败！");
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
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
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
