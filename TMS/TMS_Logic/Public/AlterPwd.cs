using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_Data_Access;
namespace TMS_Logic.Public
{
    public class AlterPwd
    {
        public static bool UpdatePwd(string account_num,int id,string newPwd)
        {
            SqlHelper.GetConn();
            string sqlStr = "update {0} set {1} = '{2}' where account_num = '{3}'";
            if(id == 0)
            {
                sqlStr = string.Format(sqlStr, "root", "root_pwd", newPwd, account_num);
            }
            else
            {
                sqlStr = string.Format(sqlStr, "user", "user_pwd", newPwd, account_num);
            }
            try
            {
                if(SqlHelper.CreateCommand(sqlStr).ExecuteNonQuery() == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                throw new Exception("修改密码失败");
            }
            finally
            {
                SqlHelper.CloseConn();
            }
        }
    }
}
