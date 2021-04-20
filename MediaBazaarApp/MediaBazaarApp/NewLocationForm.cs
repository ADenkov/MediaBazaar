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
    public partial class NewLocationForm : Form
    {
        private static LocationCollection lc;
        private static EmployeeCollection ec;
        private List<NewLocationEmployeeListing> nlels;
        private int section;
        private string locationID;
        private string address;
        private string website;
        private int phone;
        private string email;
        private LocationType type;
        private int capacity;

        public NewLocationForm(ConnectSQL cnn)
        {
            InitializeComponent();
            ec = new EmployeeCollection(cnn);
            lc = new LocationCollection(cnn, ec);
        }

        private void NewLocationForm_Load(object sender, EventArgs e)
        {
            cbDefault.Checked = true;
            tbPhone.Text = "+" + lc.GetLocationList()[0].Tel.ToString();
            tbEmail.Text = lc.GetLocationList()[0].Email;
            tbWebsite.Text = lc.GetLocationList()[0].Website;
            pContact.Visible = false;
            pEmployee.Visible = false;
            foreach (Location l in lc.GetLocationList())
                cbLocation.Items.Add(l.Address);
            cbDepratment.SelectedIndex = 0;
            cbGender.SelectedIndex = 0;
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (section == 0)
            {
                if (tbCity.Text == "" || tbStreet.Text == "" || tbPostal.Text == "")
                    MessageBox.Show("Make sure all required fields are filled in.", "Missing Fields.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    Scroller.Location = new Point(248, 131);
                    pAddress.Visible = false;
                    locationID = lblLocationID.Text;
                    address = $"{tbStreet.Text} {tbPostal.Text} {tbCity.Text}";
                    lblPanel2.ForeColor = Color.Black;
                    tbCity.Enabled = false;
                    tbPostal.Enabled = false;
                    tbStreet.Enabled = false;
                    pContact.Visible = true;
                    section++;
                }
            }
            else if (section == 1)
            {
                if (tbPhone.Text == "" || tbEmail.Text == "" || tbWebsite.Text == "" || cbType.SelectedIndex == -1)
                    MessageBox.Show("Make sure all required fields are filled in.", "Missing Fields.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    cbLocation.SelectedIndex = 0;
                    Scroller.Location = new Point(481, 131);
                    pContact.Visible = false;
                    phone = Convert.ToInt32(tbPhone.Text);
                    lblPanel3.ForeColor = Color.Black;
                    email = tbEmail.Text;
                    website = tbWebsite.Text;
                    type = LocationType.HQ;
                    if (cbType.SelectedIndex == 0)
                        type = LocationType.STORE;
                    capacity = 0;
                    if (tbCapacity.Text != "")
                        capacity = Convert.ToInt32(tbCapacity.Text);
                    lc.AddData(locationID, address, phone, email, website, type, capacity);
                    pEmployee.Visible = true;
                    btnNext.Text = "Finish";
                    section++;
                }
            }
            else if (section == 2)
            {
                pEmployee.Visible = false;
                MessageBox.Show("Location successfully added.", "Successful.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNext.Enabled = false;
            }
        }

        private void GenerateLocationID(object sender, KeyEventArgs e)
        {
            if (tbCity.Text != "" && tbStreet.Text != "" && tbPostal.Text != "")
                lblLocationID.Text = tbStreet.Text.Remove(2).ToUpper() + tbPostal.Text;
        }

        private void CbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbType.SelectedIndex == 0)
            {
                tbCapacity.Enabled = true;
                label35.Enabled = true;
                label36.Enabled = true;
            }
            else
            {
                tbCapacity.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
            }
        }

        private void CbDefault_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbDefault.Checked)
            {
                tbPhone.Enabled = true;
                tbEmail.Enabled = true;
                tbWebsite.Enabled = true;
                tbPhone.Text = "";
                tbEmail.Text = "";
                tbWebsite.Text = "";
            }
            else
            {
                tbPhone.Text = "+" + lc.GetLocationList()[0].Tel.ToString();
                tbEmail.Text = lc.GetLocationList()[0].Email;
                tbWebsite.Text = lc.GetLocationList()[0].Website;
                tbPhone.Enabled = false;
                tbEmail.Enabled = false;
                tbWebsite.Enabled = false;
            }
        }

        private void ReloadFilteredList()
        {
            EmployeeJob job = EmployeeJob.ALL;
            if (cbDepratment.SelectedIndex == 1)
                job = EmployeeJob.ADMINISTRATOR;
            else if (cbDepratment.SelectedIndex == 2)
                job = EmployeeJob.MANAGER;
            else if (cbDepratment.SelectedIndex == 3)
                job = EmployeeJob.FLOOR;
            else if (cbDepratment.SelectedIndex == 4)
                job = EmployeeJob.WAREHOUSE;

            EmployeeGender gender = EmployeeGender.ALL;
            if (cbGender.SelectedIndex == 1)
                gender = EmployeeGender.MALE;
            else if (cbGender.SelectedIndex == 2)
                gender = EmployeeGender.FEMALE;
            else if (cbGender.SelectedIndex == 3)
                gender = EmployeeGender.UNDEFINED;
            ec.GetData(cbLocation.Text);
            if (ec.FilterEmployeeList(job, gender, cbArchived.Checked).Count != 0)
            {
                flpEmployee.Controls.Clear();
                foreach (Employee emp in ec.FilterEmployeeList(job, gender, cbArchived.Checked))
                {
                    NewLocationEmployeeListing el = new NewLocationEmployeeListing();
                    el.LoadLayout(emp.First, emp.Last, emp.EmployeeID, emp.Store, emp.Job, ec, this);
                    flpEmployee.Controls.Add(el);
                }
            }
            else
                MessageBox.Show("No employee(s) found matching input.", "Employee Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void AddEmployee(NewLocationEmployeeListing nlel)
        {
            if (nlels == null)
                nlels= new List<NewLocationEmployeeListing>();
            nlels.Add(nlel);
        }

        public void RemEmployee(NewLocationEmployeeListing nlel)
        {
            nlels.Remove(nlel);
        }

        private void BtnTransferEmployee_Click(object sender, EventArgs e)
        {
            foreach(NewLocationEmployeeListing nlel in nlels)
                ec.ChangeEmployeeStoreAddress(address, nlel.ID);
            nlels.Clear();
            ReloadFilteredList();
        }

        private void SelectionChangedcommited(object sender, EventArgs e)
        {
            ReloadFilteredList();
        }

        private void CbLocation_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ec.GetData(cbLocation.Text);
            ReloadFilteredList();
        }
    }
}
