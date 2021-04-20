using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApp
{
    public class ProductCollection
    {
        private ConnectSQL cnn;
        private List<Product> products;
        private List<string> brands;
        private List<string> departments;
        private Product p;

        public ProductCollection(ConnectSQL cnn)
        {
            this.cnn = cnn;
        }

        public List<Product> GetProductPage(string department, string brand, string input, int offset, int rows, string store)
        {
            string query = "";
            if (department != "All")
                query += $" AND Department = '{department}'";
            if (brand != "All")
                query += $" AND Brand = '{brand}'";
            if (input != "")
                query += $" OR Name = '{input}' OR Description = '{input}' OR Product_ID = '{input}'";
            if(query != "")
                query = query.Remove(0, 4) + " AND";
            SetProductPageList(query, offset, rows, store);
            return products;
        }

        private void SetProductPageList(string query, int offset, int rows, string store)
        {
            SetDepANDBra(store);
            products = new List<Product>();
            string[,] PrePro = new string[rows, 12];
            using (SqlCommand cmd = new SqlCommand("SELECT DISTINCT Product_ID, Department, Brand, Name, Description, Price, Discount_Index, Note, Condition, Date_Added, Archived, Store_Address FROM InventoryData WHERE " + query + " Store_Address = '" + store + "' ORDER BY (Product_ID) OFFSET " + offset + " ROWS FETCH FIRST " + rows + " ROWS ONLY", cnn.sqlConection()))
            {
                cnn.Open();
                SqlDataReader r = cmd.ExecuteReader();
                int counter = 0;
                while (r.Read())
                {
                    PrePro[counter, 0] = r.GetString(0);
                    PrePro[counter, 1] = r.GetString(1);
                    PrePro[counter, 2] = r.GetString(2);
                    PrePro[counter, 3] = r.GetString(3);
                    PrePro[counter, 4] = r.GetString(4);
                    PrePro[counter, 5] = r.GetValue(5).ToString();
                    PrePro[counter, 6] = r.GetValue(6).ToString();
                    PrePro[counter, 7] = r.GetString(7);
                    PrePro[counter, 8] = r.GetString(8);
                    PrePro[counter, 9] = r.GetDateTime(9).ToString();
                    PrePro[counter, 10] = r.GetString(10);
                    PrePro[counter, 11] = r.GetString(11);
                    counter++;
                }
                cnn.Close();
            }
            for (int i = 0; i < rows; i++)
                using (SqlCommand cmd = new SqlCommand("SELECT TOP(1) Serial, Icon FROM InventoryData WHERE Product_ID = '" + PrePro[i, 0] + "'", cnn.sqlConection()))
                {
                    cnn.Open();
                    SqlDataReader r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        MemoryStream ms = new MemoryStream((byte[])(r[1]));
                        char arc = 'N';
                        if (PrePro[i, 10] == "Y")
                            arc = 'Y';
                        p = new Product(PrePro[i, 0], PrePro[i, 1], r.GetString(0), PrePro[i, 2], PrePro[i, 3], PrePro[i, 4], (float)Convert.ToDouble(PrePro[i, 5]), (float)Convert.ToDouble(PrePro[i, 6]), PrePro[i, 7], PrePro[i, 8], Convert.ToDateTime(PrePro[i, 9]), arc, PrePro[i, 11], Image.FromStream(ms));
                        products.Add(p);
                    }
                    cnn.Close();
                }
        }

        public void AddData(string productID, string department, string serial, string brand, string name, string description, float price, float discountIndex, string note, string condition, string dateAdded, char archived, string address, string path)
        {
            byte[] binary = null;
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            binary = br.ReadBytes((int)fs.Length);
            cnn.Open();
            string sql = "INSERT INTO InventoryData(Product_ID, Department, Serial, Brand, Name, Description, Price, Discount_Index, Note, Condition, Date_Added, Archived, Store_Address, Icon) VALUES('" + productID + "', '" + department + "', '" + serial + "', '" + brand + "', '" + name + "', '" + description + "', " + price + ", " + discountIndex + ", '" + note + "', '" + condition + "', '" + dateAdded + "', '" + archived + "', '" + address + "', @img)";
            using (SqlCommand cmd = new SqlCommand(sql, cnn.sqlConection()))
            {
                cmd.Parameters.Add(new SqlParameter("@img", binary));
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }

        public void SetDepANDBra(string store)
        {
            brands = new List<string>();
            departments = new List<string>();
            using (SqlCommand cmd = new SqlCommand("SELECT Distinct(Department) FROM InventoryData WHERE Store_address = '" + store + "'", cnn.sqlConection()))
            {
                cnn.Open();
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                    departments.Add(r.GetString(0));
                cnn.Close();
            }
            using (SqlCommand cmd = new SqlCommand("SELECT Distinct(Brand) FROM InventoryData WHERE Store_address = '" + store + "'", cnn.sqlConection()))
            {
                cnn.Open();
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                    brands.Add(r.GetString(0));
                cnn.Close();
            }
            brands = brands.Select(x => x.ToString()).Distinct().ToList();
            brands.Sort();
            departments = departments.Select(x => x.ToString()).Distinct().ToList();
        }

        public Product GetProductByID(string productID)
        {
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM InventoryData WHERE Product_ID = '" + productID + "'", cnn.sqlConection()))
            {
                cnn.Open();
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    MemoryStream ms = new MemoryStream((byte[])(r[13]));
                    p = new Product(r.GetString(0), r.GetString(1), r.GetString(2), r.GetString(3), r.GetString(4), r.GetString(5), (float)Convert.ToDouble(r.GetValue(6)), (float)Convert.ToDouble(r.GetValue(7)), r.GetString(8), r.GetString(9), r.GetDateTime(10), r.GetString(11)[0], r.GetString(12), Image.FromStream(ms));
                }
                cnn.Close();
            }
            return p;
        }

        public List<Product> GetListProductByIDByStore(string productID, string store)
        {
            List<Product> pro = new List<Product>();
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM InventoryData WHERE Product_ID = '" + productID + "' AND Store_Address = '"+store+"'", cnn.sqlConection()))
            {
                cnn.Open();
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    MemoryStream ms = new MemoryStream((byte[])(r[13]));
                    p = new Product(r.GetString(0), r.GetString(1), r.GetString(2), r.GetString(3), r.GetString(4), r.GetString(5), (float)Convert.ToDouble(r.GetValue(6)), (float)Convert.ToDouble(r.GetValue(7)), r.GetString(8), r.GetString(9), r.GetDateTime(10), r.GetString(11)[0], r.GetString(12), Image.FromStream(ms));
                    pro.Add(p);
                }
                cnn.Close();
            }
            return pro;
        }

        public int GetItemCount(string store)
        {
            int count = 0;
            using (SqlCommand cmd = new SqlCommand("SELECT count(Distinct(Product_ID)) FROM InventoryData WHERE Store_Address = '" + store + "'", cnn.sqlConection()))
            {
                cnn.Open();
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                    count = r.GetInt32(0);
                cnn.Close();
            }
            return count;
        }

        public int GetSpecificProductCount(string store, string productID)
        {
            int count = 0;
            using (SqlCommand cmd = new SqlCommand("SELECT count(*) FROM InventoryData WHERE Product_ID = '" + productID + "' AND Store_Address = '" + store + "'", cnn.sqlConection()))
            {
                cnn.Open();
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                    count = r.GetInt32(0);
                cnn.Close();
            }
            return count;
        }

        public List<string> GetBrands()
        {
            return brands;
        }

        public List<string> GetDepartements()
        {
            return departments;
        }
    }
}
