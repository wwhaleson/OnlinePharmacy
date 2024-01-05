using OnlinePharmacy.Server.Data;
using OnlinePharmacy.Server.Repository;
using OnlinePharmacy.Server.IRepository;
using OnlinePharmacy.Server.Models;
using OnlinePharmacy.Shared.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using OnlinePharmacy.Client.Pages.Prescription;
using static NuGet.Packaging.PackagingConstants;

namespace OnlinePharmacy.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        private IGenericRepository<PrescriptionItem> _prescriptionitems;
        private IGenericRepository<Prescription> _prescriptions;
        private IGenericRepository<OrderItem> _orderitems;
        private IGenericRepository<Order> _orders;
        private IGenericRepository<OnlineConsultation> _onlineconsultations;
        private IGenericRepository<Delivery> _deliverys;
        private IGenericRepository<Product> _products;
        private IGenericRepository<Category> _categorys;
        private IGenericRepository<Customer> _customers ;
        private IGenericRepository<Staff> _staffs;



        private UserManager<ApplicationUser> _userManager;

        public UnitOfWork(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IGenericRepository<PrescriptionItem> PrescriptionItems
            => _prescriptionitems ??= new GenericRepository<PrescriptionItem>(_context);
        public IGenericRepository<Prescription> Prescriptions
            => _prescriptions ??= new GenericRepository<Prescription>(_context);
        public IGenericRepository<OrderItem> OrderItems
            => _orderitems ??= new GenericRepository<OrderItem>(_context);
        public IGenericRepository<Order> Orders
            => _orders ??= new GenericRepository<Order>(_context);
        public IGenericRepository<OnlineConsultation> OnlineConsultations
            => _onlineconsultations ??= new GenericRepository<OnlineConsultation>(_context);
        public IGenericRepository<Delivery> Deliverys
    => _deliverys ??= new GenericRepository<Delivery>(_context);
        public IGenericRepository<Product> Products
            => _products ??= new GenericRepository<Product>(_context);
        public IGenericRepository<Category> Categorys
            => _categorys ??= new GenericRepository<Category>(_context);
        public IGenericRepository<Customer> Customers
            => _customers ??= new GenericRepository<Customer>(_context);
        public IGenericRepository<Staff> Staffs
    => _staffs ??= new GenericRepository<Staff>(_context);


        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save(HttpContext httpContext)
        {
            /*
            //To be implemented
            string user = "System";
            */
            var entries = _context.ChangeTracker.Entries()
                .Where(q => q.State == EntityState.Modified ||
                    q.State == EntityState.Added);

            /*
             
            foreach (var entry in entries)
            {
                ((BaseDomainModel)entry.Entity).DateUpdated = DateTime.Now;
                ((BaseDomainModel)entry.Entity).UpdatedBy = user;
                if (entry.State == EntityState.Added)
                {
                    ((BaseDomainModel)entry.Entity).DateCreated = DateTime.Now;
                    ((BaseDomainModel)entry.Entity).CreatedBy = user;
                }
            }*/

            await _context.SaveChangesAsync();
        }
    }
}