using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Adder
{
    class Annoucement
    {
        private SqlConnection cnn = new SqlConnection("Data Source=89.157.247.62;Initial Catalog=Media Bazaar;Persist Security Info=True;User ID=admin;Password=admin");

        public Annoucement() { }

        public void AddAnnoucement(string from, bool adm, bool man, bool flo, bool war, string message, string title, string date, string toStore, string fromStore)
        {
            List<string> to = new List<string>();
            if(adm == true) { to.Add("Administrator"); }
            if (man == true) { to.Add("Manager"); }
            if (flo == true) { to.Add("Floor Employee"); }
            if (war == true) { to.Add("ALL"); }

            for (int i = 0; i < to.Count; i++)
            {
                string sql = "INSERT INTO AnnoucementData(From_Department, To_Department, Message, Message_Subject, Message_Date, To_Store_Address, From_Store_Address) VALUES('" + from + "', '" + to[i] + "', '" + message + "', '" + title + "', '" + date + "', '" + toStore + "', '" + fromStore + "')";
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                }
            }
        }

        public void RemoveData()
        {
            cnn.Open();
            using (SqlCommand cmd = new SqlCommand("DELETE FROM AnnoucementData", cnn))
            {
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }
    }
}
