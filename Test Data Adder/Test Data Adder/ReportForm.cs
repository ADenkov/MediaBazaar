using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//requiered for report generation
using mw = Microsoft.Office.Interop.Word;

namespace Test_Data_Adder
{
    public partial class ReportForm : Form
    {
        private SqlConnection cnn = new SqlConnection("Data Source=89.157.247.62;Initial Catalog=Media Bazaar;Persist Security Info=True;User ID=admin;Password=admin");

        private Email email;

        public ReportForm()
        {
            InitializeComponent();
            cbDefault.Checked = true; cbDefault.Enabled = false; cbForward.Enabled = false; textBoxEmail.Enabled = false; buttonEmail.Enabled = false; lblNote.Enabled = true;
        }

        private void CbEmail_MouseClick(object sender, MouseEventArgs e)
        {
            if (cbEmail.Checked) { cbDefault.Enabled = true; cbForward.Enabled = true; buttonEmail.Enabled = true; lblNote.Enabled = false ; }
            else { cbDefault.Enabled = false; cbForward.Enabled = false; textBoxEmail.Enabled = false; buttonEmail.Enabled = false; lblNote.Enabled = true; }
        }

        private void ButtonEmail_Click(object sender, EventArgs e)
        {
            if (cbDefault.Checked || cbForward.Checked)
            {
                Random digit = new Random();
                string id = digit.Next(0, 100000000).ToString("00000000");
                email = new Email("greffnoah@gmail.com");

                if (cbDefault.Checked)
                    email.SendEmail("greffnoah@gmail.com");

                if (cbForward.Checked)
                {
                    string s = textBoxEmail.Text;
                    for (int i = 0; i < s.Count(x => x == '@'); i++)
                    {
                        string m = s;
                        if (s.Contains(" "))
                            m = s.Remove(s.IndexOf(" "));
                        if (!string.IsNullOrEmpty(m))
                        {
                            email.ForwardEmail(m);
                            s = s.Substring(s.IndexOf(" ") + 1);
                        }
                    }
                }
            }
            else
                MessageBox.Show("No recipient found. Would you like to send the report to your account?", "No emails found", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
        }

        private void CbForward_MouseClick(object sender, MouseEventArgs e)
        {
            if (cbForward.Checked)
                textBoxEmail.Enabled = true;
            else
                textBoxEmail.Enabled = false;
        }

        private void ButtonDownload_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (SqlCommand cmd = new SqlCommand("SELECT Report FROM StoreShitDataReport", cnn))
            {
                cnn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
            }
            if(dt.Rows.Count > 0)
            {
                dgv.DataSource = dt;
            }
        }

        private void BtnUpload_Click(object sender, EventArgs e)
        {
            //SqlDataAdapter da = new SqlDataAdapter();
            //using (da.DeleteCommand = new SqlCommand("DELETE FROM StoreShitDataReport", cnn))
            //{
            //    cnn.Open();
            //    da.DeleteCommand.ExecuteNonQuery();
            //    cnn.Close();
            //}

            string path = "";
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
                path = ofd.FileName.ToString();

            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            byte[] binary = br.ReadBytes((int)fs.Length);

            string reportName = path.Substring(path.LastIndexOf(@"\") + 1);
            using (SqlCommand cmd = new SqlCommand("INSERT INTO StoreShitDataReport(Report_ID, Report) VALUES('" + reportName.Remove(reportName.Length - 4) + "', @file)", cnn))
            {
                cnn.Open();
                cmd.Parameters.Add(new SqlParameter("@file", SqlDbType.Binary)).Value = binary;
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }
    }
}
