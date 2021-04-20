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
    public partial class OrderListing : UserControl
    {
        public OrderListing()
        {
            InitializeComponent();
        }

        public void LoadLayout(string order, DateTime ordered, DateTime delivery)
        {
            lblOrderID.Text = order;
            lblOrdered.Text = ordered.ToString();
            lblDelivery.Text = delivery.ToString();
        }

        private void AllControls_Enter(object sender, EventArgs e)
        {
            BackColor = Color.WhiteSmoke;
        }

        private void AllControls_Leave(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }
    }
}
