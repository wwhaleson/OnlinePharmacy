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

        public TimeOnly? ConsultationTimeStart { get; set; }

        public TimeOnly? ConsultationTimeEnd { get; set; }

        public DateOnly? ConsultationDateStart { get; set; }

        public DateOnly? ConsultationDateEnd { get; set; }

        public decimal? ConsultationPrice { get; set; }

        public string? ConsultationSymptom { get; set; }

        public string? ConsultationDiagnosis { get; set; }

        public int? ConsultationDuration { get; set; }

        public string? ConsultationStatus { get; set; }

        public string? ConsultationPlatform { get; set; }

        public int CustomerID { get; set; }

        public virtual Customer? Customer { get; set; }

        public int PharmacistID { get; set; }

        public virtual Staff? Staff { get; set; }

    }
}