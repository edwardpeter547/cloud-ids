using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multilevel
{
    public partial class UploadFile : Form
    {
        OpenFileDialog ofd = null;
        FileData filedata = null;
        public UploadFile()
        {
            InitializeComponent();
        }

        private void btnbrowsefile_Click(object sender, EventArgs e)
        {
             ofd = new OpenFileDialog
            {
                Title = "Select File to Upload",
                Filter = "Text Files (*.txt)|*.txt|Rich Text Files (*.rtf)|*.rtf|All Files (*.*)|*.*",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string sourceFilePath = ofd.FileName; // Selected file path
                string extension = Path.GetExtension(sourceFilePath)?.ToLower();
                filedata = new FileData();
                filedata.FileName = sourceFilePath;
                filedata.Extension = extension;
                txtfilename.Text = filedata.FileName;

                try
                {
                    // Check file extension
                    

                    if (filedata.Extension == ".rtf")
                    {
                        // Load RTF file
                        rtbfilecontent.LoadFile(filedata.FileName, RichTextBoxStreamType.RichText);
                    }
                    else
                    {
                        // Load plain text file
                        string content = File.ReadAllText(filedata.FileName);
                        rtbfilecontent.Text = content;
                    }
                }
                catch (Exception ex)
                {
                    Library.write_message($"An error occurred: {ex.Message}", "Invalid File", MessageStatus.ERROR);
                }
            }


        }

        private void btndecrypt_Click(object sender, EventArgs e)
        {
            if(filedata != null)
            {
                Library.write_message(filedata.FileName, "file", MessageStatus.SUCCESS);
            }
        }
    }
}
