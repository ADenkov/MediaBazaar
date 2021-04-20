using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApp
{
    public class ConnectSQL
    {
        private SqlConnection cnn;
        public string IP { get; private set; }
        public string DB { get; private set; }
        public string User { get; private set; }
        public string Pass { get; private set; }

        public ConnectSQL(string server, string database, string user, string pass)
        {
            IP = server;
            DB = database;
            User = user;
            Pass = pass;
            cnn = new SqlConnection("Data Source=" + server + ";Initial Catalog=" + database + ";Persist Security Info=True;User ID=" + user + ";Password=" + pass);
        }

        public void Open()
        {
            cnn.Open();
        }

        public void Close()
        {
            cnn.Close();
        }

        public SqlConnection sqlConection()
        {
            return cnn;
        }
    }
}
