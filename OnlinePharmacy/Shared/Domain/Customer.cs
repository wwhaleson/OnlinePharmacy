using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlinePharmacy.Shared.Domain
{
    public class Customer
    {

        public int CustomerID { get; set; }

        public string? CustFname { get; set; }

        public string? CustLname { get; set; }

        public string? CustGender { get; set; }

        public string? CustPostalCode { get; set; }

        public string? CustBlockNo { get; set; }

        public string? CustFloorNo { get; set; }

        public string? CustAddress { get; set; }

        public int? CustPhoneNo { get; set; }

        public string? CustEmail { get; set; }

        public string? CustPass { get; set; }

    }
}
