using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Product_Adder
{
    class Employee
    {
        private SqlConnection cnn = new SqlConnection("Data Source=89.157.247.62;Initial Catalog=Media Bazaar;Persist Security Info=True;User ID=admin;Password=admin");

        public Employee() { }

        public void AddEmployee(string employeeID, string first, string last, string gender, string job, string email, int phone, string address, string password, string store, string dateJoin, string dateLeft, int hours, char archived, string deported, decimal salary, char message, string path, string color)
        {
            byte[] binary = null;
            if (path != "")
            {
                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                binary = br.ReadBytes((int)fs.Length);
            }
            cnn.Open();
            string sql = "INSERT INTO EmployeeData(Employee_ID, First_Name, Last_Name, Gender, Access_Modifier, Email, Phone, Address, Password, Store_Address, Date_Joined, Date_Left, Hours_Worked, Archived, Deported_Reason, Salary, Receive_Announcements, Profile_Picture, App_Color) VALUES('" + employeeID + "', '" + first + "', '" + last + "', '" + gender + "', '" + job + "', '" + email + "', " + phone + ", '" + address + "', '" + password + "', '" + store + "', '" + dateJoin + "', '" + dateLeft + "', " + hours + ", '" + archived + "', '" + deported + "', " + salary + ", '" + message + "', @img, '" + color + "')";
            using (SqlCommand cmd = new SqlCommand(sql, cnn))
            {
                cmd.Parameters.Add(new SqlParameter("@img", binary));
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }

        public void RemoveData()
        {
            cnn.Open();
            using (SqlCommand cmd = new SqlCommand("DELETE FROM EmployeeData WHERE Employee_ID != 'admin' AND Password != 'admin'", cnn))
            {
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }
    }
}
