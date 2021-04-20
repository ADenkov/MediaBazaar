using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersApp
{
    class ProductSorter : IComparer<ProductOrderListing>
    {
        public int Compare(ProductOrderListing one, ProductOrderListing two)
        {
            if (one.QTY < two.QTY)
                return -1;
            if (one.QTY > two.QTY)
                return 1;
            return 0;
        }
    }
}
