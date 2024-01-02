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

        public int? CustPostalCode { get; set; }

        public int? CustBlockNo { get; set; }

        public int? CustFloorNo { get; set; }

        public string? CustStreetAddress { get; set; }

        public int? CustPhoneNo { get; set; }

        public string? CustEmail { get; set; }

        public string? CustPass { get; set; }

      



    }
}