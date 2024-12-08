using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multilevel
{
    public partial class ViewLogs : Form
    {
        int logcount = 1000;
        List<string> logs = new List<string>();
        public ViewLogs(bool HasBeenConnected)
        {
            InitializeComponent();
            if(HasBeenConnected == true )
            {
                for (int i = 0; i <= logcount; i++)
                {
                    string log = IntrusionDetectionProfiler.GenerateRandomIDSLog();
                    rtblogs.AppendText(log + Environment.NewLine);
                }
            }
            else
            {
                rtblogs.AppendText("There are no logs: no server has been connected" + Environment.NewLine);
            }
        }

        private void ViewLogs_Load(object sender, EventArgs e)
        {
            rtblogs.ScrollToCaret();
        }
    }
}
