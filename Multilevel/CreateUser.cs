using MD5Hash;

namespace Multilevel
{
    public partial class CreateUser : Form
    {
        public CreateUser()
        {
            InitializeComponent();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            Library.reset_fields(this);
            txtcloudid.Focus();
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            var password_field = txtpassword.Text;
            var confirm_password = txtconfirmpassword.Text;
            var email_address = txtemail.Text;
            if (Library.validate_compulsory_fields(Library.get_text_fields(this)))
            {
                if (!(Library.validate_email_address(email_address)))
                {
                    Library.write_message($"{email_address} is not a valid email address.", "Invalid Email Address","ERROR");
                    return;
                }
            }
            else
            {
                return;
            }

            if (!Library.is_matching(password_field,confirm_password))
            {
                Library.write_message("Passwords do not match!", "Password Mismatch", "ERROR");
                txtconfirmpassword.Clear();
                txtconfirmpassword.Focus();
                return;
            }
            UserModel user = new UserModel();
            user.Firstname = txtfirstname.Text;
            user.Lastname = txtlastname.Text;
            user.Email = txtemail.Text;
            user.Username = txtcloudid.Text;
            user.Passwd = Library.encrypt_password(txtpassword.Text);
            DataAccessLayer.CreateUser(user);
            string message = $"Cloud Account Created for: {user.DisplayName} click Ok to proceed to login";
            string title = "Account Creation Success";
            Library.write_message(message, title, "SUCCESS");
            Library.reset_fields(this);
            var login = new Login();
            login.Show();
            this.Hide();


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var login = new Login();
            login.Show();
            this.Hide();
        }

        private void CreateUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
