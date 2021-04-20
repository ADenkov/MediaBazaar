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
    public partial class LocationListing : UserControl
    {
        private LocationCollection lc;
        private EmployeeCollection ec;
        private LocationsForm lf;

        public LocationListing()
        {
            InitializeComponent();
        }

        public void LoadLayout(string id, string type, string address, int tel, string email, LocationCollection lc, EmployeeCollection ec, LocationsForm lf)
        {
            lblStoreTitle.Text = $"{type} - {id}";
            lblAddress.Text = address;
            lblEmail.Text = email;
            lblTel.Text = "+" + tel.ToString();
            this.lc = lc;
            this.ec = ec;
            this.lf = lf;
        }

        private void MouseEnter_Field(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
        }

        private void MouseLeave_Field(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void AllControls_Click(object sender, EventArgs e)
        {
            lc.GetLocationData(lblAddress.Text);
            ec.GetData(lblAddress.Text);
            lf.LoadNewLocation();
        }
    }
}
