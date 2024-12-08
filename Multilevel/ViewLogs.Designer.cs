namespace Multilevel
{
    partial class ViewLogs
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
            rtblogs = new RichTextBox();
            SuspendLayout();
            // 
            // rtblogs
            // 
            rtblogs.Dock = DockStyle.Fill;
            rtblogs.Location = new Point(0, 0);
            rtblogs.Name = "rtblogs";
            rtblogs.Size = new Size(1358, 828);
            rtblogs.TabIndex = 0;
            rtblogs.Text = "";
            // 
            // ViewLogs
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1358, 828);
            Controls.Add(rtblogs);
            Name = "ViewLogs";
            Text = "ViewLogs";
            Load += ViewLogs_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtblogs;
    }
}