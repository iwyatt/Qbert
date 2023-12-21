using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Qbert
{
    public partial class ProgressInd : Form
    {
        public bool cancelled = false;
        
        public ProgressInd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (progBar1.Value < progBar1.Maximum) { this.cancelled = true; }
            this.Close();
            this.Dispose();
        }

 
    }
}
