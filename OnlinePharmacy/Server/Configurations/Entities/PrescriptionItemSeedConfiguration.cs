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
    public class PrescriptionItemSeedConfiguration : IEntityTypeConfiguration<PrescriptionItem>
    {
        public void Configure(EntityTypeBuilder<PrescriptionItem> builder)
        {
            builder.HasData(
           new PrescriptionItem
           {
               PrescriptionItemID =1,
               PrescriptionItemQuantity = 1,
               PrescriptionItemSubTotal = 10,
               PrescriptionID = 1,
               ProductID = 3



           },
            new PrescriptionItem
            {
                PrescriptionItemID = 2,
                PrescriptionItemQuantity = 2,
                PrescriptionItemSubTotal = 20,
                PrescriptionID = 2,
                ProductID = 4

            }


            );

            //throw new NotImplementedException();
        }
    }
}
