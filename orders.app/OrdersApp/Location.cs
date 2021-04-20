using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersApp
{
    public class Location
    {
        public string LocationID { get; private set; }
        public string Address { get; private set; }
        public int Tel { get; private set; }
        public string Email { get; private set; }
        public string Website { get; private set; }
        public LocationType Type { get; private set; }
        public int Capacity { get; private set; }
        public int SpaceUsed { get; set; }

        public Location(string Loc, string Add, int Pho, string Ema, string Web, string Pur, int Cap)
        {
            LocationID = Loc;
            Address = Add;
            Tel = Pho;
            Email = Ema;
            Website = Web;
            Capacity = Cap;
            if (Pur == "STORE")
                Type = LocationType.STORE;
            else
                Type = LocationType.HQ;
        }
    }
}
