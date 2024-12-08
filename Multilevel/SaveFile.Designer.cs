namespace Multilevel
{
    partial class SaveFile
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
            components = new System.ComponentModel.Container();
            label3 = new Label();
            txtfilename = new TextBox();
            label1 = new Label();
            txtowner = new TextBox();
            label2 = new Label();
            txtdescription = new TextBox();
            label4 = new Label();
            txtpassword = new TextBox();
            label5 = new Label();
            txtconfirmpassword = new TextBox();
            btnupload = new Button();
            btnreset = new Button();
            pbuploading = new ProgressBar();
            tmupload = new System.Windows.Forms.Timer(components);
            lblpercent = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 31);
            label3.Name = "label3";
            label3.Size = new Size(125, 31);
            label3.TabIndex = 21;
            label3.Text = "Filename";
            // 
            // txtfilename
            // 
            txtfilename.Font = new Font("Segoe UI", 12F);
            txtfilename.Location = new Point(12, 74);
            txtfilename.Name = "txtfilename";
            txtfilename.Size = new Size(425, 50);
            txtfilename.TabIndex = 0;
            txtfilename.Tag = "Filename";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(466, 31);
            label1.Name = "label1";
            label1.Size = new Size(94, 31);
            label1.TabIndex = 23;
            label1.Text = "Owner";
            // 
            // txtowner
            // 
            txtowner.Font = new Font("Segoe UI", 12F);
            txtowner.Location = new Point(466, 74);
            txtowner.Name = "txtowner";
            txtowner.Size = new Size(452, 50);
            txtowner.TabIndex = 1;
            txtowner.Tag = "Owner";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 259);
            label2.Name = "label2";
            label2.Size = new Size(202, 31);
            label2.TabIndex = 25;
            label2.Text = "File Description";
            // 
            // txtdescription
            // 
            txtdescription.Font = new Font("Segoe UI", 12F);
            txtdescription.Location = new Point(12, 302);
            txtdescription.Multiline = true;
            txtdescription.Name = "txtdescription";
            txtdescription.Size = new Size(906, 212);
            txtdescription.TabIndex = 4;
            txtdescription.Tag = "File Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 138);
            label4.Name = "label4";
            label4.Size = new Size(272, 31);
            label4.TabIndex = 27;
            label4.Text = "Decryption Password";
            // 
            // txtpassword
            // 
            txtpassword.Font = new Font("Segoe UI", 12F);
            txtpassword.Location = new Point(12, 181);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(425, 50);
            txtpassword.TabIndex = 2;
            txtpassword.Tag = "Encryption Password";
            txtpassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(466, 138);
            label5.Name = "label5";
            label5.Size = new Size(374, 31);
            label5.TabIndex = 29;
            label5.Text = "Confirm Decryption Password";
            label5.Click += label5_Click;
            // 
            // txtconfirmpassword
            // 
            txtconfirmpassword.Font = new Font("Segoe UI", 12F);
            txtconfirmpassword.Location = new Point(466, 181);
            txtconfirmpassword.Name = "txtconfirmpassword";
            txtconfirmpassword.Size = new Size(452, 50);
            txtconfirmpassword.TabIndex = 3;
            txtconfirmpassword.Tag = "Confirm Encryption Password";
            txtconfirmpassword.UseSystemPasswordChar = true;
            // 
            // btnupload
            // 
            btnupload.BackColor = SystemColors.ButtonFace;
            btnupload.Location = new Point(578, 597);
            btnupload.Name = "btnupload";
            btnupload.Size = new Size(340, 61);
            btnupload.TabIndex = 5;
            btnupload.Text = "Upload";
            btnupload.UseVisualStyleBackColor = false;
            btnupload.Click += btnupload_Click;
            // 
            // btnreset
            // 
            btnreset.BackColor = SystemColors.ButtonFace;
            btnreset.Location = new Point(578, 530);
            btnreset.Name = "btnreset";
            btnreset.Size = new Size(340, 61);
            btnreset.TabIndex = 6;
            btnreset.Text = "Reset";
            btnreset.UseVisualStyleBackColor = false;
            btnreset.Click += btnreset_Click;
            // 
            // pbuploading
            // 
            pbuploading.Location = new Point(13, 534);
            pbuploading.Name = "pbuploading";
            pbuploading.Size = new Size(547, 28);
            pbuploading.TabIndex = 32;
            pbuploading.Visible = false;
            // 
            // tmupload
            // 
            tmupload.Tick += tmupload_Tick;
            // 
            // lblpercent
            // 
            lblpercent.AutoSize = true;
            lblpercent.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblpercent.ForeColor = Color.ForestGreen;
            lblpercent.Location = new Point(13, 565);
            lblpercent.Name = "lblpercent";
            lblpercent.Size = new Size(55, 31);
            lblpercent.TabIndex = 33;
            lblpercent.Text = "0%";
            lblpercent.Visible = false;
            // 
            // SaveFile
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 685);
            Controls.Add(lblpercent);
            Controls.Add(pbuploading);
            Controls.Add(btnreset);
            Controls.Add(btnupload);
            Controls.Add(label5);
            Controls.Add(txtconfirmpassword);
            Controls.Add(label4);
            Controls.Add(txtpassword);
            Controls.Add(label2);
            Controls.Add(txtdescription);
            Controls.Add(label1);
            Controls.Add(txtowner);
            Controls.Add(label3);
            Controls.Add(txtfilename);
            Name = "SaveFile";
            Text = "Upload";
            FormClosed += SaveFile_FormClosed;
            Load += SaveFile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox txtfilename;
        private Label label1;
        private TextBox txtowner;
        private Label label2;
        private TextBox txtdescription;
        private Label label4;
        private TextBox txtpassword;
        private Label label5;
        private TextBox txtconfirmpassword;
        private Button btnupload;
        private Button btnreset;
        private ProgressBar pbuploading;
        private System.Windows.Forms.Timer tmupload;
        private Label lblpercent;
    }
}