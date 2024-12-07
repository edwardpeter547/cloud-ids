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
        int unpackingProgress = 0;
        CloudServerModel? server = null;
        public Dashboard()
        {
            InitializeComponent();
            ConnectionStatus = Status.DISCONNECTED;
            GetCloudServers();
            show_connection_status(ConnectionStatus);

            tmlog.Interval = 500;
            tmmonitor.Interval = 300;
        }

        private void GetCloudServers()
        {
            var ServerList = DataAccessLayer.GetCloudServers();
            cbIpAddress.DataSource = ServerList;
            cbIpAddress.DisplayMember = "ServerName";
            cbIpAddress.ValueMember = "IpAddress";
            cbIpAddress.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbIpAddress.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnconnect_Click(object sender, EventArgs e)
        {
            string ipaddress = (string?)cbIpAddress.SelectedValue;

            if (string.IsNullOrEmpty(ipaddress))
            {
                Library.write_message("Please Provide Enter IP Address", "Invalid IP Address", MessageStatus.ERROR);
                cbIpAddress.Focus();
                return;
            }

            if (ConnectionStatus == Status.DISCONNECTED)
            {
                server = DataAccessLayer.GetServer(ipaddress);
                if (server != null)
                {
                    rtblogs.Clear();
                    tmlog.Start();
                    ConnectionStatus = Status.CONNECTED;
                    btnconnect.Tag = Status.DISCONNECT;
                    btnconnect.Text = btnconnect.Tag.ToString();
                }
            }
            else
            {
                ConnectionStatus = Status.DISCONNECTED;
                btnconnect.Tag = Status.CONNECT;
                btnconnect.Text = btnconnect.Tag.ToString();
                cbIpAddress.SelectedIndex = -1;
                rtblogs.Clear();
            }
            show_connection_status(ConnectionStatus);

        }

        private void show_connection_status(String connectionStatus)
        {
            if (connectionStatus == Status.CONNECTED)
            {
                txtconnectionstatus.ForeColor = Color.LimeGreen;
                cbIpAddress.Enabled = false;
            }
            else
            {
                txtconnectionstatus.ForeColor = Color.Red;
                cbIpAddress.Enabled = true;
            }

            txtconnectionstatus.Text = connectionStatus;

        }

        private void btnaddcloud_Click(object sender, EventArgs e)
        {
            var cloud = new newcloud();
            cloud.ShowDialog();
            GetCloudServers();
        }

        private void btnupload_Click(object sender, EventArgs e)
        {
            UploadFile upload = new UploadFile();
            upload.ShowDialog();
        }

        private void tmlog_Tick(object sender, EventArgs e)
        {
            var fakeLogData = new List<string>
            {
                $"connected to server {server.ServerName}@{server.IpAddress}",
                "updating IDS Ruleset...",
                "creating backup on mirrow server...",
                "configuring iptables on storage server..",
                "scanning cloud files 0 0f 100",
                "listing files"
            };

            if (unpackingProgress < fakeLogData.Count)
            {
                // Simulate random log data
                string logMessage = fakeLogData[unpackingProgress];

                // Append the new log message to the RichTextBox
                rtblogs.AppendText(logMessage + Environment.NewLine);
                rtblogs.ScrollToCaret(); // Scroll to the latest message

                // Increment the unpacking progress
                unpackingProgress++;
            }
            else
            {
                // Stop the timer when all logs have been displayed
                tmlog.Stop();
                rtblogs.AppendText("Done!" + Environment.NewLine);
                rtblogs.ScrollToCaret();
                unpackingProgress = 0;
            }
        }

        private void btnmonitor_Click(object sender, EventArgs e)
        {
            if (ConnectionStatus == Status.CONNECTED)
            {
                rtblogs.Clear();
                tmmonitor.Start();
            }
        }

        private void tmmonitor_Tick(object sender, EventArgs e)
        {
            string idslog = IntrusionDetectionProfiler.GenerateRandomIDSLog();
            rtblogs.AppendText(idslog + Environment.NewLine);
            rtblogs.ScrollToCaret(); // Scroll to the latest message
        }
    }
}
