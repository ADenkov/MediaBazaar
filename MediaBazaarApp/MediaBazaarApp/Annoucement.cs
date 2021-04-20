using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApp
{
    class Annoucement
    {
        public EmployeeJob From { get; private set; }
        public EmployeeJob To { get; private set; }
        public string Content { get; private set; }
        public string Subject { get; private set; }
        public string ToStore { get; private set; }
        public string FromStore { get; private set; }
        public DateTime Date { get; private set; }

        public Annoucement(string from, string to, string content, string subject, string toStore, string fromStore, DateTime dt)
        {
            From = EmployeeJob.ADMINISTRATOR;
            if (from == "Manager")
                From = EmployeeJob.MANAGER;
            else if (from == "Floor Employee")
                From = EmployeeJob.FLOOR;
            else if (from == "Warehouse Worker")
                From = EmployeeJob.WAREHOUSE;
            To = EmployeeJob.ADMINISTRATOR;
            if (to == "Manager")
                To = EmployeeJob.MANAGER;
            else if (to == "Floor Employee")
                To = EmployeeJob.FLOOR;
            else if (to == "Warehouse Worker")
                To = EmployeeJob.WAREHOUSE;
            Content = content;
            Subject = subject;
            ToStore = toStore;
            FromStore = fromStore;
            Date = dt;
        }
    }
}
