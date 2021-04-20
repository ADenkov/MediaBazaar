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

namespace Test_Data_Adder
{
    public partial class GenerateReportForm : Form
    {
        private SqlConnection cnn = new SqlConnection("Data Source=89.157.247.62;Initial Catalog=Media Bazaar;Persist Security Info=True;User ID=admin;Password=admin");
        private Report re;
        private Email em;

        public GenerateReportForm()
        {
            InitializeComponent();
        }

        private void GenerateReportForm_Load(object sender, EventArgs e)
        {
            cbDefault.Checked = true; pbIcon.ImageLocation = @"C:\Users\Noah\media-bazaar-group-7\Test Data Adder\pdficon.png";
            using (SqlCommand cmd = new SqlCommand("SELECT Store_Address From GeneralData WHERE HQ_Address IS NULL", cnn))
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    cbAddress.Items.Add(reader.GetString(0));
                cnn.Close();
            }
            pbSending.Visible = false;
        }

        private void CbForward_MouseClick(object sender, MouseEventArgs e)
        {
            if (cbForward.Checked) { tbEmail.Enabled = true; lblNote.Enabled = true; btnEmail.Enabled = true; tbEmail.Focus(); }
            else { tbEmail.Enabled = false; lblNote.Enabled = false; cbDefault.Checked = true; }
        }

        private void BtnEmail_Click(object sender, EventArgs e)
        {
            pbSending.Visible = true;
            for (int i = 0; i < 101; i++) { pbSending.Increment(1); Task.Delay(TimeSpan.FromMilliseconds(5)).Wait(); }
            if (!cbInventory.Checked && !cbInvoice.Checked && !cbEmployee.Checked)
                MessageBox.Show("No report type selected.", "No Report Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if(cbAddress.SelectedIndex == -1) { MessageBox.Show("No address selected for report(s).", "No Address Selected", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                em = new Email("greffnoah@gmail.com");
                re = new Report(em);
                re.Address = cbAddress.Text;
                if (cbInvoice.Checked) { re.InvoiceReport(); }
                if (cbDefault.Checked) { em.SendEmail("greffnoah@gmail.com"); }

                string email = tbEmail.Text;
                if (cbForward.Checked)
                    for (int i = 0; i < email.Count(c => c == '@'); i++)
                        if (email.Contains('@'))
                        {
                            em.ForwardEmail(email.Remove(email.IndexOf(' ')));
                            email = email.Substring(email.IndexOf(' ') + 1);
                        }
                        else { em.ForwardEmail(email); }
            }
            pbIcon.Focus();
            pbSending.Value = 0;
            pbSending.Visible = false;
        }

        private void CbDefault_MouseClick(object sender, MouseEventArgs e)
        {
            if (!cbDefault.Checked && !cbForward.Checked) { btnEmail.Enabled = false; }
            else { btnEmail.Enabled = true; }
        }

        private void CbNote_MouseClick(object sender, MouseEventArgs e)
        {
            if (cbNote.Checked) { tbNote.Enabled = true; tbNote.Focus(); }
            else { tbNote.Enabled = false; }
        }
    }
}
