using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_Model.Model
{
    public class Student
    {
        #region--学生--
        public string Student_id { get; set; }      //学号
        public string Student_name { get; set; }    //姓名
        public string Student_sex { get; set; }       //性别
        public int College_id { get; set; }         //所属学院id
        public int Class_id { get; set; }           //班级id
        public int Profession_id { get; set; }      //专业id
        public string ID_card { get; set; }         //身份证号
        public string Phone_num { get; set; }       //电话号码
        public string Email { get; set; }           //邮箱
        public int Reward_Punish_id {get;set;}      //奖惩
        public string House_address { get; set; }   //家庭地址
        public int Nation_id { get; set; }          //民族
        public DateTime Student_birthday { get; set; }//生日
        #endregion
    }
}
