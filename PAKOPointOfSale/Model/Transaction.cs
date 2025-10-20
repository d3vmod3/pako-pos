using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Transaction
{
    public int id { get; set; }

    [MaxLength(10)]
    public string? invoice_number { get; set; }  // will be assigned manually
    public string? park_number { get; set; }
    public decimal vat_amount { get; set; }
    public decimal vatable_sales { get; set; }
    public decimal vat_exempt { get; set; }
    public decimal sub_total { get; set; }
    public decimal grand_total { get; set; }
    public string payment_method { get; set; }
    public decimal cash_received { get; set; }
    public decimal cash_change { get; set; }
    public string status { get; set; }  // "success" or pending
    public string? remarks { get; set; }
    public string transaction_type { get; set; }
    public DateTime created_at { get; set; }

    public ICollection<SalesInvoiceItem> sales_invoice_items { get; set; }

}
