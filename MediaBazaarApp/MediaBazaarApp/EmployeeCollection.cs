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
    public class EmployeeCollection
    {
        private ConnectSQL cnn;
        private List<Employee> employees;
        private Employee e;

        public EmployeeCollection(ConnectSQL cnn)
        {
            this.cnn = cnn;
            employees = new List<Employee>();
        }

        public void GetData(string location)
        {
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM EmployeeData WHERE Store_Address = '" + location + "'", cnn.sqlConection()))
            {
                employees.Clear();
                cnn.Open();
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    byte[] img = (byte[])(r[17]);
                    MemoryStream ms = new MemoryStream(img);
                    e = new Employee(r.GetString(0), r.GetString(1), r.GetString(2), r.GetString(3), r.GetString(4), r.GetString(5), r.GetInt32(6), r.GetString(7), r.GetString(8), r.GetString(9), r.GetDateTime(10), r.GetDateTime(11), r.GetInt32(12), r.GetString(13)[0], r.GetString(14), Convert.ToInt32(r.GetValue(15)), r.GetString(16)[0], Image.FromStream(ms));
                    employees.Add(e);
                }
                cnn.Close();
            }
        }

        public void AddData(string employeeID, string first, string last, string gender, string job, string email, int phone, string address, string password, string store, string dateJoin, string dateLeft, int hours, char archived, string deported, int salary, char message, string path)
        {
            byte[] binary = null;
            if (path != "")
            {
                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                binary = br.ReadBytes((int)fs.Length);
            }
            cnn.Open();
            string sql = "INSERT INTO EmployeeData(Employee_ID, First_Name, Last_Name, Gender, Access_Modifier, Email, Phone, Address, Password, Store_Address, Date_Joined, Date_Left, Hours_Worked, Archived, Deported_Reason, Salary, Receive_Announcements, Profile_Picture) VALUES('" + employeeID + "', '" + first + "', '" + last + "', '" + gender + "', '" + job + "', '" + email + "', " + phone + ", '" + address + "', '" + password + "', '" + store + "', '" + dateJoin + "', '" + dateLeft + "', " + hours + ", '" + archived + "', '" + deported + "', " + salary + ", '" + message + "', @img)";
            using (SqlCommand cmd = new SqlCommand(sql, cnn.sqlConection()))
            {
                cmd.Parameters.Add(new SqlParameter("@img", binary));
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }

        public List<string> GetEmployeeEmailByStoreAndDepartement(string location, EmployeeJob department)
        {
            string dep = "Administrator";
            if (department == EmployeeJob.FLOOR)
                dep = "Floor Employee";
            else if (department == EmployeeJob.MANAGER)
                dep = "Manager";
            else if (department == EmployeeJob.WAREHOUSE)
                dep = "Warehpuse Worker";

            List<string> emp = new List<string>();
            using (SqlCommand cmd = new SqlCommand("SELECT Email FROM EmployeeData WHERE Store_Address = '" + location + "' AND Access_Modifier = '" + dep + "' AND Receive_Announcements = 'Y'", cnn.sqlConection()))
            {
                cnn.Open();
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                    emp.Add(r.GetString(0));
                cnn.Close();
            }
            return emp;
        }

        public void ChangeEmployeeStoreAddress(string newStore, string employeeID)
        {
            using (SqlCommand cmd = new SqlCommand("UPDATE EmployeeData SET Store_Address = '" + newStore + "' WHERE Employee_ID = '" + employeeID + "'", cnn.sqlConection()))
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }

        public void UpdateEmployeeProfile(string employeeID, string first, string last, string job, string email, int phone, string address, string password, string store, string dateLeft, char archived, string deported, decimal salary)
        {
            using (SqlCommand cmd = new SqlCommand("UPDATE EmployeeData SET Employee_ID = '" + employeeID + "', First_Name = '" + first + "', Last_Name = '" + last + "', Access_Modifier = '" + job + "', Email = '" + email + "', Phone = " + phone + ", Address = '" + address + "', Password = '" + password + "', Store_Address = '" + store + "', Date_Left = '" + dateLeft + "', Archived = '" + archived + "', Deported_Reason = '" + deported + "', Salary = " + salary + " WHERE Employee_ID = '" + GetEmployee().EmployeeID + "' AND Password = '" + GetEmployee().Password + "'", cnn.sqlConection()))
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }

        public List<Employee> SearchEmployee(string input)
        {
            List<Employee> emp = new List<Employee>();

            foreach (Employee e in employees)
                if (e.First.Contains(input))
                    emp.Add(e);
                else if (e.Last.Contains(input))
                    emp.Add(e);
                else if (e.Email.Contains(input))
                    emp.Add(e);
            return emp;
        }

        public List<Employee> FilterEmployeeList(EmployeeJob job, EmployeeGender gender, bool archived)
        {
            List<Employee> emp = new List<Employee>();
            List<EmployeeJob> jobEnum = new List<EmployeeJob>();
            List<EmployeeGender> genderEnum = new List<EmployeeGender>();
            if (job == EmployeeJob.ALL)
            {
                jobEnum.Add(EmployeeJob.ADMINISTRATOR);
                jobEnum.Add(EmployeeJob.MANAGER);
                jobEnum.Add(EmployeeJob.FLOOR);
                jobEnum.Add(EmployeeJob.WAREHOUSE);
            }
            else
                jobEnum.Add(job);
            if (gender == EmployeeGender.ALL)
            {
                genderEnum.Add(EmployeeGender.FEMALE);
                genderEnum.Add(EmployeeGender.MALE);
                genderEnum.Add(EmployeeGender.UNDEFINED);
            }
            else
                genderEnum.Add(gender);

            for (int i = 0; i < jobEnum.Count; i++)
                for (int y = 0; y < genderEnum.Count; y++)
                    foreach (Employee employee in employees)
                        if (employee.Job == jobEnum[i] && employee.Gender == genderEnum[y])
                            if (!archived)
                                emp.Add(employee);
                            else
                                if (employee.Archived == EmployeeArchived.AVAILABLE)
                                    emp.Add(employee);
            return emp;
        }

        public List<Employee> GetEmployeeList()
        {
            return employees;
        }

        public void SetEmployeeByID(string ID)
        {
            foreach (Employee emp in employees)
                if (emp.EmployeeID == ID)
                    e = emp;
        }

        public void SetEmployeeByFirstLast(string first, string last)
        {
            foreach (Employee emp in employees)
                if (emp.First == first && emp.Last == last)
                    e = emp;
        }

        public Employee GetEmployee()
        {
            return e;
        }
    }
}
