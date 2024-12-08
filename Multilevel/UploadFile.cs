using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multilevel
{
    public partial class UploadFile : Form
    {

        // Define a delegate and event for when file upload is completed.
        public delegate void FileUploadedEventHandler(object sender, EventArgs e);
        public event FileUploadedEventHandler FileUploaded;

        OpenFileDialog ofd = null;
        FileData filedata = null;
        CloudServerModel server;
        private readonly string encryptionKey = "1234567890123456";  // 16-byte key (128-bit)
        private readonly string encryptionIV = "abcdef9876543210";  // 16-byte IV
        public UploadFile(CloudServerModel server)
        {
            InitializeComponent();
            btndecrypt.Enabled = false;
            btnupload.Enabled = false;
            this.server = server;
            this.Text = $"Upload File to Cloud: {this.server.ServerName}";
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
            try
            {
                string encryptedText = rtbfilecontent.Text;
                string decryptedText = DecryptText(encryptedText);
                rtbfilecontent.Text = decryptedText;
                btnencrypt.Enabled = true;
                btnupload.Enabled = false;
                btndecrypt.Enabled = false;
            }
            catch (FormatException)
            {
                Library.write_message("Invalid encrypted text", "Decryption Error", MessageStatus.ERROR);
            }
        }

        private void btnencrypt_Click(object sender, EventArgs e)
        {
            string plainText = rtbfilecontent.Text;
            string encryptedText = EncryptText(plainText);
            rtbfilecontent.Text = encryptedText;
            btnupload.Enabled = true;
            btndecrypt.Enabled = true;
            btnencrypt.Enabled = false;
        }

        private string EncryptText(string plainText)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(encryptionKey);
                aesAlg.IV = Encoding.UTF8.GetBytes(encryptionIV);

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    using (StreamWriter sw = new StreamWriter(cs))
                    {
                        sw.Write(plainText);
                    }

                    return Convert.ToBase64String(ms.ToArray());
                }
            }
        }

        private string DecryptText(string cipherText)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(encryptionKey);
                aesAlg.IV = Encoding.UTF8.GetBytes(encryptionIV);

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(cipherText)))
                using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                using (StreamReader sr = new StreamReader(cs))
                {
                    return sr.ReadToEnd();
                }
            }
        }

        private void btnupload_Click(object sender, EventArgs e)
        {
            SaveFile save = new SaveFile(filename: txtfilename.Text, filecontent: rtbfilecontent.Text, server: this.server);
            save.DataUpdated += FileSavedHandler;
            save.ShowDialog();
        }

        private void FileSavedHandler(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UploadFile_FormClosed(object sender, FormClosedEventArgs e)
        {
            FileUploaded?.Invoke(this, EventArgs.Empty);
        }
    }
}
