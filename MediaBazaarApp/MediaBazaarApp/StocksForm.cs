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
    public partial class StocksForm : Form
    {
        private ProductCollection pc;
        private LocationCollection lc;
        private EmployeeProfile ep;
        private DeliveryCollection dc;
        private int page;
        private int maxPage;
        private int itemPerPage;

        public StocksForm(ConnectSQL cnn, EmployeeProfile ep)
        {
            InitializeComponent();
            this.ep = ep;
            dc = new DeliveryCollection(cnn, ep);
            pc = new ProductCollection(cnn);
            lc = new LocationCollection(cnn, new EmployeeCollection(cnn));
        }

        private void StocksForm_Load(object sender, EventArgs e)
        {
            foreach (Location l in lc.GetFilterdData(LocationType.STORE, ""))
                cbLocation.Items.Add(l.Address);
            for (int i = 0; i < cbLocation.Items.Count; i++)
                if (cbLocation.Items[i].ToString() == ep.Store)
                    cbLocation.SelectedIndex = i;
            itemPerPage = 20;
            LoadNewStore();
            LoadProductsList();
        }

        private void LoadProductsList()
        {
            flpProduct.Controls.Clear();
            lc.GetLocationData(cbLocation.Text);
            lblStore.Text = lc.LocationData().Address;
            lblStoreTel.Text = "+" + lc.LocationData().Tel.ToString();
            LocationCapacity.Maximum = lc.LocationData().Capacity;
            LocationCapacity.Value = lc.LocationData().SpaceUsed;
            lblUsed.Text = $"{lc.LocationData().SpaceUsed} / {lc.LocationData().Capacity} used";
            lblFree.Text = $"{lc.LocationData().Capacity - lc.LocationData().SpaceUsed} free";
            foreach (Product p in pc.GetProductPage(cbDepartment.Text, cbBrand.Text, tbSearchProduct.Text, page * Convert.ToInt32(itemPerPage), Convert.ToInt32(itemPerPage), cbLocation.Text))
            {
                ProductListing pl = new ProductListing();
                pl.LoadLayout(p.Name, p.ProductID, p.Brand, p.Department, pc.GetSpecificProductCount(cbLocation.Text, p.ProductID), p.Price, p.Icon, this);
                flpProduct.Controls.Add(pl);
            }
            maxPage = pc.GetItemCount(cbLocation.Text) / Convert.ToInt32(itemPerPage);
            if (pc.GetItemCount(cbLocation.Text) % Convert.ToInt32(itemPerPage) != 0)
                maxPage++;
            lblPage.Text = $"{page + 1} / {maxPage}";
        }

        private void LoadNewStore()
        {
            foreach (Button b in pMain.Controls.OfType<Button>())
                b.Font = new Font("Century Gothic", 8F, FontStyle.Regular);
            pc.SetDepANDBra(cbLocation.Text);
            cbDepartment.Items.Clear();
            cbBrand.Items.Clear();
            cbDepartment.Items.Add("All");
            cbBrand.Items.Add("All");
            foreach (string brand in pc.GetBrands())
                cbBrand.Items.Add(brand);
            foreach (string departement in pc.GetDepartements())
                cbDepartment.Items.Add(departement);
            cbDepartment.SelectedIndex = 0;
            cbBrand.SelectedIndex = 0;
            btn20.Font = new Font("Century Gothic", 8F, FontStyle.Bold);
            itemPerPage = 20;
            flpOrders.Controls.Clear();
            foreach (Delivery d in dc.GetDeliveries())
                if (d.Store == cbLocation.Text)
                {
                    OrderListing ol = new OrderListing();
                    ol.LoadLayout(d.OrderID, d.ApprovedDate, d.DeliveryDate);
                    flpOrders.Controls.Add(ol);
                }
            pProduct.Visible = false;
        }

        private void SelectedFiltersCommited(object sender, EventArgs e)
        {
            foreach(Button b in pMain.Controls.OfType<Button>())
                if (b.Focused)
                {
                    itemPerPage = Convert.ToInt32(b.Name.Substring(3));
                    b.Font = new Font("Century Gothic", 8F, FontStyle.Bold);
                }
                else
                    b.Font = new Font("Century Gothic", 8F, FontStyle.Regular);
            page = 0;
            LoadProductsList();
            btnPrevious.Enabled = false;
            if (flpProduct.Controls.Count < itemPerPage)
            {
                maxPage = 1;
                btnNext.Enabled = false;
                btn20.Font = new Font("Century Gothic", 8F, FontStyle.Bold);
            }
            else
                btnNext.Enabled = true;
            lblPage.Text = $"{page + 1} / {maxPage}";
        }

        private void CbLocation_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadNewStore();
            LoadProductsList();
        }

        private void TbSearchProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                LoadProductsList();
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            if (page > 0)
            {
                page--;
                LoadProductsList();
                btnNext.Enabled = true;
                if (page == 0)
                    btnPrevious.Enabled = false;
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (page < maxPage)
            {
                page++;
                LoadProductsList();
                btnPrevious.Enabled = true;
                if (page == maxPage - 1)
                    btnNext.Enabled = false;
            }
        }

        public void ShowProduct(ProductListing pl)
        {
            pProduct.Visible = true;
            flpSpecificProduct.Controls.Clear();
            lblProductName.Text = pc.GetProductByID(pl.ID).Name;
            lblProductDescription.Text = pc.GetProductByID(pl.ID).Description;
            lblProductDepartment.Text = pc.GetProductByID(pl.ID).Department;
            lblProductSKU.Text = pc.GetProductByID(pl.ID).ProductID;
            lblProdcutBrand.Text = pc.GetProductByID(pl.ID).Brand;
            pbProductIcon.Image = pc.GetProductByID(pl.ID).Icon;
            lblProductInStock.Text = pc.GetSpecificProductCount(cbLocation.Text, pl.ID).ToString();
            foreach (Product p in pc.GetListProductByIDByStore(pl.ID, cbLocation.Text))
            {
                SpecificProductLisitng spl = new SpecificProductLisitng();
                spl.LoadLayout(p.Serial, p.Condition, p.Price, p.Index, p.DateAdded, p.Icon);
                flpSpecificProduct.Controls.Add(spl);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            pProduct.Visible = false;
        }
    }
}
