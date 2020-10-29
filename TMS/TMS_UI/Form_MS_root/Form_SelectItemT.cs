using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMS_Logic.Public;

namespace TMS_UI.Form_MS_root
{
    public partial class Form_SelectItemT : Form
    {
        public Form_SelectItemT()
        {
            InitializeComponent();
        }

        private void Form_SelectItemT_Load(object sender, EventArgs e)
        {
            this.ChB_name.Checked = SelectItemsT.ChB_name;
            this.ChB_id.Checked = SelectItemsT.ChB_id;
            this.ChB_sex.Checked = SelectItemsT.ChB_sex;
            this.ChB_nation.Checked = SelectItemsT.ChB_nation;
            this.ChB_birthday.Checked = SelectItemsT.ChB_birthday;
            this.ChB_college.Checked = SelectItemsT.ChB_college;
            this.ChB_profession.Checked = SelectItemsT.ChB_profession;
            this.ChB_IDcard.Checked = SelectItemsT.ChB_IDcard;
            this.ChB_email.Checked = SelectItemsT.ChB_email;
            this.ChB_Phone.Checked = SelectItemsT.ChB_phone;
            this.ChB_house_address.Checked = SelectItemsT.ChB_house_address;
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            SelectItemsT.ChB_name = ChB_name.Checked;
            SelectItemsT.ChB_id = ChB_id.Checked;
            SelectItemsT.ChB_sex = ChB_sex.Checked;
            SelectItemsT.ChB_nation = ChB_nation.Checked;
            SelectItemsT.ChB_birthday = ChB_birthday.Checked;
            SelectItemsT.ChB_college = ChB_college.Checked;
            SelectItemsT.ChB_profession = ChB_profession.Checked;
            SelectItemsT.ChB_IDcard = ChB_IDcard.Checked;
            SelectItemsT.ChB_email = ChB_email.Checked;
            SelectItemsT.ChB_phone = ChB_Phone.Checked;
            SelectItemsT.ChB_house_address = ChB_house_address.Checked;

            Status.SelectChangeStatus = true;

            this.Close();
        }

        private void Btn_Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
