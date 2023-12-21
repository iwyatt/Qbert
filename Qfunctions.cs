using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Web;

namespace Qbert
{
    public class Qfunctions
    {
        public void setExpectHeader()
        {
            System.Net.ServicePointManager.Expect100Continue = false; //line added to fix proxy server problem
        }
        
        public void loadgrid(OpenFileDialog ofd, DataTable dt)
        {
            FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            dt.TableName = "LeadData";
            string[] strArray;
            string strLine;
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
        }

        public void FixPhone(DataGridView dgv)
        {
            foreach (DataGridViewColumn dc in dgv.Columns)
            {
                if (dc.HeaderText == "Phone")
                {
                    int dcindex = dc.Index;
                    int drcount = dgv.RowCount;

                    for (int i = 0; i < drcount; i++)
                    {
                        string oldphone = (String)dgv[dcindex, i].Value;
                        string newphone = formatphone(oldphone);
                        dgv[dcindex, i].Value = newphone;
                    }
                }
            }
        }

        private string formatphone(string sNumToBeFormatted) //case statement for phone formatting
        {
            if (sNumToBeFormatted == null)
            {
                return sNumToBeFormatted;
            }

            else
            {
                string functionReturnValue = null; //string to hand back to the form
                int iNumberLength = 0; // the length of the string to be evaluated
                sNumToBeFormatted.Trim(); //trim the fat of the string (ie blanks on the end)
                iNumberLength = sNumToBeFormatted.Length; //set the length of the string
                switch (iNumberLength) //each case of this switch is a function to perform on the string based on the length of the string
                {

                    case 7:
                        //Format : #######
                        functionReturnValue = sNumToBeFormatted.Substring(0, 3) + "-" + sNumToBeFormatted.Substring(3);
                        return functionReturnValue;

                    case 8:
                        //Format : ###-#### or ### ####
                        if (sNumToBeFormatted.Substring(3, 1) == "-")
                        {
                            functionReturnValue = sNumToBeFormatted;
                            return functionReturnValue;
                        }

                        else
                        {
                            functionReturnValue = sNumToBeFormatted.Substring(0, 3) + "-" + sNumToBeFormatted.Substring(4);
                            return functionReturnValue;
                        }

                    case 10:
                        //Format : ##########
                        functionReturnValue = "(" + sNumToBeFormatted.Substring(0, 3) + ") " + sNumToBeFormatted.Substring(3, 3) + "-" + sNumToBeFormatted.Substring(6);
                        return functionReturnValue;

                    case 11:
                        //Format ######-#### or ###-#######
                        if (sNumToBeFormatted.Substring(6, 1) == "-")
                        {
                            functionReturnValue = "(" + sNumToBeFormatted.Substring(0, 3) + ") " + sNumToBeFormatted.Substring(3);
                            return functionReturnValue;
                        }

                        else
                        {
                            functionReturnValue = "(" + sNumToBeFormatted.Substring(0, 3) + ") " + sNumToBeFormatted.Substring(4, 3) + "-" + sNumToBeFormatted.Substring(7);
                            return functionReturnValue;
                        }

                    case 12:
                        //Format : ### ###-####
                        functionReturnValue = "(" + sNumToBeFormatted.Substring(0, 3) + ") " + sNumToBeFormatted.Substring(4, 3) + "-" + sNumToBeFormatted.Substring(8);
                        return functionReturnValue;

                    case 13:
                        //Format : (###)###-####
                        functionReturnValue = sNumToBeFormatted.Substring(0, 5) + " " + sNumToBeFormatted.Substring(5);
                        return functionReturnValue;

                    default:
                        //Return Value Passed
                        functionReturnValue = sNumToBeFormatted;
                        return functionReturnValue;
                }
            }
        }

        private string vlookup(string sourcevalue, string lookupcolumn, string returncolumn, DataTable maptable)
        {
            string returnvalue = "";
            foreach (DataRow maprow in maptable.Rows)
            {
                if (maprow[lookupcolumn].ToString() == sourcevalue && sourcevalue != "" && (maprow[returncolumn] != null))
                {
                    returnvalue = maprow[returncolumn].ToString();
                    return returnvalue;
                }
            }
            return sourcevalue;
        }

        public void FindDupes(DataGridView dataGridView1, DataSet ds)
        {
            if (!ds.Tables[0].Columns.Contains("Duplicate"))
            {
                //ds.Tables[0].Columns.Add("Duplicate", "Duplicate");
                DataColumn dc = ds.Tables[0].Columns.Add("Duplicate");
                dc.ColumnName = "Duplicate";

            }

            foreach (DataGridViewRow dgvrow in dataGridView1.Rows)
            {
                if (dataGridView1["Email", dgvrow.Index].Value != null)
                {
                    string email = dataGridView1["Email", dgvrow.Index].Value.ToString();
                    int a = 0;
                    if (email != "")
                    {
                        while (a < dataGridView1.RowCount)
                        {

                            if (dgvrow.Index != a && dataGridView1["Email", a].Value != null && email == dataGridView1["Email", a].Value.ToString())
                            {
                                dataGridView1["Duplicate", dgvrow.Index].Value = "TRUE";
                            }
                            a++;
                        }
                    }
                }
            }
        }

        public void FixZip(DataGridView dgv)
        {
            foreach (DataGridViewColumn dc in dgv.Columns)
            {
                if (dc.HeaderText == "Zip/Postal Code")
                {
                    int dcindex = dc.Index;
                    int drcount = dgv.RowCount;

                    for (int i = 0; i < drcount; i++)
                    {
                        string oldzip = (String)dgv[dcindex, i].Value;
                        string newzip = formatzip(oldzip);
                        dgv[dcindex, i].Value = newzip;
                    }
                }
            }
        }

        private string formatzip(string oldzip)
        {
            oldzip.Trim();
            oldzip.Substring(0, 4);
            return oldzip;
        }

        public DataTable loadcsv(OpenFileDialog ofd)
        {
            FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            TextReader tx = sr;
            CsvParser csvp = new CsvParser();

            DataTable dt = csvp.Parse(tx, true);
            return dt;
        }

        public void FixFieldLengths(DataGridView dgv)
        {
            foreach (DataGridViewColumn dc in dgv.Columns)
            {
                switch (dc.Name)
                {
                    case "FirstName":
                        fixlength(dc, 20);
                        break;
                    case "LastName":
                        fixlength(dc, 40);
                        break;
                    case "StateProvince":
                        fixlength(dc, 20);
                        break;
                    case "Zip":
                        fixlength(dc, 20);
                        break;
                    case "Title":
                        fixlength(dc, 80);
                        break;
                    case "Website":
                        fixlength(dc, 255);
                        break;
                }
            }
        }

        private void fixlength(DataGridViewColumn dc, int lim)
        {
            DataGridView dgv = dc.DataGridView;
            int dcindex = dc.Index;
            int drcount = dgv.RowCount;

            for (int i = 0; i < drcount; i++)
            {
                string oldval = (String)dgv[dcindex, i].Value;
                if (oldval != null && !(oldval.Length < lim))
                {
                    oldval.Trim();
                    string newval = oldval.Substring(0, lim);
                    dgv[dcindex, i].Value = newval;
                }
            }
        }

        public void RemoveDupes(DataGridView dataGridView1, DataSet ds)
        {
            int emailrow = 0;
            foreach (DataGridViewRow dgvrow in dataGridView1.Rows)
            {
                if (dataGridView1["Email", dgvrow.Index].Value != null && dataGridView1["Email", dgvrow.Index].Value.ToString() != "")
                {
                    string email = dataGridView1["Email", dgvrow.Index].Value.ToString();
                    int a = emailrow;
                    while (a < dataGridView1.RowCount)
                    {
                        if (dgvrow.Index != a && dataGridView1["Email", a].Value != null && email == dataGridView1["Email", a].Value.ToString())
                        {
                            dataGridView1.Rows.Remove(dataGridView1.Rows[a]);
                        }
                        a++;
                    }
                }
                emailrow++;
            }
            ds.Tables[0].Columns.Remove("Duplicate");
        }

        public void PostToEloqua(DataSet ds, Dictionary<string, string> elqvals)
        {
            ProgressInd progress = ShowProgress(0, ds.Tables[0].Rows.Count, 0); //initialize progress bar
            progress.Show();

            string eloquaposturl = elqvals["Eloqua Post URL"].Trim(); //set eloqua url
            elqvals.Remove("Eloqua Post URL");

            string elqvars = "";
            foreach (KeyValuePair<string, string> entry in elqvals) //string together eloqua and campaign static values
            {
                string field = HttpUtility.UrlEncode(entry.Key.ToString());
                string value = HttpUtility.UrlEncode(entry.Value.ToString());

                elqvars += entry.Key.ToString() + "=" + entry.Value.ToString() + "&";
            }

            DataTable dt = ds.Tables[0];
            dt.Columns.Add("Qbert Post Result");
            
            foreach (DataRow dr in dt.Rows) //submit each row to eloqua
            {
                ShowProgress(progress, 0);
                if (!progress.cancelled) //when the progress indicator closes, the value of .text is ""
                {
                    string rowdata = "";
                    foreach (DataColumn dc in dt.Columns)
                    {
                        if (dr[dc].ToString() != null && dr[dc].ToString() != "")
                        {
                            rowdata += HttpUtility.UrlEncode(dc.ColumnName) + "=" + HttpUtility.UrlEncode(dr[dc].ToString()) + "&";
                        }
                        rowdata.Trim();
                    }

                    try
                    {
                        string result = eloquapost(eloquaposturl, elqvars + rowdata); //call function to send data to eloqua
                        dr["Qbert Post Result"] = result;
                    }

                    catch (Exception er)
                    {
                        string errorstring = er.ToString();
                        QError oops = new QError(errorstring);
                        oops.ShowDialog();
                    }

                    ShowProgress(progress, 1); //increment progress bar
                }
                else
                {
                    break;
                }
            }
            progress.button1.Text = "OK";
        }

        private static string eloquapost(string url, string data)
        {
            string vystup = null;
            try
            {
                //Our postvars
                byte[] buffer = Encoding.ASCII.GetBytes(data);

                //Initialisation, we use localhost, change if appliable
                HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create(url);
                //Our method is post, otherwise the buffer (postvars) would be useless
                WebReq.Method = "POST";
                //WebReq.Expect = "False";

                //We use form contentType, for the postvars.
                WebReq.ContentType = "application/x-www-form-urlencoded";

                //The length of the buffer (postvars) is used as contentlength.
                WebReq.ContentLength = buffer.Length;

                //We open a stream for writing the postvars
                Stream PostData = WebReq.GetRequestStream();

                //Now we write, and afterwards, we close. Closing is always important!
                PostData.Write(buffer, 0, buffer.Length);
                PostData.Close();

                //Get the response handle, we have no true response yet!
                HttpWebResponse WebResp = (HttpWebResponse)WebReq.GetResponse();

                //Let's show some information about the response
                //Console.WriteLine(WebResp.StatusCode);
                //Console.WriteLine(WebResp.Server);

                //Now, we read the response (the string), and output it.
                Stream Answer = WebResp.GetResponseStream();
                StreamReader _Answer = new StreamReader(Answer);
                vystup = "Status Code: " + WebResp.StatusCode.ToString() + "; Status Description: " + WebResp.StatusDescription.ToString();

                WebResp.Close();
                Answer.Close();
                //Congratulations, you just requested your first POST page, you
                //can now start logging into most login forms, with your application
                //Or other examples.
            }
            catch (Exception ex)
            {
                vystup += "; " + ex.Message.ToString();
                return vystup;
            }
            return vystup.Trim() + "\n";
        }

        public ProgressInd ShowProgress(int min, int max, int val)
        {
            ProgressInd progress = new ProgressInd();
            progress.progBar1.Minimum = min;
            progress.progBar1.Maximum = max;
            progress.progBar1.Value = val;
            return progress;
        } //create progress indicator

        public void ShowProgress(ProgressInd progress, int step)
        {
            if (progress.Text != "Cancelled")
            {
                progress.progBar1.Value += step; //increment progress bar
                progress.Text = progress.progBar1.Value.ToString() + " of " + progress.progBar1.Maximum.ToString() + " items processed...";
                progress.Refresh();
                Application.DoEvents();
            }
        }

        public void RemoveBlankRows(DataSet ds)
        {
            for (int rows = ds.Tables[0].Rows.Count - 1; rows > 0; rows--)
            {
                bool hasdata = false;
                foreach (DataColumn dc in ds.Tables[0].Columns)
                {
                    if (ds.Tables[0].Rows[rows][dc].ToString() != "")
                    {
                        hasdata = true;
                        break;
                    }
                }

                if (!hasdata)
                {
                    ds.Tables[0].Rows[rows].Delete();
                }
            }
        }

        public void InsertBlankColumn(DataSet ds)
        {
            InsertColumn ic = new InsertColumn();
            ic.ShowDialog();
        }

    }
}
