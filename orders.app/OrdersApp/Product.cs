using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersApp
{
    public class Product
    {
        public string ProductID { get; private set; }
        public string Department { get; private set; }
        public string Serial { get; private set; }
        public string Brand { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public float Price { get; private set; }
        public float Index { get; private set; }
        public string Note { get; private set; }
        public ProductCondition Condition { get; private set; }
        public DateTime DateAdded { get; private set; }
        public char Archived { get; private set; }
        public string Store { get; private set; }
        public Image Icon { get; private set; }

        public Product(string ID, string Dep, string Ser, string Bra, string Nam, string Des, float Pri, float Ind, string Not, string Con, DateTime Dat, char Arc, string Sto, Image Ima)
        {
            ProductID = ID;
            Department = Dep;
            Serial = Ser;
            Brand = Bra;
            Name = Nam;
            Description = Des;
            Price = Pri;
            Index = Ind;
            Note = Not;
            Condition = ProductCondition.NEW;
            if (Con == "Open Box")
                Condition = ProductCondition.OPENED;
            else if (Con == "Missing Items")
                Condition = ProductCondition.MISSING;
            else if (Con == "Returned")
                Condition = ProductCondition.RETURNED;
            else if (Con == "Defective")
                Condition = ProductCondition.DEFECTIVE;
            DateAdded = Dat;
            Archived = Arc;
            Store = Sto;
            Icon = Ima;
        }
    }
}
