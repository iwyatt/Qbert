using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Reflection;

namespace Qbert
{
    public partial class QbertMain : Form
    {
        Qfunctions qf = new Qfunctions(); //load helper functions
        public QbertMain()
        {
            //set static property for header to work, see: http://stackoverflow.com/questions/566437/http-post-returns-the-error-417-expectation-failed-c
            System.Net.ServicePointManager.Expect100Continue = false;
            qf.setExpectHeader();
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    if (leadds.Tables.Count > 0) { leadds.Tables.Remove(leadds.Tables[0]); } //remove existing tables
                    leaddgv.AutoGenerateColumns = true; //set to autogenerate columns
                    leadds.Tables.Add(qf.loadcsv(ofd)); //add table based on csv input
                    leadbs.DataSource = leadds.Tables[0]; //set binding data source to new table
                    leaddgv.DataSource = leadbs; //set data grid view to binding source
                    leaddgv.ContextMenuStrip = dgcontext; //set right click context menu
                }
            }

            catch (Exception er)
            {
                string errorstring = er.ToString();
                QError oops = new QError(errorstring);
                oops.ShowDialog();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void fixAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            qf.RemoveBlankRows(leadds); //run through each of the individual menu items to fix data
            qf.FindDupes(leaddgv, leadds);
            qf.RemoveDupes(leaddgv, leadds);
            qf.FixPhone(leaddgv);
            qf.FixFieldLengths(leaddgv);
        }

        private void enforceFieldLengthsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (leadds.Tables.Count > 0)
                {
                    qf.FixFieldLengths(leaddgv);
                }

                else
                {
                    QError err = new QError("No rows to modify");
                    err.ShowDialog();
                }
            }

            catch (Exception er)
            {
                QError err = new QError(er.Message);
                err.ShowDialog();
            }
        }

        private void formatPhoneNumbersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            qf.FixPhone(leaddgv);
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (leadds.Tables.Count > 0 && leadds.Tables[0].Columns.Contains("Email"))
                {
                    qf.FindDupes(leaddgv, leadds);
                }

                else
                {
                    QError err = new QError("No email column to search");
                    err.ShowDialog();
                }
            }

            catch (Exception er)
            {
                QError err = new QError(er.Message);
                err.ShowDialog();
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (leadds.Tables.Count > 0 && leadds.Tables[0].Columns.Contains("Duplicate"))
                {
                    qf.RemoveDupes(leaddgv,leadds);
                }

                else
                {
                    QError err = new QError("Duplicates not found yet. Try Searching for them first.");
                    err.ShowDialog();
                }
            }

            catch (Exception er)
            {
                QError err = new QError(er.Message);
                err.ShowDialog();
            }
        }

        private void postToEloquaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (leadds.Tables.Count > 0)
            {
                try
                {
                    Dictionary<string, string> elqvalues = new Dictionary<string, string>(); //create dictionary for static values

                    elqvalues.Add(elqField1.Text, elqtext1.Text); //add static eloqua info
                    elqvalues.Add(elqField2.Text, elqtext2.Text);
                    elqvalues.Add(elqField3.Text, elqtext3.Text);
                    elqvalues.Add(elqField4.Text, elqtext4.Text);
                    elqvalues.Add(elqField5.Text, elqtext5.Text);
                    elqvalues.Add(elqField6.Text, elqbox1.Checked.ToString());
                    //elqvalues.Add(elqField7.Text, elqbox2.Checked.ToString());
                    //elqvalues.Add(elqField8.Text, elqbox3.Checked.ToString());

                    //elqvalues.Add(campfield1.Text, camptext1.Text); //add static campaign info
                    //elqvalues.Add(campfield2.Text, camptext2.Text);

                    //elqvalues.Add(leadfield1.Text, leadtext1.Text); //add static lead info
                    //elqvalues.Add(leadfield2.Text, leadtext2.Text);
                    //elqvalues.Add(leadfield3.Text, leadtext3.Text);
                    //elqvalues.Add(leadfield4.Text, leadtext4.Text);

                    qf.PostToEloqua(leadds, elqvalues); //send over data set and eloqua+campaign static values to be processed and submitted
                }
                catch (Exception er)
                {
                    QError err = new QError(er.Message);
                    err.ShowDialog();
                }
            }

            else
            {
                QError err = new QError("No Data to Post!");
                err.ShowDialog();
            }
        }

        private void rowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            qf.RemoveBlankRows(leadds);
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            qf.InsertBlankColumn(leadds);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = System.Diagnostics.Process.Start("qbert_eloqua_template.csv");
            proc.WaitForExit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string AssemblyVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            MessageBox.Show(String.Format("Qbert V. 1.21\r\n 04/05/2011 \r\n By Isaac Wyatt \r\n [redacted email address]] \r\n https://isaacwyatt.com", "About"));
        }

    }
}
