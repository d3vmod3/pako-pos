using WinFormsApp1.Model;

public class SalesInvoiceItem
{
    public int id { get; set; }
    public int transaction_id { get; set; }
    public int product_id { get; set; }
    public decimal quantity { get; set; }
    public decimal unit_price { get; set; }
    public decimal discount { get; set; }
    public string? discount_type { get; set; }
    public decimal total_amount { get; set; }
    public string unit_of_measurement { get; set; }

    public Transaction transaction { get; set; }
    public Product product { get; set; }

}
