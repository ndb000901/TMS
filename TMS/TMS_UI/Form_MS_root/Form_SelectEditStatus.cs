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
using System.Runtime.InteropServices;

namespace TMS_UI.Form_MS_root
{
    public partial class Form_SelectEditStatus : Form
    {
        public Form_SelectEditStatus()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 点击确定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Ok_Click(object sender, EventArgs e)
        {

            if(Status.Current_id == 0)
            {
                if(this.TB_Pwd.Text == Program.Current_root.Root_pwd)
                {
                    Status.Form_StudentMS_rootEditStatus = true;
                    Status.EdittingStatus = true;
                    Status.Form_SelectEditStatus = false;
                    
                    this.Close();
                }
                else
                {
                    MessageBox.Show("密码错误", "警告");
                }
            }
            else
            {
                if (this.TB_Pwd.Text == Program.Current_user.User_pwd)
                {
                    Status.Form_StudentMS_rootEditStatus = true;
                    Status.Form_SelectEditStatus = false;

                    this.Close();
                }
                else
                {
                    MessageBox.Show("密码错误", "警告");

                }
            }
        }
        /// <summary>
        /// 点击取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Status.Form_SelectEditStatus = false;
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


        private void Form_SelectEditStatus_MouseUp(object sender, MouseEventArgs e)
        {
            //释放鼠标时的位置
            if (e.Button == MouseButtons.Left)
            {
                currentXPosition = 0; //设置初始状态
                currentYPosition = 0;
                beginMove = false;
            }

        }

        private void Form_SelectEditStatus_MouseMove(object sender, MouseEventArgs e)
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

        private void Form_SelectEditStatus_MouseDown(object sender, MouseEventArgs e)
        {
            //获取鼠标按下时的位置
            if (e.Button == MouseButtons.Left)
            {
                beginMove = true;
                currentXPosition = MousePosition.X;//鼠标的x坐标为当前窗体左上角x坐标
                currentYPosition = MousePosition.Y;//鼠标的y坐标为当前窗体左上角y坐标
            }

        }
        #endregion

        private void Form_SelectEditStatus_Load(object sender, EventArgs e)
        {

        }


        private void TB_Pwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.TB_Pwd.Text.Length < 0 || this.TB_Pwd.Text.Length > 32)
            {
                return;
            }
            if (e.KeyChar == 13)
            {
                this.Btn_Ok_Click(null, null);
            }

        }
    }
}
