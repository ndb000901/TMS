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
namespace TMS_UI
{
    public partial class Form_alterPwd : Form
    {
        public Form_alterPwd()
        {
            InitializeComponent();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if(TB_Pwd1.Text.Length == 0)
            {
                MessageBox.Show("原密码不可为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(TB_Pwd2.Text.Length == 0)
            {
                MessageBox.Show("新密码不可为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(TB_Pwd3.Text.Length == 0)
            {
                MessageBox.Show("新密码不可为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(TB_Pwd2.Text != TB_Pwd3.Text)
            {
                MessageBox.Show("两次输入的新密码不一致", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (Status.Current_id == 0)
            {
                if (TB_Pwd1.Text == Program.Current_root.Root_pwd)
                {
                    if (MessageBox.Show("是否修改密码？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        if(AlterPwd.UpdatePwd(Program.Current_root.Account_num, Status.Current_id, TB_Pwd2.Text))
                        {
                            MessageBox.Show("修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("修改失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("原密码输入错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (TB_Pwd1.Text == Program.Current_root.Root_pwd)
                {
                    if (MessageBox.Show("是否修改密码？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        if(AlterPwd.UpdatePwd(Program.Current_user.Account_num, Status.Current_id, TB_Pwd2.Text))
                        {
                            MessageBox.Show("修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("修改失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("原密码输入错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void Form_alterPwd_Load(object sender, EventArgs e)
        {

        }

        #region--移动窗口--
        bool beginMove = false;//初始化鼠标位置
        int currentXPosition;
        int currentYPosition;

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]

        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void Form_alterPwd_MouseDown(object sender, MouseEventArgs e)
        {
            //获取鼠标按下时的位置
            if (e.Button == MouseButtons.Left)
            {
                beginMove = true;
                currentXPosition = MousePosition.X;//鼠标的x坐标为当前窗体左上角x坐标
                currentYPosition = MousePosition.Y;//鼠标的y坐标为当前窗体左上角y坐标
            }
        }

        private void Form_alterPwd_MouseMove(object sender, MouseEventArgs e)
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

        private void Form_alterPwd_MouseUp(object sender, MouseEventArgs e)
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
