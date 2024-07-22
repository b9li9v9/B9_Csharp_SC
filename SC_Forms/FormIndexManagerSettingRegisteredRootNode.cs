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
    public partial class FormIndexManagerSettingRegisteredRootNode : Form
    {
        public FormIndexManagerSettingRegisteredRootNode()
        {
            InitializeComponent();
        }

        private void btnRegistered_Click(object sender, EventArgs e)
        {
            using (SC_DbContext SC_DB = new SC_DbContext())
            {
                var note = SC_DB.OrgUnits.FirstOrDefault(o => o.OrgName == this.txOrgName.Text);
                if (note != null)
                {
                    MessageBox.Show("注册失败 已存在同名节点");
                    return;
                }

            }


            using (SC_DbContext SC_DB = new SC_DbContext())
            {
                OrgUnit orgunit = new OrgUnit();
                Guid giud = new Guid();
                orgunit.Guid = giud;
                orgunit.EmpName = this.txEmpName.Text;
                orgunit.OrgName = this.txOrgName.Text;
                orgunit.OwnerId = FormsManager.UserId;
                orgunit.AV = true;
                SC_DB.OrgUnits.Add(orgunit);
                SC_DB.SaveChanges();
            }
            MessageBox.Show("根节点创建成功 请通过<查阅本节点>获取GUID");
        }
    }
}
