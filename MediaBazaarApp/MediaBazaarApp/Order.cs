using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApp
{
    class Order
    {
        public string OrderID { get; private set; }
        public string ProductID { get; private set; }
        public string ProductName { get; private set; }
        public int Quantity { get; private set; }
        public float UnitPrice { get; private set; }

        public Order (string order, string product, string name, int qty, float price)
        {
            OrderID = order;
            ProductID = product;
            ProductName = name;
            Quantity = qty;
            UnitPrice = price;
        }
    }
}
