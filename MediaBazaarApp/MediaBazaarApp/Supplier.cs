using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace MediaBazaarApp
{
    public class Supplier
    {
        private string id;
        private string name;
        private string address;
        private int phone;

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Name field can not be empty.");
                this.name = value;
            }
        }

        public string ID
        {
            get { return this.id; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("ID field can not be empty.");
                this.id = value;
            }
        }
        public string Address
        {
            get { return this.address; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Address field can not be empty.");
                this.address = value;
            }
        }
        public int Phone
        {
            get { return this.phone; }
            private set
            {
                if (value == -1)
                    throw new ArgumentException("Invalid phone number provided.");
                this.phone = value;
            }
        }

        public Supplier(string name, string ID, string address, int phone)
        {
            this.Name = name;
            this.ID = ID;
            this.Address = address;
            this.Phone = phone;
        }
    }
}
