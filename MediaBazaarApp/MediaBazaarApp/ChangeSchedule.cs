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
    public partial class ChangeSchedule : Form
    {
        private EmployeeCollection ec;
        private ScheduleCollection sc;
        private DashboardForm dbf;
        private Employee emp;
        private DateTime day;
        private string TOD;

        public ChangeSchedule(ConnectSQL cnn, Employee emp, DateTime day, string TOD, DashboardForm dbf)
        {
            InitializeComponent();
            this.emp = emp;
            this.dbf = dbf;
            this.day = day;
            this.TOD = TOD;
            ec = new EmployeeCollection(cnn);
            sc = new ScheduleCollection(cnn, ec);
            sc.GetData(emp.Store);
            lblName.Text = $"{emp.First} {emp.Last}";
            ec.GetData(emp.Store);
            foreach (Employee employee in ec.FilterEmployeeList(emp.Job, EmployeeGender.ALL, false))
                if(employee.EmployeeID != emp.EmployeeID)
                    cbNames.Items.Add($"{employee.First} {employee.Last}");
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if(cbNames.SelectedIndex != -1)
            {
                string first = cbNames.Text.Remove(cbNames.Text.IndexOf(' '));
                string last = cbNames.Text.Substring(cbNames.Text.IndexOf(' ') + 1);
                ec.SetEmployeeByFirstLast(first, last);
                sc.UpdateSchedule(emp.EmployeeID, ec.GetEmployee().EmployeeID, day, TOD);
                dbf.LoadWeekCalendar(sc.GetWeeks()[0]);
                Close();
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
