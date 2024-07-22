using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using SC_DbConfig;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SC_Forms
{
    public partial class TestDbView : Form
    {
        private SC_DbContext SC_Db = new SC_DbContext();

        public TestDbView()
        {
            InitializeComponent();

        }
        private void LoadSqlserver()
        {
            // 从数据库加载数据
            var data = SC_Db.Users.Where(u => u.UserId == FormsManager.UserId).ToList(); // 或者其他查询方式
            dataGridView1.DataSource = data;
            //SC_Db.close
        }
        private void TestDbView_Load(object sender, EventArgs e)
        {
            LoadSqlserver();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //.SaveChanges();
            MessageBox.Show("Changes saved successfully!");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
