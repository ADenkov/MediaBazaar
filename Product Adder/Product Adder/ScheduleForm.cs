using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product_Adder
{
    public partial class ScheduleForm : Form
    {
        private SqlConnection cnn = new SqlConnection("Data Source=89.157.247.62;Initial Catalog=Media Bazaar;Persist Security Info=True;User ID=admin;Password=admin");
        private List<string> reason;
        private List<string> store;
        private List<string> departments;
        private Random r;

        public ScheduleForm()
        {
            InitializeComponent();
        }

        private void ScheduleForm_Load(object sender, EventArgs e)
        {
            reason = new List<string>();
            store = new List<string>();
            departments = new List<string>();
            reason.Add("Called in sick.");
            reason.Add("Was inexplicably absent");
            reason.Add("Was at hospital");
            reason.Add("Is spending too much time in the bathroom");
            using (SqlCommand cmd = new SqlCommand("SELECT distinct(Store_Address) FROM EmployeeData", cnn))
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    store.Add(reader.GetString(0));
                cnn.Close();
            }
            using (SqlCommand cmd = new SqlCommand("SELECT distinct(Access_Modifier) FROM EmployeeData WHERE Access_Modifier != 'ALL'", cnn))
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    departments.Add(reader.GetString(0));
                cnn.Close();
            }
        }

        private void GeneratePerStorePerDep(string add, string dep)
        {
            r = new Random();
            List<string> employees = new List<string>();
            using (SqlCommand cmd = new SqlCommand("SELECT Employee_ID FROM EmployeeData WHERE Archived = 'N' AND Store_Address = '" + add + "' AND Access_Modifier = '" + dep + "'", cnn))
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    employees.Add(reader.GetString(0));
                cnn.Close();
            }
            if(employees.Count != 0)
                for (int x = 0; x < 29; x++)
                    for(int i = 0; i < 4; i++)
                        using (SqlCommand cmd = new SqlCommand("INSERT INTO ScheduleData(Day, Morning, Afternoon, Evening, Department, Store_Address) VALUES('" + DateTime.Now.AddDays(x) + "', '" + employees[r.Next(employees.Count)] + "', '" + employees[r.Next(employees.Count)] + "', '" + employees[r.Next(employees.Count)] + "', '" + dep + "', '" + add + "')", cnn))
                        {
                            cnn.Open();
                            cmd.ExecuteNonQuery();
                            cnn.Close();
                        }
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            foreach (string address in store)
                foreach (string department in departments)
                    GeneratePerStorePerDep(address, department);
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("DELETE FROM ScheduleData", cnn))
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }
    }
}
