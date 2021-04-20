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
    public partial class AnnoucementsForm : Form
    {
        private AnnoucementCollection ac;
        private LocationCollection lc;
        private EmployeeCollection ec;

        public AnnoucementsForm(ConnectSQL cnn, EmployeeProfile ep)
        {
            InitializeComponent();
            ac = new AnnoucementCollection(cnn, ep, ec);
            ec = new EmployeeCollection(cnn);
            lc = new LocationCollection(cnn, ec);
        }

        private void AnnoucementsForm_Load(object sender, EventArgs e)
        {
            LoadAllAnnoucements();
            NoAnnoucement();
            foreach (Location l in lc.GetLocationList())
                cbLocation.Items.Add(l.Address);
        }

        public void NoAnnoucement()
        {
            if (!CheckAnnoucements())
            {
                NoAnnoucements noa = new NoAnnoucements();
                noa.ActivePanelAnnoucements(this);
                flpAnnoucement.Controls.Add(noa);
            }
        }

        public void LoadAllAnnoucements()
        {
            flpAnnoucement.Controls.Clear();
            foreach (Annoucement a in ac.GetAllAnnoucements())
            {
                AnnoucementListing al = new AnnoucementListing();
                al.LoadLayout(a.From, a.Subject, a.Content, a.FromStore, a.Date);
                flpAnnoucement.Controls.Add(al);
            }
            cbLocation.SelectedIndex = 0;
            cbDepartment.SelectedIndex = 0;
            NoAnnoucement();
        }

        public void FilterAnnoucements()
        {
            EmployeeJob job = EmployeeJob.ALL;
            if (cbDepartment.SelectedIndex == 1)
                job = EmployeeJob.ADMINISTRATOR;
            else if (cbDepartment.SelectedIndex == 2)
                job = EmployeeJob.MANAGER;
            else if (cbDepartment.SelectedIndex == 3)
                job = EmployeeJob.FLOOR;
            else if (cbDepartment.SelectedIndex == 4)
                job = EmployeeJob.WAREHOUSE;
            flpAnnoucement.Controls.Clear();
            if (ac.GetFilteredList(job, cbLocation.Text).Count != 0)
            {
                foreach (Annoucement a in ac.GetFilteredList(job, cbLocation.Text))
                {
                    AnnoucementListing al = new AnnoucementListing();
                    al.LoadLayout(a.From, a.Subject, a.Content, a.FromStore, a.Date);
                    flpAnnoucement.Controls.Add(al);
                }
            }
            else
            {
                NoAnnoucements noa = new NoAnnoucements();
                noa.ActivePanelAnnoucements(this);
                flpAnnoucement.Controls.Add(noa);
            }
        }

        public bool CheckAnnoucements()
        {
            if (flpAnnoucement.Controls.Count == 0)
                return false;
            return true;
        }

        private void AllComboBox_SelectionCommited(object sender, EventArgs e)
        {
            FilterAnnoucements();
        }
    }
}
