using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using TMS_Data_Access;
using TMS_Logic;
using TMS_Logic.Public;

namespace TMS_UI
{
    public partial class Form_Login : Form
    {


        
        public Form_Login()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 点击退出按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Bt_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定退出？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        /// <summary>
        /// 点击清除按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Bt_clear_Click(object sender, EventArgs e)
        {
            TB_account_num.Text = "";
            TB_pwd.Text = "";
        }
        /// <summary>
        /// 点击登录按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Bt_login_Click(object sender, EventArgs e)
        {
            #region--设置身份id--           
            if (RBtn_root.Checked == true)
            {
                Status.Current_id = 0;
            }
            else if(RBtn_student.Checked == true)
            {
                Status.Current_id = 2;
            }
            else if(RBtn_teacher.Checked == true)
            {
                Status.Current_id = 1;
            }

            #endregion
            #region--验证账号密码--
            if (Check.NumPwdCheck(TB_account_num.Text,TB_pwd.Text,Status.Current_id))
            {
                this.DialogResult = DialogResult.OK;
                if(Status.Current_id == 0)
                {
                    Program.Current_root = Check.Current_root;
                }
                else
                {
                    Program.Current_user = Check.Current_user;
                }
            }
            else
            {
                MessageBox.Show("密码或账号错误！账号密码至少6位(数字或字母)","提示");
            }
            #endregion
        }
        /// <summary>
        /// UI加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Login_Load(object sender, EventArgs e)
        {
            this.RBtn_student.Checked = true;
            //TB_account_num.Text = "admin";
            //TB_pwd.Text = "admin";
            //TB_pwd.Focus();
            RBtn_root.Checked = true;
            //Bt_login_Click(null, null);


        }

        #region--移动窗口--
        bool beginMove = false;//初始化鼠标位置
        int currentXPosition;
        int currentYPosition;

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]

        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void Form_Login_MouseDown(object sender, MouseEventArgs e)
        {
            //获取鼠标按下时的位置
                if (e.Button == MouseButtons.Left)
                {
                    beginMove = true;
                    currentXPosition = MousePosition.X;//鼠标的x坐标为当前窗体左上角x坐标
                    currentYPosition = MousePosition.Y;//鼠标的y坐标为当前窗体左上角y坐标
                }
        }

        private void Form_Login_MouseMove(object sender, MouseEventArgs e)
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
        
        private void Form_Login_MouseUp(object sender, MouseEventArgs e)
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

        /// <summary>
        /// 当鼠标移至按钮时，改变箭头样式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Bt_login_MouseLeave(object sender, EventArgs e)
        {
            
            Bt_login.Cursor = System.Windows.Forms.Cursors.Hand;

        }
        /// <summary>
        /// 当鼠标移至按钮时，改变箭头样式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Bt_clear_MouseLeave(object sender, EventArgs e)
        {
            Bt_clear.Cursor = System.Windows.Forms.Cursors.Hand;

        }
        /// <summary>
        /// 当鼠标移至按钮时，改变箭头样式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Bt_exit_MouseLeave(object sender, EventArgs e)
        {
            Bt_exit.Cursor = System.Windows.Forms.Cursors.Hand;

        }

        #region--按下回车键进行相应处理--
        /// <summary>
        /// 账号输入按下回车键进行相应处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TB_account_num_KeyDown(object sender, KeyEventArgs e)
        {
            if(TB_account_num.Text.Length == 0)
            {
                return;
            }
            if(e.KeyValue == 13)
            {
                TB_pwd.Focus();
            }
        }
        /// <summary>
        /// 密码输入按下回车键进行相应处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TB_pwd_KeyDown(object sender, KeyEventArgs e)
        {
            if(TB_pwd.Text.Length == 0)
            {
                return;
            }
            if(e.KeyValue == 13)
            {
                this.Bt_login_Click(sender, e);

            }
        }
        #endregion

        /// <summary>
        /// 限制中文输入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TB_account_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar > 127)
            {
                e.Handled = true;
            }
        }

        private void Form_Login_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
