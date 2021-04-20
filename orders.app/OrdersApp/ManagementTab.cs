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
    public partial class ManagementTab : Form
    {
        private LocationCollection lc;
        private DeliveryCollection dc;
        private ConnectSQL cnn;

        public ManagementTab(ConnectSQL cnn)
        {
            InitializeComponent();
            this.cnn = cnn;
            lc = new LocationCollection(cnn);
            dc = new DeliveryCollection(cnn);
            LoadLocations();
            LoadData();
        }

        private void LoadLocations()
        {
            cbLocation.Items.Clear();
            foreach (Location loc in lc.GetLocationList())
                if (loc.Type == LocationType.STORE)
                    cbLocation.Items.Add(loc.Address);
            cbLocation.SelectedIndex = 0;
            UpdateStoreInfo();
        }

        private void UpdateStoreInfo()
        {
            lc.GetLocationData(cbLocation.Text);
            lblAddress.Text = lc.LocationData().Address;
            lblID.Text = lc.LocationData().LocationID;
            lblEMail.Text = lc.LocationData().Email;
            lblTel.Text = lc.LocationData().Tel.ToString();
            lblWebsite.Text = lc.LocationData().Website;
        }

        private void LoadData()
        {
            if(flpOrderList.Controls.Count != 0)
                flpOrderList.Controls.Clear();
            foreach(Delivery d in dc.GetDeliveries())
            {
                OrderConrtroller oc = new OrderConrtroller();
                oc.LoadLayout(d, this.cnn);
                flpOrderList.Controls.Add(oc);
            }
        }

        private void TbRevenue_MouseHover_1(object sender, EventArgs e)
        {
            lblRevenue.Text = $"{dc.GetAllCosts(cbLocation.Text)} EUR";
        }

        private void TbRevenue_MouseLeave_1(object sender, EventArgs e)
        {
            lblRevenue.Text = "Hover to Reveal";
        }

        #region BorderDesign
        private void FlpOrderList_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.flpOrderList.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);

        }
        #endregion

        private void CbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStoreInfo();
            LoadData();
        }
    }
}
