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
                new Category { id = 1, name = "Tools", description = "sample description", is_active = true, },
                new Category { id = 2, name = "Accessories", description = "sample description", is_active = true, },
                new Category { id = 3, name = "Electronics", description = "sample description", is_active = true, }
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
                    product_name = "Coca Cola 500ml",
                    product_brand = "Coca Cola",
                    product_description = "Refreshing carbonated beverage",
                    product_code = "CC500",
                    sku = "SUP-CC-500",
                    quantity = 500,
                    unit_of_measurement = "pcs",
                    cost_price = 40,
                    unit_price = 50,
                    remarks = "Delivered in bulk",
                    status = "Available",
                    date_received = DateTime.Parse("2025-09-28"),
                    date_expiration = DateTime.Parse("2026-09-28"),
                    created_at = new DateTime(2025, 10, 14, 10, 0, 0)
                },
                new SuppliedProduct
                {
                    id = 2,
                    supplier_id = 2,
                    product_name = "Pepsi 500ml",
                    product_brand = "Pepsi",
                    product_description = "Sweet cola beverage",
                    product_code = "PE500",
                    sku = "SUP-PE-500",
                    quantity = 480,
                    unit_of_measurement = "pcs",
                    cost_price = 38,
                    unit_price = 48,
                    remarks = "High demand item",
                    status = "Available",
                    date_received = DateTime.Parse("2025-09-27"),
                    date_expiration = DateTime.Parse("2026-09-27"),
                    created_at = new DateTime(2025, 10, 14, 10, 0, 0)
                },
                new SuppliedProduct
                {
                    id = 3,
                    supplier_id = 3,
                    product_name = "Potato Chips Classic",
                    product_brand = "Lays",
                    product_description = "Classic salted chips",
                    product_code = "PC100",
                    sku = "SUP-PC-100",
                    quantity = 300,
                    unit_of_measurement = "bags",
                    cost_price = 20,
                    unit_price = 30,
                    remarks = "Snack item batch A",
                    status = "Available",
                    date_received = DateTime.Parse("2025-09-26"),
                    date_expiration = DateTime.Parse("2026-03-26"),
                    created_at = new DateTime(2025, 10, 14, 10, 0, 0)
                },
                new SuppliedProduct
                {
                    id = 4,
                    supplier_id = 4,
                    product_name = "Chocolate Bar Sweet",
                    product_brand = "Hershey",
                    product_description = "Milk chocolate snack bar",
                    product_code = "CH200",
                    sku = "SUP-CH-200",
                    quantity = 250,
                    unit_of_measurement = "pcs",
                    cost_price = 18,
                    unit_price = 25,
                    remarks = "Fast-moving goods",
                    status = "Available",
                    date_received = DateTime.Parse("2025-09-25"),
                    date_expiration = DateTime.Parse("2026-03-25"),
                    created_at = new DateTime(2025, 10, 14, 10, 0, 0)
                },
                new SuppliedProduct
                {
                    id = 5,
                    supplier_id = 5,
                    product_name = "Laptop X200",
                    product_brand = "Dell",
                    product_description = "Business performance laptop",
                    product_code = "LPX200",
                    sku = "SUP-LP-200",
                    quantity = 15,
                    unit_of_measurement = "pcs",
                    cost_price = 22000,
                    unit_price = 25000,
                    remarks = "New tech delivery",
                    status = "Available",
                    date_received = DateTime.Parse("2025-09-24"),
                    date_expiration = DateTime.Parse("2030-09-24"),
                    created_at = new DateTime(2025, 10, 14, 10, 0, 0)
                },
                new SuppliedProduct
                {
                    id = 6,
                    supplier_id = 6,
                    product_name = "Headphones Pro",
                    product_brand = "Sony",
                    product_description = "Noise cancelling over-ear headphones",
                    product_code = "HP300",
                    sku = "SUP-HP-300",
                    quantity = 40,
                    unit_of_measurement = "pcs",
                    cost_price = 1000,
                    unit_price = 1200,
                    remarks = "High quality audio gear",
                    status = "Available",
                    date_received = DateTime.Parse("2025-09-23"),
                    date_expiration = DateTime.Parse("2030-09-23"),
                    created_at = new DateTime(2025, 10, 14, 10, 0, 0)
                },
                new SuppliedProduct
                {
                    id = 7,
                    supplier_id = 7,
                    product_name = "Sprite 500ml",
                    product_brand = "Coca Cola",
                    product_description = "Lemon-lime beverage",
                    product_code = "SP500",
                    sku = "SUP-SP-500",
                    quantity = 400,
                    unit_of_measurement = "pcs",
                    cost_price = 35,
                    unit_price = 45,
                    remarks = "Good stock turnover",
                    status = "Available",
                    date_received = DateTime.Parse("2025-09-22"),
                    date_expiration = DateTime.Parse("2026-09-22"),
                    created_at = new DateTime(2025, 10, 14, 10, 0, 0)
                },
                new SuppliedProduct
                {
                    id = 8,
                    supplier_id = 8,
                    product_name = "Biscuits Pack",
                    product_brand = "Oreo",
                    product_description = "Chocolate sandwich biscuits",
                    product_code = "BK150",
                    sku = "SUP-BK-150",
                    quantity = 600,
                    unit_of_measurement = "pcs",
                    cost_price = 15,
                    unit_price = 20,
                    remarks = "Bulk delivery",
                    status = "Available",
                    date_received = DateTime.Parse("2025-09-21"),
                    date_expiration = DateTime.Parse("2026-03-21"),
                    created_at = new DateTime(2025, 10, 14, 10, 0, 0)
                },
                new SuppliedProduct
                {
                    id = 9,
                    supplier_id = 9,
                    product_name = "Smartphone Z10",
                    product_brand = "Samsung",
                    product_description = "Android smartphone with AMOLED display",
                    product_code = "SPZ10",
                    sku = "SUP-SPZ-010",
                    quantity = 25,
                    unit_of_measurement = "pcs",
                    cost_price = 13000,
                    unit_price = 15000,
                    remarks = "Latest batch",
                    status = "Available",
                    date_received = DateTime.Parse("2025-09-20"),
                    date_expiration = DateTime.Parse("2030-09-20"),
                    created_at = new DateTime(2025, 10, 14, 10, 0, 0)
                },
                new SuppliedProduct
                {
                    id = 10,
                    supplier_id = 10,
                    product_name = "Mineral Water 500ml",
                    product_brand = "Wilkins",
                    product_description = "Clean bottled water",
                    product_code = "MW500",
                    sku = "SUP-MW-500",
                    quantity = 1000,
                    unit_of_measurement = "pcs",
                    cost_price = 10,
                    unit_price = 15,
                    remarks = "Delivered weekly",
                    status = "Available",
                    date_received = DateTime.Parse("2025-09-19"),
                    date_expiration = DateTime.Parse("2026-09-19"),
                    created_at = new DateTime(2025, 10, 14, 10, 0, 0)
                }
            );


            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    id = 1,
                    supplier_id = 1,
                    category_id = 1,
                    product_name = "Coca Cola 500ml",
                    product_brand = "Coca Cola",
                    product_description = "Refreshing soft drink",
                    product_code = "CC500",
                    sku = "CC-500-001",
                    quantity = 100,
                    unit_of_measurement = "pcs",
                    cost_price = 40,
                    unit_price = 50,
                    remarks = "Best seller",
                    status = "Available",
                    date_received = DateTime.Parse("2025-10-01"),
                    date_expiration = DateTime.Parse("2026-10-01"),
                    created_at = new DateTime(2025, 10, 14, 10, 0, 0),
                    is_active = true
                },
                new Product
                {
                    id = 2,
                    supplier_id = 2,
                    category_id = 1,
                    product_name = "Pepsi 500ml",
                    product_brand = "Pepsi",
                    product_description = "Carbonated soft drink",
                    product_code = "PE500",
                    sku = "PE-500-002",
                    quantity = 120,
                    unit_of_measurement = "pcs",
                    cost_price = 38,
                    unit_price = 48,
                    remarks = "Popular item",
                    status = "Available",
                    date_received = DateTime.Parse("2025-10-02"),
                    date_expiration = DateTime.Parse("2026-10-02"),
                    created_at = new DateTime(2025, 10, 14, 10, 0, 0),
                    is_active = true
                },
                new Product
                {
                    id = 3,
                    supplier_id = 3,
                    category_id = 2,
                    product_name = "Potato Chips Classic",
                    product_brand = "Lays",
                    product_description = "Crunchy salted potato chips",
                    product_code = "PC100",
                    sku = "PC-100-003",
                    quantity = 200,
                    unit_of_measurement = "pcs",
                    cost_price = 20,
                    unit_price = 30,
                    remarks = "Snack item",
                    status = "Available",
                    date_received = DateTime.Parse("2025-10-03"),
                    date_expiration = DateTime.Parse("2026-04-03"),
                    created_at = new DateTime(2025, 10, 14, 10, 0, 0),
                    is_active = true
                },
                new Product
                {
                    id = 4,
                    supplier_id = 4,
                    category_id = 2,
                    product_name = "Chocolate Bar Sweet",
                    product_brand = "Hershey",
                    product_description = "Milk chocolate bar",
                    product_code = "CH200",
                    sku = "CH-200-004",
                    quantity = 150,
                    unit_of_measurement = "pcs",
                    cost_price = 18,
                    unit_price = 25,
                    remarks = "Sweet snack",
                    status = "Available",
                    date_received = DateTime.Parse("2025-10-04"),
                    date_expiration = DateTime.Parse("2026-04-04"),
                    created_at = new DateTime(2025, 10, 14, 10, 0, 0),
                    is_active = true
                },
                new Product
                {
                    id = 5,
                    supplier_id = 5,
                    category_id = 3,
                    product_name = "Laptop X200",
                    product_brand = "Dell",
                    product_description = "High performance laptop",
                    product_code = "LPX200",
                    sku = "LP-200-005",
                    quantity = 10,
                    unit_of_measurement = "pcs",
                    cost_price = 22000,
                    unit_price = 25000,
                    remarks = "Electronics",
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
                    product_name = "Headphones Pro",
                    product_brand = "Sony",
                    product_description = "Noise cancelling headphones",
                    product_code = "HP300",
                    sku = "HP-300-006",
                    quantity = 25,
                    unit_of_measurement = "pcs",
                    cost_price = 1000,
                    unit_price = 1200,
                    remarks = "Audio product",
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
                    category_id = 1,
                    product_name = "Sprite 500ml",
                    product_brand = "Coca Cola",
                    product_description = "Lemon-lime soft drink",
                    product_code = "SP500",
                    sku = "SP-500-007",
                    quantity = 90,
                    unit_of_measurement = "pcs",
                    cost_price = 35,
                    unit_price = 45,
                    remarks = "Beverage",
                    status = "Available",
                    date_received = DateTime.Parse("2025-10-07"),
                    date_expiration = DateTime.Parse("2026-10-07"),
                    created_at = new DateTime(2025, 10, 14, 10, 0, 0),
                    is_active = true
                },
                new Product
                {
                    id = 8,
                    supplier_id = 8,
                    category_id = 2,
                    product_name = "Biscuits Pack",
                    product_brand = "Oreo",
                    product_description = "Chocolate sandwich biscuits",
                    product_code = "BK150",
                    sku = "BK-150-008",
                    quantity = 300,
                    unit_of_measurement = "pcs",
                    cost_price = 15,
                    unit_price = 20,
                    remarks = "Snack",
                    status = "Available",
                    date_received = DateTime.Parse("2025-10-08"),
                    date_expiration = DateTime.Parse("2026-04-08"),
                    created_at = new DateTime(2025, 10, 14, 10, 0, 0),
                    is_active = true
                },
                new Product
                {
                    id = 9,
                    supplier_id = 9,
                    category_id = 3,
                    product_name = "Smartphone Z10",
                    product_brand = "Samsung",
                    product_description = "Android smartphone",
                    product_code = "SPZ10",
                    sku = "SPZ-010-009",
                    quantity = 15,
                    unit_of_measurement = "pcs",
                    cost_price = 13000,
                    unit_price = 15000,
                    remarks = "Electronics",
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
                    category_id = 1,
                    product_name = "Mineral Water 500ml",
                    product_brand = "Wilkins",
                    product_description = "Bottled water",
                    product_code = "MW500",
                    sku = "MW-500-010",
                    quantity = 250,
                    unit_of_measurement = "pcs",
                    cost_price = 10,
                    unit_price = 15,
                    remarks = "Beverage",
                    status = "Available",
                    date_received = DateTime.Parse("2025-10-10"),
                    date_expiration = DateTime.Parse("2026-10-10"),
                    created_at = new DateTime(2025, 10, 14, 10, 0, 0),
                    is_active = true
                }
            );

        }



    }
}
