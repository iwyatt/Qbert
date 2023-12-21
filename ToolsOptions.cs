using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Qbert
{
    public partial class ToolsOptions : Form
    {
        public ToolsOptions()
        {
            InitializeComponent();
            LoadSettings();
        }

        private void LoadSettings()
        {
            textBox1.Text = Settings1.Default.MappingConfiguration.ToString();
            LoadDataGrid(Settings1.Default.MappingConfiguration.ToString());
        }

        public void LoadDataGrid(string fileloc)
        {
            StreamReader sr = new StreamReader(fileloc);
            
            DataSet ds = new DataSet();
            DataTable dt = ds.Tables.Add("TheData");
            BindingSource bs1 = new BindingSource();
            bs1.DataSource = ds;
            dgv1.Columns.Clear();
            dgv1.DataSource = bs1;
            dgv1.DataMember = "TheData";
            string strLine;
            string[] strArray;
            char[] charArray = new char[] { ',' };

            strLine = sr.ReadLine();
            strArray = strLine.Split(charArray);

            for (int x = 0; x <= strArray.GetUpperBound(0); x++)
            {
                dt.Columns.Add(strArray[x].Trim());
            }

            strLine = sr.ReadLine();
            while (strLine != null)
            {
                strArray = strLine.Split(charArray);
                DataRow dr = dt.NewRow();
                for (int i = 0; i <= strArray.GetUpperBound(0); i++)
                {
                    dr[i] = strArray[i].Trim();
                }
                dt.Rows.Add(dr);
                strLine = sr.ReadLine();
            }
            sr.Close();
            //end copied code
        }


        private void button3_Click(object sender, EventArgs e) //OK Button
        {
            Settings1.Default.Save();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) //Cancel Button
        {
            Settings1.Default.Reload();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open);
                string fileloc = fs.Name.ToString();
                fs.Close();
                
                LoadDataGrid(fileloc);
                textBox1.Text = fileloc;

                Settings1.Default.MappingConfiguration = fileloc;
            }
        }
    }
}
