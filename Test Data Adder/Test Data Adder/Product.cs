using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Data_Adder
{
    class Product
    {
        private SqlConnection cnn = new SqlConnection("Data Source=89.157.247.62;Initial Catalog=Media Bazaar;Persist Security Info=True;User ID=admin;Password=admin");

        public int Total { get; private set; }
        public List<string> ProductIDs { get; private set; }
        public List<string> Serials { get; private set; }
        public List<string> Brands { get; private set; }
        public List<string> Departments { get; private set; }
        public List<string> Names { get; private set; }
        public List<string> Descriptions { get; private set; }
        public List<string> Prices { get; private set; }
        public List<string> Indecies { get; private set; }
        public List<string> Conditions { get; private set; }
        public List<string> Notes { get; private set; }
        public List<byte[]> Images { get; private set; }

        public Product()
        {
            cnn.Open();
            using (SqlCommand cmd = new SqlCommand("SELECT count(*) FROM InventoryData", cnn))
            {
                Total = cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }

        public void AddProduct(string name, string brand, string department, string descritption, string condition, string note, float price, float discountIndex, string imagePath)
        {
            Random digit = new Random();
            string ID = department.ToUpper().Remove(3) + "-" + brand.ToUpper().Remove(3) + digit.Next(0, 1000).ToString("0000");
            string serial = brand + "---";
            serial = serial.ToUpper().Remove(3) + name.ToUpper().Remove(3) + digit.Next(1000, 10000).ToString("0000");
            float discount = discountIndex / 100;

            byte[] binary = null;
            if (imagePath != "")
            {
                FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                binary = br.ReadBytes((int)fs.Length);
            }
            cnn.Open();
            string sql = "INSERT INTO InventoryData(Product_ID, Serial, Brand, Department, Name, Description, Price, Discount_Index, Condition, Note, Picture) VALUES('" + ID + "', '" + serial + "', '" + brand + "', '" + department + "', '" + name + "', '" + descritption + "', '" + price + "', " + discount + ", '" + condition + "', '" + note + "', @img)";
            using (SqlCommand cmd = new SqlCommand(sql, cnn))
            {
                cmd.Parameters.Add(new SqlParameter("@img", binary));
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }

        public void RefreshProducts()
        {
            ProductIDs = new List<string>();
            Serials = new List<string>();
            Brands = new List<string>();
            Departments = new List<string>();
            Names = new List<string>();
            Descriptions = new List<string>();
            Prices = new List<string>();
            Indecies = new List<string>();
            Conditions = new List<string>();
            Notes = new List<string>();
            Images = new List<byte[]>();

            string sql = "SELECT * FROM InventoryData";
            cnn.Open();
            using (SqlCommand cmd = new SqlCommand(sql, cnn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ProductIDs.Add(reader.GetString(0));
                    Serials.Add(reader.GetString(1));
                    Brands.Add(reader.GetString(2));
                    Departments.Add(reader.GetString(3));
                    Names.Add(reader.GetString(4));
                    Descriptions.Add(reader.GetString(5));
                    Prices.Add(reader.GetValue(6).ToString());
                    Indecies.Add(reader.GetValue(7).ToString());
                    Conditions.Add(reader.GetString(8));
                    Notes.Add(reader.GetString(9));
                    Images.Add((byte[])reader[10]);
                }
            }
            cnn.Close();
        }
    }
}
