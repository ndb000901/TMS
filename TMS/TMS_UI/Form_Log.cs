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
    public partial class Form_Log : Form
    {
        public Form_Log()
        {
            InitializeComponent();
        }

        private void DGV_Log_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            ///添加行号
            Rectangle rect = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y,
               DGV_Log.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
                DGV_Log.RowHeadersDefaultCellStyle.Font, rect,
                DGV_Log.RowHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Right);

        }

        private void Form_Log_Load(object sender, EventArgs e)
        {
            Log.DGV_LogLoad(DGV_Log);
        }
    }
}
