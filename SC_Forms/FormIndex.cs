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


        // 本节点读取
        private void menuSelectSelfNode_Click(object sender, EventArgs e)
        {
            FormsManager.UseDisposableForm("LoadSelfNode", new FormIndexManagerSettingSelfNode());
        }



        // 根节点管理
        private void menuNodeManager_Click(object sender, EventArgs e)
        {
            FormsManager.UseDisposableForm("LoadSelfNode", new FormIndexManagerSettingRootNote()); 
        }
    }
}
