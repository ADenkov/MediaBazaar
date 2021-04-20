using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Data_Adder
{
    public partial class ProductInfo : Form
    {
        private SqlConnection cnn = new SqlConnection("Data Source=89.157.247.62;Initial Catalog=Media Bazaar;Persist Security Info=True;User ID=admin;Password=admin");
        private string filter;
        private int total;

        public ProductInfo(string productID, string department, string description, string price, string title, Image image)
        {
            InitializeComponent();
            lblProductID.Text = productID;
            lblTitle.Text = title;
            lblDescription.Text = description;
            lblDepartment.Text = department;
            lblPrice.Text = price;
            pbImage.Image = image;
            filter = title.Substring(title.IndexOf('-') + 2);
        }

        private void ProductInfo_Load(object sender, EventArgs e)
        {
            POP();
            lblTotal.Text = total.ToString();
        }

        private void POP()
        {
            using (SqlCommand cmd = new SqlCommand("SELECT Product_ID, Brand, Department, Name, Description, Price, Icon FROM InventoryData WHERE Name = '" + filter + "'", cnn))
            {
                cnn.Open();
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    total++;
                    listProduct = new List();
                    listProduct.LoadLayout(r.GetString(0), r.GetString(1), r.GetString(2), r.GetString(3), r.GetString(4), Convert.ToInt32(r.GetValue(5)), (byte[])(r[6]));
                    flp.Controls.Add(listProduct);
                }
                cnn.Close();
            }
        }
    }
}
