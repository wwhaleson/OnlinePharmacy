
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlinePharmacy.Shared.Domain
{
    public class Delivery
    {
        public int DeliveryID { get; set; }
        public DateTime? EstimatedDeliveryDate { get; set; }

        public DateTime? EstimatedDeliveryTime { get; set; }

        public string? DeliveryStatus { get; set; }

        public string? DeliveryMethod { get; set; }

        public decimal? DeliveryCost { get; set; }

        public int OrderID { get; set; }

        public virtual Order? Order { get; set; }

        
        /*
        public int StaffID { get; set; }

        public virtual Staff? Staff { get; set; }*/

    }
}