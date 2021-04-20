using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaarApp
{
    public partial class ProductListing : UserControl
    {
        private StocksForm sf;
        public string ID { get; private set; }

        public ProductListing()
        {
            InitializeComponent();
        }

        public void LoadLayout(string name, string SKU, string department, string brand, int qty, float price, Image image, StocksForm sf)
        {
            this.sf = sf;
            lblName.Text = name;
            lblSKU.Text = SKU;
            ID = SKU;
            lblPrice.Text = price.ToString("0.00");
            if (department.Length > 11)
                department = department.Remove(11) + ".";
            lblDepartment.Text = department;
            lblBrand.Text = brand;
            lblQuantity.Text = qty.ToString();
            pbIcon.Image = image;
        }

        private void AllControls_Enter(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
        }

        private void AllControls_Leave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void AllControls_Click(object sender, EventArgs e)
        {
            sf.ShowProduct(this);
        }
    }
}
