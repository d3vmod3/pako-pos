using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PAKOPointOfSale.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "SupplierDetails",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    contact_number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    account_number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    gateway = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierDetails", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    invoice_number = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    vat_amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    vatable_sales = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    vat_exempt = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    sub_total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    grand_total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    payment_method = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "UserType",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserType", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    supplier_id = table.Column<int>(type: "int", nullable: false),
                    category_id = table.Column<int>(type: "int", nullable: false),
                    product_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    product_brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    product_description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    product_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sku = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    unit_of_measurement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cost_price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    unit_price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    remarks = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    date_received = table.Column<DateTime>(type: "datetime2", nullable: false),
                    date_expiration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_category_id",
                        column: x => x.category_id,
                        principalTable: "Categories",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_SupplierDetails_supplier_id",
                        column: x => x.supplier_id,
                        principalTable: "SupplierDetails",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SuppliedProducts",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    supplier_id = table.Column<int>(type: "int", nullable: false),
                    product_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    product_brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    product_description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    product_code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sku = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    unit_of_measurement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cost_price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    unit_price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    remarks = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    date_received = table.Column<DateTime>(type: "datetime2", nullable: false),
                    date_expiration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuppliedProducts", x => x.id);
                    table.ForeignKey(
                        name: "FK_SuppliedProducts_SupplierDetails_supplier_id",
                        column: x => x.supplier_id,
                        principalTable: "SupplierDetails",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_type_id = table.Column<int>(type: "int", nullable: false),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    first_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    middle_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    last_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    suffix = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.id);
                    table.ForeignKey(
                        name: "FK_Users_UserType_user_type_id",
                        column: x => x.user_type_id,
                        principalTable: "UserType",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SalesInvoiceItems",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    transaction_id = table.Column<int>(type: "int", nullable: false),
                    product_id = table.Column<int>(type: "int", nullable: false),
                    quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    unit_price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    discount_type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    total_amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    unit_of_measurement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    transactionid = table.Column<int>(type: "int", nullable: false),
                    productid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesInvoiceItems", x => x.id);
                    table.ForeignKey(
                        name: "FK_SalesInvoiceItems_Products_productid",
                        column: x => x.productid,
                        principalTable: "Products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SalesInvoiceItems_Transactions_transactionid",
                        column: x => x.transactionid,
                        principalTable: "Transactions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "id", "description", "name" },
                values: new object[,]
                {
                    { 1, null, "Tools" },
                    { 2, null, "Accessories" },
                    { 3, null, "Electronics" }
                });

            migrationBuilder.InsertData(
                table: "SupplierDetails",
                columns: new[] { "id", "account_number", "address", "contact_number", "created_at", "gateway", "name" },
                values: new object[,]
                {
                    { 1, null, "123 Street A", "09170000001", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ABC Traders" },
                    { 2, null, "456 Street B", "09170000002", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "XYZ Supplies" },
                    { 3, null, "789 Street C", "09170000003", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "MegaCorp" },
                    { 4, null, "101 Street D", "09170000004", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Foodies Inc" },
                    { 5, null, "202 Street E", "09170000005", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "SnackKing" },
                    { 6, null, "303 Street F", "09170000006", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ElectroMart" },
                    { 7, null, "404 Street G", "09170000007", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cool Drinks Co" },
                    { 8, null, "505 Street H", "09170000008", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Fresh Foods" },
                    { 9, null, "606 Street I", "09170000009", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Global Traders" },
                    { 10, null, "707 Street J", "09170000010", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Local Supplies" }
                });

            migrationBuilder.InsertData(
                table: "UserType",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 1, "Super Admin" },
                    { 2, "Admin" },
                    { 3, "Cashier" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "id", "category_id", "cost_price", "created_at", "date_expiration", "date_received", "product_brand", "product_code", "product_description", "product_name", "quantity", "remarks", "sku", "status", "supplier_id", "unit_of_measurement", "unit_price" },
                values: new object[,]
                {
                    { 1, 1, 40m, new DateTime(2025, 10, 14, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coca Cola", "CC500", "Refreshing soft drink", "Coca Cola 500ml", 100m, "Best seller", "CC-500-001", "Available", 1, "pcs", 50m },
                    { 2, 1, 38m, new DateTime(2025, 10, 14, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pepsi", "PE500", "Carbonated soft drink", "Pepsi 500ml", 120m, "Popular item", "PE-500-002", "Available", 2, "pcs", 48m },
                    { 3, 2, 20m, new DateTime(2025, 10, 14, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lays", "PC100", "Crunchy salted potato chips", "Potato Chips Classic", 200m, "Snack item", "PC-100-003", "Available", 3, "pcs", 30m },
                    { 4, 2, 18m, new DateTime(2025, 10, 14, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hershey", "CH200", "Milk chocolate bar", "Chocolate Bar Sweet", 150m, "Sweet snack", "CH-200-004", "Available", 4, "pcs", 25m },
                    { 5, 3, 22000m, new DateTime(2025, 10, 14, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2030, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dell", "LPX200", "High performance laptop", "Laptop X200", 10m, "Electronics", "LP-200-005", "Available", 5, "pcs", 25000m },
                    { 6, 3, 1000m, new DateTime(2025, 10, 14, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2030, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sony", "HP300", "Noise cancelling headphones", "Headphones Pro", 25m, "Audio product", "HP-300-006", "Available", 6, "pcs", 1200m },
                    { 7, 1, 35m, new DateTime(2025, 10, 14, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coca Cola", "SP500", "Lemon-lime soft drink", "Sprite 500ml", 90m, "Beverage", "SP-500-007", "Available", 7, "pcs", 45m },
                    { 8, 2, 15m, new DateTime(2025, 10, 14, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oreo", "BK150", "Chocolate sandwich biscuits", "Biscuits Pack", 300m, "Snack", "BK-150-008", "Available", 8, "pcs", 20m },
                    { 9, 3, 13000m, new DateTime(2025, 10, 14, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2030, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung", "SPZ10", "Android smartphone", "Smartphone Z10", 15m, "Electronics", "SPZ-010-009", "Available", 9, "pcs", 15000m },
                    { 10, 1, 10m, new DateTime(2025, 10, 14, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wilkins", "MW500", "Bottled water", "Mineral Water 500ml", 250m, "Beverage", "MW-500-010", "Available", 10, "pcs", 15m }
                });

            migrationBuilder.InsertData(
                table: "SuppliedProducts",
                columns: new[] { "id", "cost_price", "created_at", "date_expiration", "date_received", "product_brand", "product_code", "product_description", "product_name", "quantity", "remarks", "sku", "status", "supplier_id", "unit_of_measurement", "unit_price" },
                values: new object[,]
                {
                    { 1, 40m, new DateTime(2025, 10, 14, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coca Cola", "CC500", "Refreshing carbonated beverage", "Coca Cola 500ml", 500m, "Delivered in bulk", "SUP-CC-500", "Available", 1, "pcs", 50m },
                    { 2, 38m, new DateTime(2025, 10, 14, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pepsi", "PE500", "Sweet cola beverage", "Pepsi 500ml", 480m, "High demand item", "SUP-PE-500", "Available", 2, "pcs", 48m },
                    { 3, 20m, new DateTime(2025, 10, 14, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lays", "PC100", "Classic salted chips", "Potato Chips Classic", 300m, "Snack item batch A", "SUP-PC-100", "Available", 3, "bags", 30m },
                    { 4, 18m, new DateTime(2025, 10, 14, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hershey", "CH200", "Milk chocolate snack bar", "Chocolate Bar Sweet", 250m, "Fast-moving goods", "SUP-CH-200", "Available", 4, "pcs", 25m },
                    { 5, 22000m, new DateTime(2025, 10, 14, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2030, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dell", "LPX200", "Business performance laptop", "Laptop X200", 15m, "New tech delivery", "SUP-LP-200", "Available", 5, "pcs", 25000m },
                    { 6, 1000m, new DateTime(2025, 10, 14, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2030, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sony", "HP300", "Noise cancelling over-ear headphones", "Headphones Pro", 40m, "High quality audio gear", "SUP-HP-300", "Available", 6, "pcs", 1200m },
                    { 7, 35m, new DateTime(2025, 10, 14, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coca Cola", "SP500", "Lemon-lime beverage", "Sprite 500ml", 400m, "Good stock turnover", "SUP-SP-500", "Available", 7, "pcs", 45m },
                    { 8, 15m, new DateTime(2025, 10, 14, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oreo", "BK150", "Chocolate sandwich biscuits", "Biscuits Pack", 600m, "Bulk delivery", "SUP-BK-150", "Available", 8, "pcs", 20m },
                    { 9, 13000m, new DateTime(2025, 10, 14, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2030, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung", "SPZ10", "Android smartphone with AMOLED display", "Smartphone Z10", 25m, "Latest batch", "SUP-SPZ-010", "Available", 9, "pcs", 15000m },
                    { 10, 10m, new DateTime(2025, 10, 14, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wilkins", "MW500", "Clean bottled water", "Mineral Water 500ml", 1000m, "Delivered weekly", "SUP-MW-500", "Available", 10, "pcs", 15m }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "birthday", "first_name", "gender", "last_name", "middle_name", "password", "suffix", "user_type_id", "username" },
                values: new object[,]
                {
                    { 1, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kate", "Female", "Taeza", null, "password123", null, 1, "superadmin" },
                    { 2, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Christy", "Female", "Anguluan", null, "password123", null, 2, "admin" },
                    { 3, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bryan", "Male", "Mabborang", null, "password123", null, 3, "cashier" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_category_id",
                table: "Products",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "IX_Products_supplier_id",
                table: "Products",
                column: "supplier_id");

            migrationBuilder.CreateIndex(
                name: "IX_SalesInvoiceItems_productid",
                table: "SalesInvoiceItems",
                column: "productid");

            migrationBuilder.CreateIndex(
                name: "IX_SalesInvoiceItems_transactionid",
                table: "SalesInvoiceItems",
                column: "transactionid");

            migrationBuilder.CreateIndex(
                name: "IX_SuppliedProducts_supplier_id",
                table: "SuppliedProducts",
                column: "supplier_id");

            migrationBuilder.CreateIndex(
                name: "IX_Users_user_type_id",
                table: "Users",
                column: "user_type_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SalesInvoiceItems");

            migrationBuilder.DropTable(
                name: "SuppliedProducts");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "UserType");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "SupplierDetails");
        }
    }
}
