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
        public DbSet<SuppliedProduct> SuppliedProducts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<SalesInvoiceItem> SalesInvoiceItems { get; set; }
        

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
            // Admin full access to all modules
                new Permission { id = 1, user_type_id = 1, module_name = "Users", can_view = true, can_add = true, can_edit = true, can_delete = true },
                new Permission { id = 2, user_type_id = 1, module_name = "Categories", can_view = true, can_add = true, can_edit = true, can_delete = true },
                new Permission { id = 3, user_type_id = 1, module_name = "Suppliers", can_view = true, can_add = true, can_edit = true, can_delete = true },
                new Permission { id = 4, user_type_id = 1, module_name = "SuppliedProducts", can_view = true, can_add = true, can_edit = true, can_delete = true },

                // Cashier: view only Products
                new Permission { id = 5, user_type_id = 2, module_name = "Users", can_view = false, can_add = false, can_edit = false, can_delete = false },
                new Permission { id = 6, user_type_id = 2, module_name = "Categories", can_view = true, can_add = false, can_edit = false, can_delete = false },
                new Permission { id = 7, user_type_id = 2, module_name = "Suppliers", can_view = true, can_add = false, can_edit = false, can_delete = false },
                new Permission { id = 8, user_type_id = 2, module_name = "SuppliedProducts", can_view = true, can_add = false, can_edit = false, can_delete = false },

                // Manager: view, add, edit Products and Categories
                new Permission { id = 9, user_type_id = 3, module_name = "Users", can_view = false, can_add = false, can_edit = false, can_delete = false },
                new Permission { id = 10, user_type_id = 3, module_name = "Categories", can_view = true, can_add = true, can_edit = true, can_delete = false },
                new Permission { id = 11, user_type_id = 3, module_name = "Suppliers", can_view = true, can_add = true, can_edit = true, can_delete = false },
                new Permission { id = 12, user_type_id = 3, module_name = "SuppliedProducts", can_view = true, can_add = true, can_edit = true, can_delete = false }
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
                new SupplierDetails { id = 1, name = "ABC Traders", contact_number = "09170000001", address = "123 Street A" },
                new SupplierDetails { id = 2, name = "XYZ Supplies", contact_number = "09170000002", address = "456 Street B" },
                new SupplierDetails { id = 3, name = "MegaCorp", contact_number = "09170000003", address = "789 Street C" },
                new SupplierDetails { id = 4, name = "Foodies Inc", contact_number = "09170000004", address = "101 Street D" },
                new SupplierDetails { id = 5, name = "SnackKing", contact_number = "09170000005", address = "202 Street E" },
                new SupplierDetails { id = 6, name = "ElectroMart", contact_number = "09170000006", address = "303 Street F" },
                new SupplierDetails { id = 7, name = "Cool Drinks Co", contact_number = "09170000007", address = "404 Street G" },
                new SupplierDetails { id = 8, name = "Fresh Foods", contact_number = "09170000008", address = "505 Street H" },
                new SupplierDetails { id = 9, name = "Global Traders", contact_number = "09170000009", address = "606 Street I" },
                new SupplierDetails { id = 10, name = "Local Supplies", contact_number = "09170000010", address = "707 Street J" }
            );

            modelBuilder.Entity<SuppliedProduct>().HasData(
                new SuppliedProduct
                {
                    id = 1,
                    supplier_id = 1,
                    product_name = "Engine Oil 10W-40",
                    product_brand = "Motul",
                    product_description = "High-performance 4T engine oil for motorcycles",
                    product_code = "EO1040",
                    sku = "SUP-EO-1040",
                    quantity = 200,
                    unit_of_measurement = "liters",
                    cost_price = 350,
                    unit_price = 420,
                    remarks = "Top-selling synthetic oil",
                    status = "Available",
                    date_received = DateTime.Parse("2025-09-28"),
                    date_expiration = DateTime.Parse("2028-09-28"),
                    created_at = new DateTime(2025, 10, 14, 10, 0, 0)
                },
                new SuppliedProduct
                {
                    id = 2,
                    supplier_id = 2,
                    product_name = "Motorcycle Battery YTX7A-BS",
                    product_brand = "Motolite",
                    product_description = "12V maintenance-free motorcycle battery",
                    product_code = "BTYTX7A",
                    sku = "SUP-BT-YTX7A",
                    quantity = 50,
                    unit_of_measurement = "pcs",
                    cost_price = 850,
                    unit_price = 1050,
                    remarks = "New stock batch",
                    status = "Available",
                    date_received = DateTime.Parse("2025-09-27"),
                    date_expiration = DateTime.Parse("2029-09-27"),
                    created_at = new DateTime(2025, 10, 14, 10, 0, 0)
                },
                new SuppliedProduct
                {
                    id = 3,
                    supplier_id = 3,
                    product_name = "Spark Plug CR8E",
                    product_brand = "NGK",
                    product_description = "Standard spark plug for 125cc-155cc motorcycles",
                    product_code = "SPCR8E",
                    sku = "SUP-SP-CR8E",
                    quantity = 300,
                    unit_of_measurement = "pcs",
                    cost_price = 80,
                    unit_price = 120,
                    remarks = "Popular replacement part",
                    status = "Available",
                    date_received = DateTime.Parse("2025-09-26"),
                    date_expiration = DateTime.Parse("2030-09-26"),
                    created_at = new DateTime(2025, 10, 14, 10, 0, 0)
                },
                new SuppliedProduct
                {
                    id = 4,
                    supplier_id = 4,
                    product_name = "Brake Pad Set Front",
                    product_brand = "Brembo",
                    product_description = "High-quality front brake pads for underbones",
                    product_code = "BPFRNT",
                    sku = "SUP-BP-FRNT",
                    quantity = 150,
                    unit_of_measurement = "sets",
                    cost_price = 250,
                    unit_price = 320,
                    remarks = "OEM compatible",
                    status = "Available",
                    date_received = DateTime.Parse("2025-09-25"),
                    date_expiration = DateTime.Parse("2030-09-25"),
                    created_at = new DateTime(2025, 10, 14, 10, 0, 0)
                },
                new SuppliedProduct
                {
                    id = 5,
                    supplier_id = 5,
                    product_name = "Chain & Sprocket Set 428H",
                    product_brand = "RK Takasago",
                    product_description = "Durable drive chain and sprocket combo",
                    product_code = "CS428H",
                    sku = "SUP-CS-428H",
                    quantity = 100,
                    unit_of_measurement = "sets",
                    cost_price = 600,
                    unit_price = 750,
                    remarks = "Heavy-duty variant",
                    status = "Available",
                    date_received = DateTime.Parse("2025-09-24"),
                    date_expiration = DateTime.Parse("2030-09-24"),
                    created_at = new DateTime(2025, 10, 14, 10, 0, 0)
                },
                new SuppliedProduct
                {
                    id = 6,
                    supplier_id = 6,
                    product_name = "Tire 90/80-17 Tubeless",
                    product_brand = "IRC",
                    product_description = "Tubeless rear tire for sport motorbikes",
                    product_code = "TR908017",
                    sku = "SUP-TR-9080",
                    quantity = 80,
                    unit_of_measurement = "pcs",
                    cost_price = 1150,
                    unit_price = 1350,
                    remarks = "Fresh batch tires",
                    status = "Available",
                    date_received = DateTime.Parse("2025-09-23"),
                    date_expiration = DateTime.Parse("2030-09-23"),
                    created_at = new DateTime(2025, 10, 14, 10, 0, 0)
                },
                new SuppliedProduct
                {
                    id = 7,
                    supplier_id = 7,
                    product_name = "Motorcycle Helmet Full Face",
                    product_brand = "LS2",
                    product_description = "DOT-certified full-face helmet for riders",
                    product_code = "HMFF01",
                    sku = "SUP-HM-FF01",
                    quantity = 40,
                    unit_of_measurement = "pcs",
                    cost_price = 2500,
                    unit_price = 3200,
                    remarks = "Safety approved gear",
                    status = "Available",
                    date_received = DateTime.Parse("2025-09-22"),
                    date_expiration = DateTime.Parse("2030-09-22"),
                    created_at = new DateTime(2025, 10, 14, 10, 0, 0)
                },
                new SuppliedProduct
                {
                    id = 8,
                    supplier_id = 8,
                    product_name = "LED Signal Light Set",
                    product_brand = "Osram",
                    product_description = "High-visibility LED signal lights",
                    product_code = "LDSL01",
                    sku = "SUP-LD-SL01",
                    quantity = 100,
                    unit_of_measurement = "sets",
                    cost_price = 180,
                    unit_price = 250,
                    remarks = "Energy efficient lighting",
                    status = "Available",
                    date_received = DateTime.Parse("2025-09-21"),
                    date_expiration = DateTime.Parse("2030-09-21"),
                    created_at = new DateTime(2025, 10, 14, 10, 0, 0)
                },
                new SuppliedProduct
                {
                    id = 9,
                    supplier_id = 9,
                    product_name = "Side Mirror Set",
                    product_brand = "Racing Boy",
                    product_description = "Aluminum side mirrors, universal fit",
                    product_code = "SMS01",
                    sku = "SUP-SM-S01",
                    quantity = 120,
                    unit_of_measurement = "sets",
                    cost_price = 300,
                    unit_price = 380,
                    remarks = "Available in multiple colors",
                    status = "Available",
                    date_received = DateTime.Parse("2025-09-20"),
                    date_expiration = DateTime.Parse("2030-09-20"),
                    created_at = new DateTime(2025, 10, 14, 10, 0, 0)
                },
                new SuppliedProduct
                {
                    id = 10,
                    supplier_id = 10,
                    product_name = "Air Filter Element",
                    product_brand = "K&N",
                    product_description = "Reusable high-flow air filter for scooters",
                    product_code = "AFE001",
                    sku = "SUP-AF-E001",
                    quantity = 90,
                    unit_of_measurement = "pcs",
                    cost_price = 420,
                    unit_price = 520,
                    remarks = "Washable and long-lasting",
                    status = "Available",
                    date_received = DateTime.Parse("2025-09-19"),
                    date_expiration = DateTime.Parse("2030-09-19"),
                    created_at = new DateTime(2025, 10, 14, 10, 0, 0)
                }
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
                        unit_of_measurement = "bottle",
                        cost_price = 250,
                        unit_price = 300,
                        remarks = "Best seller",
                        status = "Available",
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
                        unit_of_measurement = "pcs",
                        cost_price = 80,
                        unit_price = 120,
                        remarks = "Popular maintenance item",
                        status = "Available",
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
                        unit_of_measurement = "pcs",
                        cost_price = 950,
                        unit_price = 1200,
                        remarks = "Long-lasting battery",
                        status = "Available",
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
                        unit_of_measurement = "set",
                        cost_price = 800,
                        unit_price = 950,
                        remarks = "High-quality drive kit",
                        status = "Available",
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
                        unit_of_measurement = "pcs",
                        cost_price = 950,
                        unit_price = 1200,
                        remarks = "Durable rubber tire",
                        status = "Available",
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
                        unit_of_measurement = "pcs",
                        cost_price = 1400,
                        unit_price = 1800,
                        remarks = "Safety equipment",
                        status = "Available",
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
                        unit_of_measurement = "pair",
                        cost_price = 350,
                        unit_price = 500,
                        remarks = "Comfortable fit",
                        status = "Available",
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
                        unit_of_measurement = "set",
                        cost_price = 250,
                        unit_price = 400,
                        remarks = "Chrome finish",
                        status = "Available",
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
                        unit_of_measurement = "pcs",
                        cost_price = 90,
                        unit_price = 150,
                        remarks = "12V 35/35W",
                        status = "Available",
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
                        unit_of_measurement = "set",
                        cost_price = 600,
                        unit_price = 850,
                        remarks = "Fits most underbone models",
                        status = "Available",
                        date_received = DateTime.Parse("2025-10-10"),
                        date_expiration = DateTime.Parse("2030-10-10"),
                        created_at = new DateTime(2025, 10, 14, 10, 0, 0),
                        is_active = true
                    }
                );

        }



    }
}
