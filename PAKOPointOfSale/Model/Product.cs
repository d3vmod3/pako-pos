using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Model
{
    public class Product
    {
        public int id { get; set; }
        public int? supplier_id { get; set; }
        public int? category_id { get; set; }
        [MaxLength(50)]
        public string product_name { get; set; }
        [MaxLength(30)]
        public string? product_brand { get; set; }
        public string? product_description { get; set; }
        [MaxLength(15)]
        public string? barcode { get; set; }
        [MaxLength(12)]
        public string? product_code { get; set; }
        [MaxLength(32)]
        public string sku { get; set; }
        [Column(TypeName = "decimal(7,2)")]
        public decimal quantity { get; set; }
        public decimal low_stock_quantity { get; set; }
        public string unit_of_measurement { get; set; }
        public decimal cost_price { get; set; }
        public decimal unit_price { get; set; }
        public string remarks { get; set; }
        public string status { get; set; }
        public DateTime date_received { get; set; }
        public DateTime date_expiration { get; set; }
        public Boolean is_active { get; set; }
        public DateTime created_at { get; set; }
    }
}
