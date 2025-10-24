using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PAKOPointOfSale;
using PAKOPointOfSale.Model;
using WinFormsApp1.Model;

namespace WinFormsApp1.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SupplierDetails> SupplierDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        //public DbSet<SuppliedProduct> SuppliedProducts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<VoidTransaction> VoidTransactions { get; set; }
        public DbSet<ReturnTransaction> ReturnTransactions { get; set; }
        public DbSet<ReturnItem> ReturnItems { get; set; }
        public DbSet<SalesInvoiceItem> SalesInvoiceItems { get; set; }
        public DbSet<ParkedTransaction> ParkedTransactions { get; set; }
        public DbSet<ParkedSalesInvoiceItem> ParkedSalesInvoiceItems { get; set; }
        
        

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Program.ConnString);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserType>().HasData(
                new UserType { id = 1, name = "Super Admin" },
                new UserType { id = 2, name = "Admin" },
                new UserType { id = 3, name = "Cashier" }
            ); 
            modelBuilder.Entity<Permission>().HasData(
                // --- Super Admin (user_type_id = 1) ---
                new Permission { id = 1, user_type_id = 1, module_name = "Categories", can_view = true, can_add = true, can_edit = true, can_delete = true },
                new Permission { id = 2, user_type_id = 1, module_name = "Products", can_view = true, can_add = true, can_edit = true, can_delete = true },
                new Permission { id = 3, user_type_id = 1, module_name = "Suppliers", can_view = true, can_add = true, can_edit = true, can_delete = true },
                new Permission { id = 4, user_type_id = 1, module_name = "Sales Invoice", can_view = false, can_add = false, can_edit = false }, // SetActive is N/A, so can_delete omitted
                new Permission { id = 5, user_type_id = 1, module_name = "Transactions", can_view = true, can_add = true, can_edit = true, can_delete = true },
                new Permission { id = 6, user_type_id = 1, module_name = "User Access Control", can_view = true, can_edit = true }, // Add & SetActive are N/A, skipped
                new Permission { id = 7, user_type_id = 1, module_name = "Users", can_view = true, can_add = true, can_edit = true, can_delete = true },

                // --- Admin (user_type_id = 2) ---
                new Permission { id = 8, user_type_id = 2, module_name = "Categories", can_view = true, can_add = true, can_edit = true, can_delete = true },
                new Permission { id = 9, user_type_id = 2, module_name = "Products", can_view = true, can_add = true, can_edit = true, can_delete = true },
                new Permission { id = 10, user_type_id = 2, module_name = "Suppliers", can_view = true, can_add = true, can_edit = true, can_delete = true },
                new Permission { id = 11, user_type_id = 2, module_name = "Sales Invoice", can_view = true, can_add = true }, // Edit N/A, SetActive N/A
                new Permission { id = 12, user_type_id = 2, module_name = "Transactions", can_view = true, can_add = true, can_edit = true, can_delete = true },
                new Permission { id = 13, user_type_id = 2, module_name = "User Access Control", can_view = true, can_edit = true }, // Add & SetActive N/A
                new Permission { id = 14, user_type_id = 2, module_name = "Users", can_view = true, can_add = true, can_edit = true, can_delete = true },

                // --- Cashier (user_type_id = 3) ---
                new Permission { id = 15, user_type_id = 3, module_name = "Categories", can_view = false, can_add = false, can_edit = false, can_delete = false },
                new Permission { id = 16, user_type_id = 3, module_name = "Products", can_view = false, can_add = false, can_edit = false, can_delete = false },
                new Permission { id = 17, user_type_id = 3, module_name = "Suppliers", can_view = false, can_add = false, can_edit = false, can_delete = false },
                new Permission { id = 18, user_type_id = 3, module_name = "Sales Invoice", can_view = true, can_add = true, can_edit = true }, // SetActive N/A
                new Permission { id = 19, user_type_id = 3, module_name = "Transactions", can_view = true, can_add = false, can_edit = true, can_delete = false },
                new Permission { id = 20, user_type_id = 3, module_name = "User Access Control", can_view = false }, // Add & Edit & SetActive N/A
                new Permission { id = 21, user_type_id = 3, module_name = "Users", can_view = false, can_add = false, can_edit = false, can_delete = false }
            );


            // Example: Seeding Users
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    id = 1,
                    user_type_id = 1,
                    username = "superadmin",
                    password = "password123", // ideally hashed
                    first_name = "Kate",
                    last_name = "Taeza",
                    birthday = new DateTime(1990, 1, 1),
                    gender = "Female",
                    created_at = new DateTime(2025, 10, 14, 10, 0, 0),
                    is_active = true,
                },
                new User
                {
                    id = 2,
                    user_type_id = 2,
                    username = "admin",
                    password = "password123", // ideally hashed
                    first_name = "Christy",
                    last_name = "Anguluan",
                    birthday = new DateTime(1990, 1, 1),
                    gender = "Female",
                    created_at = new DateTime(2025, 10, 14, 10, 0, 0),
                    is_active = true,
                },
                new User
                {
                    id = 3,
                    user_type_id = 3,
                    username = "cashier",
                    password = "password123", // ideally hashed
                    first_name = "Bryan",
                    last_name = "Mabborang",
                    birthday = new DateTime(1990, 1, 1),
                    gender = "Male",
                    created_at = new DateTime(2025, 10, 14, 10, 0, 0),
                    is_active = true,
                }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category { id = 1, name = "Lubricants & Fluids", description = "Engine oils, brake fluids, and coolant products", is_active = true },
                new Category { id = 2, name = "Electrical & Batteries", description = "Motorcycle batteries, bulbs, spark plugs, and wiring components", is_active = true },
                new Category { id = 3, name = "Tires & Wheels", description = "Inner tubes, tires, and wheel accessories", is_active = true },
                new Category { id = 4, name = "Riding Gear", description = "Helmets, gloves, jackets, and safety equipment", is_active = true },
                new Category { id = 5, name = "Brakes & Suspension", description = "Brake pads, discs, shocks, and fork oils", is_active = true },
                new Category { id = 6, name = "Chains & Sprockets", description = "Drive chains, sprockets, and chain kits", is_active = true },
                new Category { id = 7, name = "Body & Accessories", description = "Side mirrors, stickers, covers, and guards", is_active = true },
                new Category { id = 8, name = "Tools & Maintenance", description = "Wrenches, lubricants, and cleaning kits", is_active = true },
                new Category { id = 9, name = "Lights & Indicators", description = "Headlights, signal lights, and LED kits", is_active = true },
                new Category { id = 10, name = "Engine Parts", description = "Pistons, gaskets, valves, and rebuild kits", is_active = true }
            );

            modelBuilder.Entity<SupplierDetails>().HasData(
                new SupplierDetails { id = 1, name = "ABC Traders", contact_number = "09170000001", address = "123 Street A", account_number = "ACC1001", gateway = "GATE1", created_at = new DateTime(2025, 1, 14) },
                new SupplierDetails { id = 2, name = "XYZ Supplies", contact_number = "09170000002", address = "456 Street B", account_number = "ACC1002", gateway = "GATE2", created_at = new DateTime(2025, 3, 7) },
                new SupplierDetails { id = 3, name = "MegaCorp", contact_number = "09170000003", address = "789 Street C", account_number = "ACC1003", gateway = "GATE3", created_at = new DateTime(2025, 5, 21) },
                new SupplierDetails { id = 4, name = "Foodies Inc", contact_number = "09170000004", address = "101 Street D", account_number = "ACC1004", gateway = "GATE4", created_at = new DateTime(2025, 2, 28) },
                new SupplierDetails { id = 5, name = "SnackKing", contact_number = "09170000005", address = "202 Street E", account_number = "ACC1005", gateway = "GATE5", created_at = new DateTime(2025, 6, 15) },
                new SupplierDetails { id = 6, name = "ElectroMart", contact_number = "09170000006", address = "303 Street F", account_number = "ACC1006", gateway = "GATE6", created_at = new DateTime(2025, 8, 3) },
                new SupplierDetails { id = 7, name = "Cool Drinks Co", contact_number = "09170000007", address = "404 Street G", account_number = "ACC1007", gateway = "GATE7", created_at = new DateTime(2025, 9, 19) },
                new SupplierDetails { id = 8, name = "Fresh Foods", contact_number = "09170000008", address = "505 Street H", account_number = "ACC1008", gateway = "GATE8", created_at = new DateTime(2025, 7, 11) },
                new SupplierDetails { id = 9, name = "Global Traders", contact_number = "09170000009", address = "606 Street I", account_number = "ACC1009", gateway = "GATE9", created_at = new DateTime(2025, 4, 26) },
                new SupplierDetails { id = 10, name = "Local Supplies", contact_number = "09170000010", address = "707 Street J", account_number = "ACC1010", gateway = "GATE10", created_at = new DateTime(2025, 12, 8) }
            );



            modelBuilder.Entity<Product>().HasData(
                    new Product
                    {
                        id = 1,
                        supplier_id = 1,
                        category_id = 1,
                        product_name = "Motor Oil 1L",
                        product_brand = "Shell Advance",
                        product_description = "Engine oil for 4-stroke motorcycles",
                        product_code = "MO1L",
                        sku = "MO-1L-001",
                        barcode = "4801981100001",
                        quantity = 80,
                        unit_of_measurement = "Bottle",
                        cost_price = 250,
                        unit_price = 300,
                        remarks = "Best seller",
                        status = "Good",
                        date_received = DateTime.Parse("2025-10-01"),
                        date_expiration = DateTime.Parse("2030-10-01"),
                        created_at = new DateTime(2025, 10, 14, 10, 0, 0),
                        is_active = true
                    },
                    new Product
                    {
                        id = 2,
                        supplier_id = 2,
                        category_id = 1,
                        product_name = "Spark Plug CR7HSA",
                        product_brand = "NGK",
                        product_description = "Standard spark plug for small motorcycles",
                        product_code = "SPCR7",
                        sku = "SP-CR7-002",
                        barcode = "4801981100002",
                        quantity = 150,
                        unit_of_measurement = "Piece",
                        cost_price = 80,
                        unit_price = 120,
                        remarks = "Popular maintenance item",
                        status = "Good",
                        date_received = DateTime.Parse("2025-10-02"),
                        date_expiration = DateTime.Parse("2030-10-02"),
                        created_at = new DateTime(2025, 10, 14, 10, 0, 0),
                        is_active = true
                    },
                    new Product
                    {
                        id = 3,
                        supplier_id = 3,
                        category_id = 2,
                        product_name = "Motorcycle Battery 12V 5Ah",
                        product_brand = "Motolite",
                        product_description = "Maintenance-free motorcycle battery",
                        product_code = "BAT12V5",
                        sku = "BAT-12V5-003",
                        barcode = "4801981100003",
                        quantity = 40,
                        unit_of_measurement = "Piece",
                        cost_price = 950,
                        unit_price = 1200,
                        remarks = "Long-lasting battery",
                        status = "Good",
                        date_received = DateTime.Parse("2025-10-03"),
                        date_expiration = DateTime.Parse("2030-10-03"),
                        created_at = new DateTime(2025, 10, 14, 10, 0, 0),
                        is_active = true
                    },
                    new Product
                    {
                        id = 4,
                        supplier_id = 4,
                        category_id = 2,
                        product_name = "Motorcycle Chain Kit",
                        product_brand = "RK Takasago",
                        product_description = "Durable chain and sprocket set",
                        product_code = "CHAINKIT",
                        sku = "CHN-KT-004",
                        barcode = "4801981100004",
                        quantity = 30,
                        unit_of_measurement = "Set",
                        cost_price = 800,
                        unit_price = 950,
                        remarks = "High-quality drive kit",
                        status = "Good",
                        date_received = DateTime.Parse("2025-10-04"),
                        date_expiration = DateTime.Parse("2030-10-04"),
                        created_at = new DateTime(2025, 10, 14, 10, 0, 0),
                        is_active = true
                    },
                    new Product
                    {
                        id = 5,
                        supplier_id = 5,
                        category_id = 3,
                        product_name = "Motorcycle Tire 17x2.50",
                        product_brand = "IRC",
                        product_description = "Tubeless motorcycle tire",
                        product_code = "TIRE17",
                        sku = "TIR-17-005",
                        barcode = "4801981100005",
                        quantity = 50,
                        unit_of_measurement = "Piece",
                        cost_price = 950,
                        unit_price = 1200,
                        remarks = "Durable rubber tire",
                        status = "Good",
                        date_received = DateTime.Parse("2025-10-05"),
                        date_expiration = DateTime.Parse("2030-10-05"),
                        created_at = new DateTime(2025, 10, 14, 10, 0, 0),
                        is_active = true
                    },
                    new Product
                    {
                        id = 6,
                        supplier_id = 6,
                        category_id = 3,
                        product_name = "Motorcycle Helmet Full Face",
                        product_brand = "LS2",
                        product_description = "DOT-approved full-face helmet",
                        product_code = "HLMFF",
                        sku = "HLM-FF-006",
                        barcode = "4801981100006",
                        quantity = 20,
                        unit_of_measurement = "Piece",
                        cost_price = 1400,
                        unit_price = 1800,
                        remarks = "Safety equipment",
                        status = "Good",
                        date_received = DateTime.Parse("2025-10-06"),
                        date_expiration = DateTime.Parse("2030-10-06"),
                        created_at = new DateTime(2025, 10, 14, 10, 0, 0),
                        is_active = true
                    },
                    new Product
                    {
                        id = 7,
                        supplier_id = 7,
                        category_id = 4,
                        product_name = "Motorcycle Gloves",
                        product_brand = "Alpinestars",
                        product_description = "Riding gloves with knuckle protection",
                        product_code = "GLV001",
                        sku = "GLV-001-007",
                        barcode = "4801981100007",
                        quantity = 60,
                        unit_of_measurement = "Pair",
                        cost_price = 350,
                        unit_price = 500,
                        remarks = "Comfortable fit",
                        status = "Good",
                        date_received = DateTime.Parse("2025-10-07"),
                        date_expiration = DateTime.Parse("2030-10-07"),
                        created_at = new DateTime(2025, 10, 14, 10, 0, 0),
                        is_active = true
                    },
                    new Product
                    {
                        id = 8,
                        supplier_id = 8,
                        category_id = 4,
                        product_name = "Motorcycle Side Mirror Set",
                        product_brand = "Racing Boy",
                        product_description = "Adjustable aluminum side mirrors",
                        product_code = "MIRSET",
                        sku = "MIR-SET-008",
                        barcode = "4801981100008",
                        quantity = 45,
                        unit_of_measurement = "Set",
                        cost_price = 250,
                        unit_price = 400,
                        remarks = "Chrome finish",
                        status = "Good",
                        date_received = DateTime.Parse("2025-10-08"),
                        date_expiration = DateTime.Parse("2030-10-08"),
                        created_at = new DateTime(2025, 10, 14, 10, 0, 0),
                        is_active = true
                    },
                    new Product
                    {
                        id = 9,
                        supplier_id = 9,
                        category_id = 5,
                        product_name = "Motorcycle Headlight Bulb H4",
                        product_brand = "Bosch",
                        product_description = "High-brightness headlight bulb",
                        product_code = "BLBH4",
                        sku = "BLB-H4-009",
                        barcode = "4801981100009",
                        quantity = 100,
                        unit_of_measurement = "Piece",
                        cost_price = 90,
                        unit_price = 150,
                        remarks = "12V 35/35W",
                        status = "Good",
                        date_received = DateTime.Parse("2025-10-09"),
                        date_expiration = DateTime.Parse("2030-10-09"),
                        created_at = new DateTime(2025, 10, 14, 10, 0, 0),
                        is_active = true
                    },
                    new Product
                    {
                        id = 10,
                        supplier_id = 10,
                        category_id = 5,
                        product_name = "Motorcycle Brake Pads Front",
                        product_brand = "Brembo",
                        product_description = "High-quality front brake pads",
                        product_code = "BRKPADS",
                        sku = "BRK-FR-010",
                        barcode = "4801981100010",
                        quantity = 75,
                        unit_of_measurement = "Set",
                        cost_price = 600,
                        unit_price = 850,
                        remarks = "Fits most underbone models",
                        status = "Good",
                        date_received = DateTime.Parse("2025-10-10"),
                        date_expiration = DateTime.Parse("2030-10-10"),
                        created_at = new DateTime(2025, 10, 14, 10, 0, 0),
                        is_active = true
                    }
                );

        }



    }
}
