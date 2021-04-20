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
    public partial class SpecificProductLisitng : UserControl
    {
        public SpecificProductLisitng()
        {
            InitializeComponent();
        }

        public void LoadLayout(string serial, ProductCondition condition, float price, float index, DateTime restock, Image icon)
        {
            lblSerial.Text = serial;
            lblCondition.Text = condition.ToString();
            if (condition == ProductCondition.MISSING)
                lblCondition.Text = "MISSING ITEM";
            else if (condition == ProductCondition.OPENED)
                lblCondition.Text = "OPEN BOXED";
            lblPrice.Text = (price * index).ToString();
            lblRestock.Text = restock.ToString();
            pbIcon.Image = icon;
            if (index != 1)
            {
                pbSale.Visible = true;
                lblDiscount.Visible = true;
                lblDiscount.Text = String.Format("{0:0\\%}", index * 100);
            }
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
