using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_Model.Model
{
    public class Nation
    {
        #region--民族--
        public int Nation_id { get; set; }          //民族id
        public string Nation_name_zh { get; set; }  //民族中文
        public string Nation_name_en { get; set; }  //民族英文
        #endregion
    }
}
