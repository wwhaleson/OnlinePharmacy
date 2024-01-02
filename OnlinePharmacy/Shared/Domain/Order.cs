using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlinePharmacy.Shared.Domain
{
    public class Order
    {

        public int OrderID { get; set; }

        public DateTime? OrderDateTime { get; set; }

        public decimal? TotalCost { get; set; }

        public String? PaymentType { get; set; }

        public int CustomerID { get; set; }

        public virtual Customer? Customer { get; set; }

        public int StaffID { get; set; }

        public virtual Staff? Staff { get; set; }
    }
}