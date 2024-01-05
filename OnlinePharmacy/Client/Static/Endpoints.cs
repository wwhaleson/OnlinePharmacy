
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlinePharmacy.Client.Static
{
    public static class Endpoints
    {
        public static readonly string Prefix = "api";
        public static readonly string CategorysEndpoint = $"{Prefix}/categorys";
        public static readonly string CustomersEndpoint = $"{Prefix}/customers";
        public static readonly string DeliverysEndpoint = $"{Prefix}/deliveries";
        public static readonly string OnlineConsultationsEndpoint = $"{Prefix}/onlineconsultations";
        public static readonly string OrdersEndpoint = $"{Prefix}/orders";
        public static readonly string OrderItemsEndpoint = $"{Prefix}/orderitems";
        public static readonly string PrescriptionsEndpoint = $"{Prefix}/prescriptions";
        public static readonly string PrescriptionItemsEndpoint = $"{Prefix}/prescriptionitems";
        public static readonly string ProductsEndpoint = $"{Prefix}/products";
        public static readonly string StaffsEndpoint = $"{Prefix}/staffs";
    }
}
