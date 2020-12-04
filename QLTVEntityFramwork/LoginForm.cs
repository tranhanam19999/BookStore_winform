using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTVEntityFramwork.Model;
namespace QLTVEntityFramwork
{
    public partial class LoginForm : Form
    {
        private QLThuVienEntities db = new QLThuVienEntities();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = db.Authenticate_User.Where(x => x.USERNAME == txtUsername.Text.ToString() && x.MATKHAU == txtPassword.Text.ToString()).ToList().FirstOrDefault();
            if (txtUsername.Text.ToString() != "" && txtPassword.Text.ToString() != "")
            {
                if (user != null)
                {
                    this.Hide();
                    FormControl formUser = new FormControl();
                    formUser.Closed += (s, args) => this.Close();
                    formUser.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No user found!");
                }
            }
            else
            {
                MessageBox.Show("Please provide username and password!");
            }
        }
    }
}
