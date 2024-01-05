using Humanizer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using OnlinePharmacy.Shared.Domain;

namespace OnlinePharmacy.Server.Configurations.Entities
{
    public class ProductSeedConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product
                {
                    ProductID = 1,
                    ProductName = "SCOTT'S Multivitamins Gummies Mango",
                    ProductBrand = "SCOTT'S",
                    ProductIngredients = "Glucose, Syrup, Sugar, Gelatin, Acidity Regulator (Citric Acid, Sodium Citrate), Humectant (Sorbitol), Flavouring substance, Vitamins and Mineral (Vitamin C, Zinc, Vitamin E, Vitamin B6, Vitamin A and Vitamin D) and Colouring substance (Tartrazine)\r\n",
                    ProductExpiryDate = DateTime.UtcNow,
                    ProductDosage = "3x/Day",
                    ProductUsage = "Strong bones and teeth, improve the immune system, growth and development",
                    ProductDescription = "Scott's is the Number 1 Kids' Multivitamin Brand in Singapore*. Worry about your little ones being picky with food and not getting the necessary nutrients for proper growth/development? Do not worry, Scott’s Multivitamin Gummies is coming to your rescue! Available in three delicious fruity flavors Apple, Tropical Fruits, and the NEWEST addition - Mango; it contains Zinc and five essential vitamins - A, B6, C, D, E - to support your kid immunity, bone growth and healthy vision every day. Moreover, Scott's micro encapsulation technology locks in the goodness of Zinc and 5 Vitamins (Vitamin A, B6, C, D & E) whilst giving kids the taste they love.",
                    PrescriptionStatus = false,
                    ProductPrice = 22,
                    StockQuantity = 100,
                    ProductCategoryID = 2

                },
                new Product
                {
                    ProductID = 2,
                    ProductName = "Panadol Children's Suspension",
                    ProductBrand = "Panadol",
                    ProductIngredients = "Active ingredient: 120 mg/5 ml Paracetamol\r\nExcipients: No Alcohol, no Aspirin.",
                    ProductExpiryDate = DateTime.UtcNow,
                    ProductDosage = "5-10ml (based on child's weight 9.5-19.5kg)\nDo not take more frequently than once every 4 Hours and do not exceed more than four doses in 24 hours. Do not take for more than 3 days without asking your doctor.",
                    ProductUsage = "Fever, Headaches, Symptoms of colds and flu, Teething pain, Toothaches, Earache, Pain associated with immunisation",
                    ProductDescription = "Panadol Children’s Suspension 1-6 Years (120mg/5ml) provides relief from fever and pain in children aged 1 to 6 years. Like all Children’s Panadol products, Panadol Children’s Suspension 1-6 Years is gentle on little stomachs. A strawberry-flavoured suspension, Panadol Children’s Suspension 1-6 Years contains no alcohol and is aspirin-free.",
                    PrescriptionStatus = false,
                    ProductPrice = 9,
                    StockQuantity = 90,
                    ProductCategoryID = 3
                },

                new Product
                {
                    ProductID = 3,
                    ProductName = "Amoxicillin",
                    ProductBrand = "Amoxil",
                    ProductIngredients = "Croscarmellose sodium, gelatin, magnesium stearate, titanium dioxide, and yellow iron oxide.",
                    ProductExpiryDate = DateTime.UtcNow,
                    ProductDosage = "1.25-12.5ml (based on child's weight 3.6-36kg)\nGive this dose three (3) times a day—once in the morning, once at mid-day, and once in the evening—for as long as directed.",
                    ProductUsage = "Bacterial infections, such as chest infections (including pneumonia) and dental abscesses. Can also be used together with other antibiotics and medicines to treat stomach ulcers.",
                    ProductDescription = "Amoxicillin is a penicillin antibiotic. It is used to treat bacterial infections, such as chest infections (including pneumonia) and dental abscesses. It can also be used together with other antibiotics and medicines to treat stomach ulcers.",
                    PrescriptionStatus = true,
                    ProductPrice = 10,
                    StockQuantity = 50,
                    ProductCategoryID = 1
                },

                new Product
                {
                    ProductID = 4,
                    ProductName = "Ibuprofen",
                    ProductBrand = "Ibuprofen",
                    ProductIngredients = "Lactose, Maize Starch, Hypromellose, Sodium Starch Glycollate, Colloidal Anhydrous Silica, Magnesium Stearate, Sucrose, Talc, Titanium Dioxide (E171) and Carnauba Wax",
                    ProductExpiryDate = DateTime.UtcNow,
                    ProductDosage = "Ibuprofen dose is 400mg(two tablets) to be taken initially. 200mg(one tablet) to 400mg(two tablets) may be taken every 4 hours when required.",
                    ProductUsage = "Treat fever, pain, and inflammation in children",
                    ProductDescription = "Ibuprofen is a nonsteroidal anti-inflammatory drug.",
                    PrescriptionStatus = true,
                    ProductPrice = 10,
                    StockQuantity = 50,
                    ProductCategoryID = 1
                },

                new Product
                {
                    ProductID = 5,
                    ProductName = "Zyrtec R",
                    ProductBrand = "Zyrtec",
                    ProductIngredients = "",
                    ProductExpiryDate = DateTime.UtcNow,
                    ProductDosage = "Children aged from 2 to 6 years: 2.5 mL of oral solution (half of a spoon) twice daily. Children aged from 6 to 12 years: 5 mg [10 drops, or 5 ml oral solution (1 full spoon) or half of the tablet] twice daily.",
                    ProductUsage = "Treats allergy symptoms like itchy eyes, sneezing, a stuffy nose or hives",
                    ProductDescription = "Zyrtec pcs 10's is now Zyrtec-R pcs 10's.\r\nNew Name, New Pack, Same Formula.\r\nZyrtec-R is an antihistamine.",
                    PrescriptionStatus = false,
                    ProductPrice = 12,
                    StockQuantity = 30,
                    ProductCategoryID = 3
                }
                );
        }
    }
}