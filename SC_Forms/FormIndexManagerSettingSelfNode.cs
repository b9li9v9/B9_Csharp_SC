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
    public partial class FormIndexManagerSettingSelfNode : Form
    {
        public FormIndexManagerSettingSelfNode()
        {
            InitializeComponent();
        }

        private void FormIndexManagerSettingLoadSelfNote_Load(object sender, EventArgs e)
        {
                dataGridView1.DataSource = GetSqlData();
        }

        private List<OrgUnit> GetSqlData()
        {
            List<OrgUnit> note;
            using (SC_DbContext SC_DB = new SC_DbContext())
            {
                note = SC_DB.OrgUnits.Where(o => o.OwnerId == FormsManager.UserId && o.ParentGuid != null).ToList();
            }
            return note;
        }
    }

}
