using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using OnlinePharmacy.Server.Configurations.Entities;
using OnlinePharmacy.Server.Models;
using OnlinePharmacy.Shared.Domain;

namespace OnlinePharmacy.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {

        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Category> Category { get; set; }
        public DbSet<Customer> Customer { get; set; }

        public DbSet<Delivery> Delivery { get; set; }

        public DbSet<OnlineConsultation> OnlineConsultation { get; set; }

        public DbSet<Order> Order { get; set; }     

        public DbSet<OrderItem> OrderItem { get; set; }

        public DbSet<Prescription> Prescription { get; set; }

       public DbSet<PrescriptionItem> PrescriptionItem { get; set;}

        public DbSet<Product> Product { get; set; }

        public DbSet<Staff> Staff { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new StaffSeedConfiguration());
            builder.ApplyConfiguration(new CategorySeedConfiguration());
            builder.ApplyConfiguration(new CustomerSeedConfiguration());
            builder.ApplyConfiguration(new DeliverySeedConfiguration());
            builder.ApplyConfiguration(new OnlineConsultationSeedConfiguration());
            builder.ApplyConfiguration(new OrderItemSeedConfiguration());
            builder.ApplyConfiguration(new OrderSeedConfiguration());
            builder.ApplyConfiguration(new PrescriptionItemSeedConfiguration());
            builder.ApplyConfiguration(new PrescriptionSeedConfiguration());
            builder.ApplyConfiguration(new ProductSeedConfiguration());
            builder.ApplyConfiguration(new RoleSeedConfiguration());
            builder.ApplyConfiguration(new UserRoleSeedConfiguration());
            builder.ApplyConfiguration(new UserSeedConfiguration());
            
        }

    }
}
