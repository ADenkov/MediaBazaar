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
using System.Text.RegularExpressions;

namespace Product_Adder
{
    public partial class ProductForm : Form
    {
        private SqlConnection cnn = new SqlConnection("Data Source=89.157.247.62;Initial Catalog=Media Bazaar;Persist Security Info=True;User ID=admin;Password=admin");

        private Product p;
        private Random r;
        private List<string> f;
        private List<string> a;
        private string[] fp;
        private bool responded;
        private int total;
        private int size;

        private List<string> cam;
        private List<string> dis;
        private List<string> hom;
        private List<string> lap;
        private List<string> mon;
        private List<string> pla;
        private List<string> reg;
        private List<string> sma;
        private List<string> tab;
        private List<string> tel;
        private List<string> vac;
        private List<string> was;
        private List<string> wir;
        private List<string> xbo;

        public ProductForm()
        {
            InitializeComponent();
            pbLoading.Visible = false;
            nudDegradation.Value = 20;
            cam = new List<string>();
            dis = new List<string>();
            hom = new List<string>();
            lap = new List<string>();
            mon = new List<string>();
            pla = new List<string>();
            reg = new List<string>();
            sma = new List<string>();
            tab = new List<string>();
            tel = new List<string>();
            vac = new List<string>();
            was = new List<string>();
            wir = new List<string>();
            xbo = new List<string>();
            f = new List<string>();
            a = new List<string>();
            p = new Product();
            GetAllFileName();
            LoadProduct();
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
                    buttonAdd.Enabled = false;
                    pbLoading.Visible = true;
                    for (int i = 0; i < size; i++)
                    {
                        DoWork();
                        pbLoading.Increment(1);
                    }
                }
                responded = true;
            }
        }

        private void DoWork()
        {
            if(f.Count != 0)
            {
                r = new Random();
                for (int y = 0; y < r.Next(5, 50); y++)
                {
                    string name = tbName.Text;
                    RegexOptions options = RegexOptions.None;
                    Regex regex = new Regex("[ ]{2,}", options);
                    name = regex.Replace(name, " ");
                    tbSerial.Clear();
                    char[] alphabetNumber = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                    for (int z = 0; z < 10; z++)
                        tbSerial.Text += alphabetNumber[r.Next(0, 36)];
                    p.AddProduct(tbProductID.Text, tbDepartment.Text, tbSerial.Text, tbBrand.Text, name, tbDescription.Text, (float)nudPrice.Value, (float)nudDiscount.Value, tbNote.Text, cbCondition.Text, tbDate.Text, 'N', tbAddress.Text, pbPicture.ImageLocation);
                    if (cbCondition.SelectedIndex != 0 && nudDegradation.Value < r.Next(100)) { cbCondition.SelectedIndex = 0; nudDiscount.Value = 1; }
                    total++;
                }
                LoadProduct();
            }
            else
            {
                pbLoading.Visible = false;
                MessageBox.Show("Process finished. Successfully added " + total.ToString() + " record(s) to the database.", "Process Finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
                buttonAdd.Enabled = true;
                responded = false;
            }
        }

        private void LoadProduct()
        {
            tbSerial.Clear();
            r = new Random();
            int p = r.Next(100);
            string fn = f[0].Substring(f[0].LastIndexOf("Department") + 11);
            fn = fn.Remove(fn.Length - 4);
            string ban = fn.Remove(0, fn.IndexOf(@"\") + 1);
            string b = "";
            b = ban.Remove(ban.IndexOf('-'));
            string n = ban.Substring(b.Length + 1).Replace('-', ' ');
            pbPicture.ImageLocation = f[0];
            tbDepartment.Text = fn.Remove(fn.IndexOf(@"\"));
            tbBrand.Text = b;
            tbName.Text = n;
            tbAddress.Text = a[r.Next(4)];
            string BID;
            if(b.Length <= 3) { BID = b; } else { BID = b.Remove(3).ToUpper(); }
            tbProductID.Text = tbDepartment.Text.Remove(3).ToUpper() + "-" + BID + r.Next(1000).ToString("000");
            if (p <= nudDegradation.Value)
            {
                cbCondition.SelectedIndex = r.Next(1, 5);
                nudDiscount.Value = (decimal)r.Next(50, 100) / 100;
            }
            else
            {
                cbCondition.SelectedIndex = 0;
                nudDiscount.Value = 1;
            }
            tbDate.Text = DateTime.Today.AddSeconds(r.Next(31560000)).ToString("yyyy-MM-dd");
            if (tbDepartment.Text == "Camera") { nudPrice.Value = (decimal)r.Next(5000, 30000) / 100; tbDescription.Text = cam[r.Next(5)]; }
            else if (tbDepartment.Text == "Dishwasher") { nudPrice.Value = (decimal)r.Next(20000, 50000) / 100; tbDescription.Text = dis[r.Next(5)]; }
            else if (tbDepartment.Text == "Home Cinema") { nudPrice.Value = (decimal)r.Next(20000, 40000) / 100; tbDescription.Text = hom[r.Next(5)]; }
            else if (tbDepartment.Text == "Laptop") { nudPrice.Value = (decimal)r.Next(80000, 250000) / 100; tbDescription.Text = lap[r.Next(5)]; }
            else if (tbDepartment.Text == "Monitor") { nudPrice.Value = (decimal)r.Next(10000, 40000) / 100; tbDescription.Text = mon[r.Next(5)]; }
            else if (tbDepartment.Text == "Playstation 4") { nudPrice.Value = (decimal)r.Next(8000, 15000) / 100; tbDescription.Text = pla[r.Next(5)]; }
            else if (tbDepartment.Text == "Refrigerator") { nudPrice.Value = (decimal)r.Next(50000, 100000) / 100; tbDescription.Text = reg[r.Next(5)]; }
            else if (tbDepartment.Text == "Smart Phone") { nudPrice.Value = (decimal)r.Next(30000, 100000) / 100; tbDescription.Text = sma[r.Next(5)]; }
            else if (tbDepartment.Text == "Tablet") { nudPrice.Value = (decimal)r.Next(20000, 50000) / 100; tbDescription.Text = tab[r.Next(5)]; }
            else if (tbDepartment.Text == "Television") { nudPrice.Value = (decimal)r.Next(30000, 120000) / 100; tbDescription.Text = tel[r.Next(5)]; }
            else if (tbDepartment.Text == "Vaccum Cleaner") { nudPrice.Value = (decimal)r.Next(5000, 10000) / 100; tbDescription.Text = vac[r.Next(5)]; }
            else if (tbDepartment.Text == "Washing Machine") { nudPrice.Value = (decimal)r.Next(20000, 40000) / 100; tbDescription.Text = was[r.Next(5)]; }
            else if (tbDepartment.Text == "Wireless Speaker") { nudPrice.Value = (decimal)r.Next(10000, 25000) / 100; tbDescription.Text = wir[r.Next(5)]; }
            else if (tbDepartment.Text == "Xbox") { nudPrice.Value = (decimal)r.Next(5000, 15000) / 100; tbDescription.Text = xbo[r.Next(5)]; }
            f.RemoveAt(0);
        }

        private void GetAllFileName()
        {
            cam = File.ReadAllLines(@"C:\Users\Noah\media-bazaar-group-7\Product Adder\Department\Camera.txt").ToList();
            dis = File.ReadAllLines(@"C:\Users\Noah\media-bazaar-group-7\Product Adder\Department\Dishwasher.txt").ToList();
            hom = File.ReadAllLines(@"C:\Users\Noah\media-bazaar-group-7\Product Adder\Department\Home Cinema.txt").ToList();
            lap = File.ReadAllLines(@"C:\Users\Noah\media-bazaar-group-7\Product Adder\Department\Laptop.txt").ToList();
            mon = File.ReadAllLines(@"C:\Users\Noah\media-bazaar-group-7\Product Adder\Department\Monitor.txt").ToList();
            pla = File.ReadAllLines(@"C:\Users\Noah\media-bazaar-group-7\Product Adder\Department\Playstation 4.txt").ToList();
            reg = File.ReadAllLines(@"C:\Users\Noah\media-bazaar-group-7\Product Adder\Department\Refrigerator.txt").ToList();
            sma = File.ReadAllLines(@"C:\Users\Noah\media-bazaar-group-7\Product Adder\Department\Smart Phone.txt").ToList();
            tab = File.ReadAllLines(@"C:\Users\Noah\media-bazaar-group-7\Product Adder\Department\Tablet.txt").ToList();
            tel = File.ReadAllLines(@"C:\Users\Noah\media-bazaar-group-7\Product Adder\Department\Television.txt").ToList();
            vac = File.ReadAllLines(@"C:\Users\Noah\media-bazaar-group-7\Product Adder\Department\Vacuum Cleaner.txt").ToList();
            was = File.ReadAllLines(@"C:\Users\Noah\media-bazaar-group-7\Product Adder\Department\Washing Machine.txt").ToList();
            wir = File.ReadAllLines(@"C:\Users\Noah\media-bazaar-group-7\Product Adder\Department\Wireless Speaker.txt").ToList();
            xbo = File.ReadAllLines(@"C:\Users\Noah\media-bazaar-group-7\Product Adder\Department\Xbox.txt").ToList();

            using (SqlCommand cmd = new SqlCommand("SELECT Address FROM LocationData WHERE Purpose = 'Store'", cnn))
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    a.Add(reader.GetString(0));
                cnn.Close();
            }

            fp = Directory.GetFiles(@"C:\Users\Noah\media-bazaar-group-7\Product Adder\Department\Camera");
            foreach (string file in fp) { f.Add(file); }
            fp = Directory.GetFiles(@"C:\Users\Noah\media-bazaar-group-7\Product Adder\Department\Dishwasher");
            foreach (string file in fp) { f.Add(file); }
            fp = Directory.GetFiles(@"C:\Users\Noah\media-bazaar-group-7\Product Adder\Department\Home Cinema");
            foreach (string file in fp) { f.Add(file); }
            fp = Directory.GetFiles(@"C:\Users\Noah\media-bazaar-group-7\Product Adder\Department\Laptop");
            foreach (string file in fp) { f.Add(file); }
            fp = Directory.GetFiles(@"C:\Users\Noah\media-bazaar-group-7\Product Adder\Department\Monitor");
            foreach (string file in fp) { f.Add(file); }
            fp = Directory.GetFiles(@"C:\Users\Noah\media-bazaar-group-7\Product Adder\Department\Playstation 4");
            foreach (string file in fp) { f.Add(file); }
            fp = Directory.GetFiles(@"C:\Users\Noah\media-bazaar-group-7\Product Adder\Department\Refrigerator");
            foreach (string file in fp) { f.Add(file); }
            fp = Directory.GetFiles(@"C:\Users\Noah\media-bazaar-group-7\Product Adder\Department\Smart Phone");
            foreach (string file in fp) { f.Add(file); }
            fp = Directory.GetFiles(@"C:\Users\Noah\media-bazaar-group-7\Product Adder\Department\Tablet");
            foreach (string file in fp) { f.Add(file); }
            fp = Directory.GetFiles(@"C:\Users\Noah\media-bazaar-group-7\Product Adder\Department\Television");
            foreach (string file in fp) { f.Add(file); }
            fp = Directory.GetFiles(@"C:\Users\Noah\media-bazaar-group-7\Product Adder\Department\Vacuum Cleaner");
            foreach (string file in fp) { f.Add(file); }
            fp = Directory.GetFiles(@"C:\Users\Noah\media-bazaar-group-7\Product Adder\Department\Washing Machine");
            foreach (string file in fp) { f.Add(file); }
            fp = Directory.GetFiles(@"C:\Users\Noah\media-bazaar-group-7\Product Adder\Department\Wireless Speaker");
            foreach (string file in fp) { f.Add(file); }
            fp = Directory.GetFiles(@"C:\Users\Noah\media-bazaar-group-7\Product Adder\Department\Xbox");
            foreach (string file in fp) { f.Add(file); }
            size = f.Count;
            pbLoading.Maximum = size;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            p.RemoveData();
        }
    }
}
