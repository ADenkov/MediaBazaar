using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApp
{
    class ScheduleCollection
    {
        private ConnectSQL cnn;
        private EmployeeCollection ec;
        private List<Schedule> schedules;
        private Schedule s;

        public ScheduleCollection(ConnectSQL cnn, EmployeeCollection ec)
        {
            this.cnn = cnn;
            this.ec = ec;
        }

        public void GetData(string store)
        {
            schedules = new List<Schedule>();
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM ScheduleData WHERE Store_Address = '" + store + "'", cnn.sqlConection()))
            {
                cnn.Open();
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    ec.SetEmployeeByID(r.GetString(1));
                    Employee m = ec.GetEmployee();
                    ec.SetEmployeeByID(r.GetString(2));
                    Employee a = ec.GetEmployee();
                    ec.SetEmployeeByID(r.GetString(3));
                    Employee e = ec.GetEmployee();
                    s = new Schedule(r.GetDateTime(0), m, a, e, r.GetString(4), r.GetString(5));
                    schedules.Add(s);
                }
                cnn.Close();
            }
        }

        public void UpdateSchedule(string currentID, string newID, DateTime day, string TOD)
        {
            using (SqlCommand cmd = new SqlCommand("UPDATE ScheduleData SET " + TOD + " = '" + newID + "' WHERE " + TOD + " = '" + currentID + "' AND Day = '" + day + "'", cnn.sqlConection()))
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }

        public List<Schedule> GetWeekSchedule(string department, DateTime week, string store)
        {
            GetData(store);
            List<Schedule> sch = new List<Schedule>();
            foreach (Schedule s in schedules)
                if (s.Day == week && s.Department == department)
                    sch.Add(s);
            return sch;
        }

        public List<DateTime> GetWeeks()
        {
            List<DateTime> days = new List<DateTime>();
            List<DateTime> dt = new List<DateTime>();
            foreach (Schedule d in schedules)
                    days.Add(d.Day);
            foreach (DateTime t in days.Distinct())
                if ((int)t.DayOfWeek == 1)
                    dt.Add(t);
            return dt;
        }
    }
}
