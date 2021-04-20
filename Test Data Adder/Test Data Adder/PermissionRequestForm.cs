using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Data_Adder
{
    public partial class PermissionRequestForm : Form
    {
        private LogedInEmployee lie;
        public static bool granted;

        public PermissionRequestForm(LogedInEmployee lie)
        {
            InitializeComponent();
            this.lie = lie;
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text == lie.Password)
            {
                granted = true;
                this.Close();
            }
            tbPassword.Clear();
        }
    }
}
