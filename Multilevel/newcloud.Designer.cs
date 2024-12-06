namespace Multilevel
{
    partial class newcloud
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
            txtip = new TextBox();
            txtserversecret = new TextBox();
            btnadd = new Button();
            btnreset = new Button();
            txtport = new TextBox();
            txtservername = new TextBox();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtip
            // 
            txtip.Font = new Font("Segoe UI", 12F);
            txtip.Location = new Point(51, 65);
            txtip.Name = "txtip";
            txtip.PlaceholderText = "IP address";
            txtip.Size = new Size(340, 50);
            txtip.TabIndex = 0;
            // 
            // txtserversecret
            // 
            txtserversecret.Font = new Font("Segoe UI", 12F);
            txtserversecret.Location = new Point(51, 409);
            txtserversecret.Name = "txtserversecret";
            txtserversecret.PlaceholderText = "Server Secret Key";
            txtserversecret.Size = new Size(340, 50);
            txtserversecret.TabIndex = 3;
            // 
            // btnadd
            // 
            btnadd.BackColor = SystemColors.ButtonFace;
            btnadd.Location = new Point(51, 560);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(340, 61);
            btnadd.TabIndex = 4;
            btnadd.Text = "Add Cloud ";
            btnadd.UseVisualStyleBackColor = false;
            btnadd.Click += btnadd_Click;
            // 
            // btnreset
            // 
            btnreset.BackColor = SystemColors.ButtonFace;
            btnreset.Location = new Point(51, 493);
            btnreset.Name = "btnreset";
            btnreset.Size = new Size(340, 61);
            btnreset.TabIndex = 5;
            btnreset.Text = "Reset Fields";
            btnreset.UseVisualStyleBackColor = false;
            btnreset.Click += btnreset_Click;
            // 
            // txtport
            // 
            txtport.Font = new Font("Segoe UI", 12F);
            txtport.Location = new Point(51, 173);
            txtport.Name = "txtport";
            txtport.PlaceholderText = "Port";
            txtport.Size = new Size(340, 50);
            txtport.TabIndex = 1;
            // 
            // txtservername
            // 
            txtservername.Font = new Font("Segoe UI", 12F);
            txtservername.Location = new Point(51, 290);
            txtservername.Name = "txtservername";
            txtservername.PlaceholderText = "Server name";
            txtservername.Size = new Size(340, 50);
            txtservername.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(51, 31);
            label3.Name = "label3";
            label3.Size = new Size(234, 31);
            label3.TabIndex = 19;
            label3.Text = "Server IP Address";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(51, 139);
            label1.Name = "label1";
            label1.Size = new Size(64, 31);
            label1.TabIndex = 20;
            label1.Text = "Port";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(51, 256);
            label2.Name = "label2";
            label2.Size = new Size(168, 31);
            label2.TabIndex = 21;
            label2.Text = "Server name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(51, 375);
            label4.Name = "label4";
            label4.Size = new Size(143, 31);
            label4.TabIndex = 22;
            label4.Text = "Secret key";
            // 
            // newcloud
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 666);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(txtservername);
            Controls.Add(txtport);
            Controls.Add(btnreset);
            Controls.Add(btnadd);
            Controls.Add(txtserversecret);
            Controls.Add(txtip);
            MaximizeBox = false;
            Name = "newcloud";
            Text = "New Cloud";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtip;
        private TextBox txtserversecret;
        private Button btnadd;
        private Button btnreset;
        private TextBox txtport;
        private TextBox txtservername;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label label4;
    }
}