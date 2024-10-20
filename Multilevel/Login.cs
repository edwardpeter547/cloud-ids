using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multilevel
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void linkcreateaccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var create_user = new CreateUser();
            create_user.Show();
            this.Hide();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            Library.reset_text_fields(this);
            txtcloudid.Focus();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (Library.validate_compulsory_fields(Library.get_text_fields(this)))
            {
                string cloud_id = txtcloudid.Text;
                string password = Library.encrypt_password(txtpassword.Text);

                var user = DataAccessLayer.GetUser(cloud_id, password);
                if ((user != null) && (user is UserModel))
                {
                    var dashboard = new Dashboard();
                    dashboard.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Invalid username or password", "Authentication Failure", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    Library.reset_fields(this);
                    txtcloudid.Focus();
                    return;
                }
            }
        }
    }
}
