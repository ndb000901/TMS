using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_Data_Access;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace TMS_Logic.Public
{
    public class Log
    {
        public static void AddLog(string account_num, Do myDo, Object_id object_Id, string ID)
        {
            SqlHelper.GetConn();
            string sqlStr = "insert into myLog values('{0}','{1}')";
            if (myDo == Do.Add)
            {
                if (object_Id == Object_id.Teacher)
                {
                    sqlStr = string.Format(sqlStr, DateTime.Now.ToString(), "Root:" + account_num + "增加" + "教师(" + ID + ")");
                }
                else if (object_Id == Object_id.Student)
                {
                    sqlStr = string.Format(sqlStr, DateTime.Now.ToString(), "Root:" + account_num + "增加" + "学生(" + ID + ")");
                }
            }
            else if (myDo == Do.Alter)
            {
                if (object_Id == Object_id.Teacher)
                {
                    sqlStr = string.Format(sqlStr, DateTime.Now.ToString(), "Root:" + account_num + "修改" + "教师(" + ID + ")");
                }
                else if (object_Id == Object_id.Student)
                {
                    sqlStr = string.Format(sqlStr, DateTime.Now.ToString(), "Root:" + account_num + "修改" + "学生(" + ID + ")");
                }

            }
            else if (myDo == Do.Delete)
            {
                if (object_Id == Object_id.Teacher)
                {
                    sqlStr = string.Format(sqlStr, DateTime.Now.ToString(), "Root:" + account_num + "删除" + "教师(" + ID + ")");
                }
                else if (object_Id == Object_id.Student)
                {
                    sqlStr = string.Format(sqlStr, DateTime.Now.ToString(), "Root:" + account_num + "删除" + "学生(" + ID + ")");
                }

            }
            SqlHelper.CreateCommand(sqlStr).ExecuteNonQuery();
            SqlHelper.CloseConn();
        }
        public static void DGV_LogLoad(DataGridView dataGridView)
        {
            SqlHelper.GetConn();
            DataSet dataSet = new DataSet();
            string sqlStr = "select add_date,details from myLog";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(SqlHelper.CreateCommand(sqlStr));
            sqlDataAdapter.Fill(dataSet);
            dataGridView.DataSource = dataSet.Tables[0];
            dataGridView.AllowUserToAddRows = false;
            SqlHelper.CloseConn();
        }
    }
    public enum Do
    {
        Add = 0,
        Alter = 1,
        Delete = 2
    }
    public enum Object_id
    {
        Root = 0,
        Teacher = 1,
        Student = 2
    }

}
