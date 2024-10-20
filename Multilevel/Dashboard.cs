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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            var data = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            lbltest.Text = data.ToString();
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
