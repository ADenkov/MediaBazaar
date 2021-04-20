using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApp
{
    public class Schedule
    {
        public DateTime Day { get; private set; }
        public Employee Morning { get; private set; }
        public Employee Afternoon { get; private set; }
        public Employee Evening { get; private set; }
        public string Department { get; private set; }
        public string Store { get; private set; }

        public Schedule(DateTime day, Employee morning, Employee afternoon, Employee evening, string dep, string store)
        {
            Day = day;
            Morning = morning;
            Afternoon = afternoon;
            Evening = evening;
            Department = dep;
            Store = store;
        }
    }
}
