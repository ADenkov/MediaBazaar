using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersApp
{
    public class EmployeeProfile
    {
        private MainForm mf;
        private ConnectSQL cnn;

        public string EmployeeID { get; private set; }
        public string First { get; private set; }
        public string Last { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public string Address { get; private set; }
        public string Store { get; private set; }
        public string Password { get; private set; }
        public EmployeeJob Role { get; private set; }
        public DateTime DateJoined { get; private set; }
        public string Hours { get; private set; }
        public string Salary { get; private set; }
        public bool Messages { get; private set; }
        public Image ProfilePic { get; private set; }
        public string Color { get; private set; }
        public bool Succeeded { get; private set; }

        public EmployeeProfile(ConnectSQL cnn, string username, string password, MainForm mf)
        {
            this.cnn = cnn;
            this.mf = mf;
            VerifyCredentials(username, password);
            if (Succeeded == true)
                GetData(username, password);
        }

        private void VerifyCredentials(string username, string password)
        {
            using (SqlCommand cmd = new SqlCommand("SELECT count(*) FROM EmployeeData WHERE Employee_ID = '" + username + "' AND Password = '" + password + "' AND Archived = 'N'", cnn.sqlConection()))
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    if ((int)reader.GetValue(0) == 1)
                        Succeeded = true;
                cnn.Close();
            }
        }

        private void GetData(string username, string password)
        {
            using (SqlCommand cmd = new SqlCommand("SELECT Employee_ID, First_Name, Last_Name, Email, Phone, Address, Store_Address, Password, Access_Modifier, Date_Joined, Hours_Worked, Salary, Receive_Announcements, Profile_Picture, App_Color FROM EmployeeData WHERE Employee_ID = '" + username + "' AND Password = '" + password + "'", cnn.sqlConection()))
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
                    Role = EmployeeJob.ADMINISTRATOR;
                    if (reader.GetString(8) == "Manger")
                        Role = EmployeeJob.MANAGER;
                    else if (reader.GetString(8) == "Floor Employee")
                        Role = EmployeeJob.FLOOR;
                    else if (reader.GetString(8) == "Warehouse Worker")
                        Role = EmployeeJob.WAREHOUSE;
                    else if (reader.GetString(8) == "ALL")
                        Role = EmployeeJob.ALL;
                    DateJoined = reader.GetDateTime(9);
                    Hours = reader.GetValue(10).ToString();
                    Salary = reader.GetValue(11).ToString();
                    Messages = false;
                    if (reader.GetString(12)[0] == 'Y')
                        Messages = true;
                    byte[] img = (byte[])(reader[13]);
                    MemoryStream ms = new MemoryStream(img);
                    ProfilePic = Image.FromStream(ms);
                    Color = reader.GetString(14);
                }
                cnn.Close();
            }
        }
        public void UpdateData(string email, string phone, string password)
        {
            using (SqlCommand cmd = new SqlCommand("UPDATE EmployeeData SET Email = '" + email + "', Phone = " + phone + ", Password = '" + password + "' WHERE Employee_ID = '" + EmployeeID + "' AND Password = '" + Password + "'", cnn.sqlConection()))
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
            GetData(EmployeeID, password);
        }

        public void UpdateData(string email, string phone, string password, string imgPath)
        {
            using (SqlCommand cmd = new SqlCommand("UPDATE EmployeeData SET Email = '" + email + "', Phone = " + phone + ", Password = '" + password + "', Profile_Picture = @img WHERE Employee_ID = '" + EmployeeID + "' AND Password = '" + Password + "'", cnn.sqlConection()))
            {
                cnn.Open();
                FileStream fs = new FileStream(imgPath, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                byte[] binary = br.ReadBytes((int)fs.Length);
                cmd.Parameters.Add(new SqlParameter("@img", binary));
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
            GetData(EmployeeID, password);
        }

        public void UpdateMessages(bool receive)
        {
            char ticker = 'Y';
            Messages = true;
            if (receive == false) { ticker = 'N'; Messages = false; }
            using (SqlCommand cmd = new SqlCommand("UPDATE EmployeeData SET Receive_Announcements = '" + ticker + "' WHERE Employee_ID = '" + EmployeeID + "' AND Password = '" + Password + "'", cnn.sqlConection()))
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
            GetData(EmployeeID, Password);
        }
    }
}
