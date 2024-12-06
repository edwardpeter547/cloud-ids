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
            panel1 = new Panel();
            button9 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            btnupload = new Button();
            button1 = new Button();
            listBox1 = new ListBox();
            lblogs = new ListBox();
            label2 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            btnaddcloud = new Button();
            txtconnectionstatus = new TextBox();
            button7 = new Button();
            btnconnect = new Button();
            txtipaddress = new TextBox();
            panel4 = new Panel();
            label3 = new Label();
            panel5 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            panel6 = new Panel();
            label4 = new Label();
            lbltest = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(btnupload);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(46, 98);
            panel1.Name = "panel1";
            panel1.Size = new Size(1385, 135);
            panel1.TabIndex = 1;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.ButtonFace;
            button9.Location = new Point(1021, 24);
            button9.Name = "button9";
            button9.Size = new Size(147, 87);
            button9.TabIndex = 7;
            button9.Text = "Logout";
            button9.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ButtonFace;
            button5.Location = new Point(1193, 68);
            button5.Name = "button5";
            button5.Size = new Size(174, 43);
            button5.TabIndex = 6;
            button5.Text = "Create Rules";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonFace;
            button4.Location = new Point(1193, 24);
            button4.Name = "button4";
            button4.Size = new Size(174, 43);
            button4.TabIndex = 5;
            button4.Text = "View Logs";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonFace;
            button3.Location = new Point(696, 24);
            button3.Name = "button3";
            button3.Size = new Size(301, 87);
            button3.TabIndex = 4;
            button3.Text = "Download File";
            button3.UseVisualStyleBackColor = false;
            // 
            // btnupload
            // 
            btnupload.BackColor = SystemColors.ButtonFace;
            btnupload.Location = new Point(366, 24);
            btnupload.Name = "btnupload";
            btnupload.Size = new Size(301, 87);
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
            button1.Size = new Size(301, 87);
            button1.TabIndex = 2;
            button1.Text = "Manage Profile";
            button1.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(850, 300);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(581, 548);
            listBox1.TabIndex = 2;
            // 
            // lblogs
            // 
            lblogs.BackColor = SystemColors.InactiveCaptionText;
            lblogs.ForeColor = Color.DarkGreen;
            lblogs.FormattingEnabled = true;
            lblogs.Location = new Point(46, 522);
            lblogs.Name = "lblogs";
            lblogs.Size = new Size(780, 324);
            lblogs.TabIndex = 9;
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
            panel2.Location = new Point(850, 253);
            panel2.Name = "panel2";
            panel2.Size = new Size(581, 43);
            panel2.TabIndex = 11;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GradientActiveCaption;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btnaddcloud);
            panel3.Controls.Add(txtconnectionstatus);
            panel3.Controls.Add(button7);
            panel3.Controls.Add(btnconnect);
            panel3.Controls.Add(txtipaddress);
            panel3.Location = new Point(46, 302);
            panel3.Name = "panel3";
            panel3.Size = new Size(780, 150);
            panel3.TabIndex = 12;
            // 
            // btnaddcloud
            // 
            btnaddcloud.BackColor = SystemColors.ButtonFace;
            btnaddcloud.Location = new Point(22, 75);
            btnaddcloud.Name = "btnaddcloud";
            btnaddcloud.Size = new Size(177, 43);
            btnaddcloud.TabIndex = 14;
            btnaddcloud.Text = "Add Cloud ";
            btnaddcloud.UseVisualStyleBackColor = false;
            btnaddcloud.Click += btnaddcloud_Click;
            // 
            // txtconnectionstatus
            // 
            txtconnectionstatus.BackColor = SystemColors.ActiveCaptionText;
            txtconnectionstatus.Font = new Font("Segoe UI", 14F);
            txtconnectionstatus.ForeColor = Color.Crimson;
            txtconnectionstatus.Location = new Point(437, 12);
            txtconnectionstatus.Name = "txtconnectionstatus";
            txtconnectionstatus.Size = new Size(329, 57);
            txtconnectionstatus.TabIndex = 12;
            txtconnectionstatus.Tag = "";
            txtconnectionstatus.TextAlign = HorizontalAlignment.Center;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ButtonFace;
            button7.Location = new Point(437, 75);
            button7.Name = "button7";
            button7.Size = new Size(329, 43);
            button7.TabIndex = 11;
            button7.Text = "Start Monitor";
            button7.UseVisualStyleBackColor = false;
            // 
            // btnconnect
            // 
            btnconnect.BackColor = SystemColors.ButtonFace;
            btnconnect.Location = new Point(205, 75);
            btnconnect.Name = "btnconnect";
            btnconnect.Size = new Size(226, 43);
            btnconnect.TabIndex = 10;
            btnconnect.Text = "connect";
            btnconnect.UseVisualStyleBackColor = false;
            btnconnect.Click += btnconnect_Click;
            // 
            // txtipaddress
            // 
            txtipaddress.Font = new Font("Segoe UI", 14F);
            txtipaddress.Location = new Point(22, 12);
            txtipaddress.Name = "txtipaddress";
            txtipaddress.PlaceholderText = "Ip Address or Domain";
            txtipaddress.Size = new Size(409, 57);
            txtipaddress.TabIndex = 9;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.GradientActiveCaption;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label3);
            panel4.Location = new Point(46, 255);
            panel4.Name = "panel4";
            panel4.Size = new Size(780, 43);
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
            panel5.Location = new Point(46, 27);
            panel5.Name = "panel5";
            panel5.Size = new Size(1385, 65);
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
            label1.Location = new Point(726, 10);
            label1.Name = "label1";
            label1.Size = new Size(654, 44);
            label1.TabIndex = 1;
            label1.Text = "CLOUD MANAGEMENT INTERFACE";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.GradientActiveCaption;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(label4);
            panel6.Location = new Point(46, 473);
            panel6.Name = "panel6";
            panel6.Size = new Size(780, 43);
            panel6.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Noto Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.RoyalBlue;
            label4.Location = new Point(-1, 1);
            label4.Name = "label4";
            label4.Size = new Size(214, 43);
            label4.TabIndex = 10;
            label4.Text = "LOGS PANEL";
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
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1475, 903);
            Controls.Add(lbltest);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(lblogs);
            Controls.Add(listBox1);
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
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Button button1;
        private Button btnupload;
        private Button button3;
        private Button button5;
        private Button button4;
        private ListBox listBox1;
        private ListBox lblogs;
        private Label label2;
        private Panel panel2;
        private Panel panel3;
        private TextBox txtconnectionstatus;
        private Button button7;
        private Button btnconnect;
        private TextBox txtipaddress;
        private Panel panel4;
        private Label label3;
        private Panel panel5;
        private Label label1;
        private Panel panel6;
        private Label label4;
        private Label label6;
        private Label label5;
        private Button button9;
        private Label lbltest;
        private Button btnaddcloud;
    }
}