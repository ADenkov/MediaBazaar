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
    public partial class NewAnnoucementForm : Form
    {
        private AnnoucementCollection ac;
        private LocationCollection lc;
        private EmployeeCollection ec;
        private EmployeeProfile ep;
        private List<CheckBox> sendType;

        public NewAnnoucementForm(ConnectSQL cnn, EmployeeProfile ep)
        {
            InitializeComponent();
            ec = new EmployeeCollection(cnn);
            ac = new AnnoucementCollection(cnn, ep, ec);
            lc = new LocationCollection(cnn, ec);
            this.ep = ep;
            foreach (Location l in lc.GetLocationList())
                cbLocation.Items.Add(l.Address);
            LoadLayout();
            sendType = new List<CheckBox> { cbAdminstrator, cbManager, cbFloor, cbWarehouse };
        }

        private bool CheckInput()
        {
            if (tbSubject.Text != "" && tbContent.Text != "" && !cbAdminstrator.Checked && !cbManager.Checked && !cbFloor.Checked && !cbWarehouse.Checked)
            {
                MessageBox.Show("Some Fields are missing, please make sure all required fields are entered correctly.", "Failed to Submit.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            MessageBox.Show("Annoucement Successfully submitted.", "Annoucement Submited.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

        private void LoadLayout()
        {
            tbSubject.Text = "";
            tbContent.Text = "";
            for (int i = 0; i < cbLocation.Items.Count; i++)
                if (cbLocation.Items[i].ToString() == ep.Store)
                    cbLocation.SelectedIndex = i;
            cbAdminstrator.Checked = false;
            cbManager.Checked = false;
            cbFloor.Checked = false;
            cbWarehouse.Checked = false;
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                List<string> address = new List<string>();
                if (cbLocation.SelectedIndex != 0)
                    address.Add(cbLocation.Text);
                else
                    foreach (string add in cbLocation.Items)
                        address.Add(add);
                if (address.Count != 1)
                    address.RemoveAt(0);
                for (int i = 0; i < address.Count; i++)
                    foreach (CheckBox c in sendType)
                        if(c.CheckState == CheckState.Checked)
                            ac.AddData(ep.Role, c.Text, tbContent.Text, tbSubject.Text, DateTime.Now, address[i], ep.Store);
                LoadLayout();
            }
        }
    }
}
