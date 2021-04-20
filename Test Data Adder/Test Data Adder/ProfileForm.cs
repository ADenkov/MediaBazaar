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
    public partial class ProfileForm : Form
    {
        private LogedInEmployee lie;

        public ProfileForm()
        {
            InitializeComponent();
            textBox1.Text = "LICA60";
            textBox2.Text = "XKPQ";
        }

        private void LoadEditables()
        {
            btnUpdate.Enabled = true; tbEmail.Enabled = true;
            tbPhone.Enabled = true; tbPassword.Enabled = true;
            label16.Enabled = true; label17.Enabled = true; label18.Enabled = true;
            pbChangeProfile.Enabled = true;
        }

        private void UnloadEditables()
        {
            btnUpdate.Enabled = false; tbEmail.Enabled = false;
            tbPhone.Enabled = false; tbPassword.Enabled = false;
            label16.Enabled = false; label17.Enabled = false; label18.Enabled = false;
            pbChangeProfile.Enabled = false;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if(btnLogin.Text == "Login")
            {
                lie = new LogedInEmployee(textBox1.Text, textBox2.Text);
                if (lie.Succeeded == false)
                    MessageBox.Show("Failed to login. Check username and password and try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    btnEdit.Enabled = true;
                    pProfile.Visible = true;
                    lblName.Text = $"{lie.First} {lie.Last}";
                    lblAddress.Text = lie.Address;
                    lblStore.Text = lie.Store;
                    lblHoursWorked.Text = lie.Hours + "H";
                    lblArrivalDate.Text = lie.DateJoined;
                    tbEmail.Text = lie.Email;
                    tbPassword.Text = lie.Password;
                    tbPhone.Text = lie.Phone;
                    pbChangeProfile.Image = lie.ProfilePic;
                    profilePicture.BackgroundImage = lie.ProfilePic;
                    if (lie.Messages == 'Y') { cbAnnoucementsByEmail.Checked = true; }
                    textBox1.Visible = false; textBox2.Visible = false;
                    btnLogin.Text = "Log out";
                }
            }
            else
            {
                profilePicture.BackgroundImage = null;
                lblName.Text = "";
                pProfile.Visible = false;
                textBox1.Visible = true;
                textBox2.Visible = true;
                btnLogin.Text = "Login";
            }
        }

        private void LblEmployeeID_MouseEnter(object sender, EventArgs e)
        {
            lblEmployeeID.Text = lie.EmployeeID;
        }

        private void LblEmployeeID_MouseLeave(object sender, EventArgs e)
        {
            lblEmployeeID.Text = "Hover to view ID";
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if(lie.ProfilePic == pbChangeProfile.Image)
                lie.UpdateData(tbEmail.Text, tbPhone.Text, tbPassword.Text);
            else
            {
                lie.UpdateData(tbEmail.Text, tbPhone.Text, tbPassword.Text, pbChangeProfile.ImageLocation);
                profilePicture.BackgroundImage = pbChangeProfile.Image;
                UnloadEditables();
                btnEdit.Enabled = true;
            }
        }

        private void PbChangeProfile_MouseClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
                pbChangeProfile.ImageLocation = ofd.FileName.ToString();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Form pr = new PermissionRequestForm(lie);
            pr.ShowDialog();

            if (PermissionRequestForm.granted == true)
            {
                LoadEditables();
                btnEdit.Enabled = false;
            }
        }

        private void PProfile_VisibleChanged(object sender, EventArgs e)
        {
            UnloadEditables();
        }

        private void CbAnnoucementsByEmail_MouseClick(object sender, MouseEventArgs e)
        {
            lie.UpdateMessages(cbAnnoucementsByEmail.Checked);
        }
    }
}
