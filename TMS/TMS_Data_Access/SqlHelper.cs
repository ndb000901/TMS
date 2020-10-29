using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TMS_Data_Access
{
    /// <summary>
    /// 
    /// </summary>
    public class SqlHelper
    {
        #region--数据库属性--
        /// <summary>
        /// 服务器
        /// </summary>
        private static string server = ".";
        public static string Server
        {
            get { return server; }
            set { server = value; }
        }
        /// <summary>
        /// 用户名
        /// </summary>
        private static string uid = "sa";
        public static string Uid
        {
            get { return uid;}
            set { uid = value; }
        }

        /// <summary>
        /// 密码
        /// </summary>
        private static string pwd = "n123456";
        public static string Pwd
        {
            get { return pwd; }
            set { pwd = value; }
        }
        #endregion

        #region--数据库操作--
        public static SqlConnection myConn;
        public static SqlCommand myCommand;
        public static string connStr = "server=" + Server + ";database=TMS_Datebase;uid=" + Uid + ";pwd=" + Pwd + ";MultipleActiveResultSets=true";

        /// <summary>
        /// 连接数据库
        /// </summary>
        public static void GetConn()
        {
            try
            {
                myConn = new SqlConnection(connStr);
                myConn.Open();
            }
            catch
            {
                throw new Exception("数据库连接异常");
                //MessageBox.Show("提示", "数据库连接异常！");
            }
        }
        /// <summary>
        /// 断开数据库连接
        /// </summary>
        public static void CloseConn()
        {
            try
            {
                myConn.Close();
            }
            catch
            {
                throw new Exception("数据库断开失败！");
            }
        }
        /// <summary>
        /// 创建SQL命令
        /// </summary>
        /// <param name="sqlStr"></param>
        /// <returns></returns>
        public static SqlCommand CreateCommand(string sqlStr)
        {
            try
            {
                myCommand = new SqlCommand(sqlStr, myConn);
                return myCommand;
            }
            catch
            {
                throw new Exception("Sql命令创建失败！");
            }
        }
        #endregion
    }
}
