using System;
using System.ComponentModel.DataAnnotations.Schema;

public class SuppliedProduct
{
    public int id { get; set; }
    [ForeignKey("supplier")]
    public int supplier_id { get; set; }
    public string product_name { get; set; }
    public string product_brand { get; set; }
    public string product_description { get; set; }
    public string product_code { get; set; }
    public string sku { get; set; }
    public decimal quantity { get; set; }
    public string unit_of_measurement { get; set; }
    public decimal cost_price { get; set; }
    public decimal unit_price { get; set; }
    public string remarks { get; set; }
    public string status { get; set; }
    public DateTime date_received { get; set; }
    public DateTime date_expiration { get; set; }
    public DateTime created_at { get; set; }

    public SupplierDetails supplier { get; set; }
}
