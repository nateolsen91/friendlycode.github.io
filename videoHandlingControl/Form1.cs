using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_HandlingControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            downloadLabel.Visible = false;
            warningLabel.Visible = false;
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            if (agreeBox.Checked == true)
                downloadLabel.Visible = true;
        }

        private void downloadButton_Enter(object sender, EventArgs e)
        {
            if (agreeBox.Checked == false)
                warningLabel.Visible = true;
        }

        private void downloadButton_Leave(object sender, EventArgs e)
        {
            warningLabel.Visible = false;
        }
    }
}
