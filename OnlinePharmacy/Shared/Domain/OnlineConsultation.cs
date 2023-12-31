using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlinePharmacy.Shared.Domain
{
    public class OnlineConsultation
    {

        public int OnlineConsultationID { get; set; }

        public DateTime? ConsultationDateTimeStart { get; set; }

        public DateTime? ConsultationDateTimeEnd { get; set; }
        
        public decimal? ConsultationPrice { get; set; }

        public string? ConsultationSymptom { get; set; }

        public string? ConsultationDiagnosis { get; set; }

        public string? ConsultationDuration { get; set; }

        public string? ConsultationStatus { get; set; }

        public string? ConsultationPlatform { get; set; }

        public int CustomerID { get; set; }

        public virtual Customer? Customer { get; set; }

        public int PharmacistID { get; set; }

        public virtual Staff? Staff { get; set; }

    }
}
