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
    public partial class DashboardForm : Form
    {
        private ConnectSQL cnn;
        private ScheduleCollection sc;
        private LocationCollection lc;
        private EmployeeCollection ec;
        private EmployeeProfile ep;
        private List<FlowLayoutPanel> flps;

        public DashboardForm(ConnectSQL cnn, EmployeeProfile ep)
        {
            InitializeComponent();
            this.ep = ep;
            this.cnn = cnn;
            ec = new EmployeeCollection(cnn);
            sc = new ScheduleCollection(cnn, ec);
            lc = new LocationCollection(cnn, ec);
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            flps = new List<FlowLayoutPanel>();
            foreach (FlowLayoutPanel flp in pMain.Controls.OfType<FlowLayoutPanel>())
                flps.Add(flp);
            foreach (Location loc in lc.GetLocationList())
                cbLocation.Items.Add(loc.Address);
            for (int i = 0; i < cbLocation.Items.Count; i++)
                if (cbLocation.Items[i].ToString() == ep.Store)
                    cbLocation.SelectedIndex = i;
            ec.GetData(cbLocation.Text);
            sc.GetData(cbLocation.Text);
            foreach (DateTime d in sc.GetWeeks())
                cbWeek.Items.Add(d);
            if (ep.Role == EmployeeJob.ADMINISTRATOR || ep.Role == EmployeeJob.ALL)
                cbDepartment.SelectedIndex = 0;
            else if (ep.Role == EmployeeJob.MANAGER)
                cbDepartment.SelectedIndex = 1;
            else if (ep.Role == EmployeeJob.FLOOR)
                cbDepartment.SelectedIndex = 2;
            else if (ep.Role == EmployeeJob.WAREHOUSE)
                cbDepartment.SelectedIndex = 3;
            if (ep.Role != EmployeeJob.ADMINISTRATOR && ep.Role != EmployeeJob.ALL)
            {
                cbLocation.Visible = false;
                cbDepartment.Visible = false;
                lblLocation.Visible = false;
                lblDepartment.Visible = false;
            }
            else if (ep.Role != EmployeeJob.MANAGER && ep.Role != EmployeeJob.ALL)
            {
                cbLocation.Visible = false;
                lblLocation.Visible = false;
            }
            cbWeek.SelectedIndex = 0;
            LoadWeekCalendar(Convert.ToDateTime(cbWeek.Text));
        }

        public void LoadWeekCalendar(DateTime day)
        {
            ec.GetData(cbLocation.Text);
            sc.GetData(cbLocation.Text);
            foreach (FlowLayoutPanel flp in pMain.Controls.OfType<FlowLayoutPanel>())
                flp.Controls.Clear();
            for (int i = 0; i < flps.Count; i++)
            {
                foreach (Schedule sch in sc.GetWeekSchedule(cbDepartment.Text, day.AddDays(i), cbLocation.Text))
                {
                    CalendarFiller cf = new CalendarFiller();
                    cf.LoadLayout(cnn, sch.Day, sch.Morning, "Morning", this);
                    flps[i].Controls.Add(cf);
                }
                foreach (Schedule sch in sc.GetWeekSchedule(cbDepartment.Text, day.AddDays(i), cbLocation.Text))
                {
                    CalendarFiller cf = new CalendarFiller();
                    cf.LoadLayout(cnn, sch.Day, sch.Afternoon, "Afternoon", this);
                    flps[i].Controls.Add(cf);
                }
                foreach (Schedule sch in sc.GetWeekSchedule(cbDepartment.Text, day.AddDays(i), cbLocation.Text))
                {
                    CalendarFiller cf = new CalendarFiller();
                    cf.LoadLayout(cnn, sch.Day, sch.Evening, "Evening", this);
                    flps[i].Controls.Add(cf);
                }
            }
        }

        private void Controls_ChangeCommited(object sender, EventArgs e)
        {
            LoadWeekCalendar(Convert.ToDateTime(cbWeek.Text));
        }
    }
}
