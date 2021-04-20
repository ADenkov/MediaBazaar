using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product_Adder
{
    public partial class AnnoucementForm : Form
    {
        private SqlConnection cnn = new SqlConnection("Data Source=89.157.247.62;Initial Catalog=Media Bazaar;Persist Security Info=True;User ID=admin;Password=admin");
        private Annoucement ann;
        private Random r;
        private List<string> subject;

        public AnnoucementForm()
        {
            InitializeComponent();
            ann = new Annoucement();
            LoadStore();
            subject = new List<string>();
            subject.Add("Regarding Store inventory.");
            subject.Add("Reminding of the store code of conduct");
            subject.Add("This Fridays Party!!!");
            subject.Add("Extra work-hours needed for sales");
            subject.Add("Keep offices clean");
            subject.Add("Review of report by end of week");
            GenerateData();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Would you like to cycle through all files automatically?", "Automate Process?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                r = new Random();
                for (int i = 0; i < Convert.ToInt32(tbCount.Text); i++)
                {
                    cbLocation.SelectedIndex = r.Next(cbLocation.Items.Count);
                    string to = cbLocation.Text;
                    cbLocation.SelectedIndex = r.Next(cbLocation.Items.Count);
                    string from = cbLocation.Text;
                    ann.AddAnnoucement(cbDepartment.Text, cbAdm.Checked, cbMan.Checked, cbFlo.Checked, cbWar.Checked, tbMessage.Text, tbSubject.Text, DateTime.Now.ToString("yyyy-MM-dd"), to, from);
                    GenerateData();
                }
            }
        }

        private void LoadStore()
        {
            using (SqlCommand cmd = new SqlCommand("SELECT Address FROM LocationData", cnn))
            {
                cnn.Open();
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                    cbLocation.Items.Add(r.GetString(0));
                cnn.Close();
            }
        }

        private void GenerateData()
        {
            r = new Random();
            List<CheckBox> cbs = new List<CheckBox>();
            var client = new WebClient();
            string text = client.DownloadString("https://randomtextgenerator.com/");
            string p = text.Substring((text.IndexOf("generatedtext") + 15), (text.IndexOf("</textarea>") - text.IndexOf("generatedtext") - 18));
            tbMessage.Text = p.Substring(0, p.IndexOf("\n\r"));
            cbDepartment.SelectedIndex = r.Next(cbDepartment.Items.Count);
            cbLocation.SelectedIndex = r.Next(cbLocation.Items.Count);
            tbSubject.Text = subject[r.Next(subject.Count)];
            foreach (CheckBox cb in this.Controls.OfType<CheckBox>())
                cbs.Add(cb);
            for (int i = 0; i < 3; i++)
            {
                var cb = cbs[r.Next(cbs.Count)];
                cb.Checked = true;
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ann.RemoveData();
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            Form etf = new EmailTestForm();
            etf.Show();
        }
    }
}
