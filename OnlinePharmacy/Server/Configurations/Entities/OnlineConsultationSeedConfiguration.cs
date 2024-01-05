using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlinePharmacy.Shared.Domain;
using System;

namespace OnlinePharmacy.Server.Configurations.Entities
{
    public class OnlineConsultationSeedConfiguration : IEntityTypeConfiguration<OnlineConsultation>
    {
        public void Configure(EntityTypeBuilder<OnlineConsultation> builder)
        {
            builder.HasData(
                new OnlineConsultation
                {
                    OnlineConsultationID = 1,
                    ConsultationTimeStart = DateTime.UtcNow, // Use UtcNow for a standardized time
                    ConsultationTimeEnd = DateTime.UtcNow,
                    ConsultationDateStart = DateTime.UtcNow,
                    ConsultationDateEnd = DateTime.UtcNow,
                    ConsultationPrice = 40, // Use decimal value
                    ConsultationSymptom = null,
                    ConsultationDiagnosis = null,
                    ConsultationDuration = 1,
                    ConsultationStatus = null,
                    ConsultationPlatform = null,
                    CustomerID = 1,
                    PharmacistID = 1
                },
                new OnlineConsultation
                {
                    OnlineConsultationID = 2,
                    ConsultationTimeStart = DateTime.UtcNow,
                    ConsultationTimeEnd = DateTime.UtcNow,
                    ConsultationDateStart = DateTime.UtcNow,
                    ConsultationDateEnd = DateTime.UtcNow,
                    ConsultationPrice = null,
                    ConsultationSymptom = null,
                    ConsultationDiagnosis = null,
                    ConsultationDuration = 2,
                    ConsultationStatus = null,
                    ConsultationPlatform = null,
                    CustomerID = 2,
                    PharmacistID = 1
                }
            );
        }
    }
}
