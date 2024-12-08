using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Multilevel
{
    public partial class SaveFile : Form
    {

        // Define a delegate and event
        public delegate void DataUpdatedEventHandler(object sender, EventArgs e);
        public event DataUpdatedEventHandler DataUpdated;

        string filename;
        string filecontent;
        private int progress = 0;
        CloudServerModel server;
        public SaveFile(string filename, string filecontent, CloudServerModel server)
        {
            InitializeComponent();
            this.filename = filename;
            this.server = server;
            this.filecontent = filecontent;
            tmupload.Interval = 100;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void SaveFile_Load(object sender, EventArgs e)
        {
            txtfilename.Text = this.filename;
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            Library.reset_fields(this, ignore_field: txtfilename.Name.ToString());
            txtfilename.Focus();
        }

        private void tmupload_Tick(object sender, EventArgs e)
        {
            // Increment progress by 1
            progress += 1;

            // Update ProgressBar value
            pbuploading.Value = progress;

            int percentage = (progress * 100) / pbuploading.Maximum;
            lblpercent.Text = $"uploading... {percentage}%";

            // If progress reaches 100%, stop the timer
            if (progress >= 100)
            {
                tmupload.Stop(); // Stop the timer when progress reaches 100%
                lblpercent.Text = $"Upload Completed! {percentage}%";
            }
        }

        private void btnupload_Click(object sender, EventArgs e)
        {

            if (Library.validate_compulsory_fields(Library.get_text_fields(this)))
            {
                if (!Library.is_matching(txtpassword.Text, txtconfirmpassword.Text))
                {
                    Library.write_message("Both Password must match", "Password Mismatch", MessageStatus.ERROR);
                    txtconfirmpassword.Clear();
                    txtconfirmpassword.Focus();
                    return;
                }

                FileModel model = new FileModel();
                model.FileName = txtfilename.Text.Trim();
                model.Owner = txtowner.Text.Trim();
                model.Secret = txtpassword.Text.Trim();
                model.Description = txtdescription.Text.Trim();
                model.FileContent = this.filecontent;
                model.Server = this.server.Id.ToString();

                DataAccessLayer.AddFile(model);
                progress = 0;
                pbuploading.Visible = true;
                lblpercent.Visible = true;
                pbuploading.Value = progress;
                lblpercent.Text = "0%";

                // Start the timer
                tmupload.Start();
            }




        }

        private void SaveFile_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataUpdated?.Invoke(this, EventArgs.Empty);
        }
    }
}
