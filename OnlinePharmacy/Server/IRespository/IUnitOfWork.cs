using OnlinePharmacy.Shared.Domain;
using Microsoft.AspNetCore.Http;
using OnlinePharmacy.Server.Repository;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace OnlinePharmacy.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<PrescriptionItem> PrescriptionItems { get; }
        IGenericRepository<Prescription> Prescriptions { get; }
        IGenericRepository<OrderItem> OrderItems { get; }
        IGenericRepository<Order> Orders { get; }
        IGenericRepository<OnlineConsultation> OnlineConsultations { get; }
        IGenericRepository<Delivery> Deliverys { get; }
        IGenericRepository<Product> Products { get; }
        IGenericRepository<Category> Categorys { get; }
        IGenericRepository<Customer> Customers { get; }
        IGenericRepository<Staff> Staffs { get; }
    }
}