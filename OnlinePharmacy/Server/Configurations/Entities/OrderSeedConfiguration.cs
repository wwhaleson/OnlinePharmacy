
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
    public class OrderSeedConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {

            builder.HasData(
            new Order
            {
                OrderID = 1,
                OrderDate = DateTime.Now,
                OrderTime = DateTime.Now,
                TotalCost = null,
                PaymentType = null,
                CustomerID = 1,
                StaffID = 2


            },
             new Order
             {
                 OrderID = 2,
                 OrderDate = DateTime.Now,
                 OrderTime = DateTime.Now,
                 TotalCost = null,
                 PaymentType = null,
                 CustomerID = 2,
                 StaffID = 2
             }


             );



            //throw new NotImplementedException();
        }
    }
}
