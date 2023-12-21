using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Qbert
{
    public partial class QError : Form
    {
        public QError(string er)
        {
            InitializeComponent();
            richTextBox2.Text = er;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
