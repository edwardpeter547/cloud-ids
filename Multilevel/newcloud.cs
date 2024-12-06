using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multilevel
{
    public partial class newcloud : Form
    {
        public newcloud()
        {
            InitializeComponent();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            Library.reset_fields(this);
            txtip.Focus();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string ipaddress = txtip.Text.ToString();
            int port_number = int.Parse(txtport.Text.ToString());

            if(!Library.validate_ipaddress(ipaddress))
            {
                Library.write_message("Invalid IpAddress", "Invalid IP", MessageStatus.ERROR);
                txtip.Clear();
                txtip.Focus();
                return;
            }

            if (!Library.IsValidPort(port_number))
            {
                Library.write_message("Invalid Port number", "Invalid Port", MessageStatus.ERROR);
                txtport.Clear();
                txtport.Focus();
            }

            CloudServerModel server = new CloudServerModel();
            server.ServerName = txtservername.Text;
            server.IpAddress = ipaddress;
            server.Port = port_number;
            server.Secret = Library.encrypt_password(txtserversecret.Text);

            DataAccessLayer.AddServer(server);
            Library.write_message("Cloud Server Added!", "Server Added", MessageStatus.SUCCESS);
            btnreset.PerformClick();
            this.Close();
        }
    }
}
