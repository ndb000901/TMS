using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_Model.Model;
namespace TMS_Model.Model
{
    public class TeacherExt:Teacher
    {
        public string Nation_name { get; set; }
        public string College_name { get; set; }
        public string Profession_name { get; set; }
    }
}
