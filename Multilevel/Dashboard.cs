using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multilevel
{

    public partial class Dashboard : Form
    {
        public string ConnectionStatus { get; set; }

        public Dashboard()
        {
            InitializeComponent();
            var data = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            lbltest.Text = data.ToString();
            ConnectionStatus = Status.DISCONNECTED;
            show_connection_status(ConnectionStatus);
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnconnect_Click(object sender, EventArgs e)
        {
            if (ConnectionStatus == Status.DISCONNECTED)
            {
                var ipaddress = txtipaddress.Text;
                var server = DataAccessLayer.GetServer(ipaddress);
                if (server != null)
                {
                    ConnectionStatus = Status.CONNECTED;
                    btnconnect.Tag = Status.DISCONNECT;
                    btnconnect.Text = btnconnect.Tag.ToString();
                    update_connection_log(server);
                }
            }
            else
            {
                ConnectionStatus = Status.DISCONNECTED;
                btnconnect.Tag = Status.CONNECT;
                btnconnect.Text = btnconnect.Tag.ToString();
                txtipaddress.Clear();
                lblogs.Items.Clear();
            }
            show_connection_status(ConnectionStatus);

        }

        private void show_connection_status(String connectionStatus)
        {
            if (connectionStatus == Status.CONNECTED)
            {
                txtconnectionstatus.ForeColor = Color.LimeGreen;
                txtipaddress.ReadOnly = true;
            }
            else
            {
                txtconnectionstatus.ForeColor = Color.Red;
                txtipaddress.ReadOnly = false;
            }

            txtconnectionstatus.Text = connectionStatus;

        }

        private void update_connection_log(CloudServerModel server)
        {
            txtconnectionstatus.Text = txtconnectionstatus.Tag.ToString();
            txtconnectionstatus.ForeColor = Color.ForestGreen;
            lblogs.Items.Add($"connecting to {server.ServerName} cloud server...");
            lblogs.Items.Add("============================");
            lblogs.Items.Add($"Server Address:\t {server.ServerName}@{server.IpAddress}:{server.Port}");
            lblogs.Items.Add($"Cloud User:\t {server.ServerName}");
            lblogs.Items.Add("============================");
            lblogs.Items.Add("Connected!");
            lblogs.Items.Add("\n");
            lblogs.Items.Add("Listing cloud files...");
            lblogs.Items.Add("Done!");
        }

        private void btnaddcloud_Click(object sender, EventArgs e)
        {
            var cloud = new newcloud();
            cloud.ShowDialog();
        }
    }
}
