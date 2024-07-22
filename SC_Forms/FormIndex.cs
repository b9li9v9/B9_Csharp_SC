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

        // 用户信息测试
        private void btnUserSetting_Click(object sender, EventArgs e)
        {
            FormsManager.UseDisposableForm("testDbView", new TestDbView());
        }

        // 顶框拖拽
        private void toolStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        // 本节点读取
        private void menuSelectSelfNode_Click(object sender, EventArgs e)
        {
            FormsManager.UseDisposableForm("LoadSelfNode", new FormIndexManagerSettingLoadSelfNote());
        }

        // 根节点注册
        private void 注册根节点ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormsManager.UseDisposableForm("RegiRootNode", new FormIndexManagerSettingRegisteredRootNode());

        }

        // 根节点查询
        private void 查询根节点ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormsManager.UseDisposableForm("LoadSelfRootNote", new FormIndexManagerSettingLoadSelfRootNote());
        }
    }
}
