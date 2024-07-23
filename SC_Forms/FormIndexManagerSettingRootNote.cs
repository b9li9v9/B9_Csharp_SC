using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
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
    public partial class FormIndexManagerSettingRootNote : Form
    {
        private List<OrgUnit> OrgUnitsTable;
        private SC_DbContext SC_DB;
        public FormIndexManagerSettingRootNote()
        {
            InitializeComponent();
            //dataGridView1.Columns[0].ReadOnly = true;
            //dataGridView1.Columns[1].ReadOnly = false;
            //dataGridView1.Columns[2].ReadOnly = false;
            //dataGridView1.Columns[3].ReadOnly = false;
            //dataGridView1.Columns[4].ReadOnly = true;
        }

        //private void FormIndexManagerSettingLoadSelfRootNote_Load(object sender, EventArgs e)
        //{
        //    this.dataGridView1.DataSource = OrgUnitsTable;
        //}

        private List<OrgUnit> GetTable()
        {
            return SC_DB.OrgUnits.Where(o => o.OwnerId == FormsManager.UserId && o.ParentGuid == null).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SC_DB == null) return;
            // 事务
            using (var transaction = SC_DB.Database.BeginTransaction())
            {
                try
                {
                    foreach (var orgUnit in OrgUnitsTable)
                    {
                        var entry = SC_DB.Entry(orgUnit);

                        if (entry.State == EntityState.Modified)
                        {
                            // 一个账户同时登录 同时打开修改框 那么这个地方就会有BUG
                            // 处理修改状态的实体对象                     
                            MessageBox.Show($"OrgUnit {orgUnit.OwnerId} is modified.");
                        }
                        else if (entry.State == EntityState.Added)
                        {
                            // 处理新增状态的实体对象
                            MessageBox.Show($"OrgUnit {orgUnit.Guid} is added.");
                        }
                        else if (entry.State == EntityState.Deleted)
                        {
                            // 处理删除状态的实体对象
                            MessageBox.Show($"OrgUnit {orgUnit.Guid} is deleted.");
                        }
                        else
                        {
                            // 处理未更改状态的实体对象
                            MessageBox.Show($"OrgUnit {orgUnit.Guid} is unchanged.");
                        }
                    }
                    SC_DB.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    // 如果出现异常，则回滚事务
                    transaction.Rollback();
                    MessageBox.Show($"提交失败 事务回滚：{ex.Message}");
                }
            }
            button3_Click(null,null);
        }

        // 删除
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // 获取选中行的索引
                var selectedIndex = dataGridView1.SelectedRows[0].Selected.ToString();

                // 删除选中行
                MessageBox.Show($"删除：{selectedIndex}"); ;
            }
        }

        // 查询
        private void button3_Click(object sender, EventArgs e)
        {
            if(SC_DB!=null) SC_DB.Dispose();
            SC_DB = new SC_DbContext();
            OrgUnitsTable = GetTable();
            this.dataGridView1.DataSource = OrgUnitsTable;
            this.dataGridView1.DataError += dataGridView1_DataError;
        }

        // 注册
        private void btnRegistered_Click(object sender, EventArgs e)
        {
            FormsManager.UseDisposableForm("RegisteredRootNode", new FormIndexManagerSettingRegisteredRootNode());
        }


        // dataerror
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // 取消默认的错误处理
            e.Cancel = true;

            // 获取出错的单元格信息
            DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

            // 自定义错误处理逻辑示例
            MessageBox.Show($"在行 {e.RowIndex + 1}，列 {cell.ColumnIndex + 1} 处发生数据错误：{e.Exception.Message}",
                            "数据错误",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

            // 可以根据需要执行其他的错误处理逻辑，例如记录日志
            // Logger.Log($"数据错误：{e.Exception.Message}");
        }

    }
}
