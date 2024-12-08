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
        CloudServerModel? server;
        bool HasBeenConnected = false;
        List<FileModel> files;
        public Dashboard()
        {
            InitializeComponent();
            ConnectionStatus = Status.DISCONNECTED;
            GetCloudServers();
            show_connection_status(ConnectionStatus);
            this.server = null;
            tmlog.Interval = 200;
            tmmonitor.Interval = 300;
            SetupDataGrid();
        }

        private void SetupDataGrid()
        {
            dgfiles.ColumnCount = 1;
            dgfiles.Columns[0].Name = "Filename";
            dgfiles.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void GetServerFiles()
        {
            files = DataAccessLayer.GetFiles();
            
            foreach (var record in files)
            {
                string[] row = new string[] {record.FileName};
                dgfiles.Rows.Add(row);
            }
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
                Library.write_message("Please select a server to connect to", "Select Server", MessageStatus.ERROR);
                cbIpAddress.Focus();
                return;
            }

            if (ConnectionStatus == Status.DISCONNECTED)
            {
                this.server = DataAccessLayer.GetServer(ipaddress);
                if (this.server != null)
                {
                    ConnectionStatus = Status.CONNECTED;
                    rtblogs.Clear();
                    tmlog.Start();
                    show_connection_status(ConnectionStatus);
                }
            }


        }

        private void show_connection_status(String connectionStatus)
        {
            if (connectionStatus == Status.CONNECTED)
            {
                txtconnectionstatus.ForeColor = Color.LimeGreen;
                cbIpAddress.Enabled = false;
                btnconnect.Enabled = false;
                btndisconnect.Enabled = true;
                btnupload.Enabled = true;
                dgfiles.Rows.Clear();
                GetServerFiles();
            }
            else
            {
                txtconnectionstatus.ForeColor = Color.Red;
                cbIpAddress.Enabled = true;
                btnconnect.Enabled = true;
                btndisconnect.Enabled = false;
                cbIpAddress.SelectedIndex = -1;
                btnmonitor.Enabled = true;
                btnupload.Enabled = false;
                tmmonitor.Stop();
                dgfiles.Rows.Clear();
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
            UploadFile upload = new UploadFile(server: this.server);
            upload.FileUploaded += Upload_FileUploaded;
            upload.ShowDialog();
        }

        private void Upload_FileUploaded(object sender, EventArgs e)
        {
            dgfiles.Rows.Clear();
            GetServerFiles();
        }

        private void tmlog_Tick(object sender, EventArgs e)
        {
            var fakeLogData = new List<string>
            {
                $"connected to server {this.server.ServerName}@{this.server.IpAddress}",
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
                btnmonitor.Enabled = false;
                HasBeenConnected = true;
            }
        }

        private void tmmonitor_Tick(object sender, EventArgs e)
        {
            string idslog = IntrusionDetectionProfiler.GenerateRandomIDSLog();
            rtblogs.AppendText(idslog + Environment.NewLine);
            rtblogs.ScrollToCaret(); // Scroll to the latest message
        }

        private void btndisconnect_Click(object sender, EventArgs e)
        {

            ConnectionStatus = Status.DISCONNECTED;
            show_connection_status(ConnectionStatus);
        }

        private void btnviewlogs_Click(object sender, EventArgs e)
        {

            ViewLogs logs = new ViewLogs(HasBeenConnected);
            logs.ShowDialog();
        }
    }
}
