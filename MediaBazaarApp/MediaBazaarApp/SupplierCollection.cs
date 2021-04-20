using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApp
{
    public class SupplierCollection
    {
        private ConnectSQL cnn;
        private List<Supplier> suppliers;

        public SupplierCollection(ConnectSQL cnn)
        {
            suppliers = new List<Supplier>();
            this.cnn = cnn;
            GetData();
        }

        public void NewSupplier(string name, string address, int phone)
        {
            string id = DateTime.Now.Ticks.ToString();
            Supplier s = new Supplier(name, id, address, phone);
            AddData(s);
        }

        public void GetData()
        {
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM SupplierData", cnn.sqlConection()))
            {
                cnn.Open();
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                    suppliers.Add(new Supplier(r.GetString(0), r.GetString(1), r.GetString(2), (int)r.GetValue(3)));
                cnn.Close();
            }
        }

        private void AddData(Supplier supplier)
        {
            using (SqlCommand cmd = new SqlCommand("INSERT INTO SupplierData(Name, ID, Address, Phone) VALUES('" + supplier.Name + "', '" + supplier.ID + "', '" + supplier.Address + "', " + supplier.Phone + ")", cnn.sqlConection()))
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }

        public IList<Supplier> GetSuppliers()
        {
            return suppliers.AsReadOnly();
        }
    }
}
