using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_Data_Access;
using TMS_Model.Model;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace TMS_Logic.Public
{

    public class Check
    {
        #region--登录界面--

        public static Root Current_root = new Root();//暂存当前root信息
        public static User Current_user = new User();//暂存当前user信息

        /// <summary>
        /// 验证是否存在该用户
        /// </summary>
        /// <param name="num"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public static bool NumPwdCheck(string num,string pwd,int id)
        {
            #region--检查账号密码格式是否有误--
            if(num.Length < 0 || num.Length > 32)
            {
                return false;
            }
            if(pwd.Length < 0 || pwd.Length > 32)
            {
                return false;
            }
            #endregion
            SqlHelper.GetConn();//连接数据库

            #region--检查并存储用户信息--
            if (id == 0)
            {
                string sqlStr = "select * from [root] where account_num = '{0}' and root_pwd = '{1}'";
                sqlStr = string.Format(sqlStr, num, pwd);          
                SqlDataReader reader = SqlHelper.CreateCommand(sqlStr).ExecuteReader();
                try
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Current_root.Account_num = reader["account_num"].ToString();
                            Current_root.Root_pwd = reader["root_pwd"].ToString();
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                catch
                {
                    throw new Exception("读取root数据发生错误！");
                }
            }
            else if(id == 1 || id == 2)
            {
                string sqlStr = "select * from [user] where account_num = '{0}' and user_pwd = '{1}' and identity_id = '{2}'";
                sqlStr = string.Format(sqlStr, num, pwd, id);
                SqlDataReader reader = SqlHelper.CreateCommand(sqlStr).ExecuteReader();
                try
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Current_user.Account_num = reader["account_num"].ToString();
                            Current_user.User_pwd = reader["user_pwd"].ToString();
                            Current_user.Id_num = reader["identity_id"].ToString();
                            Current_user.Identity_id = id;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                catch
                {
                    throw new Exception("读取user数据发生错误！");
                }

            }
            #endregion

            SqlHelper.CloseConn();//断开数据库

            return true;
        }
        #endregion


        #region--学生基本信息界面--
        public static bool CheckStuInfo(StudentExt studentExt)
        {
            if (studentExt.Student_name.Length == 0)
            {
                MessageBox.Show("姓名不可为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            if(!CheckName(studentExt.Student_name))
            {
                MessageBox.Show("姓名错误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            if (studentExt.Student_id.Length != 12)
            {
                MessageBox.Show("学号错误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (studentExt.Student_birthday > DateTime.Now)
            {
                MessageBox.Show("生日错误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (studentExt.ID_card.Length != 18)
            {
                MessageBox.Show("身份证长度错误错误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            if(studentExt.ID_card.Substring(7,4) != studentExt.Student_birthday.Year.ToString()
                || studentExt.ID_card.Substring(11,2) != studentExt.Student_birthday.Month.ToString()
                ||studentExt.ID_card.Substring(13,2) != studentExt.Student_birthday.Day.ToString())
            {
                MessageBox.Show("身份证与生日不符", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            if (studentExt.Phone_num.Length == 0)
            {
                MessageBox.Show("电话不可为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            if(CheckPhoneNum(studentExt.Phone_num))
            {
                MessageBox.Show("电话格式错误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(studentExt.Email.Length == 0)
            {
                MessageBox.Show("邮箱不可为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            if(CheckEmail(studentExt.Email))
            {
                MessageBox.Show("邮箱错误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(studentExt.Nation_name.Trim() == "")
            {
                MessageBox.Show("民族不可为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            if(studentExt.Class_name.Trim() == "")
            {
                MessageBox.Show("学院不可为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            if(studentExt.Profession_name.Trim() == "")
            {
                MessageBox.Show("专业不可为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            if(studentExt.Class_name.Trim() == "")
            {
                MessageBox.Show("班级不可为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public static bool CheckName(string name)
        {
            Regex regex1 = new Regex(@"^[\u4e00-\u9fa5]{0,}$");
            Regex regex2 = new Regex(@"^\w+$");
            if (regex1.IsMatch(name) || regex2.IsMatch(name))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool CheckPhoneNum(string phoneNum)
        {
            Regex regex = new Regex(@"^1 [358] [0-9] [0-9] [0-9] [0-9] [0-9] [0-9] [0-9] [0-9] [0-9]$");
            return regex.IsMatch(phoneNum);
        }
        public static bool CheckEmail(string email)
        {
            Regex regex = new Regex(@"^\w+((-\w+)|(\.\w+))*\@[A-Za-z0-9]+((\.|-)[A-Za-z0-9]+)*\.[A-Za-z0-9]+$");
            return regex.IsMatch(email);
        }
        #endregion


    }

}
