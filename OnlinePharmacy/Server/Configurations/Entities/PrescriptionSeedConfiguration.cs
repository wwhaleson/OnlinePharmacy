using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlinePharmacy.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace OnlinePharmacy.Server.Configurations.Entities
{
    public class PrescriptionSeedConfiguration : IEntityTypeConfiguration<Prescription>
    {
        public void Configure(EntityTypeBuilder<Prescription> builder)
        {
            builder.HasData(
            new Prescription
            {
                PrescriptionID = 1,
                IssueDate = DateTime.Today,
                ExpiryDate = DateTime.Today.AddMonths(5),
                OnlineConsultationID = 1


            },
             new Prescription
             {
                 PrescriptionID = 2,
                 IssueDate = DateTime.Now,
                 ExpiryDate = DateTime.Today.AddMonths(6),
                 OnlineConsultationID = 2


             }


             );
            //throw new NotImplementedException();
        }
    }
}
