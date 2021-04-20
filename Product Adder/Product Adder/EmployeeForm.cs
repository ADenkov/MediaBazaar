using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Product_Adder
{
    public partial class EmployeeForm : Form
    {
        private SqlConnection cnn = new SqlConnection("Data Source=89.157.247.62;Initial Catalog=Media Bazaar;Persist Security Info=True;User ID=admin;Password=admin");

        private Employee m;
        private Random r;
        private List<string> a;
        private string[] n;
        private string[] d;
        private string[] p;
        private string[] add;
        private string[] color;

        private bool responded;
        private int size;

        public EmployeeForm()
        {
            InitializeComponent();
            pbLoading.Visible = false;
            tbCount.Text = "100";
            color = new string[] { "46, 141, 255", "255, 61, 61", "254, 200, 20", "53, 219, 82" };
            m = new Employee();
            a = new List<string>();
            d = new string[] { "", "", "", "", "", "", "" ,"", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "Looking for better career prospects", "Change in career direction", "Company restructuring", "Has been fired due to inactivity", "Left for legal reasons" };
            p = Directory.GetFiles(@"C:\Users\Noah\media-bazaar-group-7\Product Adder\256 x 256");
            n = File.ReadAllLines(@"C:\Users\Noah\media-bazaar-group-7\Product Adder\names.csv");
            using (SqlCommand cmd = new SqlCommand("SELECT Address FROM LocationData", cnn))
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    a.Add(reader.GetString(0));
                cnn.Close();
            }
            add = File.ReadAllLines(@"C:\Users\Noah\media-bazaar-group-7\Product Adder\Address.csv");
            LoadEmployee();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (responded == true)
            {
                DoWork();
            }
            else
            {
                if (MessageBox.Show("Would you like to cycle through all files automatically?", "Automate Process?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    size = Convert.ToInt32(tbCount.Text);
                    tbCount.Enabled = false;
                    buttonAdd.Enabled = false;
                    pbLoading.Maximum = size;
                    pbLoading.Visible = true;
                    for (int i = size; i > 0; i--)
                    {
                        DoWork();
                        pbLoading.Increment(1);
                        Task.Delay(TimeSpan.FromMilliseconds(10)).Wait();
                    }
                    pbLoading.Visible = false;
                    MessageBox.Show("Process finished. Successfully added " + size.ToString() + " record(s) to the database.", "Process Finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    buttonAdd.Enabled = true;
                    responded = false;
                    tbCount.Enabled = true;
                }
                responded = true;
            }
        }

        private void DoWork()
        {
            LoadEmployee();
            r = new Random();
            string c = color[r.Next(color.Length)];
            char archived = 'N';
            char messages = 'Y';
            string dateLeft = "";
            if(tbDeported.Text != "") { archived = 'Y'; dateLeft = tbDateLeft.Text; }
            if (tbFirst.Text.Contains('A')) { messages = 'N'; }
            m.AddEmployee(tbID.Text, tbFirst.Text, tbLast.Text, cbGender.Text, cbJob.Text, tbEmail.Text, Convert.ToInt32(tbPhone.Text), tbAddress.Text, tbPassword.Text, tbStore.Text, tbDateJoin.Text, dateLeft, Convert.ToInt32(tbHours.Text), archived, tbDeported.Text, Convert.ToDecimal(tbSalary.Text), 'N', pbPicture.ImageLocation, c);
        }

        private void LoadEmployee()
        {
            r = new Random();
            tbPassword.Clear();
            pbPicture.ImageLocation = p[r.Next(p.Length)];
            tbFirst.Text = n[r.Next(n.Length)];
            tbLast.Text = n[r.Next(n.Length)];
            cbJob.SelectedIndex = r.Next(cbJob.Items.Count);
            cbGender.SelectedIndex = r.Next(cbGender.Items.Count);
            tbEmail.Text = tbLast.Text + "." + tbFirst.Text + "@gmail.com";
            tbPhone.Text = r.Next(1000000000).ToString("00000000000");
            string address = add[r.Next(add.Length)];
            tbAddress.Text = address.Remove(address.Length - 2);
            char[] alphabetNumber = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            for (int z = 0; z < 4; z++)
                tbPassword.Text += alphabetNumber[r.Next(0, 36)];
            tbStore.Text = a[r.Next(a.Count)];
            tbDateLeft.Text = DateTime.Today.AddSeconds(r.Next(31560000)).ToString();
            tbDateJoin.Text = (DateTime.Now - TimeSpan.FromSeconds(r.Next(31560000))).ToString("yyyy-MM-dd");
            tbHours.Text = r.Next(5, 120).ToString();
            tbID.Text = tbFirst.Text.Remove(2).ToUpper() + tbLast.Text.Remove(2).ToUpper() + r.Next(10, 100).ToString("00");
            tbDeported.Text = d[r.Next(d.Length)];
            if(cbJob.SelectedIndex == 0) { tbSalary.Text = r.Next(4000, 8000).ToString() + ".00"; }
            else if(cbJob.SelectedIndex == 1) { tbSalary.Text = r.Next(2500, 5000).ToString() + ".00"; }
            else if (cbJob.SelectedIndex == 2) { tbSalary.Text = r.Next(1500, 3000).ToString() + ".00"; }
            else if (cbJob.SelectedIndex == 3) { tbSalary.Text = r.Next(1000, 2000).ToString() + ".00"; }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadEmployee();
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            m.RemoveData();
        }
    }
}
