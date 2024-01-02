using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlinePharmacy.Shared.Domain
{
    public class OrderItem
    {
        public int OrderItemID { get; set; }

        public int OrderItemQty { get; set; }

        public decimal? OrderItemSubTotal { get; set; }

        public int OrderID { get; set; }

        public virtual Order? Order { get; set; }

        public int ProductID { get; set; }

        public virtual Product? Product { get; set; }
    }
}