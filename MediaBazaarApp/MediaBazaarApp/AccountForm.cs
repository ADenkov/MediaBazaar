using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaarApp
{
    public partial class AccountForm : Form
    {
        private EmployeeProfile ep;
        private MainForm mf;
        private string imagePath;

        public AccountForm(EmployeeProfile ep, MainForm mf)
        {
            InitializeComponent();
            this.ep = ep;
            this.mf = mf;
            LoadPanel();
        }

        private void LoadPanel()
        {
            lblHome.Text = ep.Address;
            lblStore.Text = ep.Store;
            lblStoreTel.Text = ep.Phone;
            lblDateJoined.Text = ep.DateJoined.ToString();
            lblHours.Text = ep.Hours + "H";
            tbPersonalEmail.Text = ep.Email;
            tbPersonalPhone.Text = "+" + ep.Phone;
            tbPersonalPassword.Text = ep.Password;
            pbEditPicture.Image = ep.ProfilePic;
            cbGetAnnoucements.Checked = ep.Messages;
            btnUpdateProfile.Enabled = false;
            btnCancel.Visible = false;
            pAccount.Focus();
        }

        private void CbGetAnnoucements_Click(object sender, EventArgs e)
        {
            ep.UpdateMessages(cbGetAnnoucements.Checked);
            pAccount.Focus();
        }

        private void LblID_MouseHover(object sender, EventArgs e)
        {
            lblID.Text = ep.EmployeeID;
        }

        private void LblSalary_MouseHover(object sender, EventArgs e)
        {
            lblSalary.Text = ep.Salary + ".00";
        }

        private void LeavingLabel(object sender, EventArgs e)
        {
            lblID.Text = "Hover to Reveal";
            lblSalary.Text = "Hover to Reveal";
        }

        private void BtnUpdateProfile_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(imagePath))
                ep.UpdateData(tbPersonalEmail.Text, tbPersonalPhone.Text, tbPersonalPassword.Text, pbEditPicture.ImageLocation);
            else
                ep.UpdateData(tbPersonalEmail.Text, tbPersonalPhone.Text, tbPersonalPassword.Text);
            imagePath = "";
            mf.UpdateAccountButton();
            LoadPanel();
        }

        private void PbEditPicture_Click(object sender, EventArgs e)
        {
            List<string> extensions = new List<string> { ".JPG", ".JPE", ".BMP", ".PNG" };
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
                if (extensions.Contains(Path.GetExtension(ofd.FileName.ToString().ToUpperInvariant())))
                    imagePath = ofd.FileName.ToString();
                else
                    MessageBox.Show("Selected file is not compatible. Is file an image (e.g .JPG, .PNG, etc...)?", "Invalid File Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
            pbEditPicture.ImageLocation = imagePath;
        }

        private void CredentialsChanged(object sender, EventArgs e)
        {
            if(tbPersonalEmail.Text != ep.Email || tbPersonalPhone.Text != "+" + ep.Phone || tbPersonalPassword.Text != ep.Password)
            {
                btnUpdateProfile.Enabled = true;
                btnCancel.Visible = true;
            }
        }

        private void pbEditPicture_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            btnUpdateProfile.Enabled = true;
            btnCancel.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadPanel();
        }

        private void EnterPressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                pAccount.Focus();
        }

        private void ChangeAppColor(object sender, EventArgs e)
        {
            foreach (Button b in pAccount.Controls.OfType<Button>())
                if (b.Focused)
                {
                    string color = b.BackColor.R.ToString() + ", ";
                    color += b.BackColor.G.ToString() + ", ";
                    color += b.BackColor.B.ToString();
                    ep.UpdateColor(color);
                }
        }


        // TextBox color change
        private void TbPersonalEmail_Validated(object sender, EventArgs e)
        {
            tbPersonalEmail.BackColor = Color.FromArgb(230,230,230);
        }

        private void TbPersonalPhone_Validated(object sender, EventArgs e)
        {
            tbPersonalPhone.BackColor = Color.FromArgb(230, 230, 230);
        }

        private void TbPersonalPassword_Validated(object sender, EventArgs e)
        {
            tbPersonalPassword.BackColor = Color.FromArgb(230, 230, 230);
        }

        private void TbPersonalPassword_MouseDown(object sender, MouseEventArgs e)
        {
            tbPersonalPassword.BackColor = Color.White;
        }

        private void TbPersonalPhone_MouseDown(object sender, MouseEventArgs e)
        {
            tbPersonalPhone.BackColor = Color.White;
        }

        private void TbPersonalEmail_MouseDown(object sender, MouseEventArgs e)
        {
            tbPersonalEmail.BackColor = Color.White;
        }
    }
}
