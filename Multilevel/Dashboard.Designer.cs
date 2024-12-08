namespace Multilevel
{
    partial class Dashboard
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
            panel1 = new Panel();
            button9 = new Button();
            btnviewlogs = new Button();
            button3 = new Button();
            btnupload = new Button();
            button1 = new Button();
            label2 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            btndisconnect = new Button();
            cbIpAddress = new ComboBox();
            btnaddcloud = new Button();
            txtconnectionstatus = new TextBox();
            btnmonitor = new Button();
            btnconnect = new Button();
            panel4 = new Panel();
            label3 = new Label();
            panel5 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            lbltest = new Label();
            tmlog = new System.Windows.Forms.Timer(components);
            rtblogs = new RichTextBox();
            tmmonitor = new System.Windows.Forms.Timer(components);
            dgfiles = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgfiles).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button9);
            panel1.Controls.Add(btnviewlogs);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(btnupload);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(12, 96);
            panel1.Name = "panel1";
            panel1.Size = new Size(837, 135);
            panel1.TabIndex = 1;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.ButtonFace;
            button9.Location = new Point(525, 24);
            button9.Name = "button9";
            button9.Size = new Size(122, 87);
            button9.TabIndex = 7;
            button9.Text = "Logout";
            button9.UseVisualStyleBackColor = false;
            // 
            // btnviewlogs
            // 
            btnviewlogs.BackColor = SystemColors.ButtonFace;
            btnviewlogs.Location = new Point(678, 24);
            btnviewlogs.Name = "btnviewlogs";
            btnviewlogs.Size = new Size(143, 87);
            btnviewlogs.TabIndex = 5;
            btnviewlogs.Text = "View Logs";
            btnviewlogs.UseVisualStyleBackColor = false;
            btnviewlogs.Click += btnviewlogs_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonFace;
            button3.Location = new Point(357, 24);
            button3.Name = "button3";
            button3.Size = new Size(138, 87);
            button3.TabIndex = 4;
            button3.Text = "Download File";
            button3.UseVisualStyleBackColor = false;
            // 
            // btnupload
            // 
            btnupload.BackColor = SystemColors.ButtonFace;
            btnupload.Enabled = false;
            btnupload.Location = new Point(186, 24);
            btnupload.Name = "btnupload";
            btnupload.Size = new Size(141, 87);
            btnupload.TabIndex = 3;
            btnupload.Text = "Upload File";
            btnupload.UseVisualStyleBackColor = false;
            btnupload.Click += btnupload_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Location = new Point(34, 24);
            button1.Name = "button1";
            button1.Size = new Size(112, 87);
            button1.TabIndex = 2;
            button1.Text = "Profile";
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Noto Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(-1, 1);
            label2.Name = "label2";
            label2.Size = new Size(222, 43);
            label2.TabIndex = 10;
            label2.Text = "CLOUD FILES";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientActiveCaption;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(865, 94);
            panel2.Name = "panel2";
            panel2.Size = new Size(581, 43);
            panel2.TabIndex = 11;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GradientActiveCaption;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btndisconnect);
            panel3.Controls.Add(cbIpAddress);
            panel3.Controls.Add(btnaddcloud);
            panel3.Controls.Add(txtconnectionstatus);
            panel3.Controls.Add(btnmonitor);
            panel3.Controls.Add(btnconnect);
            panel3.Location = new Point(12, 300);
            panel3.Name = "panel3";
            panel3.Size = new Size(837, 165);
            panel3.TabIndex = 12;
            // 
            // btndisconnect
            // 
            btndisconnect.BackColor = SystemColors.ButtonFace;
            btndisconnect.Location = new Point(351, 75);
            btndisconnect.Name = "btndisconnect";
            btndisconnect.Size = new Size(178, 43);
            btndisconnect.TabIndex = 16;
            btndisconnect.Text = "Disconnect";
            btndisconnect.UseVisualStyleBackColor = false;
            btndisconnect.Click += btndisconnect_Click;
            // 
            // cbIpAddress
            // 
            cbIpAddress.Font = new Font("Segoe UI", 14F);
            cbIpAddress.FormattingEnabled = true;
            cbIpAddress.Location = new Point(26, 12);
            cbIpAddress.Name = "cbIpAddress";
            cbIpAddress.Size = new Size(503, 58);
            cbIpAddress.TabIndex = 15;
            // 
            // btnaddcloud
            // 
            btnaddcloud.BackColor = SystemColors.ButtonFace;
            btnaddcloud.Location = new Point(22, 75);
            btnaddcloud.Name = "btnaddcloud";
            btnaddcloud.Size = new Size(146, 43);
            btnaddcloud.TabIndex = 14;
            btnaddcloud.Text = "Add server";
            btnaddcloud.UseVisualStyleBackColor = false;
            btnaddcloud.Click += btnaddcloud_Click;
            // 
            // txtconnectionstatus
            // 
            txtconnectionstatus.BackColor = SystemColors.ActiveCaptionText;
            txtconnectionstatus.Cursor = Cursors.No;
            txtconnectionstatus.Font = new Font("Segoe UI", 14F);
            txtconnectionstatus.ForeColor = Color.Crimson;
            txtconnectionstatus.Location = new Point(535, 13);
            txtconnectionstatus.Name = "txtconnectionstatus";
            txtconnectionstatus.ReadOnly = true;
            txtconnectionstatus.Size = new Size(286, 57);
            txtconnectionstatus.TabIndex = 12;
            txtconnectionstatus.TabStop = false;
            txtconnectionstatus.Tag = "";
            txtconnectionstatus.TextAlign = HorizontalAlignment.Center;
            // 
            // btnmonitor
            // 
            btnmonitor.BackColor = SystemColors.ButtonFace;
            btnmonitor.Location = new Point(535, 76);
            btnmonitor.Name = "btnmonitor";
            btnmonitor.Size = new Size(286, 43);
            btnmonitor.TabIndex = 11;
            btnmonitor.Text = "Start Monitor";
            btnmonitor.UseVisualStyleBackColor = false;
            btnmonitor.Click += btnmonitor_Click;
            // 
            // btnconnect
            // 
            btnconnect.BackColor = SystemColors.ButtonFace;
            btnconnect.Location = new Point(186, 75);
            btnconnect.Name = "btnconnect";
            btnconnect.Size = new Size(159, 43);
            btnconnect.TabIndex = 10;
            btnconnect.Text = "Connect";
            btnconnect.UseVisualStyleBackColor = false;
            btnconnect.Click += btnconnect_Click;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.GradientActiveCaption;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label3);
            panel4.Location = new Point(12, 253);
            panel4.Name = "panel4";
            panel4.Size = new Size(837, 43);
            panel4.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Noto Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(-1, 1);
            label3.Name = "label3";
            label3.Size = new Size(292, 43);
            label3.TabIndex = 10;
            label3.Text = "CONNECT CLOUD";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.GradientActiveCaption;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(label1);
            panel5.Location = new Point(12, 25);
            panel5.Name = "panel5";
            panel5.Size = new Size(1434, 65);
            panel5.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Noto Sans", 11F, FontStyle.Bold);
            label6.ForeColor = Color.Crimson;
            label6.Location = new Point(262, 10);
            label6.Name = "label6";
            label6.Size = new Size(95, 41);
            label6.TabIndex = 12;
            label6.Text = "Allan\r\n";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Noto Sans", 11F, FontStyle.Bold);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(22, 11);
            label5.Name = "label5";
            label5.Size = new Size(246, 41);
            label5.TabIndex = 11;
            label5.Text = "Welcome back!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14F);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(775, 10);
            label1.Name = "label1";
            label1.Size = new Size(654, 44);
            label1.TabIndex = 1;
            label1.Text = "CLOUD MANAGEMENT INTERFACE";
            // 
            // lbltest
            // 
            lbltest.AutoSize = true;
            lbltest.Location = new Point(71, 856);
            lbltest.Name = "lbltest";
            lbltest.Size = new Size(78, 32);
            lbltest.TabIndex = 16;
            lbltest.Text = "label7";
            // 
            // tmlog
            // 
            tmlog.Tick += tmlog_Tick;
            // 
            // rtblogs
            // 
            rtblogs.BackColor = Color.Black;
            rtblogs.Font = new Font("Segoe UI", 8F);
            rtblogs.ForeColor = Color.LimeGreen;
            rtblogs.Location = new Point(12, 471);
            rtblogs.Name = "rtblogs";
            rtblogs.Size = new Size(1434, 324);
            rtblogs.TabIndex = 17;
            rtblogs.Text = "";
            // 
            // tmmonitor
            // 
            tmmonitor.Tick += tmmonitor_Tick;
            // 
            // dgfiles
            // 
            dgfiles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgfiles.Location = new Point(865, 143);
            dgfiles.Name = "dgfiles";
            dgfiles.RowHeadersWidth = 82;
            dgfiles.Size = new Size(581, 322);
            dgfiles.TabIndex = 18;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1457, 807);
            Controls.Add(dgfiles);
            Controls.Add(rtblogs);
            Controls.Add(lbltest);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Dashboard";
            Text = "Dashboard";
            FormClosed += Dashboard_FormClosed;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgfiles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Button button1;
        private Button btnupload;
        private Button button3;
        private Button btnviewlogs;
        private Label label2;
        private Panel panel2;
        private Panel panel3;
        private TextBox txtconnectionstatus;
        private Button btnmonitor;
        private Button btnconnect;
        private Panel panel4;
        private Label label3;
        private Panel panel5;
        private Label label1;
        private Label label6;
        private Label label5;
        private Button button9;
        private Label lbltest;
        private Button btnaddcloud;
        private ComboBox cbIpAddress;
        private System.Windows.Forms.Timer tmlog;
        private RichTextBox rtblogs;
        private System.Windows.Forms.Timer tmmonitor;
        private Button btndisconnect;
        private DataGridView dgfiles;
    }
}