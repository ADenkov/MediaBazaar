using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Adder
{

    class Product
    {
        private SqlConnection cnn = new SqlConnection("Data Source=89.157.247.62;Initial Catalog=Media Bazaar;Persist Security Info=True;User ID=admin;Password=admin");

        public Product() { }

        public void AddProduct(string productID, string department, string serial, string brand, string name, string description, float price, float discountIndex, string note, string condition, string dateAdded, char archived, string address, string path)
        {
            byte[] binary = null;
            if (path != "")
            {
                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                binary = br.ReadBytes((int)fs.Length);
            }
            cnn.Open();
            string sql = "INSERT INTO InventoryData(Product_ID, Department, Serial, Brand, Name, Description, Price, Discount_Index, Note, Condition, Date_Added, Archived, Store_Address, Icon) VALUES('" + productID + "', '" + department + "', '" + serial + "', '" + brand + "', '" + name + "', '" + description + "', " + price + ", " + discountIndex + ", '" + note + "', '" + condition + "', '" + dateAdded + "', '" + archived + "', '" + address + "', @img)";
            using (SqlCommand cmd = new SqlCommand(sql, cnn))
            {
                cmd.Parameters.Add(new SqlParameter("@img", binary));
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }

        public void RemoveData()
        {
            cnn.Open();
            using (SqlCommand cmd = new SqlCommand("DELETE FROM InventoryData", cnn))
            {
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }
    }
}
