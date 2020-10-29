using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_Model.Model
{
    public class User
    {
        #region--用户属性--
        public string Account_num { get; set; } //用户账号
        public int Identity_id { get; set; }    //用户权限id
        public string User_pwd { get; set; }    //用户密码
        public string Id_num { get; set; }      //用户工号

        #endregion



    }
}
