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
    public partial class OrdersForm : Form
    {
        private DeliveryCollection dc;
        private LocationCollection lc;
        private EmployeeProfile ep;
        private ProductCollection pc;
        private SupplierCollection sc;
        private List<ProductOrderListing> poli;
        private Random r;
        private int page;
        private int maxPage;

        public OrdersForm(ConnectSQL cnn, EmployeeProfile ep)
        {
            InitializeComponent();
            this.ep = ep;
            pc = new ProductCollection(cnn);
            sc = new SupplierCollection(cnn);
            dc = new DeliveryCollection(cnn, ep);
            lc = new LocationCollection(cnn, new EmployeeCollection(cnn));
            poli = new List<ProductOrderListing>();
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            lc.GetLocationData(ep.Store);
            lblStore.Text = lc.LocationData().Address;
            lblStoreTel.Text = "+" + lc.LocationData().Tel.ToString();
            cbDefault.Text = $"Default ({ep.Email})";
            LoadProductsList();
            LoadSuppliers();
            dtpDelivery.Value = DateTime.Now.AddDays(7);
        }

        private void LoadSuppliers()
        {
            foreach (Supplier s in sc.GetSuppliers())
                cbSupplier.Items.Add(String.Format("{0} - {1} ({2})", s.Name, s.ID, s.Address));
            if (sc.GetSuppliers().Count == 0)
                cbSupplier.Enabled = false;
        }

        private void LoadProductsList()
        {
            List<ProductOrderListing> pols = new List<ProductOrderListing>();
            maxPage = pc.GetItemCount(ep.Store) / 50;
            if (pc.GetItemCount(ep.Store) % 50 != 0)
                maxPage++;
            lblPage.Text = $"{page + 1} / {maxPage}";
            flpInStock.Controls.Clear();
            foreach (Product p in pc.GetProductPage("All", "All", "", page * 30, 30, ep.Store))
            {
                ProductOrderListing pol = new ProductOrderListing();
                pol.LoadLayout(true, p.Name, p.Brand, p.ProductID, pc.GetSpecificProductCount(ep.Store, p.ProductID), p.Icon, this);
                pols.Add(pol);
            }
            pols.Sort(new ProductSorter());
            foreach (ProductOrderListing p in pols)
                flpInStock.Controls.Add(p);
        }

        private void CbForward_CheckedChanged(object sender, EventArgs e)
        {
            if (cbForward.Checked)
            {
                tbForwardEmail.Enabled = true;
                lblNote.Enabled = true;
            }
            else
            {
                tbForwardEmail.Enabled = false;
                lblNote.Enabled = false;
            }
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

        public void SetPOL(ProductOrderListing pol)
        {
            poli.Add(pol);
        }

        public void RemPOL(ProductOrderListing pol)
        {
            poli.Remove(pol);
        }

        private void UpdatePrice()
        {
            float price = 0;
            foreach (ProductOrderListing p in flpOrder.Controls)
                price += pc.GetProductByID(p.productID).Price;
            lblTotal.Text = price.ToString() + "EUR";
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
                p.LoadLayout(true, pol.productName, pol.productBrand, pol.productID, pc.GetSpecificProductCount(ep.Store, pol.productID), pol.productIcon, this);
                polcleaner.Add(p);
            }
            polcleaner.Sort(new ProductSorter());
            flpInStock.Controls.Clear();
            foreach (ProductOrderListing p in polcleaner)
                flpInStock.Controls.Add(p);
            poli.Clear();
            UpdatePrice();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            flpOrder.Controls.Clear();
            poli.Clear();
            LoadProductsList();
        }

        private void BtnSubmitOrder_Click(object sender, EventArgs e)
        {
            if(flpOrder.Controls.Count != 0)
            {
                if(cbSupplier.SelectedIndex != -1)
                {
                    r = new Random();
                    string note = "N/A";
                    if (tbNote.Text != "")
                        note = tbNote.Text;
                    dc.NewDelivery($"IN-{r.Next(100000).ToString("000000")}", dtpDelivery.Value, DateTime.Now, $"{ep.First} {ep.Last}", ep.Store, note);
                    foreach (ProductOrderListing p in flpOrder.Controls)
                        dc.AddOrderItem(p.productID, p.productName, p.QTY, pc.GetProductByID(p.productID).Price);
                    dc.MakeOrderReport(ep.Store);
                    dc.SendEmail(ep.Email);
                    string email = tbForwardEmail.Text;
                    if (cbForward.Checked)
                    {
                        int count = 0;
                        foreach (char c in tbForwardEmail.Text)
                            if (c == '@')
                                count++;

                        for (int i = 0; i < count; i++)
                            if (email.Contains('@') && count > 1)
                            {
                                dc.ForwardEmail(email.Remove(email.IndexOf(' ')));
                                email = email.Substring(email.IndexOf(' ') + 1);
                            }
                            else { dc.ForwardEmail(email); }
                    }
                    MessageBox.Show("Order (" + dc.GetDeliveryInfo().OrderID + ") has been succesffully submittied. \n\rAn email has been sent contain an overview of the order.", "Order Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    flpOrder.Controls.Clear();
                    LoadProductsList();
                }
                else
                    MessageBox.Show("No supplier selected.", "Missing Supplier", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TbNote_KeyDown(object sender, KeyEventArgs e)
        {
            if(tbNote.TextLength > 200)
            {
                string s = tbNote.Text;
                s = s.Remove(200);
                tbNote.Text = s;
                MessageBox.Show("Maximum note size reached.", "Note Too Long.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNewSupplier_Click(object sender, EventArgs e)
        {
            Form NewSup = new SupplierForm(sc);
            NewSup.Show();
            if(NewSup.DialogResult == DialogResult.OK)
                LoadSuppliers();
        }
    }
}
