using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaarApp
{
    public partial class NewProductForm : Form
    {
        private ProductCollection pc;
        private LocationCollection lc;
        private EmployeeProfile ep;
        private Random r;
        private string path;

        public NewProductForm(ConnectSQL cnn, EmployeeProfile ep)
        {
            InitializeComponent();
            this.ep = ep;
            pc = new ProductCollection(cnn);
            lc = new LocationCollection(cnn, new EmployeeCollection(cnn));
        }

        private void NewProductForm_Load(object sender, EventArgs e)
        {
            foreach (Location loc in lc.GetLocationList())
                cbLocation.Items.Add(loc.Address);
            for (int i = 0; i < cbLocation.Items.Count; i++)
                if (cbLocation.Items[i].ToString() == ep.Store)
                    cbLocation.SelectedIndex = i;
            pc.SetDepANDBra(cbLocation.Text);
            foreach (string d in pc.GetDepartements())
                cbDepartment.Items.Add(d);
            foreach (string b in pc.GetBrands())
                cbBrand.Items.Add(b);
            cbCondtion.SelectedIndex = 0;
        }

        private void CbAddDepartement_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAddDepartement.Checked)
            {
                tbNewDepartment.Enabled = true;
                cbDepartment.Enabled = false;
            }
            else
            {
                tbNewDepartment.Enabled = false;
                cbDepartment.Enabled = true;
            }
        }

        private void CbNewBrand_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNewBrand.Checked)
            {
                tbNewBrand.Enabled = true;
                cbBrand.Enabled = false;
            }
            else
            {
                tbNewBrand.Enabled = false;
                cbBrand.Enabled = true;
            }
        }

        private bool CheckInput()
        {
            if (cbLocation.Text == "" && tbName.Text == "" && int.TryParse(tbPrice.Text, out int n) && int.TryParse(tbUnits.Text, out int num))
                return false;
            if (cbAddDepartement.Checked)
                if (tbNewDepartment.Text == "")
                    return false;
            if(!cbAddDepartement.Checked)
                if (cbDepartment.SelectedIndex == -1)
                    return false;
            if (cbNewBrand.Checked)
                if (tbNewBrand.Text == "")
                    return false;
            if(!cbNewBrand.Checked)
                if (cbBrand.SelectedIndex == -1)
                    return false;
            return true;
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                r = new Random();
                if (path == null)
                    path = @"C:\Users\Noah\media-bazaar-group-7\MediaBazaarApp\Resourses\noimage.png";
                string serial = "";
                if (tbSerial.Text != "")
                    serial = tbSerial.Text;
                int counter = 1;
                if (tbUnits.Text != "")
                    if(int.TryParse(tbUnits.Text, out int count))
                        count = Convert.ToInt32(tbUnits.Text);
                string productID = "";
                if (tbName.TextLength >= 4)
                    productID = tbName.Text.Remove(3).ToUpper() + r.Next(1000).ToString("0000");
                else
                    productID = tbName.Text.ToUpper() + r.Next(1000).ToString("0000");
                string dep = cbDepartment.Text;
                if (cbAddDepartement.Checked)
                    dep = tbNewDepartment.Text;
                string bra = cbBrand.Text;
                if (cbNewBrand.Checked)
                    bra = tbNewBrand.Text;
                float ind = 0;
                if (tbDiscount.Text != "")
                    ind = (float)(Convert.ToDouble(tbDiscount.Text) / 100);
                for (int i = 0; i < counter; i++)
                    pc.AddData(productID, dep, tbSerial.Text, bra, tbName.Text, tbDescription.Text, (float)Convert.ToDouble(tbPrice.Text), ind, "", cbCondtion.Text, DateTime.Now.ToString(), 'N', cbLocation.Text, path);
                MessageBox.Show("Product(s) Successfully Added.", "Product Submited.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Some Fields are missing, please make sure all required fields are entered correctly.", "Failed to Submit.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void PbIcon_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
                path = ofd.FileName.ToString();
            if(path != "")
                pbIcon.ImageLocation = path;
        }

        private void EnableUnits()
        {
            if (tbSerial.TextLength > 0)
            {
                tbUnits.Enabled = false;
                label5.Enabled = false;
            }
            else
            {
                tbUnits.Enabled = true;
                label5.Enabled = true;
            }
            if(tbUnits.Text != "1")
            {
                tbSerial.Enabled = false;
                label10.Enabled = false;
            }
            else
            {
                tbSerial.Enabled = true;
                label10.Enabled = true;
            }
        }

        private void DefinedControls_Leave(object sender, EventArgs e)
        {
            EnableUnits();
        }

        private void DefinedControls_Down(object sender, KeyEventArgs e)
        {
            EnableUnits();
        }

        private void TbNewBrand_MouseLeave(object sender, EventArgs e)
        {
            string s = tbNewBrand.Text;
            tbNewBrand.Text = s.ToUpper();
        }
    }
}
