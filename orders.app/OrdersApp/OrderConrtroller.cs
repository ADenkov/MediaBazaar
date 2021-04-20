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
    public partial class OrderConrtroller : UserControl
    {
        private DeliveryCollection dl;

        public OrderConrtroller()
        {
            InitializeComponent();
        }

        public void LoadLayout(Delivery d, ConnectSQL cnn)
        {
            dl = new DeliveryCollection(cnn);
            lblOrderID.Text = d.OrderID;
            lblDate.Text = d.DeliveryDate.ToString();
            lblCosts.Text = dl.GetCostPerDelivery(d.OrderID).ToString() + " EUR";
        }
    }
}
