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
    public partial class LocationsForm : Form
    {
        private static LocationCollection lc;
        private static EmployeeCollection ec;
        private Email em;
        private EmployeeProfile ep;
        private LocationType lt;


        public LocationsForm(ConnectSQL cnn, EmployeeProfile ep)
        {
            InitializeComponent();
            ec = new EmployeeCollection(cnn);
            lc = new LocationCollection(cnn, ec);
            em = new Email(ep, new DeliveryCollection(cnn, ep));
            cbDepratment.SelectedIndex = 0;
            cbGender.SelectedIndex = 0;
            cbAddressType.SelectedIndex = 0;
            ReloadLocationList();
            this.ep = ep;
/*            if (this.ep.Role != EmployeeJob.ALL || this.ep.Role != EmployeeJob.ADMINISTRATOR)
                btnEdit.Visible = false;*/
       /*     else if (ep.Role == EmployeeJob.ADMINISTRATOR || ep.Role == EmployeeJob.ALL)
                btnEdit.Visible = true;*/
        }

        public void LoadNewLocation()
        {
            pStoreEmployeeInfo.Size = new Size(1087, 367);
            cbDepratment.SelectedIndex = 0;
            cbGender.SelectedIndex = 0;
            btnInfo.Text = "⯅";
            Employee manager = null;
            pStoreEmployeeInfo.Visible = true;
            pGeneralInfo.Visible = true;
            btnInfo.Visible = true;
            panelEditLoc.Visible = false;
            flpEmployee.Controls.Clear();
            foreach (Employee emp in ec.GetEmployeeList())
            {
                EmployeeListing el = new EmployeeListing();
                el.LoadLayout(emp.First, emp.Last, emp.EmployeeID, emp.Job, emp.Email, emp.Phone, emp.ProfilePic, this);
                flpEmployee.Controls.Add(el);
                if (emp.Job == EmployeeJob.MANAGER)
                    manager = emp;
            }
            if(manager != null)
            {
                lblManagerName.Text = $"{manager.First} {manager.Last}";
                lblManagerEmail.Text = manager.Email;
                lblManagerTel.Text = "+" + manager.Phone;
            }
            else
            {
                lblManagerName.Text = "N/A";
                lblManagerEmail.Text = "N/A";
                lblManagerTel.Text = "N/A";
            }
            lblStoreAddress.Text = lc.LocationData().Address;
            if (lc.LocationData().Capacity == 0)
                lblStoreCapacity.Text = "N/A";
            else
                lblStoreCapacity.Text = lc.LocationData().Capacity.ToString();
            lblStoreEmail.Text = lc.LocationData().Email;
            lblStoreID.Text = lc.LocationData().LocationID;
            lblStoreTel.Text = "+" + lc.LocationData().Tel.ToString();
            lblTotalEmployee.Text = flpEmployee.Controls.Count.ToString();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            if(btnInfo.Text == "⯅")
            {
                pGeneralInfo.Visible = false;
                btnInfo.Text = "⯆";
                pStoreEmployeeInfo.Size = new Size(1087, 591);
            }
            else
            {
                pGeneralInfo.Visible = true;
                btnInfo.Text = "⯅";
                pStoreEmployeeInfo.Size = new Size(1087, 367);
            }
        }

        private void CbAddressType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReloadLocationList();
        }

        private void ReloadLocationList()
        {
            lt = LocationType.ALL;
            if (cbAddressType.Text == "Store")
                lt = LocationType.STORE;
            else if (cbAddressType.Text == "Office/HQ")
                lt = LocationType.HQ;
            flpLocation.Controls.Clear();
            foreach (Location l in lc.GetFilterdData(lt, tbSearchLocations.Text))
            {
                LocationListing sl = new LocationListing();
                sl.LoadLayout(l.LocationID, l.Type.ToString(), l.Address, l.Tel, l.Email, lc, ec, this);
                flpLocation.Controls.Add(sl);
            }
            if(flpLocation.Controls.Count == 0)
                MessageBox.Show("No Location found.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void SelectionChangeCommitted(object sender, EventArgs e)
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

            if (ec.FilterEmployeeList(job, gender, cbArchived.Checked).Count != 0)
            {
                flpEmployee.Controls.Clear();
                foreach (Employee emp in ec.FilterEmployeeList(job, gender, cbArchived.Checked))
                {
                    EmployeeListing el = new EmployeeListing();
                    el.LoadLayout(emp.First, emp.Last, emp.EmployeeID, emp.Job, emp.Email, emp.Phone, emp.ProfilePic, this);
                    flpEmployee.Controls.Add(el);
                }
            }
            else
                MessageBox.Show("No employee(s) found matching input.", "Employee Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void TbSearchEmployee_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (ec.SearchEmployee(tbSearchEmployee.Text).Count != 0)
                {
                    flpEmployee.Controls.Clear();
                    foreach (Employee emp in ec.SearchEmployee(tbSearchEmployee.Text))
                    {
                        EmployeeListing el = new EmployeeListing();
                        el.LoadLayout(emp.First, emp.Last, emp.EmployeeID, emp.Job, emp.Email, emp.Phone, emp.ProfilePic, this);
                        flpEmployee.Controls.Add(el);
                    }
                }
                else
                    MessageBox.Show("No employee(s) found matching input.", "Employee Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TbSearchLocations_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                ReloadLocationList();
        }

        public void LoadProfile(EmployeeListing el)
        {
            pEmployee.Visible = true;
            ec.SetEmployeeByID(el.ID);
            tbFirst.Text = ec.GetEmployee().First;
            tbLast.Text = ec.GetEmployee().Last;
            tbEmail.Text = ec.GetEmployee().Email;
            tbAddress.Text = ec.GetEmployee().Address;
            tbPassword.Text = ec.GetEmployee().Password;
            tbPhone.Text = ec.GetEmployee().Phone.ToString();
            tbSalary.Text = ec.GetEmployee().Salary.ToString();
            tbEmployeeID.Text = ec.GetEmployee().EmployeeID;
            pbProfile.Image = ec.GetEmployee().ProfilePic;
            for (int i = 0; i < lc.GetLocationList().Count; i++)
            {
                cbLocationE.Items.Add(lc.GetLocationList()[i].Address);
                if (ec.GetEmployee().Store == lc.GetLocationList()[i].Address)
                    cbLocationE.SelectedIndex = i;
            }
            for (int i = 0; i < 4; i++)
            {
                EmployeeJob ej = EmployeeJob.ADMINISTRATOR;
                if (cbDepartmentE.Items[i].ToString() == "Manager")
                    ej = EmployeeJob.MANAGER;
                else if (cbDepartmentE.Items[i].ToString() == "Floor Employee")
                    ej = EmployeeJob.FLOOR;
                else if (cbDepartmentE.Items[i].ToString() == "Warehouse Worker")
                    ej = EmployeeJob.WAREHOUSE;
                if (ec.GetEmployee().Job == ej)
                    cbDepartmentE.SelectedIndex = i;
            }
        }

        private void BtnUpdateProfile_Click(object sender, EventArgs e)
        {
            if (cbFireEmployee.Checked)
                if(MessageBox.Show("You are about to fire an employee. \r\nBy doing so, this employee will lose access to their account and will be archived. Proceed anyway?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string job = "Administrator";
                    if (cbDepartmentE.SelectedIndex == 1)
                        job = "Manger";
                    else if (cbDepartmentE.SelectedIndex == 2)
                        job = "Floor Employee";
                    else if (cbDepartmentE.SelectedIndex == 3)
                        job = "Warehouse Worker";
                    string fired = "";
                    string date = "";
                    char arc = 'N';
                    if (cbFireEmployee.Checked)
                    {
                        arc = 'N';
                        fired = tbReason.Text;
                        date = DateTime.Now.ToString();
                    }
                    try
                    {
                        ec.UpdateEmployeeProfile(tbEmployeeID.Text, tbFirst.Text, tbLast.Text, job, tbEmail.Text, Convert.ToInt32(tbPhone.Text), tbAddress.Text, tbPassword.Text, cbLocationE.Text, date, arc, fired, Convert.ToInt32(tbSalary.Text));
                        em.UpdatedCredentials(ec.GetEmployee().Email);
                        pEmployee.Visible = false;
                        LoadNewLocation();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Some information entered was invalid. Please check again and re-submit", "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
        }

        private void CbFireEmployee_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFireEmployee.Checked)
            {
                lblReason.Enabled = true;
                tbReason.Enabled = true;
                lblNote.Enabled = true;
            }
            else
            {
                lblNote.Enabled = false;
                lblReason.Enabled = false;
                tbReason.Enabled = false;
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            pEmployee.Visible = false;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            panelEditLoc.Visible = true;
            pGeneralInfo.Visible = false;
            pOverview.Visible = false;
            LoadEditData();
        }

        private void LoadEditData()
        {
            string address = lc.LocationData().Address;
            string street = address.Substring(0, address.IndexOf(',') - 1);
            string postal = address.Substring(address.IndexOf(',') + 2, 8);
            postal = postal.Remove(4, 1);
            string city = address.Remove(0, address.LastIndexOf(' ') + 1);
            tbCity.Text = city;
            lblLocationID.Text = lc.LocationData().LocationID;
            tbPhoneNum.Text = "+" + lc.LocationData().Tel.ToString();
            tbEmailAddr.Text = lc.LocationData().Email;
            tbStreet.Text = street;
            tbWebsiteName.Text = lc.LocationData().Website;
            tbPostal.Text = postal;

            // no fkn clue why this shit doesnt work
            LocationType lt1 = LocationType.ALL;
            if (lt == LocationType.ALL)
                lt1 = LocationType.HQ;

            if (lt1 == LocationType.HQ)
                cbAddressType.SelectedItem = "HQ/Office";
            else
                cbAddressType.SelectedItem = "Store";
        }

        private void LblPanel1_Click(object sender, EventArgs e)
        {

        }

        private void LocationsForm_Load(object sender, EventArgs e)
        {

        }

        private void TbPostal_TextChanged(object sender, EventArgs e)
        {
            if (tbCity.Text != "" && tbStreet.Text != "" && tbPostal.Text != "")
                lblLocationID.Text = tbStreet.Text.Remove(2).ToUpper() + tbPostal.Text;
        }
    }
}
