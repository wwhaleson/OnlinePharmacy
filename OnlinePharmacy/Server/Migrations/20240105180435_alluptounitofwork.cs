using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnlinePharmacy.Server.Migrations
{
    /// <inheritdoc />
    public partial class alluptounitofwork : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustFname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustLname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustGender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustPostalCode = table.Column<int>(type: "int", nullable: true),
                    CustBlockNo = table.Column<int>(type: "int", nullable: true),
                    CustFloorNo = table.Column<int>(type: "int", nullable: true),
                    CustAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustPhoneNo = table.Column<int>(type: "int", nullable: true),
                    CustEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustPass = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "DeviceCodes",
                columns: table => new
                {
                    UserCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DeviceCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SessionId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClientId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceCodes", x => x.UserCode);
                });

            migrationBuilder.CreateTable(
                name: "Keys",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Use = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Algorithm = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsX509Certificate = table.Column<bool>(type: "bit", nullable: false),
                    DataProtected = table.Column<bool>(type: "bit", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Keys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersistedGrants",
                columns: table => new
                {
                    Key = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SessionId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClientId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ConsumedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Data = table.Column<string>(type: "nvarchar(max)", maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersistedGrants", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    StaffID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StaffFname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StaffLname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StaffGender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Staff_email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Staff_pass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.StaffID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductBrand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductIngredients = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProductDosage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductUsage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrescriptionStatus = table.Column<bool>(type: "bit", nullable: true),
                    ProductPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    StockQuantity = table.Column<int>(type: "int", nullable: true),
                    ProductCategoryID = table.Column<int>(type: "int", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Product_Category_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Category",
                        principalColumn: "CategoryID");
                });

            migrationBuilder.CreateTable(
                name: "OnlineConsultation",
                columns: table => new
                {
                    OnlineConsultationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConsultationTimeStart = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ConsultationTimeEnd = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ConsultationDateStart = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ConsultationDateEnd = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ConsultationPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ConsultationSymptom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConsultationDiagnosis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConsultationDuration = table.Column<int>(type: "int", nullable: true),
                    ConsultationStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConsultationPlatform = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    PharmacistID = table.Column<int>(type: "int", nullable: false),
                    StaffID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OnlineConsultation", x => x.OnlineConsultationID);
                    table.ForeignKey(
                        name: "FK_OnlineConsultation_Customer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OnlineConsultation_Staff_StaffID",
                        column: x => x.StaffID,
                        principalTable: "Staff",
                        principalColumn: "StaffID");
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OrderTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TotalCost = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PaymentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    StaffID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Order_Customer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_Staff_StaffID",
                        column: x => x.StaffID,
                        principalTable: "Staff",
                        principalColumn: "StaffID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Prescription",
                columns: table => new
                {
                    PrescriptionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OnlineConsultationID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prescription", x => x.PrescriptionID);
                    table.ForeignKey(
                        name: "FK_Prescription_OnlineConsultation_OnlineConsultationID",
                        column: x => x.OnlineConsultationID,
                        principalTable: "OnlineConsultation",
                        principalColumn: "OnlineConsultationID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Delivery",
                columns: table => new
                {
                    DeliveryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstimatedDeliveryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EstimatedDeliveryTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeliveryStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeliveryMethod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeliveryCost = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    OrderID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Delivery", x => x.DeliveryID);
                    table.ForeignKey(
                        name: "FK_Delivery_Order_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Order",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    OrderItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderItemQty = table.Column<int>(type: "int", nullable: false),
                    OrderItemSubTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => x.OrderItemID);
                    table.ForeignKey(
                        name: "FK_OrderItem_Order_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Order",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItem_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PrescriptionItem",
                columns: table => new
                {
                    PrescriptionItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrescriptionItemQuantity = table.Column<int>(type: "int", nullable: true),
                    PrescriptionItemSubTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrescriptionID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrescriptionItem", x => x.PrescriptionItemID);
                    table.ForeignKey(
                        name: "FK_PrescriptionItem_Prescription_PrescriptionID",
                        column: x => x.PrescriptionID,
                        principalTable: "Prescription",
                        principalColumn: "PrescriptionID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PrescriptionItem_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "8d9361c5-583a-4a84-bfb7-ded1d2bdf97e", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEGOlucbruP1tUgGtn39USbuTvQDEGtpIsKC0qPCL8QDH+ySqc6uuYQZE8769ZY2Vcg==", null, false, "39a8a1a4-c057-41a7-bc1e-8da116241db5", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "CategoryDescription", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Medicines that needs prescription", "Prescription Item" },
                    { 2, "Vitamins for your kids", "Vitamins" },
                    { 3, "Medicines that allow to be purchasing over the counter", "Over-The-Counter-Medicines" }
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CustomerID", "CustAddress", "CustBlockNo", "CustEmail", "CustFloorNo", "CustFname", "CustGender", "CustLname", "CustPass", "CustPhoneNo", "CustPostalCode" },
                values: new object[,]
                {
                    { 1, "Ubi Avenue 1", 55, "chaewon55@gmail.com", 5, "Chae", "Female", "Won", "helloworld1", 83719378, 123983 },
                    { 2, "Tampines Street 61", 62, "johnwick66@gmail.com", 6, "John", "Male", "Wick", "helloworld2", 93682946, 103933 }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductID", "CategoryID", "PrescriptionStatus", "ProductBrand", "ProductCategoryID", "ProductDescription", "ProductDosage", "ProductExpiryDate", "ProductIngredients", "ProductName", "ProductPrice", "ProductUsage", "StockQuantity" },
                values: new object[,]
                {
                    { 1, null, false, "SCOTT'S", 2, "Scott's is the Number 1 Kids' Multivitamin Brand in Singapore*. Worry about your little ones being picky with food and not getting the necessary nutrients for proper growth/development? Do not worry, Scott’s Multivitamin Gummies is coming to your rescue! Available in three delicious fruity flavors Apple, Tropical Fruits, and the NEWEST addition - Mango; it contains Zinc and five essential vitamins - A, B6, C, D, E - to support your kid immunity, bone growth and healthy vision every day. Moreover, Scott's micro encapsulation technology locks in the goodness of Zinc and 5 Vitamins (Vitamin A, B6, C, D & E) whilst giving kids the taste they love.", "3x/Day", new DateTime(2024, 1, 5, 18, 4, 31, 226, DateTimeKind.Utc).AddTicks(7393), "Glucose, Syrup, Sugar, Gelatin, Acidity Regulator (Citric Acid, Sodium Citrate), Humectant (Sorbitol), Flavouring substance, Vitamins and Mineral (Vitamin C, Zinc, Vitamin E, Vitamin B6, Vitamin A and Vitamin D) and Colouring substance (Tartrazine)\r\n", "SCOTT'S Multivitamins Gummies Mango", 22m, "Strong bones and teeth, improve the immune system, growth and development", 100 },
                    { 2, null, false, "Panadol", 3, "Panadol Children’s Suspension 1-6 Years (120mg/5ml) provides relief from fever and pain in children aged 1 to 6 years. Like all Children’s Panadol products, Panadol Children’s Suspension 1-6 Years is gentle on little stomachs. A strawberry-flavoured suspension, Panadol Children’s Suspension 1-6 Years contains no alcohol and is aspirin-free.", "5-10ml (based on child's weight 9.5-19.5kg)\nDo not take more frequently than once every 4 Hours and do not exceed more than four doses in 24 hours. Do not take for more than 3 days without asking your doctor.", new DateTime(2024, 1, 5, 18, 4, 31, 226, DateTimeKind.Utc).AddTicks(7404), "Active ingredient: 120 mg/5 ml Paracetamol\r\nExcipients: No Alcohol, no Aspirin.", "Panadol Children's Suspension", 9m, "Fever, Headaches, Symptoms of colds and flu, Teething pain, Toothaches, Earache, Pain associated with immunisation", 90 },
                    { 3, null, true, "Amoxil", 1, "Amoxicillin is a penicillin antibiotic. It is used to treat bacterial infections, such as chest infections (including pneumonia) and dental abscesses. It can also be used together with other antibiotics and medicines to treat stomach ulcers.", "1.25-12.5ml (based on child's weight 3.6-36kg)\nGive this dose three (3) times a day—once in the morning, once at mid-day, and once in the evening—for as long as directed.", new DateTime(2024, 1, 5, 18, 4, 31, 226, DateTimeKind.Utc).AddTicks(7469), "Croscarmellose sodium, gelatin, magnesium stearate, titanium dioxide, and yellow iron oxide.", "Amoxicillin", 10m, "Bacterial infections, such as chest infections (including pneumonia) and dental abscesses. Can also be used together with other antibiotics and medicines to treat stomach ulcers.", 50 },
                    { 4, null, true, "Ibuprofen", 1, "Ibuprofen is a nonsteroidal anti-inflammatory drug.", "Ibuprofen dose is 400mg(two tablets) to be taken initially. 200mg(one tablet) to 400mg(two tablets) may be taken every 4 hours when required.", new DateTime(2024, 1, 5, 18, 4, 31, 226, DateTimeKind.Utc).AddTicks(7475), "Lactose, Maize Starch, Hypromellose, Sodium Starch Glycollate, Colloidal Anhydrous Silica, Magnesium Stearate, Sucrose, Talc, Titanium Dioxide (E171) and Carnauba Wax", "Ibuprofen", 10m, "Treat fever, pain, and inflammation in children", 50 },
                    { 5, null, false, "Zyrtec", 3, "Zyrtec pcs 10's is now Zyrtec-R pcs 10's.\r\nNew Name, New Pack, Same Formula.\r\nZyrtec-R is an antihistamine.", "Children aged from 2 to 6 years: 2.5 mL of oral solution (half of a spoon) twice daily. Children aged from 6 to 12 years: 5 mg [10 drops, or 5 ml oral solution (1 full spoon) or half of the tablet] twice daily.", new DateTime(2024, 1, 5, 18, 4, 31, 226, DateTimeKind.Utc).AddTicks(7481), "", "Zyrtec R", 12m, "Treats allergy symptoms like itchy eyes, sneezing, a stuffy nose or hives", 30 }
                });

            migrationBuilder.InsertData(
                table: "Staff",
                columns: new[] { "StaffID", "Position", "StaffFname", "StaffGender", "StaffLname", "Staff_email", "Staff_pass" },
                values: new object[,]
                {
                    { 1, "Pharmacist", "Tom", "Male", "Lim", "tomlim@blazor.com", "P@ssword2" },
                    { 2, "Order Clerk", "Mary", "Female", "Ong", "maryong@blazor.com", "P@ssword3" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.InsertData(
                table: "OnlineConsultation",
                columns: new[] { "OnlineConsultationID", "ConsultationDateEnd", "ConsultationDateStart", "ConsultationDiagnosis", "ConsultationDuration", "ConsultationPlatform", "ConsultationPrice", "ConsultationStatus", "ConsultationSymptom", "ConsultationTimeEnd", "ConsultationTimeStart", "CustomerID", "PharmacistID", "StaffID" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 5, 18, 4, 31, 226, DateTimeKind.Utc).AddTicks(5247), new DateTime(2024, 1, 5, 18, 4, 31, 226, DateTimeKind.Utc).AddTicks(5245), null, 1, null, 40m, null, null, new DateTime(2024, 1, 5, 18, 4, 31, 226, DateTimeKind.Utc).AddTicks(5244), new DateTime(2024, 1, 5, 18, 4, 31, 226, DateTimeKind.Utc).AddTicks(5242), 1, 1, null },
                    { 2, new DateTime(2024, 1, 5, 18, 4, 31, 226, DateTimeKind.Utc).AddTicks(5260), new DateTime(2024, 1, 5, 18, 4, 31, 226, DateTimeKind.Utc).AddTicks(5258), null, 2, null, null, null, null, new DateTime(2024, 1, 5, 18, 4, 31, 226, DateTimeKind.Utc).AddTicks(5257), new DateTime(2024, 1, 5, 18, 4, 31, 226, DateTimeKind.Utc).AddTicks(5256), 2, 1, null }
                });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "OrderID", "CustomerID", "OrderDate", "OrderTime", "PaymentType", "StaffID", "TotalCost" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 1, 6, 2, 4, 31, 226, DateTimeKind.Local).AddTicks(6012), new DateTime(2024, 1, 6, 2, 4, 31, 226, DateTimeKind.Local).AddTicks(6014), null, 2, null },
                    { 2, 2, new DateTime(2024, 1, 6, 2, 4, 31, 226, DateTimeKind.Local).AddTicks(6019), new DateTime(2024, 1, 6, 2, 4, 31, 226, DateTimeKind.Local).AddTicks(6021), null, 2, null }
                });

            migrationBuilder.InsertData(
                table: "Delivery",
                columns: new[] { "DeliveryID", "DeliveryCost", "DeliveryMethod", "DeliveryStatus", "EstimatedDeliveryDate", "EstimatedDeliveryTime", "OrderID" },
                values: new object[,]
                {
                    { 1, 5m, "Standard", "Packing", new DateTime(2024, 1, 6, 2, 4, 31, 226, DateTimeKind.Local).AddTicks(4822), new DateTime(2024, 1, 6, 2, 4, 31, 226, DateTimeKind.Local).AddTicks(4847), 1 },
                    { 2, 5m, "Standard", "Packing", new DateTime(2024, 1, 6, 2, 4, 31, 226, DateTimeKind.Local).AddTicks(4853), new DateTime(2024, 1, 6, 2, 4, 31, 226, DateTimeKind.Local).AddTicks(4855), 2 }
                });

            migrationBuilder.InsertData(
                table: "Prescription",
                columns: new[] { "PrescriptionID", "ExpiryDate", "IssueDate", "OnlineConsultationID" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), 1 },
                    { 2, new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 1, 6, 2, 4, 31, 226, DateTimeKind.Local).AddTicks(6812), 2 }
                });

            migrationBuilder.InsertData(
                table: "PrescriptionItem",
                columns: new[] { "PrescriptionItemID", "PrescriptionID", "PrescriptionItemQuantity", "PrescriptionItemSubTotal", "ProductID" },
                values: new object[,]
                {
                    { 1, 1, 1, 10m, 3 },
                    { 2, 2, 2, 20m, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Delivery_OrderID",
                table: "Delivery",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_DeviceCode",
                table: "DeviceCodes",
                column: "DeviceCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_Expiration",
                table: "DeviceCodes",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_Keys_Use",
                table: "Keys",
                column: "Use");

            migrationBuilder.CreateIndex(
                name: "IX_OnlineConsultation_CustomerID",
                table: "OnlineConsultation",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_OnlineConsultation_StaffID",
                table: "OnlineConsultation",
                column: "StaffID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerID",
                table: "Order",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_StaffID",
                table: "Order",
                column: "StaffID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_OrderID",
                table: "OrderItem",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_ProductID",
                table: "OrderItem",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_ConsumedTime",
                table: "PersistedGrants",
                column: "ConsumedTime");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_Expiration",
                table: "PersistedGrants",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_ClientId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "ClientId", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_SessionId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "SessionId", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_Prescription_OnlineConsultationID",
                table: "Prescription",
                column: "OnlineConsultationID");

            migrationBuilder.CreateIndex(
                name: "IX_PrescriptionItem_PrescriptionID",
                table: "PrescriptionItem",
                column: "PrescriptionID");

            migrationBuilder.CreateIndex(
                name: "IX_PrescriptionItem_ProductID",
                table: "PrescriptionItem",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryID",
                table: "Product",
                column: "CategoryID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Delivery");

            migrationBuilder.DropTable(
                name: "DeviceCodes");

            migrationBuilder.DropTable(
                name: "Keys");

            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropTable(
                name: "PersistedGrants");

            migrationBuilder.DropTable(
                name: "PrescriptionItem");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Prescription");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "OnlineConsultation");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Staff");
        }
    }
}
