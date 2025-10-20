using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Model
{
    public class Product
    {
        public int id { get; set; }
        [ForeignKey("supplier")]
        public int? supplier_id { get; set; }
        [ForeignKey("category")]
        public int? category_id { get; set; }
        public string product_name { get; set; }
        public string? product_brand { get; set; }
        public string? product_description { get; set; }
        public string? barcode { get; set; }
        public string? product_code { get; set; }
        public string sku { get; set; }
        public decimal quantity { get; set; }
        public string unit_of_measurement { get; set; }
        public decimal cost_price { get; set; }
        public decimal unit_price { get; set; }
        public string remarks { get; set; }
        public string status { get; set; }
        public DateTime date_received { get; set; }
        public DateTime date_expiration { get; set; }
        public Boolean is_active { get; set; }
        public DateTime created_at { get; set; }
        
        public SupplierDetails supplier { get; set; }
        public Category category { get; set; }
    }
}
