using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product_Adder
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnEmployee_Click(object sender, EventArgs e)
        {
            Form emp = new EmployeeForm();
            emp.Show();
        }

        private void BtnProduct_Click(object sender, EventArgs e)
        {
            Form pro = new ProductForm();
            pro.Show();
        }

        private void BtnAnnoucement_Click(object sender, EventArgs e)
        {
            Form ann = new AnnoucementForm();
            ann.Show();
        }

        private void BtnOrders_Click(object sender, EventArgs e)
        {
            Form or = new OrderForm();
            or.Show();
        }

        private void BtnSchedule_Click(object sender, EventArgs e)
        {
            Form sc = new ScheduleForm();
            sc.Show();
        }
    }
}
