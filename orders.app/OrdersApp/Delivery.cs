using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersApp
{
    public class Delivery
    {
        public string OrderID { get; private set; }
        public DateTime DeliveryDate { get; private set; }
        public DateTime ApprovedDate { get; private set; }
        public string Name { get; private set; }
        public string Store { get; private set; }
        public string Note { get; private set; }

        public Delivery(string order, DateTime delivery, DateTime approved, string name, string store, string note)
        {
            OrderID = order;
            DeliveryDate = delivery;
            ApprovedDate = approved;
            Name = name;
            Store = store;
            Note = note;
        }
    }
}
