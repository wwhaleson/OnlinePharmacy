using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlinePharmacy.Shared.Domain
{
    public class Product
    {
        public int ProductID { get; set; }

        public string? ProductName { get; set; }

        public string? ProductBrand { get; set; }

        public string? ProductIngredients { get; set; }

        public DateTime? ProductExpiryDate { get; set; }

        public string? ProductDosage { get; set; }

        public string? ProductUsage { get; set; }

        public Boolean? PrescriptionStatus { get; set; }

        public decimal? ProductPrice { get; set; }

        public int? StockQuantity { get; set; }

        public int ProductCategoryID { get; set; }

        public virtual Category? Category { get; set; }

    }
}