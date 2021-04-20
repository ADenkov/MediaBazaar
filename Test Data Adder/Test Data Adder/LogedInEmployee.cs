using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Data_Adder
{
    public class LogedInEmployee
    {
        private SqlConnection cnn = new SqlConnection("Data Source=89.157.247.62;Initial Catalog=Media Bazaar;Persist Security Info=True;User ID=admin;Password=admin");

        public string EmployeeID { get; private set; }
        public string First { get; private set; }
        public string Last { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public string Address { get; private set; }
        public string Store { get; private set; }
        public string Password { get; private set; }
        public string Role { get; private set; }
        public string DateJoined { get; private set; }
        public string Hours { get; private set; }
        public string Salary { get; private set; }
        public char Messages { get; private set; }
        public Image ProfilePic { get; private set; }
        public bool Succeeded { get; private set; }

        public LogedInEmployee(string username, string password)
        {
            VerifyCredentials(username, password);
            if (Succeeded == true)
                GetData(username, password);
        }

        private void VerifyCredentials(string username, string password)
        {
            using (SqlCommand cmd = new SqlCommand("SELECT count(*) FROM EmployeeData WHERE Employee_ID = '" + username + "' AND Password = '" + password + "'", cnn))
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    if((int)reader.GetValue(0) == 1)
                        Succeeded = true;
                cnn.Close();
            }
        }

        private void GetData(string username, string password)
        {
            using (SqlCommand cmd = new SqlCommand("SELECT Employee_ID, First_Name, Last_Name, Email, Phone, Address, Store_Address, Password, Access_Modifier, Date_Joined, Hours_Worked, Salary, Receive_Announcements, Profile_Picture FROM EmployeeData WHERE Employee_ID = '" + username + "' AND Password = '" + password + "'", cnn))
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    EmployeeID = reader.GetString(0);
                    First = reader.GetString(1);
                    Last = reader.GetString(2);
                    Email = reader.GetString(3);
                    Phone = reader.GetValue(4).ToString();
                    Address = reader.GetString(5);
                    Store = reader.GetString(6);
                    Password = reader.GetString(7);
                    Role = reader.GetString(8);
                    DateJoined = reader.GetString(9);
                    Hours = reader.GetValue(10).ToString();
                    Salary = reader.GetValue(11).ToString();
                    Messages = reader.GetString(12)[0];
                    byte[] img = (byte[])(reader[13]);
                    MemoryStream ms = new MemoryStream(img);
                    ProfilePic = Image.FromStream(ms);
                }
                cnn.Close();
            }
        }
        public void UpdateData(string email, string phone, string password)
        {
            using (SqlCommand cmd = new SqlCommand("UPDATE EmployeeData SET Email = '" + email + "', Phone = " + phone + ", Password = '" + password + "' WHERE Employee_ID = '" + EmployeeID + "' AND Password = '" + Password + "'", cnn))
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }

        public void UpdateData(string email, string phone, string password, string imgPath)
        {
            using (SqlCommand cmd = new SqlCommand("UPDATE EmployeeData SET Email = '" + email + "', Phone = " + phone + ", Password = '" + password + "', Profile_Picture = @img WHERE Employee_ID = '" + EmployeeID + "' AND Password = '" + Password + "'", cnn))
            {
                cnn.Open();
                FileStream fs = new FileStream(imgPath, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                byte[] binary = br.ReadBytes((int)fs.Length);
                cmd.Parameters.Add(new SqlParameter("@img", binary));
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }

        public void UpdateMessages(bool receive)
        {
            char ticker = 'Y';
            if(receive == false) { ticker = 'N'; }
            using (SqlCommand cmd = new SqlCommand("UPDATE EmployeeData SET Receive_Announcements = '" + ticker + "' WHERE Employee_ID = '" + EmployeeID + "' AND Password = '" + Password + "'", cnn))
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }
    }
}
