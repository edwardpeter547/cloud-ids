namespace Multilevel
{
    partial class Login
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
            label1 = new Label();
            label2 = new Label();
            txtcloudid = new TextBox();
            txtpassword = new TextBox();
            label3 = new Label();
            btnreset = new Button();
            btnlogin = new Button();
            linkcreateaccount = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16F);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(67, 58);
            label1.Name = "label1";
            label1.Size = new Size(749, 51);
            label1.TabIndex = 0;
            label1.Text = "CLOUD AUTHENTICATION SYSTEM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.Location = new Point(80, 170);
            label2.Name = "label2";
            label2.Size = new Size(141, 37);
            label2.TabIndex = 1;
            label2.Text = "Cloud ID";
            // 
            // txtcloudid
            // 
            txtcloudid.Font = new Font("Microsoft Sans Serif", 14F);
            txtcloudid.Location = new Point(259, 161);
            txtcloudid.Name = "txtcloudid";
            txtcloudid.Size = new Size(467, 50);
            txtcloudid.TabIndex = 2;
            txtcloudid.Tag = "Cloud ID";
            // 
            // txtpassword
            // 
            txtpassword.Font = new Font("Microsoft Sans Serif", 14F);
            txtpassword.Location = new Point(259, 256);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(467, 50);
            txtpassword.TabIndex = 4;
            txtpassword.Tag = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F);
            label3.Location = new Point(80, 265);
            label3.Name = "label3";
            label3.Size = new Size(158, 37);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // btnreset
            // 
            btnreset.Font = new Font("Microsoft Sans Serif", 10F);
            btnreset.Location = new Point(257, 349);
            btnreset.Name = "btnreset";
            btnreset.Size = new Size(195, 58);
            btnreset.TabIndex = 5;
            btnreset.Text = "Reset";
            btnreset.UseVisualStyleBackColor = true;
            btnreset.Click += btnreset_Click;
            // 
            // btnlogin
            // 
            btnlogin.Font = new Font("Microsoft Sans Serif", 10F);
            btnlogin.Location = new Point(531, 349);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(195, 58);
            btnlogin.TabIndex = 6;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // linkcreateaccount
            // 
            linkcreateaccount.AutoSize = true;
            linkcreateaccount.Font = new Font("Microsoft Sans Serif", 14F);
            linkcreateaccount.Location = new Point(291, 432);
            linkcreateaccount.Name = "linkcreateaccount";
            linkcreateaccount.Size = new Size(389, 44);
            linkcreateaccount.TabIndex = 7;
            linkcreateaccount.TabStop = true;
            linkcreateaccount.Text = "Create Cloud Account";
            linkcreateaccount.LinkClicked += linkcreateaccount_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(898, 530);
            Controls.Add(linkcreateaccount);
            Controls.Add(btnlogin);
            Controls.Add(btnreset);
            Controls.Add(txtpassword);
            Controls.Add(label3);
            Controls.Add(txtcloudid);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            FormClosed += Login_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtcloudid;
        private TextBox txtpassword;
        private Label label3;
        private Button btnreset;
        private Button btnlogin;
        private LinkLabel linkcreateaccount;
    }
}