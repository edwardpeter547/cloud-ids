namespace Multilevel
{
    partial class UploadFile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            openFileDialog1 = new OpenFileDialog();
            btnbrowsefile = new Button();
            txtfilename = new TextBox();
            rtbfilecontent = new RichTextBox();
            label3 = new Label();
            btndecrypt = new Button();
            btnencrypt = new Button();
            btnupload = new Button();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnbrowsefile
            // 
            btnbrowsefile.Location = new Point(636, 32);
            btnbrowsefile.Name = "btnbrowsefile";
            btnbrowsefile.Size = new Size(150, 46);
            btnbrowsefile.TabIndex = 0;
            btnbrowsefile.Text = "Browse File";
            btnbrowsefile.UseVisualStyleBackColor = true;
            btnbrowsefile.Click += btnbrowsefile_Click;
            // 
            // txtfilename
            // 
            txtfilename.Font = new Font("Segoe UI", 10F);
            txtfilename.Location = new Point(22, 35);
            txtfilename.Name = "txtfilename";
            txtfilename.PlaceholderText = "Browse File";
            txtfilename.Size = new Size(608, 43);
            txtfilename.TabIndex = 10;
            // 
            // rtbfilecontent
            // 
            rtbfilecontent.Location = new Point(12, 152);
            rtbfilecontent.Name = "rtbfilecontent";
            rtbfilecontent.ReadOnly = true;
            rtbfilecontent.Size = new Size(1252, 524);
            rtbfilecontent.TabIndex = 11;
            rtbfilecontent.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Noto Sans", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(12, 103);
            label3.Name = "label3";
            label3.Size = new Size(178, 37);
            label3.TabIndex = 12;
            label3.Text = "File preview";
            // 
            // btndecrypt
            // 
            btndecrypt.Location = new Point(311, 696);
            btndecrypt.Name = "btndecrypt";
            btndecrypt.Size = new Size(293, 46);
            btndecrypt.TabIndex = 13;
            btndecrypt.Text = "Decrypt File";
            btndecrypt.UseVisualStyleBackColor = true;
            btndecrypt.Click += btndecrypt_Click;
            // 
            // btnencrypt
            // 
            btnencrypt.Location = new Point(12, 696);
            btnencrypt.Name = "btnencrypt";
            btnencrypt.Size = new Size(293, 46);
            btnencrypt.TabIndex = 14;
            btnencrypt.Text = "Encrypt File";
            btnencrypt.UseVisualStyleBackColor = true;
            btnencrypt.Click += btnencrypt_Click;
            // 
            // btnupload
            // 
            btnupload.Location = new Point(971, 696);
            btnupload.Name = "btnupload";
            btnupload.Size = new Size(293, 46);
            btnupload.TabIndex = 15;
            btnupload.Text = "Upload File";
            btnupload.UseVisualStyleBackColor = true;
            btnupload.Click += btnupload_Click;
            // 
            // UploadFile
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1276, 764);
            Controls.Add(btnupload);
            Controls.Add(btnencrypt);
            Controls.Add(btndecrypt);
            Controls.Add(label3);
            Controls.Add(rtbfilecontent);
            Controls.Add(txtfilename);
            Controls.Add(btnbrowsefile);
            Name = "UploadFile";
            Text = "Upload File to Cloud";
            FormClosed += UploadFile_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Button btnbrowsefile;
        private TextBox txtfilename;
        private RichTextBox rtbfilecontent;
        private Label label3;
        private Button btndecrypt;
        private Button btnencrypt;
        private Button btnupload;
    }
}