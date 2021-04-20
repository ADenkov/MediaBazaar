using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdersApp
{
    [Serializable]
    public partial class ProductsTab : Form
    {
        private ProductCollection pc;
        private LocationCollection lc;
        private List<ProductOrderListing> poli;
        private int page;
        private int maxPage;

        public ProductsTab(ConnectSQL cnn)
        {
            InitializeComponent();
            pc = new ProductCollection(cnn);
            lc = new LocationCollection(cnn);
            poli = new List<ProductOrderListing>();
            LoadLocations();
            LoadProductsList();
        }

        private void LoadLocations()
        {
            cbLocation.Items.Clear();
            foreach (Location loc in lc.GetLocationList())
                if(loc.Type == LocationType.STORE)
                    cbLocation.Items.Add(loc.Address);
            cbLocation.SelectedIndex = 0;
            lblStore.Text = cbLocation.Text;
        }

        private void LoadProductsList()
        {
            List<ProductOrderListing> pols = new List<ProductOrderListing>();
            maxPage = pc.GetItemCount(cbLocation.SelectedItem.ToString()) / 50;
            if (pc.GetItemCount(cbLocation.Text) % 50 != 0)
                maxPage++;
            flpInStock.Controls.Clear();
            foreach (Product p in pc.GetProductPage("All", "All", "", page * 30, 30, cbLocation.SelectedItem.ToString()))
            {
                ProductOrderListing pol = new ProductOrderListing();
                pol.LoadLayout(true, p.Name, p.Brand, p.ProductID, pc.GetSpecificProductCount(cbLocation.SelectedItem.ToString(), p.ProductID), p.Icon, this);
                pols.Add(pol);
            }
            pols.Sort(new ProductSorter());
            foreach (ProductOrderListing p in pols)
                flpInStock.Controls.Add(p);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            foreach (ProductOrderListing pol in poli)
                if (!flpOrder.Controls.Contains(pol))
                {
                    ProductOrderListing p = new ProductOrderListing();
                    p.LoadLayout(false, pol.productName, pol.productBrand, pol.productID, pol.QTY, pol.productIcon, this);
                    flpOrder.Controls.Add(p);
                    flpInStock.Controls.Remove(pol);
                }
            poli.Clear();
            UpdatePrice();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            List<ProductOrderListing> polcleaner = new List<ProductOrderListing>();
            foreach (ProductOrderListing p in flpInStock.Controls)
                polcleaner.Add(p);
            foreach (ProductOrderListing pol in poli)
            {
                flpOrder.Controls.Remove(pol);
                ProductOrderListing p = new ProductOrderListing();
                p.LoadLayout(true, pol.productName, pol.productBrand, pol.productID, pc.GetSpecificProductCount(cbLocation.Text, pol.productID), pol.productIcon, this);
                polcleaner.Add(p);
            }
            polcleaner.Sort(new ProductSorter());
            flpInStock.Controls.Clear();
            foreach (ProductOrderListing p in polcleaner)
                flpInStock.Controls.Add(p);
            poli.Clear();
            UpdatePrice();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProductsList();
        }

        private void LblPrev_Click(object sender, EventArgs e)
        {
            if (page > 0)
            {
                page--;
                LoadProductsList();
                lblNext.Enabled = true;
                if (page == 0)
                    lblPrev.Enabled = false;
            }
        }

        private void LblNext_Click(object sender, EventArgs e)
        {
            if (page < maxPage)
            {
                page++;
                LoadProductsList();
                lblPrev.Enabled = true;
                if (page == maxPage - 1)
                    lblNext.Enabled = false;
            }
        }

        public void SetPOL(ProductOrderListing pol)
        {
            poli.Add(pol);
        }

        public void RemPOL(ProductOrderListing pol)
        {
            poli.Remove(pol);
        }

        public void UpdatePrice()
        {
            float price = 0;
            foreach (ProductOrderListing p in flpOrder.Controls)
                price += pc.GetProductByID(p.productID).Price * p.QTY;
            lblPrice.Text = price.ToString() + "EUR";
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            flpOrder.Controls.Clear();
            poli.Clear();
            LoadProductsList();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            flpOrder.Controls.Clear();
            poli.Clear();
            LoadProductsList();
            lblPrice.Text = "0.00 EUR";
        }

        private void BtnMakeOrder_Click(object sender, EventArgs e)
        {
            flpOrder.Controls.Clear();
            poli.Clear();
            lblPrice.Text = "0.00 EUR";
            MessageBox.Show("Your Order was successfully placed!");
        }
    }
}
