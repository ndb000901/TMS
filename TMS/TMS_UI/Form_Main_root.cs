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

namespace TMS_UI
{
    public partial class Form_Main_root : Form
    {
        public Form_Main_root()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Main_Load(object sender, EventArgs e)
        {
            //加载背景图
            Form_Main_panel.BackgroundImage = Image.FromFile(@"../../../src/images/form_main_bg.jpg");
            Form_Main_panel.BackgroundImageLayout = ImageLayout.Stretch;
            if(Status.Current_id == 0)
            {
                label_userInfo.Text = " Root：  " + Program.Current_root.Account_num;
            }
            else if(Status.Current_id == 1)
            {
                label_userInfo.Text = " 教师：  " + Program.Current_user.Account_num;
            }
            else if(Status.Current_id == 2)
            {
                label_userInfo.Text = " 学生：  " + Program.Current_user.Account_num;

            }
        }
        /// <summary>
        /// 打开工具cmd
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cmd_TSMI_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Windows\System32\cmd.exe");
        }
        /// <summary>
        /// 打开工具记事本
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Notepad_TSMI_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Windows\System32\notepad.exe");
        }
        /// <summary>
        /// 打开工具计算器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Clac_TSMI_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Windows\System32\calc.exe");
        }

        /// <summary>
        /// 询问是否退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("确定退出？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }

        }
        /// <summary>
        /// 刷新实时时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Status_timer_Tick(object sender, EventArgs e)
        {
            label_dateTime.Text = DateTime.Now.ToString();

        }
        /// <summary>
        /// 退出系统
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Quit_TSMI_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// 生成学生管理系统界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StudentM_MS_Click(object sender, EventArgs e)
        {
            if(Status.Form_RootCreateStatus)
            {
                MessageBox.Show("窗体已经存在，请勿重复创建！", "警告",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;

            }
            Form_StudentMS_root form_StudentMS_Root = new Form_StudentMS_root
            {
                TopLevel = false,
                Dock = DockStyle.Fill,
                Parent = this.Form_Main_panel
            };
            form_StudentMS_Root.Show();
            Status.Form_RootCreateStatus = true;
        }

        private void Form_Main_panel_Paint(object sender, PaintEventArgs e)
        {
            //if(Form_Main_panel.)

            //string a = Form_Main_panel.Controls.ToString();
            //int i = 1;
            //foreach (Control item in Form_Main_panel.Controls)
            //{
            //    if(item is Form)
            //    {
            //        i = 0;
            //        //return;
            //    }
            //}
            //if(i == 1)
            //{
            //    return;
            //}
            //((Form_StudentMS_root)Form_Main_panel.Controls["form_StudentMS_Root"]).Width = Form_Main_panel.Width;
            //((Form_StudentMS_root)Form_Main_panel.Controls["form_StudentMS_Root"]).Height = Form_Main_panel.Height;

        }

        private void AmendPwd_TSMI_Click(object sender, EventArgs e)
        {
            Form_alterPwd form_AlterPwd = new Form_alterPwd();
            form_AlterPwd.ShowDialog();
        }

        private void SoftwareInfo_TSMI_Click(object sender, EventArgs e)
        {
            Form_SoftwareInfo form_SoftwareInfo = new Form_SoftwareInfo();
            form_SoftwareInfo.ShowDialog();
        }

        private void TeacherM_MS_Click(object sender, EventArgs e)
        {
            if (Status.Form_RootCreateStatus)
            {
                MessageBox.Show("窗体已经存在，请勿重复创建！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            Form_TeacherMS_root form_TeacherMS_Root = new Form_TeacherMS_root
            {
                TopLevel = false,
                Dock = DockStyle.Fill,
                Parent = this.Form_Main_panel
            };
            form_TeacherMS_Root.Show();
            Status.Form_RootCreateStatus = true;

        }

        private void Log_TSMI_Click(object sender, EventArgs e)
        {
            Form_Log form_Log = new Form_Log();
            form_Log.ShowDialog();
        }
    }
}
