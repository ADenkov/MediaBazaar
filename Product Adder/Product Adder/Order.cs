using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Adder
{
    class Order
    {
        private SqlConnection cnn = new SqlConnection("Data Source=89.157.247.62;Initial Catalog=Media Bazaar;Persist Security Info=True;User ID=admin;Password=admin");
        private string OrderID { get; set; }
        public Order(string id, DateTime delivery, DateTime approved, string employee, string store, string note)
        {
            OrderID = id;
            MakeNewDelivery(delivery, approved, employee, store, note);
        }

        private void MakeNewDelivery(DateTime delivery, DateTime approved, string employee, string store, string note)
        {
            cnn.Open();
            string sql = "INSERT INTO DeliveryData(Order_ID, Delivery_Date, Approval_Date, Employee_Name, Store_Address, Note) VALUES('" + OrderID + "', '" + delivery + "', '" + approved + "', '" + employee + "', '" + store + "', '" + note + "')";
            using (SqlCommand cmd = new SqlCommand(sql, cnn))
            {
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }

        public void AddProduct(string id, string name, int quantity, float price)
        {
            cnn.Open();
            string sql = "INSERT INTO OrderData(Order_ID, Product_ID, Product_Name, Quantity, Unit_Price) VALUES('" + OrderID + "', '" + id + "', '" + name + "', " + quantity + ", " + price + ")";
            using (SqlCommand cmd = new SqlCommand(sql, cnn))
            {
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }
    }
}
