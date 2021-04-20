using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApp
{
    public class LocationCollection
    {
        private ConnectSQL cnn;
        private List<Location> locations;
        private Location l;

        public LocationCollection(ConnectSQL cnn, EmployeeCollection ec)
        {
            this.cnn = cnn;
            locations = new List<Location>();
            GetData();
        }

        public void GetData()
        {
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM LocationData", cnn.sqlConection()))
            {
                cnn.Open();
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    l = new Location(r.GetString(0), r.GetString(1), r.GetInt32(2), r.GetString(3), r.GetString(4), r.GetString(5), r.GetInt32(6));
                    locations.Add(l);
                }
                cnn.Close();
            }
            foreach (Location loc in locations)
                using (SqlCommand cmd = new SqlCommand("SELECT count(*) FROM InventoryData WHERE Store_Address = '" + loc.Address + "'", cnn.sqlConection()))
                {
                    cnn.Open();
                    SqlDataReader r = cmd.ExecuteReader();
                    while (r.Read())
                        loc.SpaceUsed = r.GetInt32(0);
                    cnn.Close();
                }
        }

        public void AddData(string LocationID, string Address, int Tel, string Email, string Website, LocationType type, int Capactiy)
        {
            string sql = "INSERT INTO LocationData(Location_ID, Address, Tel, Email, Website, Purpose, Capacity) VALUES('" + LocationID + "', '" + Address + "', " + Tel + ", '" + Email + "', '" + Website + "', '" + type.ToString() + "', " + Capactiy + ")";
            using (SqlCommand cmd = new SqlCommand(sql, cnn.sqlConection()))
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }

        public List<Location> GetFilterdData(LocationType type, string input)
        {
            List<Location> loc = new List<Location>();
            List<LocationType> locType;
            if (type != LocationType.ALL)
                locType = new List<LocationType> { type };
            else
                locType = new List<LocationType> { LocationType.STORE, LocationType.HQ };
            for (int i = 0; i < locType.Count; i++)
                foreach (Location l in locations)
                    if(l.Type == locType[i])
                        if (l.Address.Contains(input) || l.LocationID.Contains(input))
                            loc.Add(l);
            return loc;
        }

        public void GetLocationData(string location)
        {
            foreach (Location loc in locations)
                if (loc.Address == location)
                    l = loc;
        }

        public Location LocationData()
        {
            return l;
        }

        public List<Location> GetLocationList()
        {
            return locations;
        }
    }
}
