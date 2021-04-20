using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaarApp
{
    public partial class SupplierForm : Form
    {
        private SupplierCollection sc;

        public SupplierForm(SupplierCollection sc)
        {
            InitializeComponent();
            this.sc = sc;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                sc.NewSupplier(tbName.Text, tbAddress.Text, Convert.ToInt32(tbPhone.Text));
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nCorrect any issue and try again.", "An Error Occured.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
