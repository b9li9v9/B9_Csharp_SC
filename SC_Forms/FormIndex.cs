using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SC_Forms
{
    public partial class FormIndex : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;

        public FormIndex()
        {
            InitializeComponent();
        }



        /// 关闭按钮
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnUserSetting_Click(object sender, EventArgs e)
        {
            Form testDbView = new TestDbView();
            testDbView.FormClosing += (object sender, FormClosingEventArgs e) =>
            {
                testDbView.Dispose();
            };
            testDbView.Show();
        }
    }
}
