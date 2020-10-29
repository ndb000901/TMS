using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMS_Model.Model;

namespace TMS_UI
{

    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form_Login form_Login = new Form_Login();
            DialogResult dialogResult = form_Login.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                Application.Run(new Form_Main_root());
            }
            else
            {
                Application.Exit();
            }
        }
        #region--全局变量--
        public static Root Current_root = new Root();
        public static User Current_user = new User();
        #endregion
    }
}
