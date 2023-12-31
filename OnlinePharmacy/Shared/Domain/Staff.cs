using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlinePharmacy.Shared.Domain
{
    public class Staff
    {
        //? Nullable
        public int StaffID { get; set; }    

        public string? StaffFname { get; set; }

        public string? StaffLname { get; set; }

        public string? StaffGender { get; set; }

        public string? Staff_email { get; set; }

        public string? Staff_pass { get; set; }

        public string? Position { get; set; }
    }
}
