using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product_Adder
{
    public partial class OrderForm : Form
    {
        private SqlConnection cnn = new SqlConnection("Data Source=89.157.247.62;Initial Catalog=Media Bazaar;Persist Security Info=True;User ID=admin;Password=admin");
        private Order o;
        private Random r;

        public OrderForm()
        {
            InitializeComponent();
            using (SqlCommand cmd = new SqlCommand("DELETE FROM OrderData", cnn))
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
            using (SqlCommand cmd = new SqlCommand("DELETE FROM DeliveryData", cnn))
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }

        private void BtnDOSHIT_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                List<string> stores = new List<string>();
                string first = "";
                string last = "";
                string pName = "";
                string pID = "";
                float price = 0;
                using (SqlCommand cmd = new SqlCommand("SELECT Address FROM LocationData WHERE Purpose = 'Store'", cnn))
                {
                    cnn.Open();
                    SqlDataReader r = cmd.ExecuteReader();
                    while (r.Read())
                        stores.Add(r.GetString(0));
                    cnn.Close();
                }
                using (SqlCommand cmd = new SqlCommand("SELECT TOP(1) First_Name, Last_Name FROM EmployeeData ORDER BY NEWID()", cnn))
                {
                    cnn.Open();
                    SqlDataReader r = cmd.ExecuteReader();
                    while (r.Read()) { first = r.GetString(0); last = r.GetString(1); }
                    cnn.Close();
                }
                r = new Random();
                o = new Order($"IN-{r.Next(100000).ToString("000000")}", DateTime.Now.AddHours(r.Next(1000000)), DateTime.Now.AddHours(r.Next(100000)), $"{first} {last}", stores[r.Next(stores.Count)], "N/A");

                for (int x = 0; x < r.Next(10, 40); x++)
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT TOP(1) Product_ID, Name, Price FROM InventoryData ORDER BY NEWID()", cnn))
                    {
                        cnn.Open();
                        SqlDataReader r = cmd.ExecuteReader();
                        while (r.Read())
                        {
                            pID = r.GetString(0);
                            pName = r.GetString(1);
                            price = (float)Convert.ToDouble(r.GetValue(2));
                        }
                        cnn.Close();
                    }
                    o.AddProduct(pID, pName, r.Next(20), price);
                }
                Task.Delay(TimeSpan.FromMilliseconds(100)).Wait();
                if (i == 19)
                    MessageBox.Show("Done Loading all " + i + 1 + "orders within the db", "Done.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
