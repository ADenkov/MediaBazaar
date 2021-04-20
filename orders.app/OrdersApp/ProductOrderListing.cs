using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdersApp
{
    public partial class ProductOrderListing : UserControl
    {
        private ProductsTab pt;
        private int[] unfocused;
        private int[] focused;
        private bool tracked;

        public string productName;
        public string productID;
        public string productBrand;
        public int QTY;
        public Image productIcon;

        public ProductOrderListing()
        {
            InitializeComponent();
        }

        public void LoadLayout(bool left, string name, string brand, string sku, int qty, Image icon, ProductsTab pt)
        {
            unfocused = new int[3];
            focused = new int[3];
            lblName.Text = name;
            productName = name;
            lblSKU.Text = sku;
            productID = sku;
            lblBrand.Text = brand;
            productBrand = brand;
            QTY = qty;
            pbIcon.Image = icon;
            productIcon = icon;
            this.pt = pt;
            if (left)
            {
                lblQuantity.Visible = true;
                lblQuantity.Text = qty.ToString();
                if (qty < 10)
                {
                    unfocused[0] = 255; unfocused[1] = 200; unfocused[2] = 200;
                    focused[0] = 255; focused[1] = 220; focused[2] = 220;
                    lblQuantity.ForeColor = Color.Crimson;
                    BackColor = Color.FromArgb(unfocused[0], unfocused[1], unfocused[2]);
                }
                else
                {
                    for (int i = 0; i < 3; i++)
                    {
                        unfocused[i] = 255;
                        focused[i] = 245;
                    }
                }
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    unfocused[i] = 255;
                    focused[i] = 245;
                }
                cbCount.Visible = true;
                for (int i = 1; i <= 100; i++)
                    cbCount.Items.Add(i);
                cbCount.SelectedIndex = 0;
                QTY = 1;
            }

        }

        private void AllControls_Enter(object sender, EventArgs e)
        {
            if(!tracked)
                BackColor = Color.FromArgb(focused[0], focused[1], focused[2]);
        }

        private void AllControls_Leave(object sender, EventArgs e)
        {
            if(! tracked)
                BackColor = Color.FromArgb(unfocused[0], unfocused[1], unfocused[2]);
        }

        private void AllControls_Click(object sender, EventArgs e)
        {
            if (!tracked)
            {
                pt.SetPOL(this);
                BackColor = Color.Silver;
                tracked = true;
            }
            else
            {
                pt.RemPOL(this);
                BackColor = Color.FromArgb(unfocused[0], unfocused[1], unfocused[2]);
                tracked = false;
            }
        }

        private void CbCount_SelectionChangeCommitted(object sender, EventArgs e)
        {
            QTY = Convert.ToInt32(cbCount.Text);
            pt.UpdatePrice();
        }
    }
}
