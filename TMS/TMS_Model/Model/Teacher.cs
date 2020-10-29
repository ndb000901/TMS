using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_Model.Model
{
    public class Teacher
    {
        #region--教师--
        public string Teacher_id { get; set; }      //职工号
        public string Teacher_name { get; set; }    //教师姓名
        public string Teacher_sex { get; set; }       //教师性别
        public int Teacher_age { get; set; }        //教师年龄
        public int College_id { get; set; }         //所属学院
        public int Nation_id { get; set; }          //民族
        public string Email { get; set; }           //邮箱
        public string Phone_num { get; set; }       //电话
        public string House_address { get; set; }   //家庭住址
        public string ID_card { get; set; }         //身份证
        public DateTime Teacher_birthday { get; set; }
        #endregion
    }
}
