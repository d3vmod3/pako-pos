using System.ComponentModel.DataAnnotations.Schema;
using WinFormsApp1.Model;

public class SalesInvoiceItem
{
    public int id { get; set; }
    [ForeignKey("transaction")]
    public int transaction_id { get; set; }
    [ForeignKey("product")]
    public int product_id { get; set; }
    public decimal quantity { get; set; }
    public decimal unit_price { get; set; }
    public decimal vat_amount { get; set; }
    public decimal vatable_sales { get; set; }
    public decimal vat_exempt { get; set; }
    public decimal discount { get; set; }
    public string? discount_type { get; set; }
    public decimal total_amount { get; set; }
    public string unit_of_measurement { get; set; }
    public string transaction_type { get; set; }

    public Transaction transaction { get; set; }
    public Product product { get; set; }

}
