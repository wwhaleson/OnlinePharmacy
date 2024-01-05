
using Humanizer;
using Microsoft.AspNetCore.Identity;
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
    public class CategorySeedConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
              new Category
              {
                  CategoryID = 1,
                  CategoryName = "Prescription Item",
                  CategoryDescription = "Medicines that needs prescription"
                  

              },
              new Category
              {
                  CategoryID = 2,
                  CategoryName = "Vitamins",
                  CategoryDescription = "Vitamins for your kids"

              },

              new Category
              {
                  CategoryID = 3,
                  CategoryName = "Over-The-Counter-Medicines",
                  CategoryDescription = "Medicines that allow to be purchasing over the counter"

              }
              );
            //throw new NotImplementedException();
        }
    }
}
