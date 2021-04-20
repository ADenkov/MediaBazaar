using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersApp
{
    public class DeliveryCollection
    {
        private ConnectSQL cnn;
        private List<Order> orders;
        private List<Delivery> deliveries;
        private Order o;
        private Delivery d;
        private float total;

        public DeliveryCollection(ConnectSQL cnn)
        {
            this.cnn = cnn;
            GetData();
        }

        public void GetData()
        {
            orders = new List<Order>();
            deliveries = new List<Delivery>();

            using (SqlCommand cmd = new SqlCommand("SELECT Order_ID, Product_ID, Product_Name, Quantity, Unit_Price FROM OrderData", cnn.sqlConection()))
            {
                cnn.Open();
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    o = new Order(r.GetString(0), r.GetString(1), r.GetString(2), r.GetInt32(3), (float)Convert.ToDouble(r.GetValue(4)));
                    orders.Add(o);
                }
                cnn.Close();
            }

            using (SqlCommand cmd = new SqlCommand("SELECT Order_ID, Delivery_Date, Approval_Date, Employee_Name, Store_Address, Note FROM DeliveryData", cnn.sqlConection()))
            {
                cnn.Open();
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    d = new Delivery(r.GetString(0), r.GetDateTime(1), r.GetDateTime(2), r.GetString(3), r.GetString(4), r.GetString(5));
                    deliveries.Add(d);
                }
                cnn.Close();
            }
        }

        public void NewDelivery(string orderID, DateTime delivery, DateTime current, string name, string store, string note)
        {
            d = new Delivery(orderID, delivery, current, name, store, note);
            string sql = "INSERT INTO DeliveryData(Order_ID, Delivery_Date, Approval_Date, Employee_Name, Store_Address, Note) VALUES('" + orderID + "', '" + delivery + "', '" + current + "', '" + name + "', '" + store + "', '" + note + "')";
            using (SqlCommand cmd = new SqlCommand(sql, cnn.sqlConection()))
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }

        public void AddOrderItem(string prodcutID, string name, int quantity, float price)
        {
            o = new Order(d.OrderID, prodcutID, name, quantity, price);
            total += price * quantity;
            string sql = "INSERT INTO OrderData(Order_ID, Product_ID, Product_Name, Quantity, Unit_Price) VALUES('" + d.OrderID + "', '" + prodcutID + "','" + name + "', " + quantity + ", " + price + ")";
            using (SqlCommand cmd = new SqlCommand(sql, cnn.sqlConection()))
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }

        public float GetCostPerDelivery(string orderID)
        {
            float cost = 0;
            using (SqlCommand cmd = new SqlCommand("SELECT CAST(SUM(Quantity * Unit_Price) AS float) FROM OrderData WHERE Order_ID = '" + orderID + "' GROUP BY Order_ID", cnn.sqlConection()))
            {
                cnn.Open();
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                    cost = (float)r.GetDouble(0);
                cnn.Close();
            }
            return cost;
        }

        public float GetAllCosts(string address)
        {
            float cost = 0;
            using (SqlCommand cmd = new SqlCommand("WITH a AS (SELECT SUM(Quantity * Unit_Price) AS b FROM OrderData O INNER JOIN DeliveryData D ON O.Order_ID = D.Order_ID WHERE D.Store_Address = '" + address + "' GROUP BY O.Order_ID) SELECT CAST(SUM(b) AS float) AS ddd FROM a", cnn.sqlConection()))
            {
                cnn.Open();
                if (cmd.ExecuteScalar() != null)
                    cost = (float)(Convert.ToDouble(cmd.ExecuteScalar()));
                cnn.Close();
            }
            return cost;
        }

        public Delivery GetDeliveryInfo()
        {
            return d;
        }

        public List<Delivery> GetDeliveries()
        {
            return deliveries;
        }

        public float GetDelvieryTotal()
        {
            return total;
        }
    }
}
