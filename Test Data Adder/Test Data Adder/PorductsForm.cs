using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Test_Data_Adder
{
    public partial class PorductsForm : Form
    {
        private SqlConnection cnn = new SqlConnection("Data Source=89.157.247.62;Initial Catalog=Media Bazaar;Persist Security Info=True;User ID=admin;Password=admin");
        private int page;
        private bool seye;
        private int viewCount;

        List<List> List;

        public PorductsForm()
        {
            InitializeComponent();
        }

        private void PorductsForm_Load(object sender, EventArgs e)
        {
            POPALL();
            tbLoadCount.Text = "30";
            lblPage.Text = "1"; page = 1; viewCount = 30;
            List<List> l = List.GetRange(0, 30);
            flp.Controls.Clear();
            foreach (List item in l)
                flp.Controls.Add(item);
        }

        private void POPALL()
        {
            List = new List<List>();
            using (SqlCommand cmd = new SqlCommand("SELECT Product_ID, Brand, Department, Name, Description, Price, Icon FROM InventoryData WHERE Condition = 'New'", cnn))
            {
                cnn.Open();
                SqlDataReader r = cmd.ExecuteReader();
                string name = "";
                while (r.Read())
                {
                    if (name != r.GetString(3))
                    {
                        list = new List();
                        list.LoadLayout(r.GetString(0), r.GetString(1), r.GetString(2), r.GetString(3), r.GetString(4), Convert.ToInt32(r.GetValue(5)), (byte[])(r[6]));
                        List.Add(list);
                    }
                    name = r.GetString(3);
                }
                cnn.Close();
            }
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            if (page > 1)
            {
                page--;
                List<List> l = List.GetRange(page * viewCount, viewCount);
                flp.Controls.Clear();
                foreach (List item in l)
                    flp.Controls.Add(item);
                lblPage.Text = page.ToString();
                seye = false;
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (!seye)
            {
                if (page <= List.Count - 1) { page++; }
                List<List> l;
                if (page == (List.Count / viewCount)) { l = List.GetRange(page * viewCount, (List.Count % viewCount)); seye = true; }
                else { l = List.GetRange(page * viewCount, viewCount); }
                flp.Controls.Clear();
                foreach (List item in l)
                    flp.Controls.Add(item);
                lblPage.Text = page.ToString();
            }
        }

        private void TbLoadCount_Leave(object sender, EventArgs e)
        {
            viewCount = Convert.ToInt32(tbLoadCount.Text);
            lblPage.Text = "1"; page = 1;
            List<List> l = List.GetRange(0, viewCount);
            flp.Controls.Clear();
            foreach (List item in l)
                flp.Controls.Add(item);
        }
    }
}
