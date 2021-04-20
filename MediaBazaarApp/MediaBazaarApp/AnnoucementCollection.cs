using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApp
{
    class AnnoucementCollection
    {
        private ConnectSQL cnn;
        private List<Annoucement> annoucements;
        private EmployeeProfile ep;
        private Email em;
        private EmployeeCollection ec;
        private Annoucement a;

        public AnnoucementCollection(ConnectSQL cnn, EmployeeProfile ep, EmployeeCollection ec)
        {
            this.cnn = cnn;
            this.ep = ep;
            this.ec = ec;
            em = new Email(ep, new DeliveryCollection(cnn, ep));
            annoucements = new List<Annoucement>();
            GetData();
        }

        public void GetData()
        {
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM AnnoucementData WHERE To_Department = '" + ep.Role + "' AND To_Store_Address = '" + ep.Store + "'", cnn.sqlConection()))
            {
                cnn.Open();
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    a = new Annoucement(r.GetString(0), r.GetString(1), r.GetString(2), r.GetString(3), r.GetString(5), r.GetString(6), r.GetDateTime(4));
                    annoucements.Add(a);
                }
                cnn.Close();
            }
        }

        public void AddData(EmployeeJob fromDep, string toDep, string content, string subject, DateTime date, string toStore, string fromStore)
        {
            foreach (string email in ec.GetEmployeeEmailByStoreAndDepartement(toStore, fromDep))
                em.SendAnnoucement(email, subject, content);
            string from = fromDep.ToString().Remove(1) + fromDep.ToString().Substring(1, fromDep.ToString().Length - 1).ToLower();
            string sql = "INSERT INTO AnnoucementData(From_Department, To_Department, Message, Message_Subject, Message_Date, To_Store_Address, From_Store_Address) VALUES('" + from + "', '" + toDep + "', '" + content + "', '" + subject + "', '" + date + "', '" + toStore + "', '" + fromStore + "')";
            using (SqlCommand cmd = new SqlCommand(sql, cnn.sqlConection()))
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }

        public List<Annoucement> GetFilteredList(EmployeeJob job, string address)
        {
            List<Annoucement> ann = new List<Annoucement>();
            List<EmployeeJob> emp;
            if (job == EmployeeJob.ALL)
                emp = new List<EmployeeJob> { EmployeeJob.ADMINISTRATOR, EmployeeJob.MANAGER, EmployeeJob.FLOOR, EmployeeJob.WAREHOUSE };
            else
                emp = new List<EmployeeJob> { job };
            for (int i = 0; i < emp.Count; i++)
                foreach (Annoucement a in annoucements)
                {
                    if (address == "All")
                        address = a.FromStore;
                    if (a.From == emp[i])
                        if (a.FromStore == address)
                            ann.Add(a);
                }
            return ann;
        }

        public List<Annoucement> GetAllAnnoucements()
        {
            return annoucements;
        }
    }
}
