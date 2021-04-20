using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Test_Data_Adder
{
    public partial class MainForm : Form
    {
        private SqlConnection cnn = new SqlConnection("Data Source=89.157.247.62;Initial Catalog=Media Bazaar;Persist Security Info=True;User ID=admin;Password=admin");
        private string imgPath;
        private string EmpID;
        private Random rdn = new Random();
        public MainForm()
        {
            InitializeComponent();
            comboBoxAccess.Items.AddRange(new string[] { "HR Department", "Manager", "Floor Employee", "Warehouse Worker" });
            textBoxFirstName.Text = "Noah";
            textBoxLastName.Text = "Greff";
            textBoxPhone.Text = "1234567890";
            textBoxEmail.Text = "something@somthing.com";
            textBoxAddress.Text = "This 1234 IS MyAddress";
            comboBoxAccess.SelectedIndex = 0;
            pictureBox.InitialImage = null;
        }

        private void ButtonImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG Files (*.jpg)|*.jpg|All Files (*.*)|*";
            ofd.Title = "Select Employee Picture";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imgPath = ofd.FileName.ToString();
                pictureBox.ImageLocation = imgPath;
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if(buttonSave.Text == "Save Changes")
            {
                byte[] binary = null;
                FileStream fs = new FileStream(imgPath, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                binary = br.ReadBytes((int)fs.Length);

                SqlDataAdapter da = new SqlDataAdapter();
                using (da.DeleteCommand = new SqlCommand("DELETE EmployeeData WHERE Employee_ID = '" + EmpID + "'", cnn))
                {
                    cnn.Open();
                    da.DeleteCommand.ExecuteNonQuery();
                    cnn.Close();
                }
                string sql = "INSERT INTO EmployeeData(Employee_ID, First_Name, Last_Name, Access_Modifier, Email, Phone, Address, Profile_Picture) VALUES('" + EmpID + "', '" + textBoxFirstName.Text + "', '" + textBoxLastName.Text + "', '" + comboBoxAccess.Text + "', '" + textBoxEmail.Text + "', " + Convert.ToInt32(textBoxPhone.Text) + ", '" + textBoxAddress.Text + "', @img)";
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cnn.Open();
                    cmd.Parameters.Add(new SqlParameter("@img", binary));
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                }
                textBoxFirstName.Clear(); textBoxLastName.Clear(); textBoxPhone.Clear(); textBoxEmail.Clear(); textBoxAddress.Clear(); comboBoxAccess.SelectedIndex = -1; pictureBox.Image = null;
            }
            else
            {
                string ID = "";
                char[] alphabet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
                char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                for (int i = 0; i < 2; i++)
                    ID += alphabet[rdn.Next(0, 26)];
                for (int i = 0; i < 2; i++)
                    ID += numbers[rdn.Next(0, 10)];

                try
                {
                    byte[] binary = null;
                    FileStream fs = new FileStream(imgPath, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    binary = br.ReadBytes((int)fs.Length);

                    string sql = "INSERT INTO EmployeeData(Employee_ID, First_Name, Last_Name, Access_Modifier, Email, Phone, Address, Profile_Picture) VALUES('" + ID + "', '" + textBoxFirstName.Text + "', '" + textBoxLastName.Text + "', '" + comboBoxAccess.Text + "', '" + textBoxEmail.Text + "', " + Convert.ToInt32(textBoxPhone.Text) + ", '" + textBoxAddress.Text + "', @img)";
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Parameters.Add(new SqlParameter("@img", binary));
                        int x = cmd.ExecuteNonQuery();
                        cnn.Close();
                        MessageBox.Show(x.ToString() + " record(s) added. Image size : " + fs.Length.ToString() + " EmployeeID : " + ID);
                    }
                    textBoxFirstName.Clear(); textBoxLastName.Clear(); textBoxPhone.Clear(); textBoxEmail.Clear(); textBoxAddress.Clear(); comboBoxAccess.SelectedIndex = -1; pictureBox.Image = null;
                }
                catch (Exception ex)
                {
                    cnn.Close();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ButtonGetData_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT * FROM EmployeeData WHERE Employee_ID = '" + textBoxID.Text + "'";
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        textBoxFirstName.Text = reader[0].ToString();
                        textBoxLastName.Text = reader[1].ToString();
                        textBoxPhone.Text = reader[2].ToString();
                        textBoxEmail.Text = reader[3].ToString();
                        textBoxAddress.Text = reader[4].ToString();
                        comboBoxAccess.Text = reader[5].ToString();
                        byte[] img = (byte[])(reader[6]);
                        MemoryStream ms = new MemoryStream(img);
                        pictureBox.Image = Image.FromStream(ms);
                        EmpID = textBoxID.Text;
                        buttonImage.Text = "Change Picture";
                        buttonSave.Text = "Save Changes";
                    }
                }
                cnn.Close();
            }
            catch (Exception ex)
            {
                cnn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonSchedule_Click(object sender, EventArgs e)
        {

        }

        private void ButtonReport_Click(object sender, EventArgs e)
        {
            Form rf = new ReportForm();
            rf.Show();
        }

        private void ButtonSendEmail_Click(object sender, EventArgs e)
        {
            Form ef = new EmailForm();
            ef.Show();
        }

        private void ButtonProduct_Click(object sender, EventArgs e)
        {
            Form pf = new PorductsForm();
            pf.Show();
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            Form rp = new GenerateReportForm();
            rp.Show();
        }

        private void BtnProfile_Click(object sender, EventArgs e)
        {
            Form pf = new ProfileForm();
            pf.Show();
        }
    }
}
