using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_Model.Model
{
    public class Profession
    {
        #region--专业--
        public int Profession_id { get; set; }      //专业id
        public string Profession_name { get; set; } //专业名称
        public int College_id { get; set; }         //所属学院
        #endregion
    }
}
