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
using TMS_Logic.Root_logic;
using TMS_UI;
using System.Runtime.InteropServices;


namespace TMS_UI.Form_MS_root
{
    public partial class Form_SelectItems : Form
    {

        public Form_SelectItems()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 读取信息显示设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_SelectItems_Load(object sender, EventArgs e)
        {
            this.ChB_id.Checked = SelectItems.ChB_id;
            this.ChB_name.Checked = SelectItems.ChB_name;
            this.ChB_address.Checked = SelectItems.ChB_address;
            this.ChB_birthday.Checked = SelectItems.ChB_birthday;
            this.ChB_class.Checked = SelectItems.ChB_class;
            this.ChB_college.Checked = SelectItems.ChB_college;
            this.ChB_email.Checked = SelectItems.ChB_email;
            this.ChB_ID_card.Checked = SelectItems.ChB_ID_card;
            this.ChB_nation.Checked = SelectItems.ChB_nation;
            this.ChB_phone.Checked = SelectItems.ChB_phone;
            this.ChB_profession.Checked = SelectItems.ChB_profession;
            this.ChB_reward_punish.Checked = SelectItems.ChB_reward_punish;
            this.ChB_sex.Checked = SelectItems.ChB_sex;


        }
        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Quit_Click(object sender, EventArgs e)
        {
            Status.Form_selectItemsCreateStatus = false; //标识窗口已关
            this.Close();
        }
        /// <summary>
        /// 保存显示信息设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            SelectItems.ChB_id = this.ChB_id.Checked;
            SelectItems.ChB_name = this.ChB_name.Checked;
            SelectItems.ChB_address = this.ChB_address.Checked;
            SelectItems.ChB_birthday = this.ChB_birthday.Checked ;
            SelectItems.ChB_class = this.ChB_class.Checked;
            SelectItems.ChB_college = this.ChB_college.Checked;
            SelectItems.ChB_email = this.ChB_email.Checked;
            SelectItems.ChB_ID_card = this.ChB_ID_card.Checked;
            SelectItems.ChB_nation = this.ChB_nation.Checked;
            SelectItems.ChB_phone = this.ChB_phone.Checked;
            SelectItems.ChB_profession = this.ChB_profession.Checked;
            SelectItems.ChB_reward_punish = this.ChB_reward_punish.Checked;
            SelectItems.ChB_sex = this.ChB_sex.Checked;
            Status.SelectChangeStatus = true;
            Status.Form_selectItemsCreateStatus = false;//标识窗体已关
            this.Close();
        }

        #region--窗体移动--
        bool beginMove = false;//初始化鼠标位置
        int currentXPosition;
        int currentYPosition;
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void Form_SelectItems_MouseDown(object sender, MouseEventArgs e)
        {
            //获取鼠标按下时的位置
            if (e.Button == MouseButtons.Left)
            {
                beginMove = true;
                currentXPosition = MousePosition.X;//鼠标的x坐标为当前窗体左上角x坐标
                currentYPosition = MousePosition.Y;//鼠标的y坐标为当前窗体左上角y坐标
            }

        }

        private void Form_SelectItems_MouseMove(object sender, MouseEventArgs e)
        {
            //获取鼠标移动到的位置
            if (beginMove)
            {
                this.Left += MousePosition.X - currentXPosition;//根据鼠标x坐标确定窗体的左边坐标x
                this.Top += MousePosition.Y - currentYPosition;//根据鼠标的y坐标窗体的顶部，即Y坐标
                currentXPosition = MousePosition.X;
                currentYPosition = MousePosition.Y;
            }

        }

        private void Form_SelectItems_MouseUp(object sender, MouseEventArgs e)
        {
            //释放鼠标时的位置
            if (e.Button == MouseButtons.Left)
            {
                currentXPosition = 0; //设置初始状态
                currentYPosition = 0;
                beginMove = false;
            }

        }
        #endregion
    }
}
