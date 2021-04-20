using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApp
{
    public class Employee
    {
        public string EmployeeID { get; private set; }
        public string First { get; private set; }
        public string Last { get; private set; }
        public EmployeeGender Gender { get; private set; }
        public EmployeeJob Job { get; private set; }
        public string Email { get; private set; }
        public int Phone { get; private set; }
        public string Address { get; private set; }
        public string Password { get; private set; }
        public string Store { get; private set; }
        public DateTime DateJoined { get; private set; }
        public DateTime DateLeft { get; private set; }
        public int Hours { get; private set; }
        public EmployeeArchived Archived { get; private set; }
        public string LeftReason { get; private set; }
        public int Salary { get; private set; }
        public char Notifications { get; private set; }
        public Image ProfilePic { get; private set; }

        public Employee(string ID, string first, string last, string gender, string job, string email, int phone, string address, string password, string store, DateTime joined, DateTime left, int hours, char archived, string reason, int salary, char notify, Image image)
        {
            EmployeeID = ID;
            First = first;
            Last = last;
            Gender = EmployeeGender.UNDEFINED;
            if (gender == "Male")
                Gender = EmployeeGender.MALE;
            else if (gender == "Female")
                Gender = EmployeeGender.FEMALE;
            Job = EmployeeJob.ADMINISTRATOR;
            if (job == "Manager")
                Job = EmployeeJob.MANAGER;
            else if (job == "Floor Employee")
                Job = EmployeeJob.FLOOR;
            else if (job == "Warehouse Worker")
                Job = EmployeeJob.WAREHOUSE;
            Email = email;
            Phone = phone;
            Address = address;
            Password = password;
            Store = store;
            DateJoined = joined;
            DateLeft = left;
            Hours = hours;
            Archived = EmployeeArchived.AVAILABLE;
            if (archived == 'N')
                Archived = EmployeeArchived.ARCHIVED;
            LeftReason = reason;
            Salary = salary;
            Notifications = notify;
            ProfilePic = image;
        }
    }
}
