using SC_DbConfig;

namespace SC_Forms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }


        private void btnRegistered_Click_1(object sender, EventArgs e)
        {
            FormsManager.ShowSingleForm("Registered");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (this.tbAcct.Text == "" || this.tbPwd.Text == "")
            {
                MessageBox.Show("�˺š����� ����Ϊ��");
                return;
            }

            using (SC_DbContext SC_Db = new SC_DbContext())
            {
                var existingUser = SC_Db.Users.FirstOrDefault(u => u.Acct == this.tbAcct.Text && u.pwd == this.tbPwd.Text);
                if (existingUser != null) 
                {
                    FormsManager.UserId = existingUser.UserId;
                    FormsManager.ShowSingleForm("Index");
                }
                else
                {
                    MessageBox.Show("�˺Ų����ڻ��������");
                    return;
                }
            }
        }
    }
}
